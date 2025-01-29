using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation1
{
     class Program
    {
        //-------------------------------- 
        //OPERATORS
        //int NoOf_Students = 4;
        //int NoOf_Subjects = 7;
        //int totalMarks = 700;

        //for (int i = 1; i <= NoOf_Students; i++)
        //{
        //    Console.WriteLine($"Enter marks for Student {i}.'{NoOf_Subjects}' Subjects For each Student");
        //    int Subject_totalMarks = 0;
        //    for (int j = 1; j <= NoOf_Subjects; j++)
        //    {
        //        Console.WriteLine($"Enter Marks for Subject {j}");
        //        int subjectMarks = int.Parse(Console.ReadLine());
        //        Subject_totalMarks += subjectMarks;
        //    }

        //    float Per = (float)Subject_totalMarks / totalMarks * 100;
        //    //Console.WriteLine($"Total Marks: {totalMarks}");
        //    //Console.WriteLine($"Overall Subject Marks: {Subject_totalMarks}");
        //    Console.WriteLine($"Your Percentage is {Per}");


        //    if (Per >= 80)
        //    {
        //        Console.WriteLine($"Total Marks: {totalMarks}");
        //        Console.WriteLine($"Obtain Marks: {Subject_totalMarks}");
        //        Console.WriteLine($"Your Percentage is: {Per} , & grade is A.");
        //    }
        //    else if (Per >= 90)
        //    {
        //        Console.WriteLine($"Total Marks: {totalMarks}");
        //        Console.WriteLine($"Obtain Marks: {Subject_totalMarks}");
        //        Console.WriteLine($"Your Percentage is: {Per} , & grade is A+.");
        //    }

        //}

        //------------------------------------- 
        //Encapsulation
        static void Main(string[] args)
        {
            /* Encapsulation Obj = new Encapsulation();
             Obj.Name = "Ali";
             Obj.Age = 100;
             Obj.Names("ali");
             Console.WriteLine(Obj.Name);
             Console.WriteLine(Obj.Age);
 */
            //------------------------------------- 
            //PLOYMROPHISM

            Child obj =new Child();
            int a = obj.polymorphism(89,56,78);
            Console.WriteLine(a);


        }

    }
}
