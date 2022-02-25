using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSession
{
    class S11_ClassAndTypes
    {
            // nested class
            public abstract class BasicDetails
            {
                public string firstName;
                public int age { get; set; }
                public char gender;
                public long phoneNumber;
                public abstract void AbstractClassAndDisplayDetails();   //Abstract method
            }
            public class studentDEtails : BasicDetails
            {
                public int rollNo;
                public int fees;
                public override void AbstractClassAndDisplayDetails()
                {
                    Console.Write("Enter Student NAme: ");
                    this.firstName = Console.ReadLine();

                    Console.Write("Enter Student Age: ");
                    this.age = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Student Gender: ");
                    this.gender = Convert.ToChar(Console.ReadLine());

                    Console.Write("Enter Student Phone NUmber: ");
                    this.phoneNumber = Convert.ToInt64(Console.ReadLine());

                    Console.Write("Enter Student Roll Number: ");
                    this.rollNo = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Student Fees: ");
                    this.fees = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine($"\n********StudentDetails: ************\n Student Name: {this.firstName}\nStudent Age: {this.age}\n Student Gender: {this.gender}\nStudent Phone: {this.phoneNumber}\nStudent Roll Number: {this.rollNo}\nStudent Fees: {this.fees} ");
                }
            }

            // *********Partial class**************
            public partial class PartialDetails
            {
                public string firstName { get; set; }
                public int age { get; set; }
                public char gender { get; set; }
                public long phoneNumber { get; set; }
            }
            public partial class PartialDetails
            {
                public void PartialClass()
                {
                    Console.Write("Enter Student Name: ");
                    this.firstName = Console.ReadLine();

                    Console.Write("Enter Student Age: ");
                    this.age = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter Student Gender: ");
                    this.gender = Convert.ToChar(Console.ReadLine());

                    Console.Write("Enter Student Phone Number: ");
                    this.phoneNumber = Convert.ToInt64(Console.ReadLine());

                    Console.WriteLine($"\n***********Student Details are: ***************\n Student Name: {this.firstName}\nStudent Age: {this.age}\n Student Gender: {this.gender}\nStudent Phone: {this.phoneNumber}");
                }
            }

             //sealed Class
        sealed class BaseClass
        {
            static int num1, num2;
            public static void Sealed_Data()
            {
                Console.WriteLine($"Addition is : {num1 + num2}");
            }
        }
        public class DerivedClass
        {
            public void Sealed_DerivedDate()
            {
                BaseClass.Sealed_Data();
            }
        }
        public static class StaticClass
        {
            static int numbers = 30;
            public static void static_Method()
            {
                int nums = StaticClass.numbers;
                Console.WriteLine("Value is : "+ nums);
            }
        }
    }
}
