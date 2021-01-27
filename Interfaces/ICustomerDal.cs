using System;

namespace Interfaces
{
    interface ICustomerDal //data access layer -dal / db işlemleri
    {
        void Add();
        void Update();
        void Delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("SQL added!");
        }

        public void Delete()
        {
            Console.WriteLine("SQL deleted!");
        }

        public void Update()
        {
            Console.WriteLine("SQL updated!");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated!");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
