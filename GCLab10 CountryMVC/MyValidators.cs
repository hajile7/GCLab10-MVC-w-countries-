namespace Validator
{
    public class Validator
    {
        //Numbers
        //Integers
        //Get Valid Integer
        public static int GetInt()
        {
            Console.Write("Please enter a number: ");
            int result = -999;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid. Please try again.");
            }
            return result;
        }

        //Overload 1 -- Custom Error Message
        public static int GetInt(string s)
        {
            Console.Write("Please enter a number: ");
            int result = -999;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine($"{s}");
            }
            return result;
        }

        //Get Positive Integer
        public static int GetPositiveInt()
        {
            Console.Write("Please enter a positive number: ");
            int result = -1;
            while (!int.TryParse(Console.ReadLine(), out result) || (result < 0))
            {
                Console.WriteLine("Invalid. Please try again.");
            }
            return result;
        }

        //Overload 1 -- Custom Error Message
        public static int GetPositiveInt(string s)
        {
            Console.Write("Please enter a positive number: ");
            int result = -1;
            while (!int.TryParse(Console.ReadLine(), out result) || (result < 0))
            {
                Console.WriteLine($"{s}");
            }
            return result;
        }

        //Get Negative Integer
        public static int GetNegativeInt()
        {
            Console.Write("Please enter a negative number: ");
            int result = 1;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid. Please try again.");
            }
            return result;
        }

        //Overload 1 -- Custom Error Message
        public static int GetNegativeInt(string s)
        {
            Console.Write("Please enter a negative number: ");
            int result = 1;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine($"{s}");
            }
            return result;
        }

        //Doubles
        //Get Valid Double
        public static double GetDouble()
        {
            Console.Write("Please enter a number: ");
            double result = -999;
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid. Please try again.");
            }
            return result;
        }

        //Overload 1 -- Custom Error Message
        public static double GetDouble(string s)
        {
            Console.Write("Please enter a number: ");
            double result = -999;
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine($"{s}");
            }
            return result;
        }

        //Get Positive Double
        public static double GetPositiveDouble()
        {
            Console.Write("Please enter a positive number: ");
            double result = -1;
            while (!double.TryParse(Console.ReadLine(), out result) || (result < 0))
            {
                Console.WriteLine("Invalid. Please try again.");
            }
            return result;
        }

        //Overload 1 -- Custom Error Message
        public static double GetPositiveDouble(string s)
        {
            Console.Write("Please enter a positive number: ");
            double result = -1;
            while (!double.TryParse(Console.ReadLine(), out result) || (result < 0))
            {
                Console.WriteLine($"{s}");
            }
            return result;
        }

        //Get Negative Double
        public static double GetNegativeDouble()
        {
            Console.Write("Please enter a negative number: ");
            double result = 1;
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid. Please try again.");
            }
            return result;
        }

        //Overload 1 -- Custom Error Message
        public static double GetNegativeDouble(string s)
        {
            Console.Write("Please enter a negative number: ");
            double result = 1;
            while (!double.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine($"{s}");
            }
            return result;
        }

        //Decimals
        //Get Valid Decimal
        public static decimal GetDecimal()
        {
            Console.Write("Please enter a number: ");
            decimal result = -999;
            while (!decimal.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid. Please try again.");
            }
            return result;
        }

        //Overload 1 -- Custom Error Message
        public static decimal GetDecimal(string s)
        {
            Console.Write("Please enter a number: ");
            decimal result = -999;
            while (!decimal.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine($"{s}");
            }
            return result;
        }

        //Get Positive Decimal
        public static decimal GetPositiveDecimal()
        {
            Console.Write("Please enter a positive number: ");
            decimal result = -1;
            while (!decimal.TryParse(Console.ReadLine(), out result) || (result < 0))
            {
                Console.WriteLine("Invalid. Please try again.");
            }
            return result;
        }

        //Overload 1 -- Custom Error Message
        public static decimal GetPositiveDecimal(string s)
        {
            Console.Write("Please enter a positive number: ");
            decimal result = -1;
            while (!decimal.TryParse(Console.ReadLine(), out result) || (result < 0))
            {
                Console.WriteLine($"{s}");
            }
            return result;
        }

        //Get Negative Decimal
        public static decimal GetNegativeDecimal()
        {
            Console.Write("Please enter a negative number: ");
            decimal result = 1;
            while (!decimal.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("Invalid. Please try again.");
            }
            return result;
        }

        //Overload 1 -- Custom Error Message
        public static decimal GetNegativeDecimal(string s)
        {
            Console.Write("Please enter a negative number: ");
            decimal result = 1;
            while (!decimal.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine($"{s}");
            }
            return result;
        }

        //Strings 
        public static string GetValidString(string s) 
        {
            string choice = Console.ReadLine().ToLower().Trim();
            while(!choice.Equals(s))
            {
                Console.WriteLine("Invalid choice. Please try again.");
                choice = Console.ReadLine().ToLower().Trim();
            }
            return choice;
        }

        //Overload 1 -- Two Valid String Allowed
        public static string GetValidString(string s, string s1)
        {
            string choice = Console.ReadLine().ToLower().Trim();
            while (!choice.Equals(s) && !choice.Equals(s1))
            {
                Console.WriteLine("Invalid choice. Please try again.");
                choice = Console.ReadLine().ToLower().Trim();
            }
            return choice;
        }

        //Overload 2 -- Three Valid String Allowed
        public static string GetValidString(string s, string s1, string s2)
        {
            string choice = Console.ReadLine().ToLower().Trim();
            while (!choice.Equals(s) && !choice.Equals(s1) && !choice.Equals(s2))
            {
                Console.WriteLine("Invalid choice. Please try again.");
                choice = Console.ReadLine().ToLower().Trim();
            }
            return choice;
        }

        //Continues
        public static bool GetContinue()
        {
            Console.WriteLine("Would you like to continue? y/n");
            while (true)
            {
                string result = Console.ReadLine().ToLower().Trim();
                if (result == "y")
                {
                    return true;
                }
                else if (result == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid. Please try again.");
                }
            }
        }

        //Overload 1 -- Custom Error Message
        public static bool GetContinue(string s)
        {
            Console.WriteLine("Would you like to continue? y/n");
            while (true)
            {
                string result = Console.ReadLine().ToLower().Trim();
                if (result == "y")
                {
                    return true;
                }
                else if (result == "n")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine($"{s}");
                }
            }
        }
    }

}

