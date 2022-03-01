using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSession
{
    class S13_MethodAndTypes_MethodOverload_override
    {
        //private method
        void Addition()
        {
            int num1, num2;
            Console.WriteLine("Enter number 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
        }
        public int Substraction(int num1, int num2)
        {
            int sub = num1 - num2;
            Console.WriteLine("\n\nAddition method called ");
            this.Addition();
            Console.WriteLine("\nReturn value " + sub);
            return sub;
        }
        //Non Static With PArameterised------------
        public void StringManupulation(string name = "Imran")
        {
            Console.Write("\nName is: " + name);
            S13_MethodAndTypes_MethodOverload_override.PrinitingName("Pune", 23);
            S13_MethodAndTypes_MethodOverload_override.PrinitingName(age: 28, address: "Address"); //Named Argument
            // S13_MethodAndTypes_MethodOverload_override.PrinitingName(23,"Address");  Error
        }

        //Static Method------------
        public static void PrinitingName(string address, int age)
        {
            Console.Write("\n\nAddress Is: " + address + "\nAge is: " + age);
        }
    }
        //Abstract Method    without abstract class you cannot create abstract method

        //public class BasicDetails   // Base Class
        //{
        //    public string firstName;
        //    public int age { get; set; }
        //    public char gender;
        //    public long phoneNumber;
        //    public abstract void AbstractClassAndDisplayDetail() 
        //    {

        //    }
        //    // Abstract Method
        //}

        //Method Overloading And Overriding
        class MethodOverLoading
        {
            public void MethodOverloading()
            {
                MethodOverLoading methodOverloading = new MethodOverLoading();
                methodOverloading.Addition();
                methodOverloading.Addition(30, 30);
            }

            public void Addition()
            {
                int num1 = 40, num2 = 40;
                Console.WriteLine($"Addition is For Non Parameter Method: {num1 + num2}");
            }
            public void Addition(int num1, int num2)
            {
                Console.WriteLine($"Addition is For Parameter Int Method: {num1 + num2}");
            }

            public virtual void Addition_MethodOverride() /// Method Overriding 
            {
                Console.Write("Enter 1st No: ");
                int no1 = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd No: ");
                int no2 = int.Parse(Console.ReadLine());

                Console.Write($"Addition is : {no1 + no2} \n\n");
            }
        }

        class MethodOverRiding : MethodOverLoading
        {
            public override void Addition_MethodOverride() /// Method Overriding 
            {
                Console.Write("Enter 1st No: ");
                int no3 = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd No: ");
                int no4 = int.Parse(Console.ReadLine());

                Console.Write($"Multiplication is : {no3 * no4}\n\n");

                Console.WriteLine("Calling Parent Method");
                base.Addition_MethodOverride();

            }

        }

    //Complete The Task : and Write Down th Program using Parameterised Method for palindrom and armstrong number
    class PalindromParameterised
    {
        public void palindrom(int n)
        {
            int r, sum = 0, temp;
            
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.Write("Number is Palindrome.");
            else
                Console.Write("Number is not Palindrome");
        }
    }
    class armstrongNumber
    {
        public void Armstrong(int number)
        {
            int temp, rem, sum = 0;
            temp = number;
            while (number > 0)
            {
                rem = number % 10;
                sum = sum + (rem * rem * rem);
                number = number / 10;
            }
            if (temp == sum)
                Console.WriteLine($"{temp} is Armstrong number");
            else
                Console.WriteLine($"{temp} is not Armstrong number");
        }
    }
}
