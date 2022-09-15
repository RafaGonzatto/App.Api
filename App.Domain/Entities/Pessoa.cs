﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class Pessoa
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PessoaCPF { get; set; }
        public string PessoaNome { get; set; }
        public int PessoaIdade { get; set; }
        public string PessoaEndereco { get; set; }
    }
}
