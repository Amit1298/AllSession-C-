using System;
using System.Collections.Generic;
using System.Text;

namespace nestedNamespace
{
    class S6_loopAndExceptionHandling
    {
        string[] name = {"Krishna","Amit","Rishi","Prakash","Faheem","Sumit","Satty","Imran","Ajay","Nitin" };

        //for loop
        public void LoopThroughName()
        {
            Console.WriteLine("Name are: ");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(name[i]+ " ");
            }
        }

        //while loop
        public void WhileLoopTable()
        {
            int number, i = 1;
            Console.WriteLine("**********You are in while loop*********************\n Enter Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            while (i <= 10)
            {
                Console.WriteLine($"{number} * {i} = " + number*i);
                i++;
            }
        }

        public void DoWhileLoopTable()
        {
            int number, i = 1;
            Console.WriteLine("You are in Do while loop \n Enter Number: ");
            number = Convert.ToInt32(Console.ReadLine());
            do
            {
                Console.WriteLine($"{number} * {i} = " + number * i);
                i++;
            } while (i < 0);
        }

        public void ContinueBreakGoTo()
        {
            for(int i= 0; i <= 20; i++)
            {
                if (i == 8)
                    goto terminateProgram;
            }
            terminateProgram:
            Console.WriteLine("This is End of the Program::");
        }

        public void TryCatchBlockWithMultipleCatch()
        {
            Console.WriteLine("***********You are in Try catch multiblock********");
            try
            {
                string name = null;
                Console.WriteLine(name.Length);

                int a = 100;
                int b = 0;
                int c = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //user define exception
        public void UserException()
        {
            float num = 20;
            float num1 = 0;
            if (num1 == 0)
            {
                throw new S6__CustomExceptionOrUserException(S6__CustomExceptionOrUserException.UserException.INVALID_DATA, "Data is not valid");
            }
        }
    }
}
