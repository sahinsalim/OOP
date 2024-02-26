namespace OOP_Add_Class
{
    class Employee
    {
        // Field Identification.
        private string _FName;
        private string _LastName;
        public string FirstName
        {
            set { _FName = value; }
            get { return _FName; }
        }

        public string LastName { 
            // Expression-bodied property accessors (=>)
            get => _LastName; 
            set => _LastName = value; 
        }

        // Auto-implemented property
        public int Age { get; set; }


        public Employee()
        {
            Console.WriteLine("Yapılandırıcı Metot Çalıştı");
        }

        // Overloading.
        public Employee(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public override string? ToString()
        {
            return $"{FirstName,-15} {LastName,-15} {Age,-5}";
        }
    }
}
