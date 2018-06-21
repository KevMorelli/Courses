using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Services.Dtos;

namespace Services
{
    public class OrderService
    {
        public List<ReadOrderDto> ReadAll()
        {
            var list = new List<ReadOrderDto>();

            var data = DataAccess.ReadAll();

            foreach (var order in data)
            {
                var orderDto = new ReadOrderDto()
                {
                    OrderID = order.OrderID,
                    CustomerName = order.Customer.ContactName,
                    Total = order.Order_Details.Sum(x => x.UnitPrice * x.Quantity - (x.UnitPrice * x.Quantity * (decimal)x.Discount))
                };

                list.Add(orderDto);
            }

            return list;
        }

        public int GetEmployeeIDService(string name, string surname)
        {
            return DataAccess.GetEmployeeID(name, surname);
        }

        public int GetProductIDService(string name)
        {
            return DataAccess.GetProductID(name);
        }

        public decimal GetProductPriceService(int id)
        {
            return DataAccess.GetProductPrice(id);
        }

        public bool CheckCustomerIDService(string id)
        {
            return DataAccess.CheckCustomerID(id);
        }

        public bool CheckOrderIDService(int id)
        {
            return DataAccess.CheckOrderID(id);
        }

        public decimal GetOrderTotalAmountService(int id)
        {
            return DataAccess.GetOrderTotalAmount(id);
        }

        public int CreateOrderService(OrderDto orderDto)
        {
            var order = new Order()
            {
                CustomerID = orderDto.CustomerID,
                EmployeeID = orderDto.EmployeeID,
                OrderDate = orderDto.OrderDate,
                RequiredDate = orderDto.RequiredDate,
                ShipName = orderDto.ShipName,
                ShipAddress = orderDto.ShipAddress,
                ShipCity = orderDto.ShipCity,
                ShipRegion = orderDto.ShipRegion,
                ShipPostalCode = orderDto.ShipPostalCode,
                ShipCountry = orderDto.ShipCountry
            };

            return DataAccess.CreateOrder(order);
        }

        public void AddOrderDetailService(List<CreateOrderDetailDto> orderDetailDto)
        {
            var orderDetails = new List<Order_Detail>();

            foreach (var detail in orderDetailDto)
            {
                var orderDetail = new Order_Detail()
                {
                    OrderID = detail.OrderID,
                    ProductID = detail.ProductID,
                    UnitPrice = detail.UnitPrice,
                    Quantity = detail.Quantity,
                    Discount = detail.Discount
                };

                orderDetails.Add(orderDetail);
            }

            DataAccess.CreateOrderDetail(orderDetails);
        }

        public string DeleteOrderService(int id)
        {
            return DataAccess.DeleteOrder(id);
        }

        public string EditOrderService(OrderDto OrderDto)
        {
            var order = new Order()
            {
                OrderID = OrderDto.OrderID,
                CustomerID = OrderDto.CustomerID,
                EmployeeID = OrderDto.EmployeeID,
                OrderDate = OrderDto.OrderDate,
                RequiredDate = OrderDto.RequiredDate,
                ShippedDate = OrderDto.ShippedDate,
                ShipVia = OrderDto.ShipVia,
                Freight = OrderDto.Freight,
                ShipName = OrderDto.ShipName,
                ShipAddress = OrderDto.ShipAddress,
                ShipCity = OrderDto.ShipCity,
                ShipRegion = OrderDto.ShipRegion,
                ShipPostalCode = OrderDto.ShipPostalCode,
                ShipCountry = OrderDto.ShipCountry
            };

            return DataAccess.EditOrder(order);
        }

        public List<BestByCountryDto> BestCustomerAndProductByCountry()
        {
            var products = DataAccess.BestProduct();
            var customers = DataAccess.BestCustomer();

            var dataToSend = new List<BestByCountryDto>();

            foreach (var product in products)
                foreach (var customer in customers)
                    if (product.Country == customer.Country)
                    {
                        var item = new BestByCountryDto()
                        {
                            Country = product.Country,
                            Name = customer.Name,
                            Total = (decimal) customer.Total,
                            Product = product.Product
                        };

                        dataToSend.Add(item);
                    }
            return dataToSend;
        }
    }
}
