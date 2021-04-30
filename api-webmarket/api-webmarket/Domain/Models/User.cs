using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_webmarket.Domain.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string email {get; set;}
        public int Cpf {get; set;}
        public string Password { get; set; }

    }
}
