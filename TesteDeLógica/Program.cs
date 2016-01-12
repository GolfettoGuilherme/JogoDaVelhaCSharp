using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeLógica
{
    class Program
    {

        int[,] velha = new int[3, 3];

        static void Main(string[] args)
        {

            ExibirMatriz();
            Console.Write("\n");
            Console.Write("\n");
            Console.WriteLine("diagonal Principal");
            ExibirDiagonalPrincipal();
            Console.Write("\n");
            Console.Write("\n");
            Console.WriteLine("diagonal Secundaria");
            ExibirDiagonalSegundaria();
            Console.Write("\n");
            Console.Write("\n");
            Console.WriteLine("Linha 1");
            ExibirLinha1();
            Console.Write("\n");
            Console.Write("\n");
            Console.WriteLine("Linha 2");
            ExibirLinha2();
            Console.Write("\n");
            Console.Write("\n");
            Console.WriteLine("Linha 3");
            ExibirLinha3();
            Console.Write("\n");
            Console.Write("\n");
            Console.WriteLine("Coluna 1");
            ExibirColuna1();
            Console.Write("\n");
            Console.Write("\n");
            Console.WriteLine("Coluna 2");
            ExibirColuna2();
            Console.Write("\n");
            Console.Write("\n");
            Console.WriteLine("Coluna 3");
            ExibirColuna3();

            Console.ReadKey();
        }

        public static void ExibirMatriz()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[{0}][{1}] \t", i, j);
                }
                Console.Write("\n");
            }
        }

        public static void ExibirDiagonalPrincipal()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(i == j)
                    {
                        Console.Write("[{0}][{1}] \t", i, j);
                    }
                    else
                    {
                        Console.Write("[X][X] \t");
                    }
                }
                Console.Write("\n");
            }
        }

        public static void ExibirDiagonalSegundaria()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == (2 - i))
                    {
                        Console.Write("[{0}][{1}] \t", i, j);
                    }
                    else
                    {
                        Console.Write("[X][X] \t");
                    }
                }
                Console.Write("\n");
            }
        }

        public static void ExibirLinha1()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(i == 0)
                    {
                        Console.Write("[{0}][{1}] \t", i, j);
                    }
                    else
                    {
                        Console.Write("[X][X] \t");
                    }
                }
                Console.Write("\n");
            }
        }

        public static void ExibirLinha2()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(i == 1)
                    {
                        Console.Write("[{0}][{1}] \t", i, j);
                    }
                    else
                    {
                        Console.Write("[X][X] \t");
                    }
                }
                Console.Write("\n");
            }
        }

        public static void ExibirLinha3()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(i == 2)
                    {
                        Console.Write("[{0}][{1}] \t", i, j);
                    }
                    else
                    {
                        Console.Write("[X][X] \t");
                    }
                }
                Console.Write("\n");
            }
        }

        public static void ExibirColuna1()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 0)
                    {
                        Console.Write("[{0}][{1}] \t", i, j);
                    }
                    else
                    {
                        Console.Write("[X][X] \t");
                    }
                }
                Console.Write("\n");
            }
        }

        public static void ExibirColuna2()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 1)
                    {
                        Console.Write("[{0}][{1}] \t", i, j);
                    }
                    else
                    {
                        Console.Write("[X][X] \t");
                    }
                }
                Console.Write("\n");
            }
        }

        public static void ExibirColuna3()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (j == 2)
                    {
                        Console.Write("[{0}][{1}] \t", i, j);
                    }
                    else
                    {
                        Console.Write("[X][X] \t");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}
