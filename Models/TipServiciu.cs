using System.ComponentModel.DataAnnotations.Schema;

namespace Coptil_Ianc_Proiect1.Models
{
    [Table("TipServiciu")]
    public class TipServiciu
    {
        public int TipServiciuId { get; set; }
        public string Denumire { get; set; }
        public string Informatii { get; set; }
        public string Pret { get; set; }
        
    }
}
