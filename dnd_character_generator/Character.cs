using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dnd_character_generator
{
    internal class Character
    {

        private string charName = string.Empty;
        private string charClass = string.Empty;
        private string charRace = string.Empty;

        public string CharName {
            get
            {
                return charName;
            }
            set
            {
                charName = value;
            } 
        }

        public string CharClass
        {
            get
            {
                return charClass;
            }
            set
            {
                charClass = value;
            }
        }

        public string CharRace
        {
            get
            {
                return charRace;
            }
            set
            {
                charRace = value;
            }
        }



        public Character()
        {
            this.charName = "Ugluk";
            RollClass();
            RollRace();

        }
        public Character(string charName)
        {
            this.charName = charName;

            //this.charClass = RollClass2();
            RollClass();
            RollRace();
        }



        public void RollClass()
        {

            int klass;
            string CurrentClass = this.charClass;

            do
            {
                //Console.WriteLine("Genererar klass");
                klass = RandomNumberGenerator.GetInt32(12);

                switch (klass)
                {
                    case 0:
                        charClass = "Barbarian";
                        break;
                    case 1:
                        charClass = "Bard";
                        break;
                    case 2:
                        charClass = "Cleric";
                        break;
                    case 3:
                        charClass = "Druid";
                        break;
                    case 4:
                        charClass = "Fighter";
                        break;
                    case 5:
                        charClass = "Monk";
                        break;
                    case 6:
                        charClass = "Paladin";
                        break;
                    case 7:
                        charClass = "Ranger";
                        break;
                    case 8:
                        charClass = "Rogue";
                        break;
                    case 9:
                        charClass = "Sorcerer";
                        break;
                    case 10:
                        charClass = "Warlock";
                        break;
                    case 11:
                        charClass = "Wizard";
                        break;

                }
            } while (CurrentClass == this.charClass);
        }


        public void RollRace()
        {
            int ras;
            string CurrentRace = this.charRace;

            do
            {

                //Console.WriteLine("Genererar ras...");
                ras = RandomNumberGenerator.GetInt32(9);

                switch (ras)
            {
                case 0:
                    charRace = "Dragonborn";
                    break;
                case 1:
                    charRace = "Dwarf";
                    break;

                case 2:
                    charRace = "Elf";
                    break;
                case 3:
                    charRace = "Gnome";
                    break;
                case 4:
                    charRace = "Half-Elf";
                    break;
                case 5:
                    charRace = "Halfling";
                    break;
                case 6:
                    charRace = "Half-Orc";
                    break;
                case 7:
                    charRace = "Human";
                    break;
                case 8:
                    charRace = "Tiefling";
                    break;
            }
            }while(CurrentRace == this.charRace);
        }


    }
}
