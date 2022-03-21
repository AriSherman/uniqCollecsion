

using System;
using System.Collections;

namespace uniqCollecsion
{
    class Program
    {
        public static void Main(string[] args)
        {
            string UserInput = "";
            Console.Clear();
            ConsoleKeyInfo input;
            List<string> Names = new List<string>();

            do
            {
                System.Console.WriteLine("----------------------");
                Console.WriteLine(@"Choose an option from foolowing list:
                               a - Add
                               d - Remove
                               e - Enumerate
                               b - Contains
                               c - Clear
                               q - Quit
                            Your option?");
                UserInput = Convert.ToString(Console.ReadLine().ToLower().Trim());
                input = Console.ReadKey();

                switch (UserInput)
                {
                    case "a": //Adds an element with validation of uniq Name to uniqCollecsion
                        Console.WriteLine("Enter your Name to Add:");
                        string nameInputAdd = Convert.ToString(Console.ReadLine());
                        try
                        {
                            Names.Add(nameInputAdd);
                            Console.WriteLine($"The element is added to {Names}");
                        }
                        catch (Exception nameAlreadyExists)
                        {
                            Console.WriteLine("Error: Name already exsist.");
                        }
                        break;
                    case "d": //Removes the element from the uniqCollecsion.
                        Console.WriteLine("Enter the Name of the element to remove:");
                        string inputNameRemove = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("The Name \"{0}\" is {1}.", inputNameRemove, Names.Remove(inputNameRemove) ? "has been removed" : "NOT in the uniqCollecsion");                       
                        break;
                    case "e": // Displays the values of the Hashtable
                        Console.WriteLine("The uniqCollecsion contains the following Names:");
                        PrintuniqCollecsion(Names);
                        break;
                    case "b": //Determines whether the uniqCollecsion contains a specific key.
                        Console.WriteLine("Enter the Name to check if Name is contained:");
                        string inputNameContain = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("The Name \"{0}\" is {1}.", inputNameContain, Names.Contains(inputNameContain) ? "in the uniqCollecsion" : "NOT in the uniqCollecsion");
                        break;
                    case "c": //Removes all elements from the uniqCollecsion.
                        Names.Clear();
                        Console.WriteLine("The uniqCollecsion is clean");
                        break;
                    case "q": //End of program
                        break;

                    default:
                        Console.WriteLine("No parameter entered");
                        break;
                }
            } while (!UserInput.Equals("q"));

            Console.WriteLine("------------------");
            Console.WriteLine("The program ended successfully, thank you for using our software.");
            Console.WriteLine("------------------");
        }
        public static void PrintuniqCollecsion(List<string> names)
        {
            foreach (string Name in names)
                Console.WriteLine($"\t{Name}");
            Console.WriteLine();
        }

    }
}