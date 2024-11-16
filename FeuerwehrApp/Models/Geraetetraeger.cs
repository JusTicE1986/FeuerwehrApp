namespace FeuerwehrApp.Models
{
    public class Geraetetraeger
    {
        public int Id { get; set; }
        public string preName { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public DateTime G26 { get; set; }
        public DateTime G26Expiring { get; set; }
        public DateTime Belastung { get; set; }
        public DateTime BelastungExpiring { get; set; }
        public DateTime Einsatz { get; set; }
        public DateTime EinsatzExpiring { get; set; }
        public DateTime Unterweisung { get; set; }
        public DateTime UnterweisungExpiring { get; set; }
        public bool IsTauglich { get; set; }
        public bool IsU50 { get; set; }
        public List<DateTime> ExpiringDates { get; set; }

        public string GetEarliestExpirationField()
        {
            var expirations = new Dictionary<string, DateTime>
            {
                {"G26", G26Expiring },
                {"Streckendurchgang", BelastungExpiring },
                {"Einsatz/Übung", EinsatzExpiring },
                {"Unterweisung", UnterweisungExpiring }
            };

            var earliest = expirations.OrderBy(e => e.Value).FirstOrDefault();
            return earliest.Key;
        }

        public bool CalculateAge(DateTime birthDate)
        {
            if (birthDate <= DateTime.Now.AddYears(-50)) { return false; }
            else
            {
                return true;
            }
        }
    }
}
