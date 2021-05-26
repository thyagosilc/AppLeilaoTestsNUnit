using System;


namespace Monp.Leilao
{
    //[TestFixture]
    public class TesteDoAvaliador
    {

        //[Test]
        public void Main()
        {
            // 1 a parte: cenario
            Usuario joao = new Usuario("Joao");
            Usuario jose = new Usuario("jose");
            Usuario Maria = new Usuario("Maria");


            Leilao leilao = new Leilao("Playstation 3 Novo");

            leilao.propoe(new Lance(joao, 200.0));
            leilao.propoe(new Lance(jose, 400.0));
            leilao.propoe(new Lance(Maria,600.0));


            //2a parte: acao
            Avaliador leiloeiro = new Avaliador();
            leiloeiro.Avalia(leilao);


            //3a parte: validacao
            double maiorEsperado = 600;
            double menorEsperado = 200;

            //Assert.AreEqual(maiorEsperado, leiloeiro.MaiorLance);
            //Assert.AreEqual(menorEsperado, leiloeiro.menorLance);
    

        }
    }
}
