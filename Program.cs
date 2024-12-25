// See https://aka.ms/new-console-template for more information
using System;
using System.Transactions;
using static System.Console;
class ConsoleProject
{
    static void Main()
    {
        int num1;
        char operation = ' ';
        int num2 = 0;
        char add = '+';
        char subtract = '-';
        char multiply = '*';
        char divide = '/';
        int total = 0;
        
        Write("Enter first number to calculate or '000' to quit >> ");
        num1 = Convert.ToInt32(ReadLine());

        while(num1 != 000)
        {
            Write("Enter operation >> ");
            operation = Convert.ToChar(ReadLine());

            if(operation == add || operation == subtract || operation == multiply || operation == divide)
            {
                Write("Enter second number >> ");
                num2 = Convert.ToInt32(ReadLine());
            }

            if (operation == add)
            {
                total = num1 + num2;
            }
            else if (operation == subtract)
            {
                total = num1 - num2;
            }
            else if (operation == multiply)
            {
                total = num1 * num2;
            }
            else
            {
                total = num1 / num2;
            }

            WriteLine("{0} {1} {2} = {3}", num1, operation, num2, total);

            Write("Enter first number to calculate or '000' to quit >> ");
            num1 = Convert.ToInt32(ReadLine());
        }
        
    }
}

