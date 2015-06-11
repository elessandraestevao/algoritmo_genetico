using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mochila
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando uma mochila ou indivíduo
            CriadorDeMochila criador = new CriadorDeMochila();
            Mochila mochila = new Mochila();
            mochila = criador.CriaIndividuo();

            Console.WriteLine("-----------Mochila------------");
            Console.WriteLine("ID: " + mochila.Id + " PESO: " + mochila.Peso + 
                " PESO MÁXIMO: " + mochila.PesoMaximo + " VALOR: " + mochila.Valor);
            Console.WriteLine("------------------Itens-----------------");
            foreach (var item in mochila.Itens)
            {
                Console.WriteLine("ID " + item.Id + " NOME: " + item.Nome + " PESO: " + item.Peso + " VALOR: " + item.Valor);
            }

            //Craindo uma lista de mochilas ou população
            IList<Mochila> populacao = new List<Mochila>();
            populacao = criador.CriaPopulacao(4);
            foreach (var m in populacao)
            {
                Console.WriteLine("-------------------Mochila------------------");
                Console.WriteLine("ID: " + m.Id + " PESO: " + m.Peso +
                    " PESO MÁXIMO: " + m.PesoMaximo + " VALOR: " + m.Valor);
                Console.WriteLine("------------------Itens-----------------");
                foreach (var item in m.Itens)
                {
                    Console.WriteLine("ID " + item.Id + " NOME: " + item.Nome + " PESO: " + item.Peso + " VALOR: " + item.Valor);
                }
            }
            Console.ReadKey();
        }
    }
}
