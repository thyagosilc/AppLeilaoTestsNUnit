using System;
using System.Collections.Generic;
using System.Text;

namespace Monp.Leilao
{
    public class Usuario
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }

        public Usuario(string nome) : this(0, nome)
        {
        }

        public Usuario(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public override bool Equals(object obj)
        {
            return obj is Usuario usuario && Id == usuario.Id && Nome == usuario.Nome;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Nome);
        }
    }
}
