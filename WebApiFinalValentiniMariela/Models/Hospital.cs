using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;

namespace WebApiFinalValentiniMariela.Models
{
    [Table("Hospital")]
    public class Hospital
    {
        [Key]
        [Required]
        public int Hospital_Cod { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Direccion { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Telefono { get; set; }
        
        public int Num_Camas { get; set; }

        #region Propiedades de navegacion
        public List<Medico> Medicos { get; set; }
        #endregion
    }
}
