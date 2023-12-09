using System.ComponentModel.DataAnnotations.Schema;

namespace Coptil_Ianc_Proiect1.Models
{
    [Table("Recenzie")]
    public class Recenzie
    {
        public int RecenzieId { get; set; }
        public int Scor { get; set; }
        public string Comentariu { get; set; }
        public DateTime Data { get; set; }
        public string NumeAutor { get; set; } 

    }
}
