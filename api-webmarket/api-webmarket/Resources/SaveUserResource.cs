using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Resources
{
    public class SaveUserResource
    {
        [Required]
        [MaxLength(30)]
        public string Nome { get; set; }
        [Required]
        [MaxLength(30)]
        public string Email { get; set; }
        [Required]
        [MaxLength(14)]
        public string Cpf { get; set; }
        [Required]
        [MaxLength(30)]
        public string Password { get; set; }
    }
}
