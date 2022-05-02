using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    internal class Program
    {
        static void Give_Inv(int Inv_Numb)
        {
            Inventar Inv = new Inventar();
            if (Inv_Numb == 1)
                if (Inv.First_Place == 0)
                {
                    Console.WriteLine("Dieser Platz ist Frei");
                }
            if (Inv_Numb == 2)
                if (Inv.Second_Place == 0)
                {
                    Console.WriteLine("Dieser Platz ist Frei");
                }
            if (Inv_Numb == 3)
                if (Inv.Third_Place == 0)
                {
                    Console.WriteLine("Dieser Platz ist Frei");
                }
            if (Inv_Numb == 4)
                if (Inv.Fourth_Place == 0)
                {
                    Console.WriteLine("Dieser Platz ist Frei");
                }
            if (Inv_Numb == 5)
                if (Inv.Fifth_Place == 0)
                {
                    Console.WriteLine("Dieser Platz ist Frei");
                }
            if (Inv_Numb == 6)
                if (Inv.Sixth_Place == 0)
                {
                    Console.WriteLine("Dieser Platz ist Frei");
                }
            if (Inv_Numb == 7)
                if (Inv.Seventh_Place == 0)
                {
                    Console.WriteLine("Dieser Platz ist Frei");
                }
            if (Inv_Numb == 8)
                if (Inv.Eighth_Place == 0)
                {
                    Console.WriteLine("Dieser Platz ist Frei");
                }
            if (Inv_Numb == 9)
                if (Inv.Ninth_Place == 0)
                {
                    Console.WriteLine("Dieser Platz ist Frei");
                }
            if (Inv_Numb == 10)
                if (Inv.Tenth_Place == 0)
                {
                    Console.WriteLine("Dieser Platz ist Frei");
                }
        }

        static void Main(string[] args)
        {
            /* Constructors */
            Inventar Inv = new Inventar();

            /*Tutorial*/
            for (int i = 0; i < 1; i++)
                Console.Write("Hello, Thank You for playing, but first, i will give you an Introduction to the Game." +
                    "This Game works with Commands, an full List of Commands, you get in the Commands_Guide.txt, here the most important.\n" +
                    "Inventar | Tells you which Item is in the Slot\n" +
                    "Upgrade [Slot] | Upgrade the Weapon that use the Slot\n" +
                    "Fight [Level] | Fight an enemy with an choosen Level\n" +
                    "");
            while (true)
            {
                /*Main Loop*/
                Console.WriteLine("Show me you next Move!");
                string Beginning = Console.ReadLine();
                if (Beginning == "Inventar")
                {
                    Console.WriteLine("What slot you lookin for?");
                    string Inv_nmb = Console.ReadLine();
                    commands.CMD_INV.INV_CMD((int)Convert.ToInt64(Inv_nmb));
                }
                else if (Beginning == "Equip" || Beginning == "equip")
                    commands.CMD_EQUIP.EQIUIP_CMD();
                else if (Beginning == "Fight" ||Beginning == "Fight")
                    commands.CMD_EQUIP.FIGHT_CMD();
                else if (Beginning == "Money" || Beginning == "money")
                {
                    Console.WriteLine(Convert.ToString(Inventar.Money));
                }
            }
        }
    }
    class Inventar
    {

        public int First_Place;
        public int Second_Place;
        public int Third_Place;
        public int Fourth_Place;
        public int Fifth_Place;
        public int Sixth_Place;
        public int Seventh_Place;
        public int Eighth_Place;
        public int Ninth_Place;
        public int Tenth_Place;
        public static int W_Equipped;
        public static int Money = 1;

    }
    public class Declarations
    {

        public static bool G36_OWNED = true;
        public bool M4A1_OWNED = false;
        public bool AK47_OWNED = false;
    }
    namespace Rifles
    {
        public class G36
        {
            /* Damage, the Weapon is Dealing */
            public int Damage = 16;
            /* Base Caliber */
            public double Caliber = 5.56;
            /* Base Durability in Shots */
            public double Durability = 300;
            /* Possible Mods, at once */
            public int Mods = 6;
        }

        public class M4A1
        {
            /* Damage, the Weapon is Dealing */
            public int Damage = 22;
            /* Base Caliber */
            public double Caliber = 7.41;
            /* Base Durability in Shots */
            public double Durability = 150;
            /* Possible Mods, at once */
            public int Mods = 4;
        }
        public class AK47
        {
            /* Damage, the Weapon is Dealing */
            public int Damage = 32;
            /* Base Caliber */
            public double Caliber = 7.62;
            /* Base Durability in Shots */
            public double Durability = 400;
            /* Possible Mods, at once */
            public int Mods = 2;


        }
    }
    namespace Items
    {
        class Healing_Drink
        {
            /* Leben, welches bei benutzung geheilt wird */
            public int HealedLife = 25;

        }
    }

    namespace commands
    {
        public class CMD_INV
        {

            public static void INV_CMD(int Inv_Numb)
            {
                RPG.Inventar Inv = new RPG.Inventar();
                if (Inv_Numb == 1)
                {
                    if (Inv.First_Place == 0)
                    {
                        Console.WriteLine("Dieser Platz ist Frei");
                    }
                    else if (Inv.First_Place == 0001)
                    {
                        Console.WriteLine("Here is an G36");
                    }
                    else if (Inv.First_Place == 0002)
                    {
                        Console.WriteLine("Here is an M4A1");
                    }
                    else if (Inv.First_Place == 0003)
                    {
                        Console.WriteLine("Here is an AK47");
                    }
                }
                if (Inv_Numb == 2)
                {
                    if (Inv.Second_Place == 0)
                    {
                        Console.WriteLine("Dieser Platz ist Frei");
                    }
                    else if (Inv.Second_Place == 0001)
                    {
                        Console.WriteLine("Here is an G36");
                    }
                    else if (Inv.Second_Place == 0002)
                    {
                        Console.WriteLine("Here is an M4A1");
                    }
                    else if (Inv.Second_Place == 0003)
                    {
                        Console.WriteLine("Here is an AK47");
                    }
                }
                if (Inv_Numb == 3)
                {
                    if (Inv.Third_Place == 0)
                    {
                        Console.WriteLine("Dieser Platz ist Frei");
                    }
                    else if (Inv.Third_Place == 0001)
                    {
                        Console.WriteLine("Here is an G36");
                    }
                    else if (Inv.Third_Place == 0002)
                    {
                        Console.WriteLine("Here is an M4A1");
                    }
                    else if (Inv.Third_Place == 0003)
                    {
                        Console.WriteLine("Here is an AK47");
                    }
                }
                if (Inv_Numb == 4)
                {
                    if (Inv.Fourth_Place == 0)
                    {
                        Console.WriteLine("Dieser Platz ist Frei");
                    }
                    else if (Inv.Fourth_Place == 0001)
                    {
                        Console.WriteLine("Here is an G36");
                    }
                    else if (Inv.Fourth_Place == 0002)
                    {
                        Console.WriteLine("Here is an M4A1");
                    }
                    else if (Inv.Fourth_Place == 0003)
                    {
                        Console.WriteLine("Here is an AK47");
                    }
                }
                if (Inv_Numb == 5)
                {
                    if (Inv.Fifth_Place == 0)
                    {
                        Console.WriteLine("Dieser Platz ist Frei");
                    }
                    else if (Inv.Fifth_Place == 0001)
                    {
                        Console.WriteLine("Here is an G36");
                    }
                    else if (Inv.Fifth_Place == 0002)
                    {
                        Console.WriteLine("Here is an M4A1");
                    }
                    else if (Inv.Fifth_Place == 0003)
                    {
                        Console.WriteLine("Here is an AK47");
                    }
                }
                if (Inv_Numb == 6)
                {
                    if (Inv.Sixth_Place == 0)
                    {
                        Console.WriteLine("Dieser Platz ist Frei");
                    }
                    else if (Inv.Sixth_Place == 0001)
                    {
                        Console.WriteLine("Here is an G36");
                    }
                    else if (Inv.Sixth_Place == 0002)
                    {
                        Console.WriteLine("Here is an M4A1");
                    }
                    else if (Inv.Sixth_Place == 0003)
                    {
                        Console.WriteLine("Here is an AK47");
                    }
                }
                if (Inv_Numb == 7)
                {
                    if (Inv.Seventh_Place == 0)
                    {
                        Console.WriteLine("Dieser Platz ist Frei");
                    }
                    else if (Inv.Seventh_Place == 0001)
                    {
                        Console.WriteLine("Here is an G36");
                    }
                    else if (Inv.Seventh_Place == 0002)
                    {
                        Console.WriteLine("Here is an M4A1");
                    }
                    else if (Inv.Seventh_Place == 0003)
                    {
                        Console.WriteLine("Here is an AK47");
                    }
                }
                if (Inv_Numb == 8)
                {
                    if (Inv.Eighth_Place == 0)
                    {
                        Console.WriteLine("Dieser Platz ist Frei");
                    }
                    else if (Inv.Eighth_Place == 0001)
                    {
                        Console.WriteLine("Here is an G36");
                    }
                    else if (Inv.Eighth_Place == 0002)
                    {
                        Console.WriteLine("Here is an M4A1");
                    }
                    else if (Inv.Eighth_Place == 0003)
                    {
                        Console.WriteLine("Here is an AK47");
                    }
                }
                if (Inv_Numb == 9)
                {
                    if (Inv.Ninth_Place == 0)
                    {
                        Console.WriteLine("Dieser Platz ist Frei");
                    }
                    else if (Inv.Ninth_Place == 0001)
                    {
                        Console.WriteLine("Here is an G36");
                    }
                    else if (Inv.Ninth_Place == 0002)
                    {
                        Console.WriteLine("Here is an M4A1");
                    }
                    else if (Inv.Ninth_Place == 0003)
                    {
                        Console.WriteLine("Here is an AK47");
                    }
                }
                if (Inv_Numb == 10)
                {
                    if (Inv.Tenth_Place == 0)
                    {
                        Console.WriteLine("Dieser Platz ist Frei");
                    }
                    else if (Inv.Tenth_Place == 0001)
                    {
                        Console.WriteLine("Here is an G36");
                    }
                    else if (Inv.Tenth_Place == 0002)
                    {
                        Console.WriteLine("Here is an M4A1");
                    }
                    else if (Inv.Tenth_Place == 0003)
                    {
                        Console.WriteLine("Here is an AK47");
                    }
                }
            }

        }
        public class CMD_EQUIP
        {

            public static void EQIUIP_CMD()
            {
                Console.WriteLine("Welche Waffe möchtest du ausrüsten?");
                string EQ = Console.ReadLine();
                if (EQ == "G36" || EQ == "g36")
                {

                    if (RPG.Declarations.G36_OWNED == true)
                    {
                        RPG.Inventar.W_Equipped = 1001;
                        Console.WriteLine(Convert.ToString(RPG.Inventar.W_Equipped));

                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }

                }
            } 
            public static void FIGHT_CMD()
            {

                if (RPG.Inventar.W_Equipped == 1001)
                {

                    Console.WriteLine("You won the Fight");
                    RPG.Inventar.Money++;

                }

            }


        }
    }
}
