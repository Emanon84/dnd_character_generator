using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_generator
{
    internal class Character
    {

        public string CharName = string.Empty;
        public string CharClass = string.Empty;
        public string CharRace = string.Empty;

        public Character()
        {
            this.CharName = "Ugluk";
            RollClass();
            RollRace();

        }
        public Character(string CharName)
        {
            this.CharName = CharName;

            //this.CharClass = RollClass2();
            RollClass();
            RollRace();
        }



        public void RollClass()
        {

            int klass;
            string CurrentClass = this.CharClass;

            do
            {
                //Console.WriteLine("Genererar klass");
                klass = RandomNumberGenerator.GetInt32(12);

                switch (klass)
                {
                    case 0:
                        CharClass = "Barbarian";
                        break;
                    case 1:
                        CharClass = "Bard";
                        break;
                    case 2:
                        CharClass = "Cleric";
                        break;
                    case 3:
                        CharClass = "Druid";
                        break;
                    case 4:
                        CharClass = "Fighter";
                        break;
                    case 5:
                        CharClass = "Monk";
                        break;
                    case 6:
                        CharClass = "Paladin";
                        break;
                    case 7:
                        CharClass = "Ranger";
                        break;
                    case 8:
                        CharClass = "Rogue";
                        break;
                    case 9:
                        CharClass = "Sorcerer";
                        break;
                    case 10:
                        CharClass = "Warlock";
                        break;
                    case 11:
                        CharClass = "Wizard";
                        break;

                }
            } while (CurrentClass == this.CharClass);
        }


        public void RollRace()
        {
            int ras;
            string CurrentRace = this.CharRace;

            do
            {

                //Console.WriteLine("Genererar ras...");
                ras = RandomNumberGenerator.GetInt32(9);

                switch (ras)
            {
                case 0:
                    CharRace = "Dragonborn";
                    break;
                case 1:
                    CharRace = "Dwarf";
                    break;

                case 2:
                    CharRace = "Elf";
                    break;
                case 3:
                    CharRace = "Gnome";
                    break;
                case 4:
                    CharRace = "Half-Elf";
                    break;
                case 5:
                    CharRace = "Halfling";
                    break;
                case 6:
                    CharRace = "Half-Orc";
                    break;
                case 7:
                    CharRace = "Human";
                    break;
                case 8:
                    CharRace = "Tiefling";
                    break;
            }
            }while(CurrentRace == this.CharRace);
        }


    }
}
