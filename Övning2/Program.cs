using System;
using System.Linq;
using System.IO;

namespace Övning2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*************************");
            Console.WriteLine("* This is the main menu *");
            Console.WriteLine("*************************");
            Console.ForegroundColor = ConsoleColor.White;

            string uSelection;

            do
            {
                Console.WriteLine("");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*****************************************");
                Console.WriteLine("* Please navigate by selecting a number *");
                Console.WriteLine("*****************************************");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("1- Youth or Pensioner");
                Console.WriteLine("2- Going as a group");
                Console.WriteLine("3- Repeat ten times");
                Console.WriteLine("4- The third word");
                Console.WriteLine("0- Quit the application");

                
                uSelection = Console.ReadLine();

                switch (uSelection)
                {
                    case "1":   CheckAge();
                        break;
                    case "2":   CheckGroup();
                        break;
                    case "3":   RepeatTenTimes();
                        break;
                    case "4":   SplitString();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("invalid selection, try again");
                        break;
                }

            }
            while (uSelection != "0");
            Console.WriteLine("Thank you and welcome back!");
            Console.Read();
        }

        private static void CheckAge()
        {
            Console.WriteLine("Checking user age");
            Console.Write("Enter your age: ");
            int userAge = int.Parse(Console.ReadLine());

            if (userAge <= 20)
            {
                Console.WriteLine("Youth price: 80kr");
                Console.ReadLine();
            }
            else if (userAge >= 64)
            {
                Console.WriteLine("Pensioner price: 90kr");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Standard price: 120kr");
                Console.ReadLine();
            }
        }

        private static int CheckAge2(int i)
        {
            Console.WriteLine($"Checking age for user nr {i}");
            Console.Write("Enter your age: ");
            int userAge = int.Parse(Console.ReadLine());

            if (userAge <= 20)
            {
                return 80;
            }
            else if (userAge >= 64)
            {
                return 90;
            }
            else
            {
                return 120;
            }

        }

        private static void CheckGroup()
        {
            Console.WriteLine("Checking group information");
            Console.WriteLine("**************************");
            Console.Write("Enter the number of members:");
            int agroup = int.Parse(Console.ReadLine());

            int totalCost = 0;

            for (int i = 1; i < agroup + 1; i++)
            {
                totalCost = totalCost + CheckAge2(i);
            }

            Console.WriteLine($"The total cost for the group is: {totalCost} kr");

            //Console.WriteLine(agroup);
            //Console.Write($"Enter your age of the member: {agroup}");
            Console.ReadLine();


            
        }

        private static  void RepeatTenTimes()
        {
            Console.WriteLine("Repeating a word ten times");
            Console.Write("Please enter a word: "); //we will asume the user enter a word only.
            string userWord = Console.ReadLine();

            
            for (int i = 0; i < 10; i++) 
            {
                
                Console.Write("{0}, ",userWord);
                

            }
        }

        private static void SplitString()
        {
            Console.WriteLine("Spliting a three words string");
            Console.Write("Please enter three words: "); //we will asume the user enter three words only.
            string uWords = Console.ReadLine();

            Console.WriteLine("The string you enterd is:\n" + uWords);
            string[] myStr = uWords.Split(' ');
            Console.WriteLine("\nBelow is the last splitted word:");
            
            Console.WriteLine(myStr[2]);
           
        }

    }
}
