using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4.Models
{



    public static class MathOperations
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public static int Add(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }

        public static int Add(List<int> numbers)
        {
            return numbers.Sum();
        }
    }






    public class Customer
    {
        public Customer(string name)
        {
            ValidateName(name);

            Id = 13; // todo: should be auto-generated
            Orders = new List<Order>();
        }

        public Customer(int id, string name)
        {
            Id = id;

            ValidateName(name);

            Name = name;
            Orders = new List<Order>();
        }

        public void AddOrder(int id, Store store, List<string> articles)
        {
            AddOrder(new Order()
            {

            });
        }

        public void AddOrder(Order order)
        {
            if (order.Articles.Count > 0)
            {
                Orders.Add(order);
            }
        }

        public void AddOrder(List<Order> orders)
        {
            Orders.AddRange(orders);
        }

        private void ValidateName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException();
            }
            else if (name.Length < 3)
            {
                throw new ArgumentException();
            }
        }


        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
        public string Address { get; set; }
        public int Money { get; set; }
        private string _cardNumber { get; set; }
        public string CardNumber { get
            {
                return _cardNumber.Substring(0, 4);
            }
            set
            {
                _cardNumber = value;
            }
        }


        public static bool IsValidCustomer(Customer customer)
        {
            return true;
        }

        public static bool IsCreditCardValid(string creditcard)
        {
            return true;
        }
    }

    class VIPCustomer : Customer
    {
        public bool ReceivesWelcomingGift = true;

        public VIPCustomer(string name) : 
                             base(name)
        {

        }
        public VIPCustomer(int id, string name) :
                             base(id, name)
        {

        }
    }
}
