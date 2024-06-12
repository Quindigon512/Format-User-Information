//----------------------------------------------
// Author:     Quinn Trate
// Date:       February 3, 2024
// Purpose:    Constructor Class for User
//             Objects. Includes Print
//             Function for Formatting
//----------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormatUsers
{
    internal class User
    {
        // User Variables
        private string strFirstName;
        private string strLastName;
        private int intAge;
        private int intHeight;
        private double dblWeight;

        // User Constructor
        public User(string strFirstName, string strLastName, int intAge, int intHeight, double dblWeight)
        {
            this.strFirstName = strFirstName;
            this.strLastName = strLastName;
            this.intAge = intAge;
            this.intHeight = intHeight;
            this.dblWeight = dblWeight;
        }

        // Converts the Height from Inches to Feet
        public static string convertHeight(int intHeight)
        {
            string strInches = "";
            string strFeet = "";
            string strNewHeight = "";

            int intInches = intHeight % 12;
            int intFeet = (intHeight - intInches) / 12;

            if (intInches == 1)
                strInches = "Inch";
            else
                strInches = "Inches";

            if (intFeet == 1)
                strFeet = "Foot";
            else
                strFeet = "Feet";

            if (intInches == 0 && intFeet == 0)
                strNewHeight = "0 Feet, 0 Inches";
            else if (intInches == 0)
                strNewHeight = intFeet + " " + strFeet;
            else if (intFeet == 0)
                strNewHeight = intInches + " " + strInches;
            else
                strNewHeight = intFeet + " " + strFeet + ", " + intInches + " " + strInches;

            return strNewHeight;
        }

        // Prints the Information
        public void print()
        {
            Console.WriteLine("Name: " + strFirstName + " " + strLastName);
            Console.WriteLine("Age: " + intAge + " Years Old");
            Console.WriteLine("Height: " + convertHeight(intHeight));
            Console.WriteLine("Weight: " + dblWeight + " Pounds");
            Console.WriteLine("");
        }
    }
}
