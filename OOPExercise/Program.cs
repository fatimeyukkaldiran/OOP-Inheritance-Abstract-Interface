using System;

namespace OOPExercise
{
    partial class Program
    {
        static void Main(string[] args)
        {
            CustomerManager cm = new CustomerManager(); //customermanager sınıfın instancesi(örneği) oluşturuldu
            cm.Add();
            cm.Update();

            ProductManager pm = new ProductManager();
            pm.Add();
            pm.Update();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Jennifer"; 
            customer1.LastName = "Aniston";
            customer1.City = "Los Angeles";

            Customer customer2 = new Customer()
            {
                Id = 2,
                FirstName = "Fatime",
                LastName = "Yükkaldıran",
                City = "ŞanlıUrfa"
            };
            Console.WriteLine(customer1.FirstName + " " + customer1.LastName);
            Console.WriteLine(customer2.FirstName + " " + customer2.LastName);
        }
    }
}
