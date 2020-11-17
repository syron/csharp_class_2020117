using ConsoleApp4.Helper;
using ConsoleApp4.Models;
using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(MathOperations.Add(1, 1));
            //Console.WriteLine(MathOperations.Add(1, 1, 1));
            //Console.WriteLine(MathOperations.Add(1, 1, 1, 1));
            //Console.WriteLine(MathOperations.Add(new List<int>() { 1, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6, 2, 3, 4, 5, 6 }));



            Store storeX = new Store();
            storeX.Id = 1;
            storeX.Name = "Karlstad's bästa propellerbutik!";

            Customer customerX = new Customer(1, "Rob");


            int x = 15;

            Human human = new Human();
            human.Name = "Robert";
            Console.WriteLine(human.ToString());



            Console.WriteLine(storeX.ToString());
            Console.WriteLine(customerX.ToString());

            Console.WriteLine(x);


            



            return;

            


            Customer customer = null;

            try
            {
                customer = new Customer(1, "Rob");
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine("You know what?! The customer's name must not be empty!");
                return;
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine("Customer name is too short. Atleast 3 digits must be used!");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Något gick fel, försök igen!");
                return;
            }
            finally
            {
                
            }


         
            Store store = new Store();
            store.Id = 1;
            store.Name = "Kalle Kula i Malmö";


            //// way number 1



            //Order order = new Order();
            //order.Id = 2;
            //order.OrderDate = DateTime.UtcNow;
            //order.Store = store;
            //order.Customer = customer;

            //order.Articles.Add("Coca Cola Zero");
            //order.Articles.Add("Kinder Mini-Mix Adventskalender");

            //order.Finish();



            //Order order2 = new Order();
            //order2.Id = 2;
            //order2.OrderDate = DateTime.UtcNow;
            //order2.Store = store;
            //order2.Customer = customer;

            //order2.Articles.Add("Mellanmjölkdryck");

            //order2.Finish();





            //// det här ska hända, först när kund lämnar butik
            //customer.AddOrder(order);
            //customer.AddOrder(order2);




            List<Order> theCustomersOrders = new List<Order>();

            Order order = new Order();
            order.Id = 2;
            order.OrderDate = DateTime.UtcNow;
            order.Store = store;
            order.Customer = customer;

            order.Articles.Add("Coca Cola Zero");
            order.Articles.Add("Kinder Mini-Mix Adventskalender");

            order.Finish();
            theCustomersOrders.Add(order);


            Order order2 = new Order();
            order2.Id = 2;
            order2.OrderDate = DateTime.UtcNow;
            order2.Store = store;
            order2.Customer = customer;

            order2.Articles.Add("Mellanmjölkdryck");

            order2.Finish();

            theCustomersOrders.Add(order2);



            customer.AddOrder(theCustomersOrders);




            List<Order> orders = new List<Order>();
            List<string> strings = new List<string>();
            List<int> ints = new List<int>();




            //Dictionary<string, Human> myFellowHumans = new Dictionary<string, Human>();
            //myFellowHumans.Add("8888888888", new Human() { Name = "Robert", IsHungry = true });
            //myFellowHumans.Add("9999999999", new Human() { Name = "Winston", IsHungry = true });
            //myFellowHumans.Add("7777777777", new Human() { Name = "Leonard", IsHungry = false });




            ////var currentHuman = myFellowHumans[personnr];
            ////Console.WriteLine("Ok, är du " + currentHuman.Name + "?");


            //List<Human> humans = new List<Human>();
            //humans.Add(new Human() { Name = "Robert", IsHungry = true, InsuranceNumber = "8888888888" });
            //humans.Add(new Human() { Name = "Winston", IsHungry = true, InsuranceNumber = "9999999999" });
            //humans.Add(new Human() { Name = "Leonard", IsHungry = false, InsuranceNumber = "7777777777" });


            //// foreach, for, while, do..while
            ////    if


            //// problemställning: HItta RObert

            //foreach (var human in humans)
            //{
            //    if (human.InsuranceNumber == personnr)
            //    {
            //        Console.WriteLine("Ok, är du " + human.Name + "?");
                    
            //    }
            //}



            //Console.Write("Ge mig ditt personr (XXXXXXXXXX): ");
            //string personnr = Console.ReadLine();


            //int i = 0;
            //do
            //{
            //    var human = humans[i];

            //    if (human.InsuranceNumber == personnr)
            //    {
            //        Console.WriteLine("Ok, är du " + human.Name + "?");
            //    }

            //    i++;
            //}
            //while (i < humans.Count);



            ////foreach (var human in humans)
            ////{
            ////}


            ////int i = 0;
            ////while (i < humans.Count)
            ////{
            ////    var human = humans[i];

            ////    if (human.InsuranceNumber == personnr)
            ////    {
            ////        Console.WriteLine("Ok, är du " + human.Name + "?");
            ////    }

            ////    i++;
            ////}


            ////string personnr = "";
            ////while (personnr.Length != 10)
            ////{
            ////    Console.Write("Ge mig ditt personr (XXXXXXXXXX): ");
            ////    personnr = Console.ReadLine();

            ////    if (personnr.Length != 10)
            ////    {
            ////        Console.WriteLine("Försök igen...");
            ////    }
            ////}

            //personnr = "";
            //while (true)
            //{
            //    Console.Write("Ge mig ditt personr (XXXXXXXXXX): ");
            //    personnr = Console.ReadLine();

            //    if (personnr.Length != 10)
            //    {
            //        Console.WriteLine("Försök igen...");
            //    }
            //    else
            //    {
            //        break;
            //    }

            //}



            ////for (int i = 0; i < humans.Count; i++)
            ////{
            ////    var human = humans[i];

            ////    if (human.InsuranceNumber == personnr)
            ////    {
            ////        Console.WriteLine("Ok, är du " + human.Name + "?");
            ////    }

            ////}


            //Console.ReadLine();
        }
    }
}
