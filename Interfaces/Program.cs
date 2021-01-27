using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // InterfaceIntro();
            //bir interface tek başına newlenemez
            // IPerson person = new IPerson();
            // Interface, Abstract gibi soyut sınıflar newlenemez
            //IPerson person = new Customer();
            //IPerson person1 = new Student();
            // Demo();

            //bir verimizi hem oracle hem sql db yazma

            ICustomerDal[] customerDals = new ICustomerDal[] {new SqlServerCustomerDal(), new OracleCustomerDal()};

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfaceIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Jan",
                LastName = "Rucinski",
                Adress = "Warsaw DS Ustronie"
            };
            personManager.Add(customer);

            Student student = new Student
            {
                Id = 1,
                FirstName = "Görkem",
                LastName = "Ünal",
                Department = "Computer Science"
            };
            personManager.Add(student);
        }

        interface IPerson //öğrenci ve customer bir persondur
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }
        }

        class Customer : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Adress { get; set; }
        }
        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Department { get; set; }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine("customer = " + person.FirstName + " " + person.LastName + " " + person.Id);
            }
        }
    }
}
