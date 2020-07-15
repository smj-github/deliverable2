using System;

namespace Deliverable2
{
    class Program
    {
        static void Main()
        {
            string input;
            string message = string.Empty;
            int checksum = 0;

            // Get input message
            Console.WriteLine("Enter your message");
            input = Console.ReadLine();

            // convert input message into upper case
            input = input.ToUpper();

            foreach (char c in input)
            {
                // Get the unicode value for each letter in the input
                int uniVal = Convert.ToInt32(c);

                //Get the code for each character of the input and build it into the message variable
                if (message.Length == 0)
                    message = ((uniVal - 65) + 1).ToString();
                else 
                    message = message + "-" + ((uniVal - 65) + 1).ToString();

                //Calculate checksum 
                checksum += uniVal; 
            }

            Console.WriteLine("Your encoded message is : " + message);
            Console.WriteLine("Message checksum is : " + checksum);
            
        }
    }
}
