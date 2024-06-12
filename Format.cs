//----------------------------------------------
// Author:     Quinn Trate
// Date:       February 3, 2024
// Purpose:    Enter in User Information
//             and the Program will Format
//             the Information
//----------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatUsers
{
    class Format
    {
        static void Main(string[] args)
        {
            // Initial Variables
            bool flag = true;
            int counter = 0;
            string answer = "";
            List<User> arrUser = new List<User>();

            while (flag)
            {
                // Get User Information
                Console.WriteLine("Please Enter User #" + (counter + 1) + "'s Information");
                Console.WriteLine("First Name:");
                string strFirstName = Console.ReadLine();
                Console.WriteLine("Last Name:");
                string strLastName = Console.ReadLine();
                Console.WriteLine("Age:");
                int intAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Height (in Inches):");
                int intHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Weight (in Pounds):");
                double dblWeight = Convert.ToDouble(Console.ReadLine());

                // Creates New User Object and Adds it to the ArrayList
                arrUser.Add(new User(strFirstName, strLastName, intAge, intHeight, dblWeight));

                // Asks for More Users
                Console.WriteLine("\nIs There Another User you Need to Enter? (Y/N)");
                answer = Console.ReadLine();
                Console.WriteLine();

                // Ensures Correct Input
                while (answer != "Y" && answer != "y" && answer != "N" && answer != "n")
                {
                    Console.WriteLine("Error. Please Enter Y/N");
                    answer = Console.ReadLine();
                }

                // Increase the User Counter
                if (answer == "Y" || answer == "y")
                    counter++;
                // End While
                else if (answer == "N" || answer == "n")
                {
                    flag = false;
                    Console.WriteLine();
                }
            }

            Console.Clear();

            // Print all Formatted User Information
            Console.WriteLine("User Information\n");
            for (int i = 0; i < arrUser.Count; i++)
                arrUser[i].print();

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
