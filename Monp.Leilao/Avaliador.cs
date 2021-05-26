using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Monp.Leilao
{
    public class Avaliador
    {
        private double media = 0;
        private double maiorDeTodos = Double.MinValue;
        private double menorDeTodos = Double.MaxValue;
        private List<Lance> maiores;



        public void Avalia(Leilao leilao)
        {
            foreach (var lance in leilao.Lances)
            {
                if (lance.Valor > maiorDeTodos)
                {
                    maiorDeTodos = lance.Valor;
                }
                if(lance.Valor < menorDeTodos)
                {
                    menorDeTodos = lance.Valor;
                }
            }

            pegarMaioresNo(leilao);
        }

        private void pegarMaioresNo(Leilao leilao)
        {
            List<Lance> lista = new List<Lance>(leilao.Lances.OrderByDescending(x => x.Valor));
            maiores = new List<Lance>();
            int count = 3;
            for (int i = 0; i < lista.Count; i++)
            {
                if (i == count) return;
                maiores.Add(lista[i]);
            };
        }

        public void CalcularMediaLances(Leilao leilao)
        {
            double qtdeLances = leilao.Lances.Count;
            double ValorTotal =  leilao.Lances.Sum(x => x.Valor);
            this.media = ValorTotal / qtdeLances ;
        }

        public List<Lance> TresMaiores
        {
            get { return this.maiores; }
        }


        public double MaiorLance
        {
            get { return maiorDeTodos; }
        }
        public double menorLance
        {
            get { return menorDeTodos; }
        }

        public double Media
        {
            get { return media; }
        }
    }
}
