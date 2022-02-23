using System;
using nestedNamespace;
namespace NameSpaceTwo
{
    class NameSpacesTwo : S4_AccessModifiereAndKeyword //Child Class OR Derived Class
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********** Inside the Second NameSpace ***********");
            S4_AccessModifiereAndKeyword nameSpace2 = new S4_AccessModifiereAndKeyword();
            //nameSpace2.PublicArithmaticOperation();

            NameSpacesTwo name = new NameSpacesTwo();
            name.PublicArithmaticOperation();
            name.ProtectedOperation();
        }
    }

}
