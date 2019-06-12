using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Rotorua Thermal Holiday Park User Login Application v1
            //Kris Boyte 30016677
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(
                "**************************************\n" +
                "*****Rotorua Thermal Holiday Park*****\n" +
                "**************************************\n" +
                "       *******User Login*******       \n" +
                "**************************************\n");

            bool usernameTest = false;

            while (usernameTest == false)
            {
                //user input
                Console.Write("\nPlease enter your username: ");
                //call method to validate username
                usernameTest = ValidateUsername(Console.ReadLine());

                if (usernameTest == false) //if validation returns false, display error, loop continues
                {
                    Console.WriteLine("Username invalid. Username must be at least 8 characters long. Please try again.");
                }
                else //if validation returns true, display success, loop ends
                {
                    Console.WriteLine("Success!");
                }
            }

            bool passwordTest = false;            
            while (passwordTest == false)
            {
                //user input
                Console.Write("\nPlease enter your password: ");
                string password1 = Console.ReadLine();
                Console.Write("\nPlease enter your password again: ");
                string password2 = Console.ReadLine();
                //call method to validate password
                passwordTest = ValidatePassword(password1, password2); 
                
                if (passwordTest == false) //if validation returns false, display error, loop continues
                {
                    Console.WriteLine("password invalid. Your passwords must match and be at least 8 characters long. Please try again.");
                }
                else //if validation returns true, display success, loop ends
                {
                    Console.WriteLine("Success! You are now logged in.");
                }
            }                     
            Console.ReadLine();
        }
        static bool ValidateUsername(string name)
        {
            if(name.Length >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }
        static bool ValidatePassword(string pass1, string pass2)
        {
            if (pass1 == pass2 && pass1.Length >= 8)
            {
                return true;
            }
            else
            {
                return false;                
            }            
        }
    }
}
