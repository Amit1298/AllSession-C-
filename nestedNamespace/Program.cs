using System;
using nestedNamespace.nNamespace;

namespace nestedNamespace
{
    class namespace1
    {
        int a = 0, b = 0, c = 0;
        public void Addition()
        {
            this.a = 20;
            this.b = 30;
            this.c = a + b;
            Console.WriteLine("Addition of two number: " + this.c);
        }
    }
        namespace nNamespace
    {
        class namespace2
        {
            int a = 0, b = 0, c = 0;
            public void sub()
            {
                this.a = 45;
                this.b = 25;
                this.c = a - b;
                Console.WriteLine("Subtraction of two number: "+ this.c);
            }
        }
    }
    class Program : S4_AccessModifiereAndKeyword
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //namespace1 obj = new namespace1();
            //obj.Addition();
            //namespace2 obj2 = new namespace2();
            //obj2.sub();
            //Multiple obj3 = new Multiple();
            //obj3.multiple1();
            //divide obj4 = new divide();
            //obj4.divivde1();

            ////Variable Session 2
            //variableSession2 obj5 = new variableSession2();
            //obj5.VariablesAndUses();

            //Session 3
            //   S3_OperatorAndTypeConversion obj6 = new S3_OperatorAndTypeConversion();
            //   obj6.operatorAndConversion();


            //Session 4 Access Modifieres And Keywords
            //S4_AccessModifiereAndKeyword modifier = new S4_AccessModifiereAndKeyword();
            //modifier.PublicArithmaticOperation();
            ////modifier.PrivateAssignmentOperator();    //need to PrivateMethod explain

            //Program prg = new Program();
            ////Child Class
            //ChildClass child = new ChildClass();
            //child.PublicLogicalOperation();
            //prg.ProtectedOperation();




            //Session 5 Selection and Condition Statement
            S5_SelectionAndStatmentProgram obj7 = new S5_SelectionAndStatmentProgram();
            //obj7.MarkChecker();
            //obj7.Nestedif();
            //obj7.SwitchCase();
            //obj7.SwitchGroup();
            S5_Task task = new S5_Task();
            //task.checkNumber();
            // task.Armstrong();
            //task.prime();
            //task.palindrome();
            //task.Fibonacci();
            //Console.Write("1: Check Odd Even \n2: Armstrong Number \n3: Fibonacci Series \n4: Palindrome Number \n5: Prime Number\n6: Natural Number \n7: palindrome1to100\n8: Perfect Number\n");
            //Console.Write("Please Select the Number: ");
            //int select = int.Parse(Console.ReadLine()); 

            //task.Armstrong();
            /////task.ArmstrongWithForLoop();

            //switch (select)
            //{
            //    case 1:
            //        task.checkNumber();
            //        break;
            //    case 2:
            //        task.Armstrong();
            //        break;
            //    case 3:
            //        task.Fibonacci();
            //        break;
            //    case 4:
            //        task.palindrome();
            //        break;
            //    case 5:
            //        task.prime();
            //        break;
            //    case 6:
            //        task.naturalNumber();
            //        break;
            //    case 7:
            //        task.palindrome1to100();
            //        break;
            //    case 8:
            //        task.perfectNumber();
            //        break;
            //}

            // Session 6 Exception handling
            S6_loopAndExceptionHandling exception = new S6_loopAndExceptionHandling();
            //exception.LoopThroughName();
            //exception.WhileLoopTable();
            //exception.DoWhileLoopTable();
            //exception.ContinueBreakGoTo();
            //exception.TryCatchBlockWithMultipleCatch();
            //exception.UserException();


            //Session 7 Array and Types
            S7__ArraysAndTypes array = new S7__ArraysAndTypes();
            //array.SingleDimensionalArray();
            //array.MultiDimensionalArray();
           // array.sortArray();
            //array.sortArray2D();


            //Session 8 Call by value and refrence
            S8_callingValueAndReferenceProgram callby = new S8_callingValueAndReferenceProgram();
            //callby.PassByValue();
            //callby.PassByRefrence();
            //callby.PassByOut();

            //Session 9 var Dynamic and Properties
            S9_varAndDynamicAndProperties varDynamic = new S9_varAndDynamicAndProperties();
            //varDynamic.varAndDynamic();
            //varDynamic.PropertiesMethod();
            //varDynamic.StaticProperty();


            //S10__Params
            S10_ParamsAndIndexer param = new S10_ParamsAndIndexer();
            //param.Params_Operation(20, 22, 33, 44);
            //param.Params_Array("Sumit", "Sujit", "Abhilasha", "Imran", "Amit", "Anmol");
            //param.Params_MultipleValue(2, 3, 4, 'A', 'B', "Amit", "Somesh", "Sohel");
            //IndexerAccept.Indexer_Accept();
            //Console.ReadLine();


           
        }
    }
}
