using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Data
{
    public static class DataAccess
    {
        public static List<Order> ReadAll()
        {
            using (var context = new Context())
            {
                return context.Orders
                    .Include(c => c.Customer)
                    .Include(c => c.Order_Details)
                    .AsNoTracking()
                    .ToList();
            }
        }

        public static List<CountryBestCustomer> BestCustomer()
        {
            using (var contex = new Context())
            {
                return contex.Customers
                .GroupBy(x => x.Country)
                .Select(x => new CountryBestCustomer
                {
                    Country = x.Key,
                    Name = x
                        .OrderByDescending(c => c.Orders
                        .Sum(g => g.Order_Details
                        .Sum(d => d.Quantity * d.Product.UnitPrice)))
                        .Select(h => h.ContactName)
                        .FirstOrDefault(),
                    Total = x.Select(v => v.Orders
                        .Where(c => c.CustomerID == x
                        .OrderByDescending(w => w.Orders
                        .Sum(g => g.Order_Details
                        .Sum(d => d.Quantity * d.Product.UnitPrice)))
                        .Select(h => h.CustomerID)
                        .FirstOrDefault())
                        .Sum(g => g.Order_Details
                        .Sum(d => d.Quantity * d.Product.UnitPrice)))
                        .Sum()
                })
                .ToList();
            }
        }

        public static List<CountryBestProduct> BestProduct()
        {
            using (var contex = new Context())
            {
                return contex.Customers
                .GroupBy(x => x.Country)
                .Select(x => new CountryBestProduct
                {
                    Country = x.Key,
                    Product = x
                    .SelectMany(c => c.Orders)
                    .SelectMany(v => v.Order_Details)
                    .GroupBy(b => b.ProductID)
                    .OrderByDescending(t => t.Count())
                    .FirstOrDefault()
                    .Select(b => b.Product.ProductName)
                    .FirstOrDefault()

                })
                .ToList();
            }
        }

        public static int GetEmployeeID(string name, string surname)
        {
            var employeeID = 0;

            using (var context = new Context())
            {
                try
                {
                    employeeID = context.Employees
                        .AsNoTracking()
                        .First(e => e.FirstName == name && e.LastName == surname)
                        .EmployeeID;
                }
                catch (Exception)
                {
                    employeeID = 0;
                }
            }

            return employeeID;
        }

        public static int GetProductID(string name)
        {
            var id = 0;

            using (var context = new Context())
            {
                try
                {
                    id = context.Products
                        .First(c => c.ProductName == name)
                        .ProductID;
                }
                catch (Exception)
                {
                    id = 0;
                }
            }

            return id;
        }

        public static decimal GetProductPrice(int id)
        {
            var price = 0m;

            using (var context = new Context())
            {
                price = (decimal)context.Products
                    .FirstOrDefault(c => c.ProductID == id)
                    .UnitPrice;
            }

            return price;
        }

        public static decimal GetOrderTotalAmount(int id)
        {
            var total = 0m;

            using (var context = new Context())
            {
                total = context.Orders
                    .FirstOrDefault(c => c.OrderID == id)
                    .Order_Details
                    .Sum(c => (c.UnitPrice * c.Quantity) - ((c.UnitPrice * c.Quantity) * (decimal)c.Discount));
            }
            return total;
        }

        public static bool CheckCustomerID(string id)
        {
            var exist = false;

            using (var context = new Context())
            {
                exist = context.Customers
                    .FirstOrDefault(c => c.CustomerID == id) != null;
            }

            return exist;
        }

        public static bool CheckOrderID(int id)
        {
            var exist = false;

            using (var context = new Context())
            {
                exist = context.Orders
                    .FirstOrDefault(c => c.OrderID == id) != null;
            }

            return exist;
        }

        public static int CreateOrder(Order order)
        {
            var orderID = 0;
            using (var context = new Context())
            {
                context.Orders.Add(order);
                context.SaveChanges();
                orderID = order.OrderID;
            }
            return orderID;
        }

        public static void CreateOrderDetail(List<Order_Detail> orderDetail)
        {
            using (var context = new Context())
            {
                foreach (var detail in orderDetail)
                {
                    context.Order_Details.Add(detail);
                }
                context.SaveChanges();
            }
        }

        public static string DeleteOrder(int id)
        {
            var msg = "";

            using (var context = new Context())
            {
                try
                {
                    var order = context.Orders
                        .Include(c => c.Customer)
                        .Include(c => c.Order_Details)
                        .First(c => c.OrderID == id);

                    if (order.Customer.Country == "Mexico" || order.Customer.Country == "France")
                        msg = "Error, can't delete an order from Mexico or France";
                    else
                    {
                        foreach (var detail in order.Order_Details)
                        {
                            context.Order_Details.Remove(detail);
                        }

                        context.Orders.Remove(order);

                        context.SaveChanges();

                        msg = "Order deleted correctly.";
                    }
                }
                catch (Exception)
                {
                    msg = "Error, the order doesn't exist...";
                }
            }

            return msg;
        }

        public static string EditOrder(Order newOrder)
        {
            var msg = "";

            using (var context = new Context())
            {
                try
                {
                    var order = context.Orders
                        .FirstOrDefault(c => c.OrderID == newOrder.OrderID);

                    if (newOrder.EmployeeID != 0 || newOrder.EmployeeID != null)
                        order.EmployeeID = newOrder.EmployeeID;

                    if (newOrder.CustomerID != "")
                        order.CustomerID = newOrder.CustomerID;

                    if (newOrder.OrderDate != null)
                        order.OrderDate = newOrder.OrderDate;

                    if (newOrder.RequiredDate != null)
                        order.RequiredDate = newOrder.RequiredDate;

                    if (newOrder.ShippedDate != null)
                        order.ShippedDate = newOrder.ShippedDate;

                    if (newOrder.ShipVia != 0 || newOrder.ShipVia != null)
                        order.ShipVia = newOrder.ShipVia;

                    if (newOrder.Freight != 0 || newOrder.Freight != null)
                        order.Freight = newOrder.Freight;

                    if (newOrder.ShipName != "")
                        order.ShipName = newOrder.ShipName;

                    if (newOrder.ShipAddress != "")
                        order.ShipAddress = newOrder.ShipAddress;

                    if (newOrder.ShipCity != "")
                        order.ShipCity = newOrder.ShipCity;

                    if (newOrder.ShipRegion != "")
                        order.ShipRegion = newOrder.ShipRegion;

                    if (newOrder.ShipPostalCode != "")
                        order.ShipPostalCode = newOrder.ShipPostalCode;

                    if (newOrder.ShipCountry != "")
                        order.ShipCountry = newOrder.ShipCountry;

                    context.SaveChanges();

                    msg = "Changes saved correctly.";

                }
                catch (Exception)
                {
                    msg = "Error saving changes!";
                }
            }

            return msg;
        }

    }
}
