using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Meta
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int UsuarioId { get; set; }
        public bool Concluida { get; set; }

        public Meta(string descricao, int usuarioId)
        {
            Descricao = descricao;
            UsuarioId = usuarioId;
            Concluida = false;
        }
        public void Concluir()
        {
            Concluida = true;
        }
    }
}