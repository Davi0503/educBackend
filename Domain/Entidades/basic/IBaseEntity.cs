using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entidades.basic
{
    public class BaseEntity
    {
        public int Id { get; set; }

        [Required]
        public bool Ativo { get; set; }

        public DateTime Created_At { get; set; }

        public DateTime Updated_At { get; set; }


    }
}
