using System;
using System.Collections.Generic;
using System.Text;

namespace nestedNamespace
{
    class S5_Task
    {
        int number;
        public void checkNumber()
        {
           
            Console.Write("Enter the number : ");
            number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
                Console.WriteLine($"{number} is Even");
            else
                Console.WriteLine($"{number} is Odd");
        }

        int rem, sum = 0, temp;
        public void Armstrong()
        {
            Console.Write("Enter the number : ");
            number = int.Parse(Console.ReadLine());
            temp = number;
            while (number > 0)
            {
                rem = number % 10;
                sum = sum + (rem * rem * rem);
                number = number / 10;
            }
            if(temp==sum)
                Console.WriteLine($"{temp} is Armstrong number");
            else
            Console.WriteLine($"{temp} is not Armstrong number");
        }

        public void ArmstrongWithForLoop() {
            int temp1, sum = 0;
            Console.WriteLine("enter the no");
            int n = int.Parse(Console.ReadLine());
            temp1 = n;
            for (int i = n; i > 0; i = n / 10)
            {
                int r = n % 10;
                sum = sum + (r * r * r);
            }
            if (sum == temp1)
            {
                Console.WriteLine("no is armstrong number");
            }
            else
            {
                Console.WriteLine("no is not armstrong number");
            }
        }

        public void prime()
        {
            int i, m = 0, flag = 0;
            Console.Write("Enter the number : ");
            number = int.Parse(Console.ReadLine());
            m = number / 2;
            for (i = 2; i <= m; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine($"{number} is not prime number");
                    flag = 1;
                    break;
                }
            }
            if(flag==0)
                Console.WriteLine($"{number} is prime number");
        }
        public void palindrome()
        {
            int r, temp, sum = 0;
            Console.Write("Enter the number : ");
            number = int.Parse(Console.ReadLine());
            temp = number;
            while (number > 0)
            {
                r = number % 10;
                sum = (sum * 10) + r;
                number = number / 10;
            }
            if(temp==sum)
                Console.WriteLine($"{temp} is Palindrome");
            else
                Console.WriteLine($"{temp} is not Palindrome");
        }
        public void Fibonacci()
        {
            int n1 = 0, n2 = 1, n3, i;
            Console.Write("Enter the number : ");
            number = int.Parse(Console.ReadLine());
            Console.Write(n1+" "+n2+" ");
            for (i = 2; i < number; ++i)
            {
                n3 = n1 + n2;
                Console.Write(n3+" ");
                n1 = n2;
                n2 = n3;
            }
        }

        public void naturalNumber()
        {
            Console.WriteLine("Print a Natural Number 1-100: ");
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void palindrome1to100()
        {
            int num, n, temp, r;
            temp = number;
            for (num = 0; num <= 100; num++)
            {
                temp = 0;
                n = num;
                while (n != 0)
                {
                    r = n % 10;
                    temp = (temp * 10) + r;
                    n = n / 10;
                }
                if(num == temp)
                Console.WriteLine(num);
            }
        }

        public void perfectNumber()
        {
            Console.WriteLine("Find the perfect numbers between 1 and 500:");
            Console.WriteLine("------------------------------------------------");
            int i = 1, u = 1, sum = 0;
            Console.WriteLine("The perfect numbers between 1 to 500 are:");
            while (i <= 500)
            {
                while (u <= 500)
                {
                    if (u < i)
                    {
                        if (i % u == 0)
                            sum = sum + u;
                    }
                    u++;
                }
                if (sum == i)
                {
                    Console.Write(i + " ");
                }
                i++;
                u = 1;
                sum = 0;
            }
        }
    }
}
