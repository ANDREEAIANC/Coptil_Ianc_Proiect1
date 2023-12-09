using System.ComponentModel.DataAnnotations.Schema;

namespace Coptil_Ianc_Proiect1.Models
{
    [Table("Camera")]
    public class Camera
    {
        public int CameraId { get; set; }
        public int Numar { get; set; }
        public int CapacitateMaxima { get; set; }
        public int TipCameraId { get; set; }
        public TipCamera? TipCamera { get; set; }
    }
}
