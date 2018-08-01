using System;

namespace MonthsOfTheYear
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Month's of The Year");
            Console.Write("Enter a number for the corresponding month: ");

            //This makes the cosole read the number the user entered and assigns it to a variable called userValue.
            string userValue = Console.ReadLine();

            //Because this variable is dependent on IF statements, it is assigned to quotes. 
            string message = "";

            //There can only be one If statement. In order to say "or if," "else if" is used.
            if (userValue == "1")
                message = "January";
            else if (userValue == "2")
                message = "February";
            else if (userValue == "3")
                message = "March";
            else if (userValue == "4")
                message = "April";
            else if (userValue == "5")
                message = "May";
            else if (userValue == "6")
                message = "June";
            else if (userValue == "7")
                message = "July";
            else if (userValue == "8")
                message = "August";
            else if (userValue == "9")
                message = "September";
            else if (userValue == "10")
                message = "October";
            else if (userValue == "11")
                message = "November";
            else if (userValue == "12")
                message = "December";

            //There can only be one Else. This is like saying "for anything else that I didn't include in the above statements, do this."
            else
                message = "Sorry, you've entered an invalid answer.";

            //This prints the message to the console.
            Console.WriteLine(message);

            Console.ReadLine();

        }
    }
}
