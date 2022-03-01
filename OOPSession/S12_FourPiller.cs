using System;
using System.Collections.Generic;
using System.Text;

namespace OOPSession
{
    class S12_FourPiller
    {
        int age;
        private string employeeName;
        public string address;
        //Abstraction
        void Adstraction_Method()
        {
            double salary;
            const double tax = 0.1;
            double netSalary;
            Console.WriteLine("Enter Employee Name: ");
            employeeName = Console.ReadLine();

            Console.WriteLine("Enter Employee Age: ");
            age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Net Pay: ");
            netSalary = double.Parse(Console.ReadLine());

            //Calling Encapsulation method
            Encapsulation encap = new Encapsulation();
            encap.AccessingEncapsulation();

            if(netSalary >= 30000)
            {
                salary = netSalary - (tax * netSalary);
                Console.WriteLine($"*****Employee Details is ********\n Employee Name: {employeeName}\nEmployee Age: {age}\nEmplyee Address: {address}\nSalary: {salary}\n");
            }else
                Console.WriteLine($"*****Employee Details is ********\n Employee Name: {employeeName}\nEmployee Age: {age}\nEmplyee Address: {address}\nSalary: {netSalary}\n");
        }
        public void NonAbstraction_Method()
        {
            this.Adstraction_Method();
        }
    }
    //Encapsulation
    class Encapsulation
    {
        public void AccessingEncapsulation()
        {
            S12_FourPiller accessEncapData = new S12_FourPiller();
            accessEncapData.address = Console.ReadLine();
        }
        public void PolyMorphism()
        {
            Encapsulation polymorphism = new Encapsulation();
            polymorphism.Addition();
            polymorphism.Addition(30, 30);
        }
        public void Addition()
        {
            int num1 = 40, num2 = 40;
            Console.WriteLine($"Addition is for non parameter method; {num1+num2}");
        }
        public void Addition(int num1,int num2)
        {
            Console.WriteLine($"Addition is for parameter method; {num1 + num2}");
        }
    }

    //*************** Inheritance **************
    class Parent_Inheritance
    {
        public string name = "Imran";
        public int age = 88;
        public int workingHours = 12;
        int salary = 450000;

        public void Parent_InheritanceMethod()
        {
            Console.WriteLine($"The Person Detail is:**********\nName: {name}\nAge: {age}\nSalary: {salary}\nWork Hour: {workingHours}");
        }
    }

    class Single_Inheritance : Parent_Inheritance   // Single
    {
        long contactNo = 9988776655;
        string address = "Mumbai Pune Highway...";

        public void Single_InheritanceMethod()
        {
            Single_Inheritance baseInherit = new Single_Inheritance();
            baseInherit.Parent_InheritanceMethod();

            Console.Write($"Contat Number: {contactNo}\nAddress: {address}\n");
        }
    }

    class Hirarchical_Inheritance : Parent_Inheritance  // Hirarchical Inheritance
    {
        string[] city = { "Pune", "Latur", "Mumbai", "Dubai", "Jermany", "America", "Nashik", "Amrawati", "London", "UK", "US", "Japan", };
        public void Hirarchical_InheritanceMethod()
        {
            Console.Write("\nCities Are: ");
            foreach (string cities in city)
                Console.Write(cities);
        }
    }

    class Multilevel_Inheritance : Hirarchical_Inheritance  // Multilevel
    {
        int[] number = { 0, 11, 110, 1100, 11000, 1100000 };
        public void Multilevel_InheritanceMethod()
        {
            Console.Write("\nNumbers Are: ");
            for (int i = 0; i < number.Length; i++)
                Console.Write(i);
        }
    }

    //************Multiple Inheritance *****************
    interface MultipleInheritance
    {
        void Multiple_InheritanceAccess();
    }
    class Multiple_Inheritance : Multilevel_Inheritance, MultipleInheritance
    {
        public void Multiple_InheritanceAccess()
        {
            int no1 = 20, no2 = 40;
            Console.WriteLine($"Addition is :{no1 + no2}\nSubstraction is: {no2 - no1}");
        }
    }
        abstract class Student
    {
        public abstract void StudentInfo();
        public void StudentName()
        {
            Console.WriteLine("Amit Kumar");
        }
    }
    class StudentClass : Student
    {
        public override void StudentInfo()
        {
            Console.WriteLine("Name of Student is Amit");
        }
    }
    //Encapsulation
    class Employee
    {
        private int EmpId;
        private string EmpName;
        public int id { get { return EmpId; } set {EmpId = value; } }
        public string name { get {return EmpName; } set {EmpName = value; } }
    }
   
}
