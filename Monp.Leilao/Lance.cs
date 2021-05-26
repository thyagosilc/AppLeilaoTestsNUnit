using System;
using System.Collections.Generic;
using System.Text;

namespace Monp.Leilao
{
    public class Lance
    {
        public Usuario Usuario { get; private set; }
        public double Valor { get; private set; }

        public Lance(Usuario usuario, double valor)
        {
            Usuario = usuario;
            Valor = valor;
        }
    }
}
