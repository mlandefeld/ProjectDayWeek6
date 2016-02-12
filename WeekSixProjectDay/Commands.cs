using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WeekSixProjectDay
{
    class Commands
    {
        public static void CreateMeeting()
        {
            Console.WriteLine("What date are you creating a meeting for? (Answer in MMDDYY)");
            string filename = Console.ReadLine();
            Console.WriteLine("What team do you wish to create a meeting for?");
            ViewTeam();
            Console.WriteLine();

            StreamWriter newMeeting = new StreamWriter("Minutes" +filename + ".txt");

            newMeeting.WriteLine("We Can Code IT");
            newMeeting.WriteLine("50 Public Square, Suite 200, ");
            newMeeting.WriteLine("Cleveland, OH 44113");
            newMeeting.WriteLine("*********************************************************");
            newMeeting.WriteLine("\"Meeting Minutes\"");

            newMeeting.Close();

        }

        public static void EveryFileText()
        {
            
        }

        public static void ViewTeam()
        {
            string viewTeam = "________________________________________________________" +
                "\nEnter the number for the item you wish to select\n1. Administration Team\n2. Marketing Team \n3. Education Team\n4. All Team";
            Console.WriteLine(viewTeam);
            int teamInput = int.Parse(Console.ReadLine());

            while (true)
            {
                if (teamInput == 1)
                {
                    AdministrationTeam();
                    break;
                }
                else if (teamInput == 2)
                {
                    MarketingTeam();
                    break;
                }
                else if (teamInput == 3)
                {
                    EducationTeam();
                    break;
                }
                else if (teamInput == 4)
                {
                    AllTeam();
                    break;
                }
            }
        }

        public static void AdministrationTeam()
        {
            List<string> adminTeam = new List<string>();
            adminTeam.Add("Amy Arthur");
            adminTeam.Add("Bob Bobert");
            adminTeam.Add("Carl Cruso");
            adminTeam.Add("Dana Donner");

            Console.WriteLine("Administration Team Directory" +
               "\n*********************************************************");
            foreach (var name in adminTeam)
            {
                Console.WriteLine(name);

            }

        }

        public static void MarketingTeam()
        {
            List<string> markTeam = new List<string>();
            markTeam.Add("Eric Elton");
            markTeam.Add("Fred Fredricks");
            markTeam.Add("Gigi Golden");
            markTeam.Add("Harry Humphries");

            Console.WriteLine("Marketing Team Directory" +
               "\n*********************************************************");
            foreach (var name in markTeam)
            {
                Console.WriteLine(name);

            }
        }

        public static void EducationTeam()
        {
            List<string> eduTeam = new List<string>();
            eduTeam.Add("Ida Idle");
            eduTeam.Add("James Jameson");
            eduTeam.Add("Kate Kerrington");
            eduTeam.Add("Lucy Lucky");

            Console.WriteLine("Education Team Directory" +
               "\n*********************************************************");
            foreach (var name in eduTeam)
            {
                Console.WriteLine(name);
            }

        }

        public static void AllTeam()
        {
            Dictionary<string, string> allTeam = new Dictionary<string, string>();
            allTeam.Add("Amy Arthur", "(Administration Team)");
            allTeam.Add("Bob Bobert", "(Administration Team)");
            allTeam.Add("Carl Cruso", "(Administration Team)");
            allTeam.Add("Dana Donner", "(Administration Team)");
            allTeam.Add("Eric Elton", "(Marketing Team)");
            allTeam.Add("Fred Fredricks", "(Marketing Team)");
            allTeam.Add("Gigi Golden", "(Marketing Team)");
            allTeam.Add("Harry Humphries", "(Marketing Team)");
            allTeam.Add("Ida Idle", "(Education Team)");
            allTeam.Add("James Jameson", "(Education Team)");
            allTeam.Add("Kate Kerrington", "(Education Team)");
            allTeam.Add("Lucy Lucky", "(Education Team)");

            Console.WriteLine("All Team Directory" +
                "\n*********************************************************");
            foreach (KeyValuePair<string, string> pair in allTeam)
            {
                Console.WriteLine(pair.Key + " " + pair.Value);
            }


        }

        public static void Header()
        {
            string s = "Meeting Minutes Creation Software";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine(s);
        }

        public static void Exit()
        {
            Console.Clear();
            Console.WriteLine("\nGoodbye! We hope you enjoyed creaing meeting minutes with this software!\n");
            Environment.Exit(0);
        }
    }
}
