using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Services;
using Services.Dtos;
using System.Globalization;

namespace App
{
    class Program
    {
        static OrderService service = new OrderService();

        static void Main(string[] args)
        {
            do
            {
                var MenuSelection = ArrowMenu("Order management menu",
                    new string[] { "Create", "Read", "Update", "Delete", "Quit" });

                switch (MenuSelection)
                {
                    case 0:
                        CreateMenu();
                        break;
                    case 1:
                        ReadMenu();
                        break;
                    case 2:
                        UpdateMenu();
                        break;
                    case 3:
                        DeleteMenu();
                        break;
                    default:
                        return;
                }

            } while (true);
        }

        public static int ArrowMenu(string menu, string[] menuItems)
        {
            Console.CursorVisible = false;
            Console.Clear();

            var curItem = 0;
            ConsoleKeyInfo key;
            var borderSize = menu.Length * 2;

            /////////////TITLE BUILD/////////////
            Console.Write("      ");
            for (int i = 0; i < borderSize; i++)
            {
                Console.Write("=");
            }

            Console.SetCursorPosition(menu.Length / 2 + 5, 1);
            Console.WriteLine(menu);

            Console.Write("      ");
            for (int i = 0; i < borderSize; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
            //////////////////////////////////////

            Console.WriteLine("\n Move with up and down arrows, press enter to select:\n");

            foreach (var item in menuItems)
            {
                Console.WriteLine($"   {item}");
            }

            do
            {
                Console.SetCursorPosition(0, 6 + curItem);
                Console.Write("=>");

                key = Console.ReadKey(true);

                if (key.Key.ToString() == "DownArrow" && curItem < menuItems.Length - 1)
                {
                    Console.SetCursorPosition(0, 6 + curItem);
                    Console.Write("  ");
                    curItem++;
                }
                else if (key.Key.ToString() == "UpArrow" && curItem > 0)
                {
                    Console.SetCursorPosition(0, 6 + curItem);
                    Console.Write("  ");
                    curItem--;
                }

            } while (key.KeyChar != 13); //13 = Enter

            Console.CursorVisible = true;
            Console.Clear();

            return curItem;
        }
        
        public static void CreateMenu()
        {
            var orderID = service.CreateOrderService(EnterOrderInfo(true));

            EnterOrderDetailInfo(orderID);

            var totalAmount = service.GetOrderTotalAmountService(orderID);

            Console.WriteLine($"Order {orderID} with a total amount of ${totalAmount} created correctly.");

            Console.Read();
        }
        
        public static void ReadMenu()
        {
            var menuSelection = ArrowMenu("Read order menu",
                new string[] { "All orders", "Best customer and product by country", "Back" });

            switch (menuSelection)
            {
                case 0:
                    var all = service.ReadAll();
                    foreach (var o in all)
                    {
                        Console.WriteLine($"Order ID: {o.OrderID}, Customer: {o.CustomerName}, Total: ${decimal.Round(o.Total,2)}");
                    }
                    Console.Read();
                    break;

                case 1:
                    var data = service.BestCustomerAndProductByCountry();

                    foreach (var item in data)
                    {
                        Console.WriteLine($"{item.Country}");
                        Console.WriteLine($"Best customer: {item.Name}, total: ${decimal.Round(item.Total,2)}");
                        Console.WriteLine($"Best product: {item.Product}\n");
                    }
                    
                    Console.Read();
                    break;
            }
        }

        public static void UpdateMenu()
        {
            Console.WriteLine(service.EditOrderService(EnterOrderInfo(false)));

            Console.Read();
        }

        public static void DeleteMenu()
        {
            Console.Write("Enter the order ID: ");

            if (int.TryParse(Console.ReadLine(), out int id))
                Console.WriteLine(service.DeleteOrderService(id));
            else
                Console.WriteLine("Error! Invalid ID...");

            Console.Read();
        }

        public static OrderDto EnterOrderInfo(bool create)
        {
            var order = new OrderDto();
            var employeeID = 0;
            var customerID = "";
            var datePattern = "dd-MM-yyyy";

            if (!create)
            {
                do
                {

                    Console.Write("Enter order ID: ");
                    if (int.TryParse(Console.ReadLine(), out int id))
                    {
                        if (service.CheckOrderIDService(id))
                            order.OrderID = id;
                        else
                            Console.WriteLine("Error! the order doesn't exist...");
                    }
                    else
                        Console.WriteLine("Error! ID invalid...");

                } while (order.OrderID == 0);
            }

            do
            {
                Console.Write("Enter customer ID: ");
                var id = Console.ReadLine().ToUpper();

                if (id.Length == 5)
                    if (service.CheckCustomerIDService(id))
                        customerID = id;

                if (customerID == "")
                    Console.WriteLine("Error! Customer not found. Please try again...");
            } while (customerID == "");

            order.CustomerID = customerID;

            do
            {
                Console.Write("Enter employee name: ");
                var name = Console.ReadLine();

                Console.Write("Enter employee surname: ");
                var surname = Console.ReadLine();

                employeeID = service.GetEmployeeIDService(name, surname);

                if (employeeID == 0)
                    Console.WriteLine("Error! Employee not found. Please try again...");
            } while (employeeID == 0);

            order.EmployeeID = employeeID;

            if (create)
                order.OrderDate = DateTime.Today;
            else
            {
                Console.Write("Enter order date in format dd-mm-yyyy: ");

                var date = Console.ReadLine();

                if (DateTime.TryParseExact(date, datePattern, null,
                    DateTimeStyles.None, out DateTime parsedDate))
                    order.RequiredDate = parsedDate;
            }

            Console.Write("Enter required date in format dd-mm-yyyy: ");

            do
            {
                var date = Console.ReadLine();

                if (DateTime.TryParseExact(date, datePattern, null,
                    DateTimeStyles.None, out DateTime parsedDate))
                    order.RequiredDate = parsedDate;
                else
                    Console.WriteLine("Invalid date, please try again...");
            } while (order.RequiredDate == null);

            //Asumo que ShippedDate,ShipVia,Freight se deberian ingresar más tarde cuando
            //se realice el envio.
            if (!create)
            {
                Console.Write("Enter shipped date in format dd-mm-yyyy: ");

                var date = Console.ReadLine();

                if (DateTime.TryParseExact(date, datePattern, null,
                    DateTimeStyles.None, out DateTime parsedDate))
                    order.ShippedDate = parsedDate;

                Console.Write("Enter ship via value: ");
                if (int.TryParse(Console.ReadLine(), out int via))
                    order.ShipVia = via;

                Console.Write("Enter freight value: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal freight))
                    order.Freight = freight;
            }

            Console.Write("Enter shippment name: ");
            order.ShipName = Console.ReadLine();

            Console.Write("Enter destination address: ");
            order.ShipAddress = Console.ReadLine();

            Console.Write("Enter destination city: ");
            order.ShipCity = Console.ReadLine();

            Console.Write("Enter destination region: ");
            order.ShipRegion = Console.ReadLine();

            Console.Write("Enter destination postal code: ");
            order.ShipPostalCode = Console.ReadLine();

            Console.Write("Enter destination country: ");
            order.ShipCountry = Console.ReadLine();

            return order;
        }

        public static void EnterOrderDetailInfo(int orderID)
        {
            var input = "";
            var orderDetailsDto = new List<CreateOrderDetailDto>();

            do
            {
                Console.Write("Press ENTER to add a product or enter Q to exit: ");
                input = Console.ReadLine().ToLower();

                if (input == "")
                {
                    var orderDetail = new CreateOrderDetailDto
                    {
                        OrderID = orderID
                    };

                    do
                    {
                        Console.Write("Product name: ");
                        var productName = Console.ReadLine();

                        var productID = service.GetProductIDService(productName);

                        if (productID == 0)
                            Console.WriteLine("Error! Product not found, please try again...");
                        else
                            orderDetail.ProductID = productID;

                    } while (orderDetail.ProductID == 0);

                    orderDetail.UnitPrice = service.GetProductPriceService(orderDetail.ProductID);

                    do
                    {
                        Console.Write("Enter a quantity: ");
                        if (short.TryParse(Console.ReadLine(), out short quantity))
                            orderDetail.Quantity = quantity;

                    } while (orderDetail.Quantity <= 0);

                    do
                    {
                        Console.Write("Enter a discount (Max 30): ");
                        if (float.TryParse(Console.ReadLine(), out float discount))
                            orderDetail.Discount = discount / 100;

                    } while (orderDetail.Discount < 0 || orderDetail.Discount > 30);

                    orderDetailsDto.Add(orderDetail);
                }

            } while (input != "q");

            service.AddOrderDetailService(orderDetailsDto);
        }
    }
}
