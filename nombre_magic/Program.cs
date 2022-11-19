using System;

namespace nombre_magic
{
    internal class Program
    {
        static void Game()
        {
            Random rand = new Random();

            const int NOMBRE_MIN = 1;
            const int NOMBRE_MAX = 10;

            int NOMBRE_MAGIC = rand.Next(NOMBRE_MIN, NOMBRE_MAX + 1);

            int nombreUser = NOMBRE_MAGIC + 1;

            int nbVie = 4;

            while (nbVie > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"Vies restantes:{nbVie} ");
                nombreUser = DemanderNombre(NOMBRE_MIN, NOMBRE_MAX);

                if (nombreUser > NOMBRE_MAGIC)
                {
                    Console.WriteLine($"Le nombre est plus petit ");
                }
                else if (nombreUser < NOMBRE_MAGIC)
                {
                    Console.WriteLine($"Le nombre est plus grand ");
                }
                else
                {
                    break;
                }
                nbVie--;
            }

            if (nombreUser == NOMBRE_MAGIC)
            {
                Console.WriteLine("Bravos tu as trouver le nombre magic");
            }
            else
            {
                Console.WriteLine($"Tu as pas trouver le nombre magic c'etait le {NOMBRE_MAGIC} \n\tGAME OVER!!\n");
            }
            
        }
        
        static int DemanderNombre(int MIN, int MAX)
        {

            int nombre_int = 0;
            while ((nombre_int < MIN) || (nombre_int > MAX))
            {
                Console.WriteLine($"Choisi un nombre entre {MIN} et {MAX}");
                string nombre = Console.ReadLine();

                try
                {
                    nombre_int = int.Parse(nombre);

                    if ((nombre_int < MIN) || (nombre_int > MAX))
                    {
                        Console.WriteLine($"ERREUR le nombre dois etres entre {MIN} et {MAX}");
                    }

                }
                catch
                {
                    Console.WriteLine("ERREUR! tu dois chosir un nombre valide!");
                }


            }

            return nombre_int;

        }

        static void Main(string[] args)
        {

            string a = "oui";
            string nouvelleParti = a;

            while (nouvelleParti == a)
            {
                Game();

                Console.WriteLine("Envie de jouer a nouveau?");
                nouvelleParti = Console.ReadLine();

                if (nouvelleParti == a)
                {
                    Console.WriteLine("Ok alors c'est reparti");
                    
                }
                else
                {
                    Console.WriteLine("A bientot ");
                }
            }



        }
    }
}