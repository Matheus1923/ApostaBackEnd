using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApostaBackEnd.Models
{
    [Table("Resultado")]
    public class Resultado
    {
        [Key]
        [Column("idresultado")]
        [Required]

        public Int32 IdResultado { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O campo deve ter entre 10 á 50 caracteres")]
        [Column("nome")]

        public string Nome { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O campo deve ter entre 10 á 50")]
        [Column("vencedor")]

        public string Vencedor { get; set; }

        [Column("idjogo")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public int IdJogo { get; set; }

        [Column("idclube")]
        [Required(ErrorMessage = "O campo é obrigatório")]

        public int IdClube { get; set; }
    }
}
