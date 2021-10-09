using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApostaBackEnd.Models
{
    [Table("Clube")]
    public class Clube
    {
        [Key]
        [Column("idclube")]
        [Required(ErrorMessage = "O campo deve ser obrigatório")]

        public Int32 IdClube { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O valor de caracteres deve ser de 10 á 50")]
        [Column("nome")]

        public string Nome { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O valor de caracteres deve ser de 10 á 50")]
        [Column("telefone")]

        public string Telefone { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O valor de caracteres deve ser de 10 á 50")]
        [Column("email")]

        public string Email { get; set; }
    }
}
