using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApostaBackEnd.Models
{
    [Table("Aposta")]
    public class Aposta
    {
        [Key]
        [Column("idaposta")]
        [Required(ErrorMessage = " O campo deve ser obrigatório")]

        public Int32 IdAposta { get; set; }

        [Column("idcliente")]
        [Required(ErrorMessage = " O campo deve ser obrigatório")]
        public int IdCliente { get; set; }

        [Column("datacomopra")]
        [Required(ErrorMessage = "O campo deve ser Obrigatório")]

        public DateTime DataCompra { get; set; }

        [Column("valor")]
        [Required (ErrorMessage = "O campo deve ser obrigatório")]

        public decimal Valor { get; set; }

        [Column("pago")]
        
        public Boolean Pago { get; set; }

        [Column("idjogo")]
        [Required(ErrorMessage = " O campo é obrigatório")]

        public int IdJogo { get; set; }


    }
}
