using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ProjectAbyss
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Variables*/
            string input;
            string name;
            int nbLords;
            int sumMonster;
            int nbPlayer;
            bool correct = false;
            Player player;
            List<Lord> lords = new List<Lord>();
            List<Allie> allies = new List<Allie>();
            List<Player> players = new List<Player>();

            /*Début*/

            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "DESKTOP-LDQJCOT.database.windows.net";
                builder.UserID = "root";
                builder.Password = "";
                builder.InitialCatalog = "abyss";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    Console.WriteLine("Test");

                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT *");
                    sb.Append("FROM color");
                    String sql = sb.ToString();

                    using(SqlCommand command = new SqlCommand(sql, connection))
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while(reader.Read())
                            {
                                Console.WriteLine("{0}   {1}", reader.GetString(0), reader.GetString(1));
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Erreur lors de la connexion à la Base de Données : \n{0}", e);
            }

            /*do
            {
                Console.WriteLine("Nombre de Joueur ?");
                input = Console.ReadLine();

                if (int.TryParse(input, out nbPlayer))
                    if (nbPlayer > 1 && nbPlayer < 5)
                        correct = true;
            } while (!correct);

            Console.Clear();

            for (int i = 0; i < nbPlayer; i++)
            {
                Console.WriteLine("Nom du Joueur {0}?", i + 1);
                name = Console.ReadLine();

                sumMonster = InputMonster();

                Console.Clear();
                do
                {
                    Console.WriteLine("Nombre de Seigneur(s) ?");
                    input = Console.ReadLine();

                    if (int.TryParse(input, out nbLords))
                        correct = true;
                } while (!correct);

                if (nbLords > 0)
                {
                    for (int j = 0; j < nbLords; j++)
                    {
                        lords.Add(InputLord());
                    }
                }

                player = new Player(name, lords, sumMonster);

                allies = InputAllie("red");
                player.allies[0] = player.MaxAllie(allies);

                allies = InputAllie("blue");
                player.allies[1] = player.MaxAllie(allies);

                allies = InputAllie("purple");
                player.allies[2] = player.MaxAllie(allies);

                allies = InputAllie("yellow");
                player.allies[3] = player.MaxAllie(allies);

                allies = InputAllie("green");
                player.allies[4] = player.MaxAllie(allies);

                player.ResultCalculation();

                players.Add(player);
                lords.Clear();
            }


            DisplayResult(players);

            */
            /*Fin*/

        }

        //Saisie des Alliés
        static List<Allie> InputAllie(string color)
        {
            /*Variables*/
            int nbAllies;   //Nombre d'Alliés
            int ip;
            bool correct = false;
            string input;
            Allie allie;
            List<Allie> allies = new List<Allie>();

            /*Début*/
            do
            {
                Console.Clear();
                Console.WriteLine("Nombre d'Alliés {0}?", color);
                input = Console.ReadLine();

                if (int.TryParse(input, out nbAllies))
                    correct = true;
            } while (!correct);

            for (int i = 0; i < nbAllies; i++)
            {
                ip = InputInfluence(i);
                allie = new Allie(color, ip);
                allies.Add(allie);
            }

            return allies;
            /*Fin*/
        }

        //Saisie des Points d'Influences des Alliés
        static int InputInfluence(int i)
        {
            /*Variables*/
            string input;
            bool correct = false;
            int ip;         //Points d'influences            

            /*Début*/
            do
            {
                Console.Clear();
                Console.WriteLine("Influence de l'allié {0}?", i + 1);
                input = Console.ReadLine();

                if (int.TryParse(input, out ip))
                    if (ip > 0 && ip < 6)
                        correct = true;

            } while (!correct);

            return ip;

            /*Fin*/
        }

        //Saisie des Monstres
        static int InputMonster()
        {
            /*Variables*/
            bool correct = false;
            string input;
            int nbMonster;
            int ip;
            int sum = 0;

            /*Début*/
            Console.Clear();

            do
            {
                Console.WriteLine("Nombre de Monstre(s) ?");
                input = Console.ReadLine();

                if (int.TryParse(input, out nbMonster))
                    correct = true;
            } while (!correct);

            if (nbMonster > 0)
            {
                for (int i = 0; i < nbMonster; i++)
                {
                    do
                    {
                        Console.WriteLine("Points d'Influences ?");
                        input = Console.ReadLine();

                        if (int.TryParse(input, out ip))
                            correct = true;
                    } while (!correct);

                    sum += ip;
                }
            }

            return sum;
            /*Fin*/
        }

        //Saisie des Seigneurs
        static Lord InputLord()
        {
            string input;
            bool correct = false;
            string name;
            string color;
            int ip;
            Lord lord;

            Console.Clear();

            Console.WriteLine("Nom Seigneur");
            name = Console.ReadLine();

            Console.WriteLine("Couleur Seigneur");
            color = SelectColor();            

            do
            {
                Console.WriteLine("Points d'Influences ?");
                input = Console.ReadLine();

                if (int.TryParse(input, out ip))
                    correct = true;
            } while (!correct);

            lord = new Lord(name, color, ip);

            return lord;
        }

        //Affichage du Résultat
        static void DisplayResult(List<Player> players)
        {
            /*Variables*/
            Player win = new Player();
            
            /*Début*/
            Console.Clear();

            foreach (Player play in players)
            {                
                play.ResultCalculation();
                Console.WriteLine("***{0}***", play.name);
                Console.WriteLine("Lieux : {0}\nSeigneurs : {1}\nAlliés : {2}\nMonstres : {3}", play.sumLocation, play.sumLord, play.sumAllies, play.sumMonster);
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Total : {0}", play.result);
                Console.WriteLine("\n=====================================================\n");

                if (play.result > win.result)
                    win = play;
            }

            Console.WriteLine("Vainqueur : {0}\nTotal : {1}", win.name, win.result);
            /*Fin*/
        }

        /*Sélection Couleurs*/
        static string SelectColor()
        {
            bool correct = false;
            int select;
            string input;
            string color;

            do
            {
                Console.WriteLine("Choisir la couleur du Seigneur.");
                Console.WriteLine("1. Rouge");
                Console.WriteLine("2. Bleu");
                Console.WriteLine("3. Violet");
                Console.WriteLine("4. Jaune");
                Console.WriteLine("5. Vert");

                input = Console.ReadLine();

                if (int.TryParse(input, out select))
                    if (select > 0 && select < 6)
                        correct = true;
            } while (!correct);

            switch (select)
            {
                case 1:     //Crabe
                    color = "red";
                    break;
                case 2:     //Poulpe
                    color = "blue";
                    break;
                case 3:     //Méduse
                    color = "purple";
                    break;
                case 4:     //Hippocampe
                    color = "yellow";
                    break;
                case 5:     //Coquillage
                    color = "green";
                    break;
                default:
                    color = "";
                    break;
            }

            return color;
        }
    }
}
