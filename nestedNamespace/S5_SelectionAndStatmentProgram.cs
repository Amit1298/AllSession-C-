using System;
using System.Collections.Generic;
using System.Text;

namespace nestedNamespace
{
    class S5_SelectionAndStatmentProgram
    {
        public void MarkChecker()
        {
            Console.WriteLine("Enter percentage value \t");
            int percentage = int.Parse(Console.ReadLine());
            if(percentage >= 80)
                Console.WriteLine("Congrets You top");
            else if(percentage >= 60)
                Console.WriteLine("Good you are eligble");
            else if(percentage >= 50)
                Console.WriteLine("All the best");
            else if(percentage < 35)
                Console.WriteLine("You are fail");
            else
                Console.WriteLine("try next time");
        }

        //nested if
        public void Nestedif()
        {
            int no1 = 52;
            if(no1 > 50)
            {
                if(no1< 40)
                    Console.WriteLine("less");
                else
                    Console.WriteLine("Big");
            }
            else
            {
                if(no1 == 52)
                    Console.WriteLine("Value is equal");
                else
                    Console.WriteLine("Value is notequal");
            }
        }

        //Switch case
        public void SwitchCase()
        {
            Console.WriteLine("Enter Week Number \t");
            int weekno = int.Parse(Console.ReadLine());
            switch (weekno)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednessday");
                    break;
                case 4:
                    Console.WriteLine("Thuresday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturaday");
                    break;
                case 8:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Enter valid number");
                    break;
                
            }
        }

        public void SwitchGroup()
        {
            Console.WriteLine("Enter charcter \t");
            char alpha = Convert.ToChar(Console.ReadLine());
            switch (alpha)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Vowel");
                    break;
                case 'A':
                    Console.WriteLine("**********You are in capital letter \n enter the capital letter************************");
                    char cap = Convert.ToChar(Console.ReadLine());
                    switch (cap)
                    {
                        case 'A':
                        case 'E':
                        case 'I':
                        case 'O':
                        case 'U':
                            Console.WriteLine($"{cap} is vowel");
                            break;
                        default:
                            Console.WriteLine($"{cap} not vowel");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Not Vowel");
                    break;
            }
        }
    }
}
