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
                    Console.WriteLine("Adivinaré un número, piensalo bien y da enter para comenzar");
                    Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("Analizando pensamientos...");
                    Thread.Sleep(4000);

                    Console.Clear();
                    Console.WriteLine("Digita tu número aquí y da enter xd:");
                    string intput = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("Continuando Análisis...");
                    Thread.Sleep(3000);

                    esNumero = int.TryParse(intput, out numero);


                    if (!esNumero)
                    {
                        Console.Clear();
                        Console.WriteLine("Eso no es valido, da enter para reintentar");
                        Console.ReadLine();

                        Console.Clear();
                        Console.WriteLine("Reintentando...");
                        Thread.Sleep(3000);
                    }
                }

                Console.Clear();
                Console.WriteLine("Tu número es:" + numero);
                Console.WriteLine("¿Deseas reiniciar?(s/n)");
                string salchichon = Console.ReadLine();
                reiniciar = salchichon.Trim().ToLower() == "s";

                if (salchichon.Trim().ToLower() == "n")
                {
                    Console.Clear();
                    Console.WriteLine("Cerrando...");
                    Thread.Sleep(3000);
                    Environment.Exit(1);
                }

                Console.Clear();
                Console.WriteLine("Reiniciando...");
                Thread.Sleep(3000);

            } while (reiniciar);
        }
    }
}