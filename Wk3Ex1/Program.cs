using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk3Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //sets the score variable to 0
            int score = 0;

            //provides an empty string for changing later
            string letterGrade = "";

            //Prompts the user to enter score grade
            Console.WriteLine("What is the numeric score (0 to 100)?");

            //Initializes score as a converted double in case of decimals
            score = (int)Convert.ToDouble(Console.ReadLine());

            //begins switch statement to start letter grades. I used score / 10 because I wouldnt know how to do each number 1-100 without doing every switch case for each number. I dont recall if we did this in class, but i was stumped here!
            switch (score / 10) {
                
                //Begins cases for 100/perfect score as A
                case 10:
                    //converts letterGrade to an "A" string
                    letterGrade = "A";
                    break;
               //Cases for below 100 and above 90
                case 9:
                    //Still an A
                    letterGrade = "A";
                    break;
               //Cases for below 90 and above 80
                case 8:
                    //Converts letterGrade to a "B"
                    letterGrade = "B";
                    break;
               //Cases for above 70 and below 80
                case 7:
                    //Converts letterGrade to "C"
                    letterGrade = "C";
                    break;
                //Cases for above 60 and below 70
                case 6:
                    letterGrade = "D";
                    break;
                //Cases for above 50 and below 60
                case 5:
                    letterGrade = "F";
                    break;
               
                //For below 50, i didnt want the default selection to pick it up as an error if below, so I created cases from below 50 all the way to 0.
                case 4:
                    letterGrade = "F";
                    break;
               
                //Case for 30 score
                case 3:
                    letterGrade = "F";
                    break;
                //case for 20
                case 2:
                    letterGrade = "F";
                    break;
               //case for 10 
                case 1:
                    letterGrade = "F";
                    break;
                //case for 0
                case 0:
                    letterGrade = "F";
                    break;
              
                //I created a default control in case the user entered a number not between 1-100 and prompts them to enter a correct one
                default:
                    Console.WriteLine("Please enter a valid number between 1-100");
                    break;


            }

            //Adds the determined score and lettergrade into a prompt so the user can see them printed.
            Console.WriteLine("The letter grade for score " + score + " is " + letterGrade);

            //disallows the console from closing immediately after use
            Console.ReadLine();


            //I really didn't know how to do this one. It was the decimals that got me, maybe I was just overcomplicating it but i wish i could use an if/else statement for this one haha

        }
    }
}
