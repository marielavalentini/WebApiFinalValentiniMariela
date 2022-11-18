using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiFinalValentiniMariela.Models
{
    [Table("Doctor")]

    public class Medico
    {
        [Key]
        [Required]
        public int Doctor_No { get; set; }

        public int Hospital_Cod { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Apellido { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string  Especialidad { get; set; }

        #region Propiedades de navegacion

        [ForeignKey ("Hospital_Cod")]
        public Hospital Hospital { get; set; }

        #endregion

    }
}
