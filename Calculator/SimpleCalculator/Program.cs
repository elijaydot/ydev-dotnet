using System;
using static CalculatorLibrary.CalculatorModel;


namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                // Ask the user to type the first number.
                Console.WriteLine("Type your 1st number, and then press Enter");
                double input_1 = Convert.ToDouble(Console.ReadLine());

                // Ask the user to type the second number.
                Console.WriteLine("Type your 2nd number, and then press Enter");
                double input_2 = Convert.ToDouble(Console.ReadLine());

                // Ask the user to choose an option.
                Console.WriteLine("Enter the action to be performed");  
                Console.WriteLine("\tPress 1 for Addition");  
                Console.WriteLine("\tPress 2 for Subtraction");  
                Console.WriteLine("\tPress 3 for Multiplication");  
                Console.WriteLine("\tPress 4 for Division");
                Console.Write("Your option? ");  
                int action = Convert.ToInt32(Console.ReadLine());  
                
                double result = 0;

                switch (action) 
                {  
                    case 1: {  
                        result = Addition(input_1, input_2);  
                        break;  
                    }  
                    case 2: {  
                        result = Subtraction(input_1, input_2);  
                        break;  
                    }  
                    case 3: {  
                        result = Multiplication(input_1, input_2);  
                        break;  
                    }  
                    case 4: {
                        // Ask the user to enter a non-zero divisor until they do so.
                        while (input_2 == 0)
                        {
                            Console.WriteLine("Enter a non-zero divisor: ");
                            input_2 = Convert.ToDouble(Console.ReadLine());
                        } 
                        
                        result = Division(input_1, input_2);  
                        break;  
                    }  
                    default:  
                        Console.WriteLine("Wrong action!! try again");  
                        break;  
                }  
                Console.WriteLine("The result is {0}", result);  
                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }

            
        }

        
    }
}