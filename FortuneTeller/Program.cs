using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {

            // Global Variable declarations

            
            string userFirstName = "empty";
            string userLastName = "empty";
            string favoriteColor = "empty";
            string location = "empty";
            string modeOfTransport = "empty";
               
            int userAge = 0;
            int userBirthMonth = 0;
            int userNumberOfSiblings = 0;
            int yearsUntilRetirement = 0;

            double amountOfMoney = 0;

            //DISPLAY A Welcome message

            Console.WriteLine("                          Welcome to Fortune Teller 1.0");
            Console.WriteLine();
            Console.WriteLine("                           I can tell you your Fortune ");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                               lets get started...     ");
            Console.WriteLine();
            Console.WriteLine();

            //INPUT


            //Input of user Data- solicit input from user,store data and format as necessary 

            //Get userFirstName
            Console.WriteLine("Enter your First Name, please.");
                userFirstName = Console.ReadLine();
            //userFirstName = userFirstName.ToLower();//set string lower case to process

             //Get userLastName
                Console.WriteLine();
                Console.WriteLine("Enter your Last Name, please.");
                userLastName = Console.ReadLine();
            

            //Get userAge
                Console.WriteLine();
                Console.WriteLine("Enter your Age as a number, please.");
                userAge = int.Parse(Console.ReadLine());

                //Get userBirthMonth
                Console.WriteLine();
                Console.WriteLine("Enter the month of your birth in numerical format MM, please.");
                userBirthMonth = int.Parse(Console.ReadLine());

            //Get Favorite Color

            //ask user to select from following
                Console.WriteLine();
                Console.WriteLine("Enter a favorite color from the following:");
                Console.WriteLine();
                Console.Write("Red, Orange, Yellow, Green, Blue, Indigo, Violet");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Enter your Favorite color, please." + "       or Enter " + "\"Help\"" + " for the Help Menu");
                favoriteColor = Console.ReadLine();
                favoriteColor = favoriteColor.ToLower(); //set string lower case to process

                //Help Menu---Display

                // if help entered display a list of colors
                if (favoriteColor == "help") {

                    Console.WriteLine("Here is the list of available colors");
                    Console.WriteLine();
                    Console.WriteLine("              Red                   ");
                    Console.WriteLine("              Orange                ");
                    Console.WriteLine("              Yellow                ");
                    Console.WriteLine("              Green                 ");
                    Console.WriteLine("              Blue                  ");
                    Console.WriteLine("              Indigo                ");
                    Console.WriteLine("              Violet                ");
                };
            //end help menu

            //get userNumberOfSiblings
            Console.WriteLine();
            Console.WriteLine("Enter the number of siblings, please.");
            userNumberOfSiblings = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //LOGIC AND CALCULATIONS

            //Calc years until retirement
            // if age years are even retire in 20yrs. if age years odd retire in 15yrs.

            if (userAge % 2 == 0)
                {
                    yearsUntilRetirement = 20;
                 }else {
                        yearsUntilRetirement = 15;
                       }

                // choose vacation Home based on number of siblings

                if (userNumberOfSiblings < 0) {
                   location = "Yakutsk";
                    modeOfTransport = "pair of Snow Shoes";
                   }

                switch (userNumberOfSiblings)
                {
                    case 0:
                        location = "Malibu Beach";
                        break;

                    case 1:
                        location = "Seattle";
                        break;

                    case 2:
                        location = "Upstate New York";
                        break;

                    case 3:
                        location = "Italy";
                        break;

                    //default:
                
                }
                if (userNumberOfSiblings >3){
                    location = "Switzerland";
                   }

                //Set Mode of Transportayion Based on ROYGBIV selection

                if ((favoriteColor == "red")&&(userNumberOfSiblings>=0)) {
                    modeOfTransport = "Corvette";
                    }else
                if ((favoriteColor == "orange")&& (userNumberOfSiblings >= 0)){
                    modeOfTransport = "Motorcycle";
                    }else
                if ((favoriteColor == "yellow")&& (userNumberOfSiblings >= 0)){
                    modeOfTransport = "Taxi";
                    }else
                if ((favoriteColor == "green") && (userNumberOfSiblings >= 0)){
                    modeOfTransport = "Bicycle";
                    }else
                if ((favoriteColor == "blue") && (userNumberOfSiblings >= 0)){
                    modeOfTransport = "Tour Bus";
                    }else   
                if ((favoriteColor == "indigo") && (userNumberOfSiblings >= 0)){
                    modeOfTransport = "Aeroplane";
                    }else
                if ((favoriteColor == "violet") && (userNumberOfSiblings >= 0)){
                    modeOfTransport = "Moped";
                    }else
                if(modeOfTransport=="pair of Snow Shoes") {  //keeps mode of transport Snow shoes if negative int entered for numberOfSiblings
                        modeOfTransport = "pair of Snow Shoes";
                    }else { modeOfTransport = "Pair of Hiking Boots";}
            

                // Calculates Money in the Bank based on Birth month entered
            
                if ((userBirthMonth < 1) || (userBirthMonth > 12)){
                    amountOfMoney = 0;
                    } else 
                if ((userBirthMonth >= 1) && (userBirthMonth <= 4)) {
                    amountOfMoney = userBirthMonth * 4000;
                    } else 
                if ((userBirthMonth >= 5) && (userBirthMonth <= 8)) {
                    amountOfMoney = userBirthMonth * 8000;
                    } else 
                if ((userBirthMonth >= 9) && (userBirthMonth <= 12)){
                    amountOfMoney = userBirthMonth * 12000;}


            //OUTPUT

            //Displays Fortune output

               
                Console.WriteLine();
                Console.WriteLine(userFirstName + " " + userLastName + " will retire in " + yearsUntilRetirement + " years with $" + amountOfMoney + ".00 in the bank,");
                Console.WriteLine("a vacation home in " + location + ", and a " + modeOfTransport + ".");
                Console.WriteLine();
          
        }
    }
}
