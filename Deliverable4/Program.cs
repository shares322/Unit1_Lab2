using System;
using System.Text;

namespace Deliverable4
{
    class Program
    {
        static void Main(string[] args)
        {
            // capture message 
            Console.Write("Please enter a message: ");
            string input = Console.ReadLine();

            // covert everything to uppercase  
            string ucaseInput = input.ToUpper();

            // Convert the string into a byte[].
            byte[] message = Encoding.ASCII.GetBytes(ucaseInput);

            int checksum = 0;
            // generate the unicode numbers for each letter of the message
            for (int i = 0; i < ucaseInput.Length; i++)
            {
                //add up the amounts of each letter
                checksum += ucaseInput[i];
            }   
            
            // the message with encoded letters to numbers
            Console.WriteLine("Your encoded message is: " + "{0}", string.Join("-", message));
                       
            // sum the unicode amounts, store in checksum and print out the sum
            
            Console.WriteLine("Message checksum is: " + checksum);
        }
    }
}
