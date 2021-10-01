using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\Admin\OneDrive - Sysco Corporation\Desktop\Logs\log.txt", text);

            //string text = File.ReadAllText("C:\\Users\\Admin\\OneDrive - Sysco Corporation\\Desktop\\Logs\\log.txt");

            //DateTime dateTime = new DateTime(1995, 5, 23, 8, 32, 45);

            //DateTime yearofBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearofGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = yearofGraduation - yearofBirth;

            //const string casinoName = "Grand Hotl and Casino";
            //Console.Write("Welcome to the {0}. let's start by telling me your name.", casinoName);  //creating a constant variable

           

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("How much money did you vring today?");
            int bank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, {0}. would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);

                player.ID = Guid.NewGuid(); //GUID
                using (StreamWriter file = new StreamWriter(@"C:\Users\Admin\OneDrive - Sysco Corporation\Desktop\Logs\log.txt", true))
                {
                    file.WriteLine(player.Id);
                    
                }

                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while(player.isActivelyPlaying && player.Balance >0) // check while player is actively player amd check if the blance is greater  than zero ( if the player alnce blow zero  he cannot play). if true it will continue playin
                {
                    game.Play();

                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }

            Console.WriteLine("Fell free to look around the casino. Bye for now.");
            Console.ReadLine();



         
        }
    }
}

