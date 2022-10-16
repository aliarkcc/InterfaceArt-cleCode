using System;
using System.Security.AccessControl;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new CorporateCustomerManager());
            customerManager.TakeAction();
            Console.ReadLine();
        }

        public interface ICustomerManager
        {
            void Add();
        }

        public class CustomerManager
        {
            private ICustomerManager _customerManager;

            public CustomerManager(ICustomerManager customerManager)
            {
                _customerManager = customerManager;
            }

            public void TakeAction()
            {
                _customerManager.Add();
            }
        }

        public class IndividualCustomerManager : ICustomerManager
        {
            public void Add()
            {
                Console.WriteLine("Corporate Customer Add");
            }
        }
        public class CorporateCustomerManager : ICustomerManager
        {
            public void Add()
            {
                Console.WriteLine("Individual Customer Add");
            }
        }
    }
}
