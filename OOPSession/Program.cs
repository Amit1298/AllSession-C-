using System;
namespace OOPSession
{
    class Program
    {
        static void Main(string[] args)
        {
            S11_ClassAndTypes.studentDEtails abstractClass = new S11_ClassAndTypes.studentDEtails();
            abstractClass.AbstractClassAndDisplayDetails();
            S11_ClassAndTypes.PartialDetails partialClass = new S11_ClassAndTypes.PartialDetails();
            partialClass.PartialClass();
        }
    }
}
