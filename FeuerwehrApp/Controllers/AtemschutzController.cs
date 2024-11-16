using FeuerwehrApp.Data;
using FeuerwehrApp.Migrations;
using FeuerwehrApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FeuerwehrApp.Controllers
{
    public class AtemschutzController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AtemschutzController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Overview()
        {
            var masken = _context.Masken.OrderBy(m => m.ExpiringDate).ToList();
            var geraete = _context.Geraete.OrderBy(m => m.ExpiringDate).ToList();
            var agt = _context.AGT.OrderBy(m => m.ExpiringDates.Min()).ToList();
            var fs = _context.DrivingLicense.OrderBy(m => m.ExpiringDate).ToList();
            var fm = _context.Feuerwehrmann.OrderBy(m => m.preName).ToList();

            var viewModel = new OverviewViewModel
            {
                Atemschutzmasken = masken,
                Atemschutzgeraete = geraete,
                AGT = agt,
                DrivingLicenses = fs,
            };

            return View(viewModel);
        }

        public IActionResult CreateEditMaske()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEditMaske(Atemschutzmaske maske)
        {
            maske.ExpiringDate = maske.CheckDate.AddMonths(6);
            _context.Masken.Add(maske);
            _context.SaveChanges();
            return RedirectToAction(nameof(Overview));
        }
        public IActionResult DeleteMaske(int id)
        {
            var maske = _context.Masken.Find(id);
            if (maske != null)
            {
                _context.Masken.Remove(maske);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Overview));
        }

        public IActionResult CreateEditGeraet()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateEditGeraet(Atemschutzgeraet geraet)
        {
            geraet.ExpiringDate = geraet.CheckDate.AddMonths(6);
            _context.Geraete.Add(geraet);
            _context.SaveChanges();
            return RedirectToAction(nameof(Overview));
        }
        public IActionResult DeleteGeraet(int id)
        {
            var geraet = _context.Geraete.Find(id);
            if (geraet != null)
            {
                _context.Geraete.Remove(geraet);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Overview));
        }

        public IActionResult CreateEditAGT(int id)
        {
            if (id != 0)
            {
                var agt = _context.AGT.Find(id);
                return View(agt);

            }
            return View();
        }
        [HttpPost]
        public IActionResult CreateEditAGT(Geraetetraeger agt)
        {

            if (agt.IsU50 = agt.CalculateAge(agt.birthDate))
            {
                agt.G26Expiring = agt.G26.AddYears(3).AddDays(-1);
            }
            else
            {
                agt.G26Expiring = agt.G26.AddYears(1).AddDays(-1);
            }
            agt.BelastungExpiring = agt.Belastung.AddYears(1).AddDays(-1);
            agt.EinsatzExpiring = agt.Einsatz.AddYears(1).AddDays(-1);
            agt.UnterweisungExpiring = agt.Unterweisung.AddYears(1).AddDays(-1);


            List<DateTime> ExpiringDates = new List<DateTime>
            {
                agt.G26Expiring,
                agt.BelastungExpiring,
                agt.EinsatzExpiring,
                agt.UnterweisungExpiring,
            };
            if (agt.Id == null)
            {
                _context.AGT.Add(agt);
            }
            else
            {
                _context.AGT.Update(agt);
            }
            agt.ExpiringDates = ExpiringDates;
            _context.SaveChanges();
            return RedirectToAction(nameof(Overview));
        }
        public IActionResult DeleteAGT(int id)
        {
            var agt = _context.AGT.Find(id);
            if (agt != null)
            {
                _context.AGT.Remove(agt);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Overview));
        }
        public IActionResult DetailsAGT()
        {
            var geraetetraeger = _context.AGT.ToList();
            var viewModel = new OverviewViewModel
            {
                AGT = geraetetraeger,
            };
            return View(viewModel);
        }

        public IActionResult CreateEditLicense(int id)
        {
            if (id != 0)
            {
                var fs = _context.DrivingLicense.Find(id);
                return View(fs);
            }
            return View();
        }
        [HttpPost]
        public IActionResult CreateEditLicense(Models.Fuehrerschein fs)
        {
            if (fs.Id == null)
            {
                fs.CheckDate = DateTime.Today;
                _context.DrivingLicense.Add(fs);
            }
            else
            {
                _context.DrivingLicense.Update(fs);
            }

            _context.SaveChanges();
            return RedirectToAction(nameof(Overview));
        }
        public IActionResult DeleteLicense(int id)
        {
            var fs = _context.DrivingLicense.Find(id);
            if (fs != null)
            {
                _context.DrivingLicense.Remove(fs);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Overview));
        }
        public IActionResult CheckLicense(int id)
        {
            var fs = _context.DrivingLicense.Find(id);
            {
                if (fs != null)
                {
                    fs.CheckDate = DateTime.Today;
                    _context.Update(fs);
                    _context.SaveChanges();
                }
                return RedirectToAction(nameof(Overview));
            }
        }

        public IActionResult CreateEditFM()
        {
            var dienstgrade = new Dictionary<int, string>
            {
                { 1, "Feuerwehrmannanwärter/in" },
                { 2, "Feuerwehrmann/-frau" },
                { 3, "Oberfeuerwehrmann/-frau" },
                { 4, "Hauptfeuerwehrmann/-frau" },
                { 5, "Löschmeister/in" },
                { 6, "Oberlöschmeister/in" },
                { 7, "Hauptlöschmeister/in" },
                { 8, "Brandmeister/in" },
                { 9, "Oberbrandmeister/in" },
                { 10, "Hauptbrandmeister/in" },
            };
            ViewBag.Dienstgrade = dienstgrade;
            return View();
        }
        [HttpPost]
        public IActionResult CreateEditFM(Models.Feuerwehrmann fm)
        {
            
            if (fm.Id == 0)
            {
                _context.Feuerwehrmann.Add(fm);
            }
            else 
            {
                _context.Feuerwehrmann.Update(fm);
            }
            _context.SaveChanges();

            return RedirectToAction(nameof(Overview));

        }
        public IActionResult DetailsFM() 
        {
            var dienstgrade = new Dictionary<int, string>
            {
                { 1, "Feuerwehrmannanwärter/in" },
                { 2, "Feuerwehrmann/-frau" },
                { 3, "Oberfeuerwehrmann/-frau" },
                { 4, "Hauptfeuerwehrmann/-frau" },
                { 5, "Löschmeister/in" },
                { 6, "Oberlöschmeister/in" },
                { 7, "Hauptlöschmeister/in" },
                { 8, "Brandmeister/in" },
                { 9, "Oberbrandmeister/in" },
                { 10, "Hauptbrandmeister/in" },
            };
            ViewBag.Dienstgrade = dienstgrade;
            var feuerwehrmann = _context.Feuerwehrmann.ToList();
            var viewModel = new OverviewViewModel
            {
                Feuerwehrmaenner = feuerwehrmann,
            };
            return View(viewModel); 
        }
    }
}
