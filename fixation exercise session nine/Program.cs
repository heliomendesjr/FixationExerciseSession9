using System;
using System.Globalization;
using fixation_exercise_session_nine.Entities;


namespace fixation_exercise_session_nine
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Eneter cliente data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Eneter order data(DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Status: ");
            OrderStatus orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birthDate);
            Order order = new Order(DateTime.Now, orderStatus, client );

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product Name:");
                string nameProduct = Console.ReadLine();
                Console.Write("Product price: ");
                double priceProduct = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Product product = new Product(nameProduct, priceProduct);

                Console.Write("Quantity: ");
                int qunatity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(qunatity,priceProduct, product);
                order.AddItem(orderItem);

            }
                   
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");            
            Console.WriteLine(order);


        }
    }
}
