namespace Struct_Student
{
    internal class Program
    {
        struct Student
        {
            private string _name;
            private bool _gender;
            private int _age;
            private int _std;
            private char _div;
            private double _marks;

            public Student(string _name, bool _gender, int _age, int _std, char _div, double _marks)
            {
                this._name = _name;
                this._gender = _gender;
                this._age = _age;
                this._std = _std;
                this._div = _div;
                this._marks = _marks;
            }

            public void SetName(string name)
            {
                this._name = name;
            }

            public void SetGender(bool gender)
            {
                this._gender = gender;
            }

            public void SetMarks(double marks)
            { this._marks = marks; }
            public void SetStd(int std)
            { this._std = std; }

            public void SetDiv(char div)
            { this._div = div; }

            public void SetAge(int age)
            {
                this._age = age;
            }
            public string GetName()
            {
                return _name;
            }

            public int GetAge()
            {
                return _age;
            }

            public bool GetGender()
            {
                return _gender;
            }

            public int GetStd()
            {
                return _std;
            }
            public double GetMarks()
            {
                return _marks;
            }

            public char GetDiv()
            {
                return _div;
            }
            public void AcceptDetails()
            {
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();
                SetName(name);
                Console.WriteLine("Enter Gender");
                string gdr = Console.ReadLine();
                bool gender = Convert.ToBoolean(gdr);
                SetGender(gender);
                Console.WriteLine("Enter age:");
                string str = Console.ReadLine();
                int age = Convert.ToInt32(str);
                SetAge(age);
                Console.WriteLine("Enter std:");
                string std1 = Console.ReadLine();
                int std = Convert.ToInt32(std1);
                SetStd(std);
                Console.WriteLine("Enter div: ");
                string div = Console.ReadLine();
                char div1 = Convert.ToChar(div);
                SetDiv(div1);
                Console.WriteLine("Enter marks: ");
                string mks = Console.ReadLine();
                double marks = Convert.ToDouble(mks);
                SetMarks(marks);
            }

            public void ShowDetails()
            {
                Console.WriteLine("===STUDENT DETAILS===");
                Console.WriteLine($"Name:{GetName()}");
                Console.WriteLine($"Gender:{GetGender()}");
                Console.WriteLine($"Age:{GetAge()}");
                Console.WriteLine($"Std:{GetStd()}");
                Console.WriteLine($"Div:{GetDiv()}");
                Console.WriteLine($"Marks:{GetMarks()}");
            }
            static void Main(string[] args)
            {
                Student s1 = new Student();
                s1.AcceptDetails();
                s1.ShowDetails();
            }
        }
    }
}
