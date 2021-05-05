using System;

namespace CalculatorLibrary
{
    public class CalculatorModel
    {
        //Addition   
        public static double Addition(double num1, double num2) 
        {
            double result = num1 + num2;
            return result;
        }
        //Substraction  
        public static double Subtraction(double num1, double num2) {  
            double result = num1 - num2;  
            return result;  
        }  
        //Multiplication  
        public static double Multiplication(double num1, double num2) {  
            double result = num1 * num2;  
            return result;  
        }  
        //Division  
        public static double Division(double num1, double num2) {  
            double result = num1 / num2;  
            return result;  
        }  

    }
}