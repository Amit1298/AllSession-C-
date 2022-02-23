using System;
using nestedNamespace;
namespace NameSpace2
{
    class NameSpacesTwo : S4_AccessModifiereAndKeyword
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
