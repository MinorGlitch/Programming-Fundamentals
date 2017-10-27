using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AndreyAndBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> products = new Dictionary<string, double>();

            ReadProducts(products);

            List<Customer> customers = new List<Customer>();

            ReadCustomers(customers, products);

            double totalBill = 0.0D;

            double customerBill = 0.0D;

            foreach (Customer customer in customers.OrderBy(x => x.Name))
            {
                Console.WriteLine(customer.Name);

                foreach (KeyValuePair<string, int> productList in customer.ProductsBought)
                {
                    Console.WriteLine($"-- {productList.Key} - {productList.Value}");

                    foreach (KeyValuePair<string, double> product in products)
                    {
                        if (productList.Key == product.Key)
                        {
                            customerBill += product.Value * productList.Value;
                            totalBill += product.Value * productList.Value;
                        }
                    }
                }

                Console.WriteLine($"Bill: {customerBill:F2}");

                customerBill = 0;
            }

            Console.WriteLine($"Total bill: {totalBill:F2}");
        }

        private static void ReadCustomers(List<Customer> customers, Dictionary<string, double> products)
        {
            string[] customerArgs = Console.ReadLine().Split(',');

            while (customerArgs[0] != "end of clients")
            {
                string[] customerNameAndProduct = customerArgs[0].Split('-');

                string customerName = customerNameAndProduct[0];

                string customerProduct = customerNameAndProduct[1];

                int productQuantity = int.Parse(customerArgs[1]);

                bool existingClient = false;

                foreach (Customer checkForCustomer in customers)
                {
                    if (customerName == checkForCustomer.Name)
                    {
                        existingClient = true;

                        if (products.ContainsKey(customerProduct))
                        {
                            if (checkForCustomer.ProductsBought.ContainsKey(customerProduct))
                            {
                                checkForCustomer.ProductsBought[customerProduct] += productQuantity;
                            }
                            else
                            {
                                checkForCustomer.ProductsBought.Add(customerProduct, productQuantity);
                            }
                        }
                    }
                }

                if (!existingClient)
                {
                    Customer customer = new Customer();

                    customer.ProductsBought = new Dictionary<string, int>();

                    if (products.ContainsKey(customerProduct))
                    {
                        customer.Name = customerName;

                        customer.ProductsBought.Add(customerProduct, productQuantity);

                        customer.Bill = productQuantity * products[customerProduct];

                        customers.Add(customer);
                    }
                }

                customerArgs = Console.ReadLine().Split(',');
            }
        }

        private static void ReadProducts(Dictionary<string, double> products)
        {
            int productsInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < productsInput; i++)
            {
                string[] productArgs = Console.ReadLine().Split('-');

                string productName = productArgs[0];

                double productPrice = double.Parse(productArgs[1]);

                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, productPrice);
                }
                else
                {
                    products[productName] = productPrice;
                }
            }
        }
    }

    class Customer
    {
        public string Name { get; set; }
        public double Bill { get; set; }
        public Dictionary<string, int> ProductsBought { get; set; }
    }
}
