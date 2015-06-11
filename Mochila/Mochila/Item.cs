using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mochila
{
    public class Item
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public double Peso { get; set; }
        public double Valor { get; set; }

        public Item(long id, string nome, double peso, double valor)
        {
            this.Id = id;
            this.Nome = nome;
            this.Peso = peso;
            this.Valor = valor;
        }
    }
}
