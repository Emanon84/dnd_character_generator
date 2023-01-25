﻿using System;

namespace dnd_character_generator
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Vad vill du att din karaktär ska heta?");
            string karaktar = Console.ReadLine();
            Console.WriteLine("Genererar karaktär...");
            Console.WriteLine("---------------------");
            Console.WriteLine("---------------------");
            Character Char1 = new Character(karaktar);

            //Console.WriteLine("Namn: {0}, Klass: {1}, Ras: {2}", Char1.CharName, Char1.CharClass, Char1.CharRace);
            //Console.WriteLine(" ");
            int choice = 100;
            do
            {
                Console.WriteLine("---------------------");
                Console.WriteLine("Namn: {0}, Klass: {1}, Ras: {2}", Char1.CharName, Char1.CharClass, Char1.CharRace);
                Console.WriteLine(" ");
                Console.WriteLine("Välj ett av följande: ");
                Console.WriteLine("1: Godkänn karaktär");
                Console.WriteLine("2: Byt klass på karaktär");
                Console.WriteLine("3: Byt ras på karaktär");
                Console.WriteLine("---------------------");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out choice))
                {

                    Console.Clear();
                    //Console.WriteLine(choice);
                    Console.WriteLine("Ogiltigt val, försök igen");
                   

                }
                else if (choice > 3 || choice < 1)
                {
                    Console.Clear();
                    Console.WriteLine("Du måste väljar 1, 2 eller 3");
                    choice = 100;
                }
                else if (choice == 1)
                {                  
                    Console.WriteLine("Karaktären godkänd! Avslutar programmet");
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Genererar ny klass...");
                    Char1.RollClass();
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Generear ny ras");
                    Char1.RollRace();
                }

            } while (choice != 1);


        }
    }
}
