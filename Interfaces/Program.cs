using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // IntarfacesIntro();

            // Demo();


            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal(),
            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();

            }
            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void IntarfacesIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Address = "Ankara" });
            Customer customer = new Customer { Id = 1, FirstName = "Engin", LastName = "Demiroğ", Address = "Ankara" };
            manager.Add(customer);

            Student student = new Student { Id = 1, FirstName = "Derin", LastName = "Demiroğ", Departmant = "Computer Sciences" };
            manager.Add(student);
        }

        interface IPerson
        {
            int Id { get; set; }
            string FirstName{ get; set; }
            string LastName { get; set; }
        }
        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }

        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }

        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);
            }
        }
    }
}
