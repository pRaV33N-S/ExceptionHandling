using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandleing
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {

        }
    }
    public class calculation
    {
        public static byte Add(byte num1,byte num2)
        {
            var result = num1 + num2;
            return (byte)result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num1, num2, result;
            //try
            //{
            //    Console.WriteLine("Enter First Number");
            //    num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Second Number");
            //    num2 = int.Parse(Console.ReadLine());
            //    result = num1 + num2;
            //    Console.WriteLine($"Result after adding {num1} and {num2} = {result}");
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine("Error!!!"+ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("End of Program...");
            //    Console.ReadKey();
            //}
            /*byte fnum, snum;
            try
            {
                Console.WriteLine("Enter First Number");
                fnum = byte.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                snum = byte.Parse(Console.ReadLine());
                Console.WriteLine("Result : \t "+ calculation.Add(fnum,snum));
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Format Error"+fe.Message);
            }
            catch(OverflowException fe) { Console.WriteLine("OverFlow Error"+fe.Message); }
            catch(Exception fe) { Console.WriteLine("Error"+fe.Message); }
            finally
            {
                Console.WriteLine("End of the Program");
            }*/
            try
            {
                int userAge;
                Console.WriteLine("Enter your Age");
                userAge = int.Parse(Console.ReadLine());
                if (userAge < 0)
                {
                    throw new CustomException("Age must be positive number, Please enter positive number");
                }
                else if (userAge >= 18)
                {
                    Console.WriteLine("You are eligible for voting");
                }
                else
                {
                    Console.WriteLine("You are not eligible for voting, You have to wait");
                }
            }
            catch(CustomException ex) { Console.WriteLine("Custom Error!!!"+ex.Message); }
            catch(Exception ex) { Console.WriteLine("Error!!!"+ex.Message); }
            finally
            {
                Console.WriteLine("***Bye Bye Birdie***");
            }
        }
    }
}
