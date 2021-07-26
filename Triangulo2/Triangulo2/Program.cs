using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo2
{
    class Program
    {
        static void Main(string[] args)
        {
            int lado1;
            int lado2;
            int lado3;
           
            Console.WriteLine("**********************");
            Console.WriteLine("Validação de Triangulo");
            Console.WriteLine("**********************");

            Console.WriteLine("Digite o primeiro Lado: ");
            lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo Lado: ");
            lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o terceiro Lado: ");
            lado3 = Convert.ToInt32(Console.ReadLine());

            string textoExibicao = string.Format("Lado1: {0} - Lado2: {1} - Lado1: {2} ", lado1, lado2, lado3);
            Console.WriteLine(textoExibicao);


            Console.ReadKey();
        }
    }
}
