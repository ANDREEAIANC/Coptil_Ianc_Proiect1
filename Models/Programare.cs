using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Coptil_Ianc_Proiect1.Models
{
    [Table("Programare")]
    public class Programare
    {
        public int ProgramareId { get; set; }
        public string NumePrenumeClient { get; set; }
        public string TelefonClient { get; set; }
        public string Email { get;set; }
        public DateTime DataSiOra {  get; set; }
        public string NumePisica { get; set; }
        public int VarstaPisica { get; set; }
        public string RasaPisica { get; set; }
        public string SexPisica { get; set; }
        public string? Observatii { get; set; }

        public int TipHranaId { get; set; }
        public TipHrana? TipHrana { get; set; }

        public int TipCameraId { get; set; }
        public TipCamera? TipCamera { get; set; }

        public int TipServiciuId { get; set; }
        public TipServiciu? TipServiciu { get; set; }
    }
}
