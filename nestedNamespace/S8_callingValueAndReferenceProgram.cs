using System;
using System.Collections.Generic;
using System.Text;

namespace nestedNamespace
{
    class S8_callingValueAndReferenceProgram
    {
        public void PassByValue_Addition(int num)
        {
            num = num + 10;
            Console.WriteLine("Value is: "+ num);
        }

        public void PassByValue()
        {
            int numMul = 20;
            PassByValue_Addition(numMul);
            Console.WriteLine("Inside PassByValue "+ numMul+"\n\n");
        }

        //Refrence type
        public void PassByReference_Subtraction(ref int value)
        {
            value = value - 10;
            Console.WriteLine("Subtraction value is : "+ value);
        }

        public void PassByRefrence()
        {
            int numDiv = 30;
            PassByReference_Subtraction(ref numDiv);
            Console.WriteLine("Inside passbyRefrence: "+ numDiv+"\n");
        }

        //passby out : out keyword
        public void PassByOut_Devide(out int value)
        {
            value = 60;
            Console.WriteLine("\nOutValue is : "+ value);
        }

        public void PassByOut()
        {
            int numDivide;
            PassByOut_Devide(out numDivide);
            Console.WriteLine("Inside passbyout: "+ numDivide+ "\n");
        }
    }
}
