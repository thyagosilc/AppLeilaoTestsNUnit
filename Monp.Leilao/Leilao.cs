using System;
using System.Collections.Generic;
using System.Text;

namespace Monp.Leilao
{
    public class Leilao
    {
        public string Descricao { get; set; }
        public IList<Lance> Lances { get; set; }

        public Leilao(string descricao)
        {
            this.Descricao = descricao;
            this.Lances = new List<Lance>();
        }

        public void propoe(Lance lance)
        {
            Lances.Add(lance);
        }
    }
}
