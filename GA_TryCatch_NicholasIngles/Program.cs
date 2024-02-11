// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {

        int number = 0; 
        bool error = false;

        try
        {
           
            Console.Write("What is your age? Please enter a proper whole integer: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

        } 
        catch (FormatException fex)
        {
           
            Console.WriteLine("Invalid age input. Try again.");
            error = true;
        }
        catch (Exception ex)
        {
            
            Console.WriteLine("Unexpected error occured. Try again.");
            error = true;
        }

        if (error == true)
        {
            
        }
        else
        {
            Console.WriteLine("Wow, you are " + number + "? Awesome, welcome!");
        }




    }
}