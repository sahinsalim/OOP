namespace OOP_Add_Class 
{

    public class Employee
    {
        private string _firstName;
        private string _lastName;
        private List<Employee> _employees = new List<Employee>();

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }

        public int Age { get; set; }

        public List<Employee> Employees => _employees;

        public Employee()
        {
            Console.WriteLine("Yapılandırıcı Metot Çalıştı");
        }

        public Employee(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string ToString()
        {
            return $"{FirstName,-15} {LastName,-15} {Age,-5}";
        }

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public void AddRange(params Employee[] employees)
        {
            _employees.AddRange(employees);
        }

        public List<Employee> GetEmployees() => _employees;
    }

}
