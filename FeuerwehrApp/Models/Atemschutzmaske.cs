namespace FeuerwehrApp.Models
{
    public class Atemschutzmaske
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime CheckDate { get; set; }
        public DateTime ExpiringDate { get; set; }
        public bool IsPersonalized { get; set; }
        public string StoragePlace { get; set; }

        public void CalcExpiringDate()
        {
            ExpiringDate = CheckDate.AddMonths(6);
        }
    }
}
