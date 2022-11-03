using System;
namespace ElephantGame
{
    class program
    {
        static void Main(string[] args)
        {
            Elephant lucinda = new Elephant() { EarSize = 33, Name = "Lucinda" };
            Elephant lloyd = new Elephant() { EarSize = 40, Name = "Lloyd" };

            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 for swap, 4 for changed value and 5 for messaging");
            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You pressed " + input);
                if (input == '1')
                {
                    Console.WriteLine("Calling lloyd.WhoAmI()");
                    lloyd.WhoAmI();
                }
                else if (input == '2')
                {
                    Console.WriteLine("Calling lucinda.WhoAmI()");
                    lucinda.WhoAmI();
                }
                else if (input == '3')
                {
                    Elephant holder;
                    holder = lloyd;
                    lloyd = lucinda;
                    lucinda = holder;
                    Console.WriteLine("References have been Swapped");
                }
                else if (input == '4')
                {
                    lloyd = lucinda;
                    lloyd.EarSize = 4321;
                    lloyd.WhoAmI();
                }
                else if(input == '5')
                {
                    
                    lucinda.SpeakTo(lloyd, "Hy, Lloyd!");
                }
                else
                {
                    Console.WriteLine();
                }

            }
        }
    }
}