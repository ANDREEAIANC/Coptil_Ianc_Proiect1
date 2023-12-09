using System.ComponentModel.DataAnnotations.Schema;

namespace Coptil_Ianc_Proiect1.Models
{
    [Table("TipHrana")]
    public class TipHrana
    {
        public int TipHranaId { get; set; }
        public string Denumire { get; set; }
        public string Pret { get; set;}
        public string? Observatii { get; set; }
    }
}
