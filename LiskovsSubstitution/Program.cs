using System;

namespace LiskovsSubstitution
{
    //Liskov's Substitution:
    //Nesneler sırf birbirine benzediği için birbirinin yerine kullanılmamalı!
    //(veri tabanı tasarımlarında gerçek müşteri - tüzel müşteri örneği)
    class Program
    {
        static void Main(string[] args)
        {
            Company company = new Company
            {
                Id = 1,
                CompanyName = "XYZ AŞ",
                TradeNumber = "12345678910"
            };
            Person person = new Person
            {
                Id = 2,
                FirstName = "Recep Tayyip",
                LastName = "Sever",
                NationalityNumber = "1234567890"
            };

            Console.WriteLine(company.CompanyName);
            Console.WriteLine(person.FirstName);
        }
    }
    class Customer
    {
        public int Id { get; set; }
    }
    class Person : Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityNumber { get; set; }
    }
    class Company : Customer
    {
        public string CompanyName { get; set; }
        public string TradeNumber { get; set; }
    }
}
