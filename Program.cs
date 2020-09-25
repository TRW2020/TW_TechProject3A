/*
    Author: Tyler Wildrick
    Date: 9/21/2020
    Comments: This C# Console application code demonstrates the use of
              methods after getting input from a user. The program has two
              methods. One value return method and one void method.
              One method is designed to calculate the users maximum heart rate
              after entering their age. The other method is designed to 
              calculate the users recommended heart rate range during exercise
              based on the calculated maximum heart rate. 
*/using System;
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
                // REPLACE WITH METHOD!!!
               //Console.WriteLine("Hello " + input);
            } //End of Try
            
            catch
            {

            } //End of Catch
        } // End of Main
        /*
            This static value return method calculates your maximum heart rate
            A static method cannot be instantiated with the key word "new".
            The accessor is private which means the method is limited to the
            containing class. 
        */
        private static string Greet_User(string user_name)
        {
            // The formula for max heart rate during exercise is 220 minus your age
            string greeting = "Hello " + user_name;
            Console.WriteLine(greeting);
            //Console.WriteLine("Hello" + user_name);
            //Console.WriteLine("Your maximum heart rate during exercise should be " + calculate_max_heart_rate + " beats per minute.");

            return user_name;
        } // End of Max_Heart_Rate
    } // End of Class
} // End of Namespace
