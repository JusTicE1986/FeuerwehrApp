namespace FeuerwehrApp.Models
{
    public class Fuehrerschein
    {
        public int Id { get; set; }
        public string preName { get; set; }
        public string lastName { get; set; }
        public string FSKlasse { get; set; }
        public string Usage {  get; set; }
        public DateTime CheckDate { get; set; }
        public DateTime ExpiringDate { get; set; }
        public bool IsOK { get; set; }
    }
}
