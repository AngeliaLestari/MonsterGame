using System;
using System.Linq.Expressions;

namespace Monster_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Buildacreature("Ghost", "Monster", "Ghost");
          
            RandomCreature();

        }

        static void Buildacreature(string head, string body, string feet)
        {
            int headnum = Translatetonumber(head);
            int bodynum = Translatetonumber(body);
            int feetnum = Translatetonumber(feet);
            SwitchCase(headnum, bodynum, feetnum);

        }
        
        static void RandomCreature()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);
            SwitchCase(head, body, feet);
        }

        static void SwitchCase (int head, int body, int feet) 
        {
            switch (head) 
            {
                case 1:
                GhostHead();
                break;

                case 2:
                MonsterHead();
                break;

                case 3:
                BugHead();
                break;

            }

            switch(body)
            {
                case 1:
                GhostBody();
                break;

                case 2:
                MonsterBody();
                break;

                case 3:
                BugBody();
                break;

            }

            switch(feet)
            {
                case 1:
                GhostFeet();
                break;

                case 2:
                MonsterFeet();
                break;

                case 3:
                BugFeet();
                break;

            }
        }

        static int Translatetonumber(string creature) 
        {
            switch (creature) 
            {
                case "Ghost":
                return 1;
   
                case "Monster":
                return 2;
               
                case "Bug":
                return 3;
           
                default:
                return 1;
            } 
        }
        

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("　  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");

        












     }
        }
}
