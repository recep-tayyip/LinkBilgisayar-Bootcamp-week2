using System;

namespace OpenClosed_DependensyInversion
{
    //Open Closed Principle:
    //Bir projeye yeni bir özellik eklendiğinde mevcuutaki kodlarda ne kadar değişiklik yapılıyor!?

    //Dependency Inversion Principle:
    //sınıflar veya katmanlar birbirileriyle olan bağımlılığını soyut nesneler üzerinden gerçekleştirmelidir.


    //Senaryo
    //Projede SQL Server veri tabanlarında Entity Framework kullanırken
    //Oracle veri tabanlarında NHibernate kullanmak istersem?!

    class Program
    {
        static void Main(string[] args)
        {
            //CustomerManager customerManager=new CustomerManager();

            CustomerManager customerManager1 = new CustomerManager(new EfCustomerDal());
            CustomerManager customerManager2 = new CustomerManager(new NhCustomerDal());

            customerManager1.Add();
            customerManager2.Add();
        }
    }
    //Business Layer
    class CustomerManager
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }
        public void Add()
        {
            //Business & DAL bağımlılığı
            //gevşek bağımlılık (Loosely Coupled)

            //EfCustomerDal customerDal = new EfCustomerDal();
            //NhCustomerDal customerDal=new NhCustomerDal();
            //customerDal.Add();

            _customerDal.Add();
        }
    }

    //Data Access Layer
    class EfCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("used with Entity Framework");
        }
    }

    class NhCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("used with NHibernate");
        }
    }

    internal interface ICustomerDal
    {
        void Add();
    }
}