using System;
using System.Collections.Generic;
using System.Text;

namespace nestedNamespace
{
    class S3_OperatorAndTypeConversion
    {
        static int no1 = 10, no2 = 10, no3 = 21, no4 = 22, sum;
        public void operatorAndConversion()
        {
            int[] num1 = { };
            Console.WriteLine("***********Arithematic Operator*************");
            sum = no1 + no2;
            Console.WriteLine("Addition: \t"+sum);
            Console.WriteLine($"Substraction: \t {no3-no2}");
            Console.WriteLine($"Multiplication: \t {no3 * no1}");
            Console.WriteLine($"Division: \t {no3 / no2}");

            Console.WriteLine("***************Assignment Operator****************\n");
            Console.WriteLine($"Assign Value \t {no1 = no3}");
            Console.WriteLine($"Add Equal \t {sum += no3}");
            Console.WriteLine($"Sun=m Equal \t {sum -= no3}");

            Console.WriteLine("*************Profile postfix Operation****************\n");
            Console.WriteLine($"Postfix -- :\t {sum = no3--}");
            Console.WriteLine($"Postfix ++ : \t {sum = no3++}");

            Console.WriteLine($"--Prefix : \t {sum=--no3}");
            Console.WriteLine($"++Prefix : \t {sum = ++no3}");

            Console.WriteLine("********Logical & relatioal*************\n");
            if(no1 == no2 || no3 == no4)
            {
                Console.WriteLine("number is geater");
            }
            else
            {
                Console.WriteLine("number is lesser");
            }

            Console.WriteLine("***************Misslenius Operation******************\n");
            Console.WriteLine("Size of DataType int is: "+ sizeof(int));
            Console.WriteLine("Size of DataType int is: " + sizeof(float));
            Console.WriteLine("Size of ArrayDataType is: " + typeof(int[]));
            Console.WriteLine("Size of Integer Data is: " + typeof(int));

            Console.WriteLine("***********Ternary or Condition Operator******************");
            sum = no2 > no3 ? no2 : no3;
            Console.WriteLine("Condition operation "+ sum +"\n");

            Console.WriteLine("********Type Conversion : Implicit**************\n");
            int number = 66;
            long dataNo = number;
            float value = dataNo;
            Console.WriteLine($"Value of numbe is: {number} \t value of data: {dataNo} \t value : {value}");

            Console.WriteLine("***********Type Conversion : Explicit*******************\n");
            double decimalValue = 1123.888F;
            int a;
            a = Convert.ToInt32(decimalValue);
            Console.WriteLine("Value of after conversion: "+ a);
            Console.WriteLine("*************Boxing unboxing*****************\n");
            //Boxing
            string name = "Amit";
            object fname = name;
            name = "Krishna";
            Console.WriteLine("Hello :"+ name);
            Console.WriteLine("Hello Boxer object: "+ fname);

            //Unboxing
            string Lname = Convert.ToString(fname);
            Console.WriteLine("Hello Unboxer object: "+ Lname);

        }
    }
}
