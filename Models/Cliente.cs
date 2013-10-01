﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TrabalhoBernardi.Models
{
    public class Cliente
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Codigo { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        [EmailAddress()]
        public string Email { get; set; }
        [Required]
        public char Sexo { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        [Range(0.00, 100.00)]
        public double Saldo_Creditos { get; set; }
        public string Descricao_Logradouro { get; set; }
        public int Numero_Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
    }
}