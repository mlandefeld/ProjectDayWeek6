using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeekSixProjectDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Meeting Minutes Creation Software";
            string s = "Meeting Minutes Creation Software";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);

            string menu = "________________________________________________________" +
                "\nEnter the number for the item you wish to select\n1. Create Meeting\n2. View Team\n3. Exit";
            Console.WriteLine(menu);
            string input = Console.ReadLine();

            while (true)
            {
                Console.WriteLine(menu);
                if (input == "1")
                {
                    Console.Clear();
                    Commands.Header();
                    Commands.CreateMeeting();
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "2")
                {
                    Console.Clear();
                    Commands.Header();
                    Commands.ViewTeam();
                    Console.WriteLine(menu);
                    input = Console.ReadLine();
                    continue;
                }
                else if (input == "3")
                {
                    Commands.Exit();
                }
                else
                {
                    Console.WriteLine("Oops! You need to enter a vaild menu number!");
                    input = Console.ReadLine();
                }

            }
        }
    }
}

