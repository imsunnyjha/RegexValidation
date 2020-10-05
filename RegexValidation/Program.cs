using System;
using System.Text.RegularExpressions;

namespace RegexValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int pinCode;
            Console.WriteLine("Let's Validate Pin Code!");
            string pinPattern = "[1-9]{1}[0-9]{5}";
            Console.WriteLine("Enter ZIP Code: ");
            string pin = Console.ReadLine();
            if (!Regex.IsMatch(pin, pinPattern))
                throw new Exception("ZIP Code should be a 6 digit number");
            else
            {
                pinCode = int.Parse(pin);
                Console.WriteLine(+pinCode + " validated!");
            }
        }
    }
}
