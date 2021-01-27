using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[]
            {
                new Worker(),
                new Manager(),
                new Robot()
            };
            foreach (var worker in workers)
            {
                worker.Work();
            }
            IEat[] eats = new IEat[]
            {
                new Worker(),
                new Manager()

            };
            foreach (var eat in eats)
            {
                eat.Eat();
            }

            ISalary[] salaries = new ISalary[]
            {
                new Worker(),
                new Manager()
            };
            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }
        }
    }

    interface IWorker
    {
        void Work();
       
    }
    interface IEat
    {
        void Eat();
    }
    interface ISalary
    {
        void GetSalary();
    }
    class Manager : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, IEat, ISalary //bir class birden fazla interfaceyi implemente edebilir
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
