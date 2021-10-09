using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApostaBackEnd.Models
{
    [Table("Estadio")]
    public class Estadio
    {
        [Key]
        [Column("idestadio")]
        [Required(ErrorMessage = "O campo deve ser obrigatório")]

        public Int32 IdEstadio { get; set; }

        [Required]
        [StringLength(50,MinimumLength =10, ErrorMessage = "O campo deve conter no minimo 10 caracteres e no maximo 50")]
        [Column("nome")]

        public string Nome { get; set; }
    }
}
