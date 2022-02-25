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
            absDemo.StudentInfo();
            absDemo.StudentName();

            Employee encaps = new Employee();
            encaps.id = 11;
            encaps.name = "Krishna";
            Console.WriteLine($"My name is {encaps.name} and my id is {encaps.id}");
        }
    }
}
