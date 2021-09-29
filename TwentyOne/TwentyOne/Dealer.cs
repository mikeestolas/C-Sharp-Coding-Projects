using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());

            string card = string.Format(Deck.Cards.First().ToString() + "\n");   //to log
            Console.WriteLine(card);
            using (StreamWriter file = new StreamWriter(@"C:\Users\Admin\OneDrive - Sysco Corporation\Desktop\Logs\log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);

            }


                //Console.WriteLine(Deck.Cards.First().ToString() + "\n");
                Deck.Cards.RemoveAt(0);

        }
    }
}
