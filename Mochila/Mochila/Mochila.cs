using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mochila
{
    public class Mochila
    {
        public long Id { get; set; }
        public double Peso { get; set; }
        public double Valor { get; set; }
        public IList<Item> Itens { get; set; }
        public double PesoMaximo { get; set; }

        public Mochila()
        {            
            this.PesoMaximo = 9000.0;
            this.Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            if (verificaPesoDoItem(item) && verificaPesoMaximoDaMochila(item))
            {
                this.Itens.Add(item);
                this.Peso += item.Peso;
                this.Valor += item.Valor;
            }
        }

        private bool verificaPesoDoItem(Item item){
            if (item.Peso < this.PesoMaximo)
            {
                return true;
            }
            return false;
        }

        private bool verificaPesoMaximoDaMochila(Item item)
        {
            if (this.Peso + item.Peso < this.PesoMaximo)
            {
                return true;
            }
            return false;
        }
    }
}
