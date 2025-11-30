using Namespace_Assign.College.StudentInfo;

namespace Namespace_Assign
{

    namespace College
    {
        namespace StudentInfo
        {
            class Student
            {
                public static void ShowDetails()
                {
                    Console.WriteLine("Namespace - Student ");
                }
            }
        }
    }

    namespace School
    {
        namespace StudentInfo
        {
            class Student
            {
                public static void ShowDetails()
                {
                    Console.WriteLine("Namespace - School ");
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            College.StudentInfo.Student.ShowDetails();
            School.StudentInfo.Student.ShowDetails();


        }
    }
}
