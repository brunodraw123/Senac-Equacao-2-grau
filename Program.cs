using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, t, x1, x2;
            int q;
            //
            Console.WriteLine("*EQUAÇÃO DE SEGUNDO GRAU*");
            Console.WriteLine("QUANTAS VEZES VOCÊ QUER REPETIR O PROGRAMA?");
            q = int.Parse(Console.ReadLine());
            //
            for (int c2 = 0; c2 < q; c2++)
            {
                Console.WriteLine("_____________________________________");
                Console.WriteLine("DIGITE 'A'");
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("DIGITE 'B'");
                b = float.Parse(Console.ReadLine());
                Console.WriteLine("DIGITE 'C'");
                c = float.Parse(Console.ReadLine());
                //
                t = Math.Pow(b, 2) - 4 * a * c;
                //Console.Write(t);
                //
                if (t >= 0)
                {
                    x1 = (-b + (Math.Sqrt(t))) / 2 * a;
                    Console.WriteLine("X' É IGUAL À " + x1);
                    //
                    x2 = (-b - (Math.Sqrt(t))) / 2 * a;
                    Console.WriteLine("X'' É IGUAL À " + x2);
                }
                else
                {
                    Console.WriteLine("OPERAÇÃO INVÁLIDA (NÃO EXISTE RAÍZ QUADRADA DE NUMERO NEGATIVO)");

                }
                Console.WriteLine("_____________________________________");

            }
        }
    }
}

