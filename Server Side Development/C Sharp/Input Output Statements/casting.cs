//C# Lab 1 casting between classes code by Alisher Yuldashev. 
//Programming Diploma - SharePoint Specialization (Innotech College).

#region Namespace references
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace CSharpLab01Exercise01
{
    class Program
    {   
        static void Main(string[] args)
        {
            #region Constants
            //declare constants (k)
            const string kMessage = "Cast decimal 12.346567 to ";
            const decimal kDecimalNumber = 12.346567M;
            #endregion

            #region Variables Declaration
            //declare variables (_) and initialize to min value
            sbyte _sbyte = SByte.MinValue;                  // System.SByte            
            byte _byte = Byte.MinValue;                     // System.Byte
            short _short = Int16.MinValue;                  // System.Int16
            ushort _ushort = UInt16.MinValue;               // System.UInt16
            int _int = Int32.MinValue;                      // System.Int32
            uint _uint = UInt32.MinValue;                   // System.UInt32
            long _long = Int64.MinValue;                    // System.Int64
            ulong _ulong = UInt64.MinValue;                 // System.UInt64
            char _char = Char.MinValue;                     // System.Char
            float _float = Single.MinValue;                 // System.Single
            double _double = Double.MinValue;               // System.Double
            DateTime _dateTime = DateTime.MinValue;         // System.DateTime
            string _string = String.Empty;                  // System.String
            bool _bool = false;                             // System.Boolean
            #endregion

            #region Cast logic            
            // Assign constant to into your variables
            _sbyte = Convert.ToSByte(kDecimalNumber);   // convert the constant to the sbyte variable            
            _byte = Convert.ToByte(kDecimalNumber);      
            _short = Convert.ToInt16(kDecimalNumber);     
            _ushort = Convert.ToUInt16(kDecimalNumber);   
            _int = Convert.ToInt32(kDecimalNumber);     
            _uint = Convert.ToUInt32(kDecimalNumber);    
            _long = Convert.ToInt64(kDecimalNumber);     
            _ulong = Convert.ToUInt64(kDecimalNumber);   
            _float = Convert.ToSingle(kDecimalNumber);   
            _double = Convert.ToDouble(kDecimalNumber);    
            _string = Convert.ToString(kDecimalNumber);                
            // for this convert to int first
            _char = Convert.ToChar(Convert.ToInt32(kDecimalNumber));     
            _bool = Convert.ToBoolean(Convert.ToInt32(kDecimalNumber));  

            //for dates convert the decimal to a long to represent the number of ticks, then create a new DateTime object with the ticks            
            _dateTime = new DateTime(Convert.ToInt64(kDecimalNumber));       // convert the constant  to the DateTime variable           
            #endregion

            #region Output to Console
            Console.WriteLine("Here an explicit numeric conversion is used to convert decimal type to sbyte, byte, short, number, ushort, int, uint, long, ulong, char, float, double, string, date, boolean");
            Console.WriteLine("");  // Empty line
            Console.WriteLine(kMessage + "sbyte " + _sbyte.ToString());            
            Console.WriteLine(kMessage + "byte " + _byte.ToString());
            Console.WriteLine(kMessage + "short " + _short.ToString());
            Console.WriteLine(kMessage + "ushort " + _ushort.ToString());
            Console.WriteLine(kMessage + "int " + _int.ToString());
            Console.WriteLine(kMessage + "uint " + _uint.ToString());
            Console.WriteLine(kMessage + "long " + _long.ToString());
            Console.WriteLine(kMessage + "ulong " + _ulong.ToString());
            Console.WriteLine(kMessage + "char " + _char.ToString());
            Console.WriteLine(kMessage + "float " + _float.ToString());
            Console.WriteLine(kMessage + "double " + _double.ToString());
            Console.WriteLine(kMessage + "string " + _string.ToString());
            Console.WriteLine(kMessage + "date " + _dateTime.ToString());
            Console.WriteLine(kMessage + "bool " + _bool.ToString());
            #endregion
            
            Console.Write("\n\nPress return to close the window\n\n");
            Console.ReadLine();
        }
    }
}
