using System;

namespace Interfaces1
{
    class Program
    {
        // İnterface new'lenemez
        static void Main(string[] args)
        {
           // IPersonManager customerManager = new CustomerManager();
           
          //  IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
        }
    }

    interface IPersonManager
    {
        //unimplemented operation //burada içerisine yazdığımız kod heryerde ortak demektir.
        void Add();
        void Updated();
    }
    //class PersonManager
    //{ 
    //    //implemented operation-içi doldurulmuş tamamlanmış demektir 
    //    public void Add()
    //    {
    //        Console.WriteLine("Eklendi");
    //    }

    //}

    // inherits - class --------- implements- interface
    class CustomerManager : IPersonManager
    {
      
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void Updated()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }
    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
             // personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Updated()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Updated()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }
    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }
    }
}
