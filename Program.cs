using RequisicaoDeProduto.Dependencies;
using RequisicaoDeProduto.Dependencies.Enums;
using System.Text;

namespace RequisicaoDeProduto
{
    class Program
    {
        static void Main()
        {

            

            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime dateBirth = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data: ");
            Console.Write("Status: {0}", Enum.Parse<OrderStatusEnum>("Processing"));
            Console.Write("How many items to this order? ");
            int itemsToOrder = int.Parse(Console.ReadLine());

            Client client = new Client(name, email, dateBirth);
            DateTime dateNow = DateTime.Now;
            var orderStatus = OrderStatusEnum.Processing;
            Order order = new Order(dateNow, orderStatus, client);

            for (int i = 0; i < itemsToOrder; i++)
            {
                Console.WriteLine("Enter #{0} item data: ", i + 1);
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = int.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                Product product = new Product(productName, price);

                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.AddItem(productName, orderItem);

            }

            Console.WriteLine();
            Console.WriteLine(order);
            

        }

    }
}






