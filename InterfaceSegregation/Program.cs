using System;

namespace InterfaceSegregation
{
    //InterfaceSegregation:
    //Bir sınıfın bir interfaceden implemente olması durumunda interface içerisindekibütün operasyonları gerçekten
    //kullanıyor olması gerekir. Eğer bir operasyonu kullanılmıyorsa o zaman bu prensibi çiğnenmiş olur.
    //Tek bir interface oluşturmak yerine interfaceleri doğru parçalara ayırarak kullanmak işimizi kolaylaştıracaktır

    //Senaryo:
    //Bir kurumda personel, işçi ve stajyer çalışan hakları:
    //personel: maaş + remote çalışma + ticket
    //işçi: maaş
    //stajyer:ticket
    //çalışan hakları tek bir interfacede tanımlanmamalı! ayrı interfaceler oluşturulmalı.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Employee : IPayment, IRemotely, ITicket
    {
        public void Pay()
        {
            //operation codes
        }

        public void Remote()
        {
            //operation codes
        }

        public void TicketPay()
        {
            //operation codes
        }
    }

    class Worker : IPayment
    {
        public void Pay()
        {
            //operation codes
        }
    }

    class Trainee : ITicket
    {
        public void TicketPay()
        {
            //operation codes
        }
    }

    public interface IPayment
    {
        void Pay();
    }

    public interface IRemotely
    {
        public void Remote();
    }

    public interface ITicket
    {
        void TicketPay();
    }
}
