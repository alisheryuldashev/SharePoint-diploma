//C# Control Flow Lab 2 code by Alisher Yuldashev. 
//Programming Diploma - SharePoint Specialization (Innotech College)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Flow_Lab_2 {
    class Program {
                
        #region explanation of the algorithm that I used
        /*input = int;
        1. figure out start position
            a)  y = 7; x = 0; 
        2. write y number of stars *
        3. set new position 
            a) y = y - 1; x = x + 1;
        4. repeat 2 and 3 till x = input or y = 0; 
        */
        #endregion
            
        static void Main(string[] args) {

            //description
            Console.WriteLine("This C# console program will draw left half of the christmas tree using the * character\n\n");

            //ask user for the input
            Console.Write(String.Format("How long your christmas tree should be (please enter a number from 1 to 10): "));
            string input = Console.ReadLine();
            int inputAsNumber = Convert.ToInt32(input);
            
            //declare variables
            //starting position of the cursor. 
            int x = 0;
            int y = inputAsNumber;
            //draw symbol
            string star = "*";
            
            //clear screen
            Console.Clear();

            //the christmas tree will be drawn from ground up.
            while (y != 0) {//terminate when we reach to the top
                Console.SetCursorPosition(x, y); //set starting position
                for (int idx = 0; idx < y; idx++) { //draw stars y amount of times         
                    Console.Write(star);                    
                }
                x += 1; //update column number to shift starting position to the left
                y -= 1; //update row number to shift starting position up
            }
            Console.SetCursorPosition(0, inputAsNumber+1); //set cursor position below christmas tree          

            //close program
            Console.Write("\nPress return to close the window\n\n");
            Console.ReadLine();
        }
    }
}
