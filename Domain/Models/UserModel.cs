using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserModel
    {
        [Required(ErrorMessage ="Nome é obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage ="Senha é obrigatório")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; set; }

    }
}
