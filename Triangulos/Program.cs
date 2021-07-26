using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classificação de um Triangulo
            // 3 Lados iguais = Triangulo Equilatero
            // 2 Lados iguais e 1 Diferente = Triangulo Isoceles
            // 3 Lados Diferentes = Triangulo Escaleno
           
            int L1;
            int L2;
            int L3;
            string texto;

            Console.WriteLine("Triangulos");
            Console.WriteLine("Digite L1");
            texto = Console.ReadLine();
            L1 = Convert.ToInt32(texto);

            Console.WriteLine("Digite L2");
            texto = Console.ReadLine();
            L2 = Convert.ToInt32(texto);

            Console.WriteLine("Digite L3");
            texto = Console.ReadLine();
            L3 = Convert.ToInt32(texto);

            Console.WriteLine("Lado 1: " + L1 + " Lado 2: " + L2 + " Lado 3: " + L3);
            Console.ReadKey();            
           
        }
    }
}
