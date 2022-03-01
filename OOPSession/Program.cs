using System;
using static OOPSession.S11_ClassAndTypes;

namespace OOPSession
{
    class Program
    {
        static void Main(string[] args)
        {
            studentDEtails abstractClass = new studentDEtails();
            //abstractClass.AbstractClassAndDisplayDetails();
            PartialDetails partialClass = new PartialDetails();
            // partialClass.PartialClass();

            // Sealed Class
            DerivedClass obj = new DerivedClass();
          //  obj.Sealed_DerivedDate();
            //StaticClass.static_Method();

            //S12_FourPiller (Abstraction,Encapsulation)
            S12_FourPiller fourPillar = new S12_FourPiller();
            // fourPillar.NonAbstraction_Method();
            StudentClass absDemo = new StudentClass();
            //absDemo.StudentInfo();
           // absDemo.StudentName();

            Employee encaps = new Employee();
            //encaps.id = 11;
            // encaps.name = "Krishna";
            // Console.WriteLine($"My name is {encaps.name} and my id is {encaps.id}");

            Encapsulation polymorPhism = new Encapsulation();
            //polymorPhism.PolyMorphism();


            Single_Inheritance childClass = new Single_Inheritance();
            //childClass.Single_InheritanceMethod();

            Multiple_Inheritance multiple_Inheritance = new Multiple_Inheritance();
            //multiple_Inheritance.Parent_InheritanceMethod();


            //S13__MethodAnd Types
            S13_MethodAndTypes_MethodOverload_override methods = new S13_MethodAndTypes_MethodOverload_override();
            //methods.StringManupulation();
            //methods.Substraction(60,30);

            MethodOverLoading methodOverload_Override = new MethodOverRiding();
         //   methodOverload_Override.Addition_MethodOverride();

            PalindromParameterised palin = new PalindromParameterised();
            Console.Write("Enter the Number: ");
           // palin.palindrom(int.Parse(Console.ReadLine()));

            armstrongNumber arm = new armstrongNumber();
            arm.Armstrong(int.Parse(Console.ReadLine()));
        }
    }
}
