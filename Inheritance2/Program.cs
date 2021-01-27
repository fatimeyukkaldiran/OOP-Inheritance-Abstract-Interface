using System;

namespace Interface2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            CustomerManager customerManager = new CustomerManager();

           // customerManager.Add();
            IPersonManager pm = new CustomerManager(); //Interface onu implemente eden class'ın ref tutuyor
            pm.Add();
            IPersonManager[] persons = new IPersonManager[]{
                new CustomerManager(), new EmployeeManager() };
            foreach (var person in persons)
            {
                person.Add();
            }
        }
    }
    interface IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("ekleme yapıldı");
        }
    }
    // implemented operation

    class CustomerManager : IPersonManager
    {
  
    }
    class EmployeeManager : IPersonManager
    {
     
    }
}
