using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mochila
{
    public class CriadorDeMochila
    {
        public Mochila Mochila { get; set; }
        public IList<Mochila> ListaDeMochilas { get; set; }

        public CriadorDeMochila()
        {
            this.ListaDeMochilas = new List<Mochila>();
        }

        public Mochila CriaIndividuo()
        {
            return criaUmaMochila();
        }

        public IList<Mochila> CriaPopulacao(int tamanho)
        {
            criaMochilas(tamanho);
            return ListaDeMochilas;
        }

        private void criaMochilas(int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
            {                
                this.ListaDeMochilas.Add(criaUmaMochila());
            }
        }

        private Mochila criaUmaMochila()
        {
            return adicionaItensAMochila(5, new Mochila());
        }

        private Mochila adicionaItensAMochila(int quantidade, Mochila mochila)
        {
            Random random = new Random();
            double peso = random.Next(1000);
            double valor = random.Next(1000);
            for (int i = 1; i <= quantidade; i++)
            {
                mochila.AdicionaItem(new Item(i, "Item" + i, peso, valor));
                peso = random.Next(10000);
                valor = random.Next(100000);
            }
            return mochila;
        }
    }
}
