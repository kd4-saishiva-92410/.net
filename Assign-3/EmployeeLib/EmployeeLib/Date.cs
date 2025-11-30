namespace EmployeeLib
{
    public class Date
    {
		private int _day;

		private int _month;

		private int _year;

		public int Year
		{
			get { return _year; }
			set { _year = value; }
		}


		public int Month
		{
			get { return _month; }
			set { _month = value; }
		}

		public int Day
		{
			get { return _day; }
			set { _day = value; }
		}

        public Date()
        {
            
        }

        public Date(int day, int month, int year)
        {
            _day = day;
            _month = month;
            _year = year;
        }

		public void  AcceptDate()
		{
			
			Console.WriteLine("Enter Day :");
			Day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Month :");
            Month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Year :");
            Year = Convert.ToInt32(Console.ReadLine());
        }

		public bool IsValid(int Day,int Month,int Year)
		{
            if (Day>0 || Day<32 && Month>0 || Month<13)
            {
                return true;	
            }
			else
			{
				Console.WriteLine("Invalid Date");
				return false;
			}
        }

		public void PrintDate()
		{
			Console.WriteLine($"{Day}/{Month}/{Year}");
		}

		public static int AgeCalculate(int Yr)
		{					
			int currentyr = DateTime.Now.Year;
			int getDiff = currentyr - Yr;
			return getDiff;
		}

        public override string ToString()
		{
			return $"{Day.ToString()}/{Month.ToString()}/{Year.ToString()}";
		}
    }

	


	public class Person
	{
		private string _name;

		private bool _gender;

		private string _address;

		Date birth = new Date();

		public string Address
		{
			get { return _address; }
			set { _address = value; }
		}


		public bool Gender
		{
			get { return _gender; }
			set { _gender = value; }
		}


		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

        public Person()
        {
            
        }

        public Person(string name, bool gender, string address, Date birth)
        {
            _name = name;
            _gender = gender;
            _address = address;
            this.birth = birth;
        }

		public virtual void Accept()
		{
			Console.WriteLine("Enter Name : ");
			Name = Console.ReadLine();
            Console.WriteLine("Enter Gender (female -> true, Male -> false) : ");
            Gender = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Enter Birth Date");
            birth.AcceptDate();
        }

		public virtual void Print()
		{
			Console.WriteLine($"Name : {Name}");
			if (Gender)
			{
				Console.WriteLine("Gender : Female");
			}
			else
			{
                Console.WriteLine("Gender : Male");
            }
			birth.PrintDate();
			Console.WriteLine($"Age : {Date.AgeCalculate(birth.Year)}");
		}

		public override string ToString()
		{
			return $"Name - {Name} Gender - {Gender} {birth.ToString()}";
		}
    }


	public class Employee : Person 
	{
		private static int count = 100;
		private int _id;
		private double _salary;
		private string _designation;
        public enum DepartmentType
        {
            HR, Sales, IT, Finance
        };

		private DepartmentType _department;

		public DepartmentType Department
		{
			get { return _department; }
			set { _department = value; }
		}



		public string Designation
		{
			get { return _designation; }
			set { _designation = value; }
		}


		public double Salary
		{
			get { return _salary; }
			set { _salary = value; }
		}


		public int Id
		{
			get { return _id; }
		}

        public Employee():base()
        {
			_id = count++;
        }

        public Employee( double salary, string designation):base()
        {
			_id = count++;
            _salary = salary;

        }

        public override void Accept()
        {
            base.Accept();
			Console.WriteLine("Enter Salary : ");
			Salary = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter Department ( 0 = HR, 1 = Sales, 2 = IT, 3 = Finance): \") : ");
			Department = (DepartmentType) Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
			Console.WriteLine($"Employee Id : {Id}");
            base.Print();
			Console.WriteLine($"Salary - {Salary}");
            Console.WriteLine($"Designation - {Designation}");
            Console.WriteLine($"Department - {Department}");
        }

        public override string ToString()
        {
            return $"{base.ToString()} Salary - {Salary} Designation - {Designation} Department - {Department}" ;
        }
    }


	public class Manager:Employee
	{
		private double _bonus;

		public double Bonus
		{
			get { return _bonus; }
			set { _bonus = value; }
		}

        public Manager():base()
        {
			Designation = "Manager"; ;
        }

        public Manager(double bonus):base()
        {
			Designation = "Manager";
            _bonus = bonus;
        }

		public override void Accept() 
		{
			base.Accept();
			Console.WriteLine("Enter Bonus : ");
			Bonus = Convert.ToDouble(Console.ReadLine());
		}

        public override void Print()
        {
            base.Print();
			Console.WriteLine($"Bonus - {Bonus}");
        }

        public override string ToString()
        {
            return $"{base.ToString()} Bonus - {Bonus}";
        }
    }

    public class Supervisor : Employee
    {
        private int _subordinates;

        public int Subordinates
        {
            get { return _subordinates; }
            set { _subordinates = value; }
        }

        public Supervisor():base()
        {
			Designation = "Supervisor";
        }

        public Supervisor(double bonus):base()
        {
            _subordinates = Subordinates;
            Designation = "Supervisor";
        }

        public override void Accept()
        {
            base.Accept();
            Console.WriteLine("Enter Subordinates : ");
            Subordinates = Convert.ToInt32(Console.ReadLine());
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Subordinates - {Subordinates}");
        }

        public override string ToString()
        {
            return $"{base.ToString()} Subordinates - {Subordinates}";
        }
    }

	public class WageEmp : Employee
	{
		private int hours;

		private int rate;

		public int Rate
		{
			get { return rate; }
			set { rate = value; }
		}


		public int Hours
		{
			get { return hours; }
			set { hours = value; }
		}

        public WageEmp():base()
        {
			Designation = "Wage";
        }

        public WageEmp(int hours, int rate):base()
        {
            this.hours = hours;
            this.rate = rate;
        }

        public override void Accept()
        {
            base.Accept();
			Console.WriteLine("Enter Hours : ");
			Hours = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Rate (per hour basis) :");
			Rate = Convert.ToInt32(Console.ReadLine());	
        }

        public override void Print()
        {
            base.Print();
			Console.WriteLine($"Hours : {Hours}");
			Console.WriteLine($"Rate : {Rate}");
        }

        public override string ToString()
        {
            return $"{base.ToString()} Hours - {Hours} Rate - {Rate}";
        }
    }

}
