using AS2223_4G_INF_PerilliCristian_GerarchiaFigureConsole;
using System;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace AS2223_INF_4G_PerilliCristian_GerarchiaFigureConsole // Note: actual namespace depends on the project name.
{


    internal class Program
    {




        static void Main(string[] args)
        {
            char tasto;
            figure figura = new figure();
            string PuntiAttesa = ". . .";
            Console.WriteLine("Program In console sulla gerarchia di figure.");
            Console.WriteLine("Realizzato da Cristian Perilli IVG INF il 16 / 11 / 2022 per il 17 / 11 / 2022");
            Console.Write("Premere un tasto per iniziare! "); 
            //piccolo effetto visivo
            for(int i = 0; i < PuntiAttesa.Length; i++)
            {
                Console.Write(PuntiAttesa[i]);
                System.Threading.Thread.Sleep(400);
            }
            Console.ReadKey();
            Console.Clear();
            do
            {
                Console.WriteLine("Inserisci il tipo di figura che vuoi utilizzare per i calcoli di 'Area' e 'Perimetro'");               
                Console.WriteLine(" 1 - Quadrato'");
                Console.WriteLine(" 2 - Rettangolo");
                Console.WriteLine(" 3 - Cerchio");
                Console.WriteLine(" 4 - Interrompi programma");             
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                tasto = key.KeyChar;
                switch (tasto)
                {
                    case '1':
                        figura.Figura("quadrato");
                        quadrato quad = new quadrato();
                        Console.WriteLine("Inserisci lato: ");
                        quad.Quadrato(Convert.ToInt32(Console.ReadLine()));
                        break;

                    case '2':
                        figura.Figura("rettangolo");
                        rettangolo rett = new rettangolo();
                        Console.WriteLine("Inserisci base: ");
                        int bbase = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Inserisci altezza: ");
                        rett.Rettangolo(Convert.ToInt32(Console.ReadLine()), bbase);
                        break;

                    case '3':
                        figura.Figura("cerchio");
                        cerchio cerc = new cerchio();
                        Console.WriteLine("Inserisci raggio: ");
                        cerc.Cerchio(Convert.ToInt32(Console.ReadLine()));
                        break;

                    default:

                        break;
                }
                if (tasto != '4')
                {
                    Console.WriteLine("L'area è: " + figura.Area() + "      Mentre Il perimetro è: " + figura.Perimetro());
                    for (int i = 0; i < PuntiAttesa.Length; i++)
                    {
                        Console.Write(PuntiAttesa[i]);
                        System.Threading.Thread.Sleep(800);
                    }
                }
                Console.Clear();
            } while (tasto != '4');
        }
    }
}
