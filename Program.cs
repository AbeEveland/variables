using System;

namespace tonye
{
    class Program
    {
        static void Main(string[] args)
        {
           int      numberOfCupsOfCoffee = 2;
           string   fullName = "Abe Eveland";
           DateTime today = DateTime.Today;
           
           Console.WriteLine("");
           Console.WriteLine("");
           Console.WriteLine($" My name is {fullName}. Today is {today.ToString("D")}. I drink {numberOfCupsOfCoffee} cups of coffe per day.");
           
           Console.Write(" What is your name? ");
           string userName = Console.ReadLine();
           Console.WriteLine("");

           if(userName.ToUpper() == "ALICE") {
             Console.Write(" Hey! I know you!");
               } else {
             Console.Write($" Nice to meet you {userName}!");
             }
           Console.Write(" Please enter a number: ");
           
           string firstNumberAsString = Console.ReadLine();
           Console.WriteLine("");
           Console.Write(" Nice number! Please enter another number: ");
           string secondNumberAsString = Console.ReadLine();
           
           Double firstOperand  = Double.Parse(firstNumberAsString);
           Double secondOperand = Double.Parse(secondNumberAsString);
           Double sum           = firstOperand + secondOperand;
           Double difference    = firstOperand - secondOperand;
           Double product       = firstOperand * secondOperand;           
           Double quotient      = firstOperand / secondOperand;
           Double remainder     = firstOperand % secondOperand;
           
           Console.WriteLine("");
           Console.WriteLine($" Thanks! That is another nice number! Did you know that {firstNumberAsString} + {secondNumberAsString} = {sum}?");
           Console.Write(" Press enter to find the difference");
           Console.ReadLine();
           Console.WriteLine($" {firstNumberAsString} - {secondNumberAsString} = {difference}");
           Console.WriteLine(" Press enter to find the product");
           Console.ReadLine();
           Console.WriteLine($" {firstNumberAsString} * {secondNumberAsString} = {product}");
           Console.WriteLine(" Press enter to find the quotient");
           Console.ReadLine();
           Console.WriteLine($" {firstNumberAsString} / {secondNumberAsString} = {quotient}");
           Console.ReadLine();
           Console.WriteLine(" Press enter to find the remainder");
           Console.WriteLine($" {firstNumberAsString} % {secondNumberAsString} = {remainder}");
           Console.WriteLine("");
           Console.WriteLine("");
        }
    }
}
