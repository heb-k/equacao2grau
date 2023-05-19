using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace equacao
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                equacao e = new equacao();

                Console.WriteLine("insira o valor a:");
                e.a = double.Parse(Console.ReadLine());

                while (e.a == 0)
                {
                    Console.WriteLine("A não pode ser igual a 0!!\nInsira um valor valido:");
                    e.a = double.Parse(Console.ReadLine());
                }

                Console.WriteLine("insira o valor b:");
                e.b = double.Parse(Console.ReadLine());

                Console.WriteLine("insira o valor c:");
                e.c = double.Parse(Console.ReadLine());

                if (e.delta() < 0)
                {
                    Console.WriteLine("as raízes da equação são: " + e.x1() + "i e " + e.x2() + "i");
                }
                else
                {
                    Console.WriteLine("as raízes da equação são: " + e.x1() + " e " + e.x2());
                }

                Console.WriteLine("deseja recomeçar? s/n");
                ConsoleKeyInfo keyInfo = Console.ReadKey();
                char tecla = keyInfo.KeyChar;

                while (true)
                {
                    if (char.ToUpper(tecla) == 'S')
                    {
                        Console.Clear();
                        break;
                    }
                    else if (char.ToUpper(tecla) == 'N')
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        keyInfo = Console.ReadKey();
                        tecla = keyInfo.KeyChar;
                    }
                }

            }
        }

    }
}


