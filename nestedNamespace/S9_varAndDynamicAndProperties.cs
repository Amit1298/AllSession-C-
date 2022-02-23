using System;
using System.Collections.Generic;
using System.Text;

namespace nestedNamespace
{
    class S9_varAndDynamicAndProperties
    {
        public void varAndDynamic()
        {
            Console.WriteLine("*********You are in var***********\n");
            var data = "Program One";
            //data = 100; // error value cannot change
            foreach (char program in data)
            {
                Console.WriteLine(program);
            }

            Console.WriteLine("\nDatatype of var is: " + data.GetType() + "\n");

            Console.WriteLine("*********You are in dynamic*****************/n");
            dynamic name = "This is the program of amit";
            //name = 100;
            Console.WriteLine("value is : " + name + "\n");

            Console.WriteLine("Message is: ");
            foreach (dynamic message in name)
            {
                Console.WriteLine(message);
            }

            Console.WriteLine("\nDatatype of Dynamic is " + name.GetType() + "\n");
        }

        //properties
        public void PropertiesMethod()
        {
            Properties propertiees = new Properties();
            Console.WriteLine("Enter StudentId: ");
            propertiees.studentId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Student Name: ");
            propertiees.studentName = Console.ReadLine();

            Console.WriteLine("Enter Student Phone");
            propertiees.studentPhone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Student City");
            propertiees.studentCity = Console.ReadLine();

            Console.WriteLine("Enter student Add: ");
            propertiees.student_Add = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter StudentMarks: "); //readonly properties
            //propertiees.studentMarks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Student ID: {propertiees.studentId} \nstudentAdd: {propertiees.student_Add} \nStudent Name: {propertiees.studentName} \nstudent Phone: {propertiees.studentPhone} \nStudent City: {propertiees.studentCity}");
        }
        //Static Property
        public void StaticProperty()
        {
            Console.WriteLine("Enter School Name: ");
            Properties.school_Name = Console.ReadLine();
            Console.WriteLine("School Nameis: "+Properties.school_Name);
        }
    }
    class Properties
    {
        public int studentId { get; set; }
        public string studentName { get; set; }
        public string studentCity { get; set; }
        public dynamic studentPhone { get; set; }
        //public var studentGender{get; set;}
        public int studentMarks { get; } // readonly
        private int studentAdd;
        public int student_Add
        {
            set
            {
                if (value <= 0)
                    Console.WriteLine("Not allowed");
                else
                    this.studentAdd = value;
            }
            get { return this.studentAdd; }
        }
        //static property
        static string schoolName;
        static string schoolAdd;

        public static string school_Name
        {
            get { return schoolName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    Console.WriteLine("Empty string not allowed");
                else
                    schoolName = value;
            }
        }
        public static string school_Add { get; set; }
    }
}