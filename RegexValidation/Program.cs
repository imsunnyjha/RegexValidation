using System;
using System.Text.RegularExpressions;

namespace RegexValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pincode Validation
            Console.WriteLine("Let's Validate Pin Code!");
            string pinPattern = @"^[1-9]{1}[0-9]{2}\s{0,1}[0-9]{3}$";
            Console.WriteLine("Enter ZIP Code: ");
            string pin = Console.ReadLine();
            if (!Regex.IsMatch(pin, pinPattern))
                throw new Exception("ZIP Code should be a 6 digit number");
            else
            {
                Console.WriteLine(value: pin + " validated!");
            }

            //EmailId validation

            Console.WriteLine("Let's Validate Email ID!");
            string emailPattern = @"^([a-z][a-z0-9.+_-]*@([a-z0-9]([a-z0-9-]*[a-z0-9])?\.)+[a-z0-9]([a-z0-9-]*[a-z])?)$";
            Console.WriteLine("Enter Email Id: ");
            string emailid = Console.ReadLine();
            if (!Regex.IsMatch(emailid, emailPattern))
                throw new Exception("Email Id should be in proper format");
            else
            {
                Console.WriteLine(value: emailid + " validated!");
            }
        }
    }
}
