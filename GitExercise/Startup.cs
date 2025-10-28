using System;

namespace GitExercise
{
    public class Startup
    {
        private static bool CheckCredentials()
        {
            Console.Write("Enter password to gain access: "); string password = Console.ReadLine(); Console.Clear();
            return password == Password;
        }
        private const string Password
        =
        "abcd1234";
        public static void Main()
        {
<<<<<<< HEAD

            bool isAuthorized = CheckCredentials();
            if (!isAuthorized)
            {
                Console.WriteLine("Access denied."); Console.ReadKey(intercept: true);
                return;
            }
=======
>>>>>>> c1593a8c1fb42134fe0a277b11f5fff52c0d1f25
            Console.Clear();
            Console.WriteLine("Console Calculator App");
            Console.WriteLine(new string('-', 15));

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("Choose one from the listed options:");
            foreach (string option in OptionsManager.OptionsList)
            {
                Console.WriteLine($"\t{option}");
            }

            Console.Write("Option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "a":
                    OptionsManager.Add(a, b);
                    break;
                case "s":
                    OptionsManager.Subtract(a, b);
                    break;
                case "m":
                    OptionsManager.Multiply(a, b);
                    break;
<<<<<<< HEAD
                case "d":
                    OptionsManager.Divide(a, b);
                    break;
                case "sabs":
                    OptionsManager.SubtractAbs(a, b);
                    break;
                case "dr":
                    OptionsManager.DivideReainder(a, b);
                case "ex":
                    Console.Clear();
                    Console.WriteLine("Goodbye");
                    ConsoleReadKey(true);
                    return;
                case "pow":
                    OptionsManager.Power(a, b);
                    break;
                case "log":
                    OptionsManager.Log(a, b);
                    break;
                case "fact":
                    OptionsManager.Factorial(a, b);
                    break;
=======
                case "dr":
                    OptionsManager.DivideRemainder(a, b);
                    break;
                case "ex":
                    Console.Clear();
                    Console.WriteLine("Goodbye");
                    return;
>>>>>>> c1593a8c1fb42134fe0a277b11f5fff52c0d1f25
            }

                Console.WriteLine("Pres any key to close the app...");
                Console.ReadKey(true);
            }
        }
    }
}
