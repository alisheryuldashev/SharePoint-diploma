//C# Control Flow Lab 1 code by Alisher Yuldashev. 
//Programming Diploma - SharePoint Specialization (Innotech College)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Flow_Lab_1 {
    class Program {
        static void Main(string[] args) {
            #region declare variables
            string answer = String.Empty;
            int tries = 1;
            int greatestNumber = 0;
            #endregion

            #region Prompt for input and find the highest number            
            Console.WriteLine("This C# program will ask you any four integer values and then will find the greatest value of the four integers\n");
            //ask for 4 numbers
            for (int index = 0; index < 4; index++) {
                Console.Write(String.Format("Enter your {0} integer value: ", OutputFor(tries))); //see OutputFor method below
                answer = Console.ReadLine();
                //convert input into an integer
                int answerAsNumber = Convert.ToInt32(answer);
                //if answer is higher than the greatest number, update the new greatest number or continue.
                if (answerAsNumber > greatestNumber) {
                    greatestNumber = answerAsNumber;
                    tries++;
                } else {
                    tries++;
                    continue;
                }               

            }
            //show answer
            Console.WriteLine(String.Format("\nThe greatest value is {0}", greatestNumber));
            #endregion
            //close program
            Console.Write("\nPress return to close the window\n\n");
            Console.ReadLine();
        }
        
        #region Method for adding postfixes to number of tries
        static string OutputFor(int input) {
            string[] postfix = { "st", "nd", "rd" }; 
            string temp = (input > 3) ? "th" : postfix[input - 1]; //use postfixes from array otherwise use "th"
            return (input + temp);
        }
        #endregion
    }
}

