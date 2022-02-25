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
