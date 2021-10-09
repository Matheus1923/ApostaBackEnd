﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApostaBackEnd.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        [Column("idcliente")]
        [Required(ErrorMessage = "O campo deve ser obrigatório")]

        public Int32 IdCliente { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O campo deve ter no minimo 10 á 50 caracteres")]
        [Column("nome")]

        public string Nome { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O campo deve ter no minimo 10 á 50 caracteres")]
        [Column("email")]

        public string Email { get; set; }

    }
}
