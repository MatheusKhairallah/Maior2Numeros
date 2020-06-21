using System;

namespace Maior2Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois números");
            Console.Write("Primeiro número: ");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Segundo número: ");
            int n2=Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            
            if(n1>n2)
            Console.WriteLine("O maior é " +n1);
            else
            Console.WriteLine("O maior é " +n2);
            }



        }
    }

