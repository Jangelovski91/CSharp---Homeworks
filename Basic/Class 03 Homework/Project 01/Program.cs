using System;

namespace Project_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise01- SumOfEven

            //int[] intArray1 = new int[6];
            //Console.WriteLine("Enter the 1st number!");
            //intArray1[0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the 2nd number!");
            //intArray1[1] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the 3th number!");
            //intArray1[2] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the 4th number!");
            //intArray1[3] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the 5th number!");
            //intArray1[4] = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the 6th number!");
            //intArray1[5] = int.Parse(Console.ReadLine());
            //int resultNum = 0;

            //for (int i = 0; i <= 5; i++)
            //{
            //    if (intArray1[i] % 2 == 0)
            //    {
            //        resultNum += intArray1[i];

            //    }
            // };
            //Console.WriteLine("The resault is" + resultNum);

            #endregion

            #region Exercise02 StudentGroup
            string[] studentsG1 = new string[] { "Bob", "Jill", "Greg", "John", "Michael" };
            string[] studentsG2 = new string[] { "Trajko", "Petko", "Stanko", "Zdravko", "Branko" };
            Console.WriteLine("Enter student group(1 or 2)...");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= studentsG1.Length; i++)
            {

                if (number == 1)
                {

                    Console.WriteLine(studentsG1[i]);
                }
                else if (number == 2)
                {
                    Console.WriteLine(studentsG2[i]);
                }
                else Console.WriteLine("This group does not exist!");

            };
            #endregion




            Console.ReadLine();
        }
    }
}
