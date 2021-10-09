using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApostaBackEnd.Models
{
    [Table("Jogo")]
    public class Jogo
    {
        [Key]
        [Column("idjogo")]
        [Required (ErrorMessage = "O campo é obrigatório")]

        public Int32 IdJogo { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O campo deve ter entre 10 á 50 caracteres")]
        [Column("nome")]

        public string Nome { get; set; }

        [Column("idestadio")]
        [Required(ErrorMessage = "O campo é obrigatório")]
        
        public int IdEstadio { get; set; }

        [Column("idclube")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public int IdClube { get; set; }
    }
}
