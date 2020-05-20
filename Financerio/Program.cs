using System;
using System.Collections.Generic;

namespace Financerio
{
    class Program
    {
        static void Main(string[] args)
        {

            // DECLARAÇÃO = INSTANCIAMENTO
            List<Dados> list = new List<Dados>();


            Console.WriteLine("Entre com a quantidade");
            int n = int.Parse(Console.ReadLine());

            int codigo = 1;

            for (int i = 0; i < n; i++)
            {
                codigo = i + 1;

                Console.Write("Data: ");
                DateTime data = DateTime.Parse(Console.ReadLine());

                Console.Write("Consumidor: ");
                string consumidor = Console.ReadLine();

                list.Add(new Dados(codigo, data, consumidor));
            }
                       
            Console.WriteLine("");
            foreach (Dados obj in list)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
