using Domain.Entidades.basic;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades
{
    public class User : IBaseEntity
    {

        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Senha { get; set; }
        public bool Ativo { get; set; }
        public DateTime Created_At { get; set; } 
        public DateTime Updated_At { get; set; }





    }
}
