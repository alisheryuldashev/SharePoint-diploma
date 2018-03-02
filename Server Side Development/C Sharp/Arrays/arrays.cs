/*
C# Arrays Lab by Alisher Yuldashev. 
Programming Diploma - SharePoint Specialization (Innotech College)

This is a student grading system program. This program will display a menu 
that enables the instructor to choose whether they want to view all students 
records or view only the records of a specific student by the student’s id.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Grading_System {
    class Program {
        static void Main(string[] args) {
            //flag for while loop
            bool programEnd = false;
            string input = string.Empty;
            
            //Menu of choices
            #region Menu
            while (programEnd == false) {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("MENU\n");
                Console.ResetColor();
                Console.WriteLine("1. View all Students' Records");
                Console.WriteLine("2. View a Student's Records by ID");
                Console.WriteLine("3. Show the Highest Final Grade");
                Console.WriteLine("4. Exit");
                Console.WriteLine();
                Console.Write("Please enter your choice: ");
                input = Console.ReadLine();
                #endregion

                #region arrays
                //initialize the 2d array for grades table
                int[,] grades = new int[,] {
                { 12345, 80, 70, 85, 90, 90 },
                { 23456, 95, 85, 75, 95, 95 },
                { 34567, 90, 95, 80, 75, 85 },
                { 45678, 85, 90, 95, 95, 80 }
                };

                //initialize array for final grades
                decimal[] finalGrade = { 84.67M, 91.00M, 85.33M, 86.33M };
                #endregion

                #region Switch statement            
                switch (input) {
                    case "1": //write a header row and all rows; see methods details below
                        outputHeader(); 
                        outputRows(0, grades.GetLength(0), grades, finalGrade);                        
                        break;

                    case "2": //find student by ID, and search grades by student ID
                        Console.Write("Please enter Student ID: ");
                        string ID = Console.ReadLine();
                        int numID = Convert.ToInt32(ID);

                        //keep track of row number
                        int indexRow = -1;
                        //look for ID and remember row number
                        for (int row = 0; row < grades.GetLength(0); row++) {
                            if (numID == grades[row, 0]) {
                                indexRow = row;                                                               
                            }                   
                        }
                        if (indexRow == -1) {
                            Console.WriteLine("Student with ID {0} could not be found\n", ID);
                            goto case "2";
                        } else {
                            outputHeader();
                            outputRows(indexRow, indexRow + 1, grades, finalGrade);
                        }                 
                        break;

                    case "3": //find student with a highest final grade
                        outputHeader();                        
                        //set a new highest grade at -1
                        decimal highest = -1;
                        //keep track of row number
                        indexRow = -1;
                        //search for highest grade
                        for (int idx = 0; idx < finalGrade.Length; idx++) {
                            if (finalGrade[(idx)] > highest) {
                                highest = finalGrade[(idx)]; //update final grade with the highest number
                                indexRow = idx; //update the row index where grade is found
                            } 
                        }
                        outputRows(indexRow, indexRow + 1, grades, finalGrade);
                        break;
                    case "4":                       
                        programEnd = true;
                        break;
                    default:
                        Console.WriteLine("\nError: the selected choice {0} does not exist.", input);
                        
                        break;
                }
                Console.WriteLine("\nPress return key to continue");
                Console.ReadLine();
            }
            #endregion
                        
        }
        //method to output two header rows
        static void outputHeader() {
            Console.Write("StudentID\tAttendance\tLab1\tLab2\tLab3\tCase Study\tFinal Grade\t\n"); //using tabs (\t)
            Console.WriteLine("===================================================================================");
        }
        //method to output required rows
        static void outputRows(int startrow, int endrow, int[,] grades, decimal[] finalGrade) {
            int startcol = grades.GetLowerBound(1);
            int endcol = grades.GetUpperBound(1) + 1;
            for (int indexRow = startrow; indexRow < endrow; indexRow++) {
                for (int col = startcol; col < endcol; col++) {                    
                    Console.Write(grades[indexRow, col] + ((col > 1) ? "\t" : "\t\t"));                    
                }
                Console.Write("\t" + finalGrade[indexRow]);
                Console.WriteLine();
            }
        }
    }
}
