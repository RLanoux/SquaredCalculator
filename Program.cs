using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Midterm
{
    class Program
    {
        static void Main( )
        {
            //Declare variables
            String strUserResponse = String.Empty;
            String strUserName = String.Empty;
            Double intFirstNumber = 0.0;
            Double intSum = 0.0;

            //Add a Welcome Screen.
            Console.WriteLine("Well come to Ye Squared Calculator Inn.");
            Console.WriteLine();

            //Ask the user for their name.
            Console.Write("Please log your name in our register. ");

            //Get the user's input and store it in variable strUserResponse.
            strUserResponse = Console.ReadLine();
            strUserName = strUserResponse;

            //Greet the user by name.
            Console.WriteLine();
            Console.WriteLine("Well come " + strUserResponse + "! Ye have come on squared night, so all your money will be \nsquared tonight!");

            //Get the user's number and convert it to a number.
            Console.Write("\nPlease tell me how much money you have, so I may square it? ");
            strUserResponse = Console.ReadLine();

            //Convert to an integer and store as an integer.
            try
            {
                intFirstNumber = Convert.ToDouble(strUserResponse);
            }
            catch (Exception e)
            {
                Console.Write("\nI can not square that number! ");
                Console.WriteLine(e.Message);
                Pause("I'm throwing you out of my inn, unless you leave now! Press enter to leave.");
                return;
            }

            //Square the number.
            intSum = (intFirstNumber * intFirstNumber);

            //Inform the user of the result
            Console.Write("\nYour money is: ");
            Console.Write(intSum.ToString());
            Console.WriteLine(" squared.");
            Pause("You can now go to your room. Press enter to be shown to your room.");
           }
        static void Pause(String sMsg)
        {
            Console.WriteLine("\n" + sMsg);
            Console.ReadLine();
        }
    }
}
