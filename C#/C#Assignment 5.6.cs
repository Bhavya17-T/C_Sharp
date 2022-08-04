using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Team
    {
        private string PlayerName;
        private int RunsScored;
        public string playername
        {
            get { return PlayerName; }
            set { PlayerName = value; }
        }
        public int runsscored
        {
            get { return RunsScored; }
            set { RunsScored = value; }
        }
        public void Display()
        {
            Console.WriteLine("player name :" +PlayerName);
            Console.WriteLine("Runs Scored : " +RunsScored);
        }
    }

    class Player
    {
        static void Main()
        {
            Console.WriteLine("enter size");
            int n = int.Parse(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Player Name : ");
                arr[i] = Console.ReadLine();
                if (i< n)
                {
                    Console.WriteLine("Runs Scored : ");
                    int RunsScored = int.Parse(Console.ReadLine());
                }
            } 
            Team T = new Team();
            T.playername = "Sachin";
            T.runsscored = 100;
            T.Display();
            
        }
    }
   



}
    
