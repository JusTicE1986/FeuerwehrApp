using Azure.Core.Pipeline;

namespace FeuerwehrApp.Models
{
    public class Feuerwehrmann
    {
        public int Id { get; set; }
        public string preName { get; set; }
        public string lastName { get; set; }
        public int dienstGrad { get; set; }
        public DateTime Geburtsdatum { get; set; }

        
            
            
    }
}
