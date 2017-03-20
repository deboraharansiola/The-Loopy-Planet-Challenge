using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Loopy_Planet_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuChoice = 0;
            double weight = 0;
            do
            {



                Console.WriteLine("              Menu of Planets         ");// List of available Menu Choice
                Console.WriteLine("              ==== == =======         ");// To centre the headline Menu of Planets
                Console.WriteLine("1. Jupiter      2. Mars      3. Mercury");
                Console.WriteLine("4. Neptune      5. Pluto     6. Saturn");
                Console.WriteLine("7. Uranus       8. Venus     9. <Quit>");

                // Console.WriteLine();
                do
                {
                    Console.Write("Enter your menu choice = ");
                    menuChoice = int.Parse(Console.ReadLine());

                    if (menuChoice < 1)// The Loop Statement 
                        Console.WriteLine("wrong Menu Choice, Please re-select from menu 1-9");

                } while (menuChoice < 1);
                if (menuChoice > 9)// Tthe Loop Statement

                    Console.WriteLine("Wrong Menu Choice, Please re-select from menu 1-9");
                if (menuChoice != 9)
                {
                   
                    Console.WriteLine(" Your menu choice is: {0}", menuChoice);

                    Console.Write(" Enter your weight on earth = "); 
                    weight = double.Parse(Console.ReadLine());

                    Console.Write("Your weight on earth is: {0}", weight);

                    if (weight < 1)
                        Console.WriteLine("Invalid Weight");
                    if (weight > 4999)
                        Console.WriteLine("Invalid Weight");

                }
                switch (menuChoice) //Initiate the Switch Statement for the integer menuChoice
                {
                    case 1:

                        Console.WriteLine("Your weight on Jupiter is " + 2.64 * weight);// Jupiter weight calculation
                        break;
                        
                    case 2:

                        Console.WriteLine("Your weight on Mars is " + 0.38 * weight);// Mars weight calculation
                        break;
                        
                    case 3:

                        Console.WriteLine("Your weight on Mercury is " + 0.37 * weight);// Mercury weight calculation
                        break;
                        
                    case 4:

                        Console.WriteLine("Your weight on Neptune is " + 1.12 * weight);// Neptune weight calculation
                        break;
                        
                    case 5:

                        Console.WriteLine("Your weight on Pluto is " + 0.04 * weight);// Plutor weight calculation
                        break;
                        
                    case 6:

                        Console.WriteLine("Your weight on Saturn is " + 1.15 * weight);// Ssaturn weight calculation
                        break;
                        
                    case 7:

                        Console.WriteLine("Your weight on Uranus is " + 1.15 * weight); // Uranus weight calculation
                        break;
                       
                    case 8:

                        Console.WriteLine("Your weight on Venus is " + 0.88 * weight);// Venus weight calculation
                        break;
                        
                    case 9:

                        Console.WriteLine("Have a great day! Goodbye!");// Leaves a Goodbye message and Quit
                        break;

                }
                }while (menuChoice != 9);// Loop Statement of menu choice not equals to 9
                                         
            Console.ReadLine();

        }
    }
}
