using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, enum, boolean value types
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;

            //Console.WriteLine("sayi 1: " + sayi1);

            ////array, class interface... reference types

            //int[] sayilar1 = new int[] { 1, 2, 3 };
            //int[] sayilar2 = new int[] { 10, 20, 30 };

            //sayilar1 = sayilar2;
            //sayilar2[0] = 1000;

            //Console.WriteLine("sayilar1[0] = " + sayilar1[0]);

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirtstName = "Enes";

            person2 = person1;
            person1.FirtstName = "Etka";

            Console.WriteLine(person2.FirtstName);

            Customer customer = new Customer();
            customer.FirtstName = "Salih";
            customer.CreditCardNumber = "1234567890";

            Employee employee = new Employee();
            employee.FirtstName = "Ramiz";

            // customer = employee; //Bu sekilde bir atama yapamayiz. Nasil ki string ve int farkli türlerdir, burada da customer ve employee farkli türler

            Person person3 = customer;   // Bu sekilde bir atama yapilabilir cünkü inheritance sebebi ile her customer ayni zamanda bir person olur.
            customer.FirtstName = "Ahmet";

            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(customer);

        }
    }

    // base class : Person
    class Person
    {
        public int Id { get; set; }
        public string FirtstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person) //Parametre olarak Person yazdigimiz icin hem customer hem de employee ile calisabiliriz
        {
            Console.WriteLine(person.FirtstName);
        }
    }
}
