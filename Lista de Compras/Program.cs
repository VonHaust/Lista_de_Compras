using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Compras
{         //March
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Lista = new List<string>();

            string A = "1";
            string B = "1";
            string Add;
            string Remv;

            while (A == "1") //Adicionar
            {
                Console.WriteLine("Informe o nome do item que deseja comprar:");
                Add = Console.ReadLine();

                Lista.Add(Add);
                Console.WriteLine("Deseja comprar mais algum item? Digite 1 para SIM e 2 para NÃO:");
                A = Console.ReadLine();
            }

            Lista.Sort(); //Organizar
            Console.WriteLine("O seu carrinho de compras possui: " + Lista.Count + " itens.");

            for (int i = 0; i < Lista.Count; i++)
            {
                Console.WriteLine(Lista[i]); 
            }

            Console.WriteLine("Deseja remover algum item de seu carrinho? Digite 1 para SIM e 2 para NÃO:");
            B = Console.ReadLine();

            while (B == "1") //Remover
            {
                Console.WriteLine("Digite o nome do item que deseja remover:");
                Remv = Console.ReadLine();
                Lista.Remove(Remv);

                Console.WriteLine("Item removido com sucesso!");
                Console.WriteLine("Deseja remover outro item? Digite 1 para SIM e 2 para NÃO:");
                B = Console.ReadLine();
            }

            Console.WriteLine("Sua lista agora possui " + Lista.Count + " itens."); //Apresentar
            for (int i = 0; i < Lista.Count; i++)
            {
                Console.WriteLine(Lista[i]);
            }

            Console.ReadKey();
        }
    }
}
