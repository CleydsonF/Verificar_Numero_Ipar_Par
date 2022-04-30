using System;

namespace Verificardor_Nun_Ímpar_Par
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp = "s";
            while (resp == "s")
            {

                Console.WriteLine("Digite um número para verificarmos se é Ímpar ou Par: ");
                double n1 = double.Parse(Console.ReadLine());
                double n2 = 2;

                double resultado = n1 % n2;
                if (resultado == 0)
                {
                    Console.WriteLine("Número Par");
                    Console.WriteLine("Deseja verificar outro número? (s/n)");
                    resp = Console.ReadLine();
                    Console.Clear();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Número Ímpar");
                    Console.WriteLine("Deseja Deseja verificar outro número?? (s/n)");
                    resp = Console.ReadLine();
                    Console.Clear();
                }
                
                Console.WriteLine("Fim do programa");
            }

        }
    }
}
