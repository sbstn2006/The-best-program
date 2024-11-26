using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace practicas
{
    class ejercicio1
    {
        static void Main(string[] args)
        {
            bool reiniciar;
            do
            {
                int numero = 0;
                bool esNumero = false;

                while (!esNumero)
                {
                    Console.Clear();
                    Console.WriteLine("Adivinaré un número, piensalo y da enter para continuar :b");
                    Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("Analizando pensamientos...");
                    Thread.Sleep(4000);

                    Console.Clear();
                    Console.WriteLine("Digita tu número aquí:");
                    string intput = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("Continuando análisis...");
                    Thread.Sleep(3500);

                    esNumero = int.TryParse(intput, out numero);

                    if (!esNumero)
                    {
                        Console.Clear();
                        Console.WriteLine("Eso no es valido, da enter para reintentar >:(");
                        Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("Reintentando...");
                        Thread.Sleep(3000);
                    }
                }
                Console.Clear();
                Console.WriteLine("Tu número es: " + numero);
                Console.WriteLine("¿Deseas reiniciar? (s/n)");
                string sancocho = Console.ReadLine();
                reiniciar = sancocho.Trim().ToLower() == "s";

                if (sancocho.Trim().ToLower() == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Cerrando...");
                    Thread.Sleep(3500);

                    Environment.Exit(1);
                }

                Console.Clear();
                Console.WriteLine("Reiniciando...");
                Thread.Sleep(3500);

            } while (reiniciar);
        }
    }
}