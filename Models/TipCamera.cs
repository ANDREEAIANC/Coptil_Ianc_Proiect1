using System.ComponentModel.DataAnnotations.Schema;

namespace Coptil_Ianc_Proiect1.Models
{
    [Table("TipCamera")]
    public class TipCamera
    {
        public int TipCameraId { get; set; }
        public string Denumire { get; set; }
        public int Pret { get; set; }
        public string Facilitati {  get; set; }

    }
}
