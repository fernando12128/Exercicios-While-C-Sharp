using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicio_C_sharp
{
    internal class Digitar_numero
    {
        public static void Main(string[] args)
        {
            int sobre = 0;
            int resposta = 1;
            while (resposta != 0) {
                Console.WriteLine("Digite um numero : ");
                resposta = Convert.ToInt16(Console.ReadLine());

                sobre += resposta;

                Console.WriteLine($"O Valor total é {sobre}");
            }
            
        }
    }
}
