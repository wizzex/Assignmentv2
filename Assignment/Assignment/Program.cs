using System;

namespace Assignment
{
    //Struct
    struct Student
    {
        string LastName;
        string FirstName;
        string StudentNumuber;
        float AverageScore;
    }

    //main
    class Program
    {
        static void Main(string[] args)
        {
            //List<Student> CDL = new List<Student>();
            //PopulateWithSampleData();
            //Console.ReadKey();
        }
    }



    //methods
    static void Add(string LastName, string FirstName, string StudentNumber, float AverageScore) //f
    {
        Student LastName = new Student(LastName, FirstName, StudentNumber, AverageScore);
        CDL.Add(LastName.ToLower());
     }
    static void GetElement(int index) //f
    {
        Console.WriteLine(CDL[index].LastName + " " + CDL[index].FirstName + " Student Number: " + CDL[index].StudentNumber + " Average score: " + CDL[index].AverageScore);
    }
    static void RemoveByIndex(int index) //f
    {
        CDL.RemoveAt(index);
    }
    static void RemoveFirst()
    {
        CDL.RemoveAt(0);
    }
    static void RemoveLast()//f
    {
        CDL.RemoveAt(CDL.Count - 1);
    }
    static void DisplayList()
    {
        foreach(var c in CDL)
        {
            Console.WriteLine(c.LastName + " " + c.FirstName + " " + c.StudentNumber + " " + c.AverageScore);
        }
    }
    static void PopulateWithSampleData()
    {
        CDL bertonne = new CDL(Bertonne, Orianne, 1312, 16);
        CDL desgranges = new CDL(Desgranges, Romain, 7568, 17);
        CDL schalk = new CDL(Schalk, Mejdi, 2310, 18);
        CDL gilbert = new CDL(Gilbert, Fanny, 3454, 14);
    }

}   
