/*
    Author: Tyler Wildrick
    Date: 9/21/2020
    Comments: This C# Console program that demonstrates the use of a method 
              after getting input from the user (their name) and responds
              with a greeting. 
*/

using System;
using System.IO;

namespace TW_TechProject3A
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Please Enter Your Name!");

            try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to store user's name
                string user_name = input;                
                // Calls method
                string get_user_greeting = User_Greeting (input);                                          
            } //End of Try

            catch
            {
                Console.WriteLine("Please enter an string value for your name ...");
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            } //End of Catch

        } // End of Main
        /*
            This static value return method that greets the user after receiving their name.
            The accessor is private which means the method is limited to the
            containing class. 
        */
        private static string User_Greeting(string user_name)
        {
            // The formula for greeting the user
            string greeting = "Hello " + user_name;
            Console.WriteLine(greeting);            

            return greeting;
        } // End of User_Greeting
    } // End of Class
} // End of Namespace
