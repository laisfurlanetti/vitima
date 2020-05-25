using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace vitima
{
    class Program
    {
        static void Main(string[] args)
        {
            int contar = VerificarVitima();

            if (contar == 2)
            {
                Console.Write("\n Voce e suspeito");
            }
            if (contar == 3 || contar == 4)
            {
                Console.Write("\n Voce e cumplice");
            }
            if (contar == 5)
            {
               Console.Write("\n ASSASSINO");
            }
            if (contar < 2)
            {
                Console.Write("\n Voce e Inocente");
            }

            Console.Read();
        }
        public static int VerificarVitima()
        {
            string resposta;
            int contar = 0;

            Console.WriteLine("Responda com S ou N:");
            Console.Write("Telefonou para vitima? ");
            resposta = Console.ReadLine();
            if (resposta == "s")
            {
                contar++;
            }
            Console.Write("Esteve no local do crime? ");
            resposta = Console.ReadLine();
            if (resposta == "s")
            {
                contar++;
            }
            Console.Write("Mora perto da vitima? ");
            resposta = Console.ReadLine();
            if (resposta == "s")
            {
                contar++;
            }
            Console.Write("Devia para a vitima? ");
            resposta = Console.ReadLine();
            if (resposta == "s")
            {
                contar++;
            }
            Console.Write("Ja trabalhou com a vitima? ");
            resposta = Console.ReadLine();
            if (resposta == "s")
            {
                contar++;
            }
            return contar;
        }
    }
}
