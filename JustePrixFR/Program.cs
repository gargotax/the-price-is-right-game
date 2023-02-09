global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;

namespace justePrix
{
    public class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("bienvenue au juste prix!");
            Console.WriteLine("pour jouer ecrivez un numero compris entre 0 et 100");


            Random justePrix = new Random();
            int num = justePrix.Next(0, 101);
            int life = 10;
            bool win = false;


            while (life > 0 && !win)
            {
                int inputnumber;
                string inputString = Console.ReadLine();

                if (int.TryParse(inputString, out inputnumber))
                {
                    if (inputnumber < 0 || inputnumber > 100)
                    {
                        Console.WriteLine("j'ai dit entre 0 e 100!");
                    }
                    else if (inputnumber == num)
                    {
                        Console.WriteLine("bravo vous avez deviné le juste prix:" + num);
                        win = true;
                    }

                    if (inputnumber > num)
                    {
                        Console.WriteLine("moins");
                        life--;
                        Console.WriteLine("vous avez encore: " + life + " tentatives");
                    }

                    if (inputnumber < num)
                    {
                        Console.WriteLine("plus");

                        life--;
                        Console.WriteLine("vous avez encore: " + life + " tentatives");
                    }

                    if (life == 0)
                    {
                        Console.WriteLine($"game over, le juste prix était: {0}", num);
                        win = true;
                    }



                }


            }


        }


    }



}