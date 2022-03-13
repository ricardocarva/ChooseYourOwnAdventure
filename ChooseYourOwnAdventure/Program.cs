using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            /*
                        This program is a Choose Your Own Adventure Game where depending on the choices the user makes, the program leads them to different results.

                        Author: Ricardo Carvalheira
            */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"\r\nHello, {name}! Welcome to our story.\r\n");

            Console.WriteLine("It begins on a cold rainy night." +
             "You're sitting in your room and hear a noise coming " +
             "from down the hall. Do you go investigate?");

            Console.Write("Type YES or NO: ");

            string noiseChoice = Console.ReadLine();

            if (noiseChoice.ToUpper() == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!");
                Console.WriteLine("THE END.");
                Console.WriteLine("\r\n     Press Enter to close tab...");
                Console.ReadLine();
                Environment.Exit(0);

            }
            else if (noiseChoice.ToUpper() == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.");
                Console.WriteLine("You walk towards it. Do you open it or knock?");
            }
            else
            {
                Console.WriteLine("Not a valid input");
                Console.WriteLine("THE END.");
                Console.WriteLine("\r\n     Press Enter to close tab...");
                Console.ReadLine();
                Environment.Exit(0);
            }

            Console.Write("Type OPEN or KNOCK: ");
            string doorChoice = Console.ReadLine();

            if (doorChoice.ToUpper() == "KNOCK")
            {
                Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"");
                Console.WriteLine("\"Poor people have it. Rich people need it. If you eat it you die. What is it?\"");
                Console.Write("Type your answer: ");
                string riddleAnswer = Console.ReadLine();

                if (riddleAnswer.ToUpper() == "NOTHING")
                {
                    Console.WriteLine("The door opens and NOTHING is there.");
                    Console.WriteLine("You turn off the light and run back to your room and lock the door.");

                }
                else
                {
                    Console.WriteLine("You answered incorrectly. The door doesn't open.");

                }
                Console.WriteLine("THE END.");
                Console.WriteLine("\r\n     Press Enter to close tab...");
                Console.ReadLine();
                Environment.Exit(0);


            }
            else if (doorChoice.ToUpper() == "OPEN")
            {
                Console.WriteLine("The door is locked! See if one of your three keys will open it.");
                Console.Write("Enter a number (1-3): ");
                string keyChoice = Console.ReadLine().ToUpper().ToString();

                switch (keyChoice)
                {
                    case "1":
                        Console.WriteLine("You choose the first key. Lucky choice!");
                        Console.WriteLine("The door opens and NOTHING is there. Strange...");
                        Console.WriteLine("THE END.");
                        break;

                    case "2":
                        Console.WriteLine("You choose the second key. The door doesn't open.");
                        Console.WriteLine("THE END.");
                        break;

                    case "3":
                        Console.WriteLine("You choose the third key. The door doesn't open.");
                        Console.WriteLine("THE END.");
                        break;

                    default:
                        Console.WriteLine("Not a valid input");
                        Console.WriteLine("THE END.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Not a valid input");
                Console.WriteLine("THE END.");
       
            }   
            Console.WriteLine("\r\n     Press Enter to close tab...");
            Console.ReadLine();
            Console.Clear();
            Environment.Exit(0);

        }
    }
}
