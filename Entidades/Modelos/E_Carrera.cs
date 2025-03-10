using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class E_Carrera
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdCarrera { get; set; }

        [Required(ErrorMessage = "Debe capturar la clave")]
        [StringLength(3, MinimumLength = 3, ErrorMessage = "Debe capturar 3 digitos")]
        public string ClaveCarrera { get; set; }

        [Required(ErrorMessage = "Debe capturar el nombre")]
        public string NombreCarrera { get; set; }

        [Required(ErrorMessage = "Debe capturar el Alisa")]
        public string AliasCarrera { get; set; }

        public bool EstadoCarrera { get; set; }

        //public virtual ICollection<E_Materia> Materias { get; set; }
    }
}
