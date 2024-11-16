namespace FeuerwehrApp.Models
{
    public class OverviewViewModel
    {
        public IEnumerable<Atemschutzmaske> Atemschutzmasken { get; set; }
        public IEnumerable<Atemschutzgeraet> Atemschutzgeraete { get; set; }
        public IEnumerable<Geraetetraeger> AGT { get; set; }
        public IEnumerable<Fuehrerschein> DrivingLicenses { get; set; }
        public IEnumerable<Feuerwehrmann> Feuerwehrmaenner { get; set; }
    }
}
