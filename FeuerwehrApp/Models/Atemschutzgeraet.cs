namespace FeuerwehrApp.Models
{
    public class Atemschutzgeraet
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime CheckDate { get; set; }
        public DateTime ExpiringDate { get; set; }

        
    }
}
