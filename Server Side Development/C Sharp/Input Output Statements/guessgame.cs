//C# Lab 1 guess game code by Alisher Yuldashev. 
//Programming Diploma - SharePoint Specialization (Innotech College).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLab01Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Constants (k)
            // Declare constants for the maximum number in the randon number you will generate
            const int kMaxNumber = 25;
            // and for the maximum number of guesses the user is allowed to take            
            const int kMaxTries = 6;
            #endregion

            #region Variable Declaration                        
            string _playersAnswer = string.Empty;            
            int _playersAnswerAsNumber = 0;                        
            int _numOfTries = 0;            
            bool found = false;           
            string _ourAnswerLower = ("Try a number that is lower than ");
            string _ourAnswerHigher = ("Try a number that is higher than ");
            #endregion
           
            Console.WriteLine("Let's play a game.");
            Console.WriteLine("\nI'll get a number between 1 and " + kMaxNumber + " and you can try to guess in within " + kMaxTries + " chances");
            Console.WriteLine("\nI'll tell you if you got the number,\n or if the number if higher\n or lower than your guess");
            Console.WriteLine("\nAre you ready?  I've got the random number in mind...\n\n");

            #region Generate a random number            
            Random _RandomNumberGenerator = new Random();
            // Use your constant to set the maximum
            int _ourNumber  = _RandomNumberGenerator.Next(1, kMaxNumber);
            //Console.WriteLine(" The number is " + _ourNumber);
            #endregion

            while (_numOfTries < kMaxTries) {
               
                Console.Write(String.Format("Attempt {0}: What number do you guess? ", _numOfTries + 1));
                _playersAnswer = Console.ReadLine(); 
                _playersAnswerAsNumber = Convert.ToInt32(_playersAnswer);

                if (_playersAnswerAsNumber == _ourNumber) {
                    found = true;
                    Console.WriteLine(String.Format("\nCongratulations! You guessed it in {0} tries!", (_numOfTries + 1)));
                    break;                    
                }
                else if (_playersAnswerAsNumber > _ourNumber)
                {
                    Console.WriteLine(_ourAnswerLower + _playersAnswer);
                }
                else if (_playersAnswerAsNumber < _ourNumber)
                {
                    Console.WriteLine(_ourAnswerHigher + _playersAnswer);
                }                                            
                _numOfTries++;
            }

            if (found == false)
            {
                Console.WriteLine("\n\nSorry you didn't get, but the number I was choosen was " + _ourNumber);
            }

            Console.Write("\n\nPress return to close the window\n\n");
            Console.ReadLine();
        }
    }
}
