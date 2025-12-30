using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataCriacao { get; set; }

        public Usuario(string nome, string email)
        {
            Nome = nome;
            Email = email;
            DataCriacao = DateTime.UtcNow;
        }
    }
}