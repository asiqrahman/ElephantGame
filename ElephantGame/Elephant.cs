using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElephantGame
{
    class Elephant
    {
        public int EarSize;
        public string Name;
        public void WhoAmI()
        {
            Console.WriteLine("I am " + Name + " my ear size is " + EarSize + ".");
        }
        public void HearMessage(string message, Elephant WhoSaidIt)
        {
            Console.WriteLine(Name + " heard a message");
            Console.WriteLine(WhoSaidIt.Name + " said this: " + message);
        }
        public void SpeakTo(Elephant WhoToTalkTo, string message)
        {
            WhoToTalkTo.HearMessage(message,this);
        }
    }
}
