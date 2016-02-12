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


            StreamWriter newMeeting = new StreamWriter("Minutes" + filename + ".txt");

            newMeeting.WriteLine("We Can Code IT");
            newMeeting.WriteLine("50 Public Square, Suite 200, ");
            newMeeting.WriteLine("Cleveland, OH 44113");
            newMeeting.WriteLine("*********************************************************");
            newMeeting.WriteLine("\"Meeting Minutes\"");


            Console.WriteLine("What team do you wish to create a meeting for?");
            MeetType();
            string chooseTeam = Console.ReadLine();
            if (chooseTeam == "1")
            {
                newMeeting.WriteLine("Administration Team");
                Console.WriteLine("*********************************************************");
                Console.WriteLine("Write the name of the team member who is taking the meeting minutes:");
                AdministrationTeam();
                Console.WriteLine("*********************************************************");
                string minuteTaker = Console.ReadLine();
                newMeeting.WriteLine(minuteTaker);
            }
            else if (chooseTeam == "2")
            {
                newMeeting.WriteLine("Marketing Team");
                Console.WriteLine("*********************************************************");
                Console.WriteLine("Write the name of the team member who is taking the meeting minutes:");
                MarketingTeam();
                Console.WriteLine("*********************************************************");
                string minuteTaker = Console.ReadLine();
                newMeeting.WriteLine(minuteTaker);
            }
            else if (chooseTeam == "3")
            {
                newMeeting.WriteLine("Education Team");
                Console.WriteLine("*********************************************************");
                Console.WriteLine("Write the name of the team member who is taking the meeting minutes:");
                EducationTeam();
                Console.WriteLine("*********************************************************");
                string minuteTaker = Console.ReadLine();
                newMeeting.WriteLine(minuteTaker);
            }
            else if (chooseTeam == "4")
            {
                newMeeting.WriteLine("All Team");
                Console.WriteLine("*********************************************************");
                Console.WriteLine("Write the name of the team member who is taking the meeting minutes:");
                AllTeam();
                Console.WriteLine("*********************************************************");
                string minuteTaker = Console.ReadLine();
                newMeeting.WriteLine(minuteTaker);
            }
            else
            {
                Console.WriteLine("Oh no! Try an input that works!");
                Console.ReadLine();
            }


            Console.WriteLine("*********************************************************");
            Console.WriteLine("Write the name of the team member leading the meeting:");
            string teamLead = Console.ReadLine();
            if (teamLead == "1")
            {
                
                AdministrationTeam();
            }
            else if (teamLead == "2")
            {
                MarketingTeam();
            }
            else if (teamLead == "3")
            {
                EducationTeam();
            }
            else if (teamLead == "4")
            {
                AllTeam();
            }
            else
            {
                Console.WriteLine("Oh no! Try an input that works!");
                Console.ReadLine();
            }

            /*
            if (chooseTeam == "1")
            {

                AdministrationTeam();
            }
            else if (chooseTeam == "2")
            {
                MarketingTeam();
            }
            else if (chooseTeam == "3")
            {
                EducationTeam();
            }
            else if (chooseTeam == "4")
            {
                AllTeam();
            }
            else
            {
                Console.WriteLine("Oh no! Try an input that works!");
                Console.ReadLine();
            }
            */

            Console.WriteLine("Please write the topic of your meeting: ");
            string topic = Console.ReadLine();

            Console.WriteLine("Please write the meeting notes: ");
            string notes = Console.ReadLine();

            Console.WriteLine("Would you like to enter notes for another topic? (Y or N)");


            newMeeting.WriteLine("Topic: " + topic);
            newMeeting.WriteLine("Notes:");
            newMeeting.WriteLine(notes);


            newMeeting.Close();

            Console.Clear();
            //print summary
            Console.WriteLine("Summary: ");

            StreamReader readSummary = new StreamReader("Minutes" + filename + ".txt");

            using (readSummary)
            {
                int lineNumber = 0;
                string line = readSummary.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.WriteLine("{5}", lineNumber, line);
                    line = readSummary.ReadLine();
                }

            }
        }

        public static void MeetType()
        {
            List<string> meetingType = new List<string>();
            meetingType.Add("1. Administration Team");
            meetingType.Add("2. Marketing Team");
            meetingType.Add("3. Education Team");
            meetingType.Add("4. All Team");

            foreach (var name in meetingType)
            {
                Console.WriteLine(name);

            }
        }

        public static void ViewTeam()
        {
            string viewTeam = "________________________________________________________" +
                "\n1. Administration Team\n2. Marketing Team \n3. Education Team\n4. All Team";

            List<string> meetingType = new List<string>();
            meetingType.Add("Administration Team");
            meetingType.Add("Marketing Team");
            meetingType.Add("Education Team");
            meetingType.Add("All Team");


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
                else
                {
                    Console.WriteLine("Oh no! Try an input that works!");
                    Console.ReadLine();
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
