using System;
using System.Collections.Generic;


namespace mm
{

    public struct Student
    {
        public string LastName;
        public string FirstName;
        public string StudentNumber;
        public float AverageScore;
    }


    public class methods
    {
        public static void Add(List<Student> A, Student B) //f
        {
            A.Add(B);
        }
        public static void GetElement(List<Student> A, int index) //f
        {
            Console.WriteLine(A[index].LastName + " " + A[index].FirstName + " Student Number: " + A[index].StudentNumber + " Average score: " + A[index].AverageScore);
        }
        public static void RemoveByIndex(List<Student> A, int index) //f
        {
            A.RemoveAt(index);
        }
        public static void RemoveFirst(List<Student> A)
        {
            A.RemoveAt(0);
        }
        public static void RemoveLast(List<Student> A)
        {
            A.RemoveAt(A.Count - 1);
        }
        public static void DisplayList(List<Student> A)
        {
            if (A.Count == 0) 
            {
                Console.WriteLine("List is empty");
            }
            foreach (var c in A)
            {
                Console.WriteLine(c.LastName + " " + c.FirstName + " " + c.StudentNumber + " " + c.AverageScore);
            }
        }
        public static void PopulateWithSampleData(List<Student> A) //create students and add them to the specified list 
        {
            Student bertonne = new Student();
            bertonne.LastName = "Bertonne";
            bertonne.FirstName = "Orianne";
            bertonne.StudentNumber = "1213";
            bertonne.AverageScore = 16;
            A.Add(bertonne);
            Student desgranges = new Student();
            desgranges.LastName = "Desgranges";
            desgranges.FirstName = "Romain";
            desgranges.StudentNumber = "7568";
            desgranges.AverageScore = 17;
            A.Add(desgranges);
            Student schalk = new Student();
            schalk.LastName = "Schalk";
            schalk.FirstName = "Mejdi";
            schalk.StudentNumber = "2310";
            schalk.AverageScore = 18;
            A.Add(schalk);
            Student gilbert = new Student();
            gilbert.LastName = "Gilbert";
            gilbert.FirstName = "Fanny";
            gilbert.StudentNumber = "4565";
            gilbert.AverageScore = 14;
            A.Add(gilbert);
        }

        //ASignment 2
        public static void Sort(List<Student> A, int Direction)
        {
            if (Direction == 1) // from lowest to biggest
            {

                int n = A.Count - 1;
                for (int i = 0; i < n; i++)
                { 
                    for (int j = i + 1; j <= n; j++)
                    {
                        if(A[i].AverageScore>A[j].AverageScore)
                        {
                            Student B = new Student();
                            B = A[i];
                            A[i] = A[j];
                            A[j] = B;
                        }
                    }
                    
                }
            }
            if (Direction == -1) //from bigest to lowest
            {
                int n = A.Count - 1;
                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j <= n; j++)
                    {
                        if (A[i].AverageScore < A[j].AverageScore)
                        {
                            Student B = new Student();
                            B = A[i];
                            A[i] = A[j];
                            A[j] = B;
                        }
                    }

                }
            }
  
        }
        public static void GetMaxElement(List<Student> A)
        {
            int n = A.Count - 1;
            Student B = new Student();
            B = A[0];
            for(int i = 1; i <= n; i++)
            {
                if(B.AverageScore<=A[i].AverageScore)
                {
                    B = A[i];
                }
            }
            Console.WriteLine(B.LastName + " " + B.FirstName + " " + B.StudentNumber + " " + B.AverageScore);
        }
        public static void GetMinElement(List<Student> A)
        {
            int n = A.Count - 1;
            Student B = new Student();
            B = A[0];
            for (int i = 1; i <= n; i++)
            {
                if (B.AverageScore >= A[i].AverageScore)
                {
                    B = A[i];
                }
            }
            Console.WriteLine(B.LastName + " " + B.FirstName + " " + B.StudentNumber + " " + B.AverageScore);
        }
        
    }


    //main
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> CDL = new List<Student>();
            
            Console.WriteLine("What do you cant to do \n 1)Populate with Sample Data \n 2)Add element \n 3)Get element \n 4)Remove by index \n 5)Remove first \n 6)Remove last");
            Console.WriteLine(" 7)Display list \n 8)Sort \n 9)Get max \n 10)Get min \n 11)Exit \n Write the number of your answer and press enter \n \n After an action display the list (7) to see the changement");
            int r = 12;
            while (r != 11)
            {
                r = int.Parse(Console.ReadLine());
                if (r == 1)
                {
                    methods.PopulateWithSampleData(CDL);
                }
                if (r == 2)
                {
                    Student c = new Student();
                    Console.WriteLine("last name:");
                    c.LastName = Console.ReadLine();
                    Console.WriteLine("First name");
                    c.FirstName = Console.ReadLine();
                    Console.WriteLine("Student Number");
                    c.StudentNumber = Console.ReadLine();
                    Console.WriteLine("Average Score");
                    c.AverageScore = int.Parse(Console.ReadLine());
                    methods.Add(CDL, c);
                }
                if (r == 3)
                {
                    Console.WriteLine("Which element do you want?(enter a number)");
                    int t = int.Parse(Console.ReadLine());
                    methods.GetElement(CDL, t);
                }
                if(r==4)
                {
                    Console.WriteLine("Which element do you want to remove(index in the list)");
                    int p = int.Parse(Console.ReadLine());
                    methods.RemoveByIndex(CDL, p);
                }
                if(r==5)
                {
                    methods.RemoveFirst(CDL);
                }
                if(r==6)
                {
                    methods.RemoveLast(CDL);
                }
                if(r==7)
                {
                    methods.DisplayList(CDL);
                }
                if(r==8)
                {
                    Console.WriteLine("Type 1 for lower to bigger and -1 for bigger to lower");
                    int o = int.Parse(Console.ReadLine());
                    methods.Sort(CDL, o);
                }
                if(r==9)
                {
                    methods.GetMaxElement(CDL);
                }
                if(r==10)
                {
                    methods.GetMinElement(CDL);
                }
            }
           }
    }
    

}
