using WPFDemo.EF.Models;
using WPFDemo.Repository.Interfaces;

namespace WPFDemo.Repository
{
    internal class InMemoryOrderRepository : IOrderRepository
    {
        public void Add(Order order)
        {
            _orders.Add(order);
        }

        public void Delete(Guid id)
        {
            var order = _orders.FirstOrDefault(o => o.Id.Equals(id));
            if (order != null)
            {
                _orders.Remove(order);
            }
        }

        public IEnumerable<Order> GetAll()
        {
            return _orders;
        }

        private List<Order> _orders = new()
        {
            new Order
            {
                Id = new Guid("d4871d98-2a83-491b-9784-1124c3e0f78f"),
                CustomerId = new Guid("248f576a-9b37-45fc-b4fa-a71578e9b1d7"),
                Notes = "Home delivery",
                OrderDate = new DateTime(2023, 5, 20),
                OrderStatus = "Paid",
                ShippingAddress = "123 Main St, Anytown, USA",
                TotalAmount = 352.2M
            },
            new Order
            {
                Id = new Guid("e4871d98-2a83-491b-9784-1124c3e0f78f"),
                CustomerId = new Guid("348f576a-9b37-45fc-b4fa-a71578e9b1d7"),
                Notes = "Office delivery",
                OrderDate = new DateTime(2023, 5, 18),
                OrderStatus = "Pending",
                ShippingAddress = "456 Elm St, Othertown, USA",
                TotalAmount = 452.5M
            },
            new Order
            {
                Id = new Guid("f4871d98-2a83-491b-9784-1124c3e0f78f"),
                CustomerId = new Guid("448f576a-9b37-45fc-b4fa-a71578e9b1d7"),
                Notes = "Gift wrap",
                OrderDate = new DateTime(2023, 5, 15),
                OrderStatus = "Shipped",
                ShippingAddress = "789 Oak St, Sometown, USA",
                TotalAmount = 123.45M
            },
            new Order
            {
                Id = new Guid("a4871d98-2a83-491b-9784-1124c3e0f78f"),
                CustomerId = new Guid("548f576a-9b37-45fc-b4fa-a71578e9b1d7"),
                Notes = "Urgent delivery",
                OrderDate = new DateTime(2023, 5, 10),
                OrderStatus = "Cancelled",
                ShippingAddress = "101 Pine St, Anycity, USA",
                TotalAmount = 678.9M
            },
            new Order
            {
                Id = new Guid("b4871d98-2a83-491b-9784-1124c3e0f78f"),
                CustomerId = new Guid("648f576a-9b37-45fc-b4fa-a71578e9b1d7"),
                Notes = "Standard delivery",
                OrderDate = new DateTime(2023, 5, 5),
                OrderStatus = "Paid",
                ShippingAddress = "202 Maple St, Othercity, USA",
                TotalAmount = 789.0M
            },
            new Order
            {
                Id = new Guid("d3589ba6-e26f-42d4-90ed-14e11d365b37"),
                CustomerId = new Guid("1a1c38c6-10d2-4563-878d-0a76b5cf4462"),
                Notes = "Gift wrap, please",
                OrderDate = new DateTime(2023, 6, 15),
                OrderStatus = "Shipped",
                ShippingAddress = "202 Elm St, Sometown, USA",
                TotalAmount = 123.45M
            },
            new Order
            {
                Id = new Guid("b2e31744-3c1f-42ed-9b26-d26f8d58d6a9"),
                CustomerId = new Guid("b8475b8f-498d-4f37-8f49-c2a236dbf92a"),
                Notes = "Leave at the front door",
                OrderDate = new DateTime(2023, 7, 20),
                OrderStatus = "Processing",
                ShippingAddress = "303 Oak St, Yourtown, USA",
                TotalAmount = 234.56M
            },
            new Order
            {
                Id = new Guid("fdc7207a-469d-4387-8151-8e5c4f8b2e0e"),
                CustomerId = new Guid("d7a3b8a4-c13f-4e7e-8c6d-8fb2c5d29c5a"),
                Notes = "No contact delivery",
                OrderDate = new DateTime(2023, 8, 25),
                OrderStatus = "Delivered",
                ShippingAddress = "404 Birch St, Anyplace, USA",
                TotalAmount = 345.67M
            },
            new Order
            {
                Id = new Guid("ec8b7698-9d6b-4e95-9f2b-b1f5b8e5cfe4"),
                CustomerId = new Guid("79f6a6eb-cd58-4d48-a7a3-d5e3bcd7c6f8"),
                Notes = "Deliver after 5 PM",
                OrderDate = new DateTime(2023, 9, 30),
                OrderStatus = "Pending",
                ShippingAddress = "505 Cedar St, Othertown, USA",
                TotalAmount = 456.78M
            },
            new Order
            {
                Id = new Guid("a9f5c3b8-1d3a-4a9a-b9fc-d5e8d9f8c6f1"),
                CustomerId = new Guid("21d9c1c4-8c7e-4b1e-8c2b-5e4f2b5c4d3a"),
                Notes = "Fragile items",
                OrderDate = new DateTime(2023, 10, 5),
                OrderStatus = "Cancelled",
                ShippingAddress = "606 Maple St, Thiscity, USA",
                TotalAmount = 567.89M
            },
            new Order
            {
                Id = new Guid("b2f50af0-2e4a-4146-aa8d-6f6a4cf2764e"),
                CustomerId = new Guid("4c6d3c5e-dce5-4bc9-99e8-5be6c7bbbf75"),
                Notes = "Handle with care",
                OrderDate = new DateTime(2023, 11, 10),
                OrderStatus = "Shipped",
                ShippingAddress = "707 Walnut St, Anothertown, USA",
                TotalAmount = 678.90M
            },
            new Order
            {
                Id = new Guid("d1a7d7cc-b508-4e8e-b472-dc837f2cb73b"),
                CustomerId = new Guid("fde8c8a3-03d9-492e-844b-4ad9e9776a69"),
                Notes = "Signature required",
                OrderDate = new DateTime(2023, 12, 15),
                OrderStatus = "Processing",
                ShippingAddress = "808 Pine St, Somewhere, USA",
                TotalAmount = 789.01M
            },
            new Order
            {
                Id = new Guid("c3ac6411-1f43-4b45-bf81-2d25de7b7c1b"),
                CustomerId = new Guid("3bf0c68b-bf61-479f-bff3-7d682f7dc759"),
                Notes = "Rain check if not at home",
                OrderDate = new DateTime(2024, 1, 20),
                OrderStatus = "Pending",
                ShippingAddress = "909 Oak St, Othercity, USA",
                TotalAmount = 890.12M
            },
            new Order
            {
                Id = new Guid("0f8e0e2a-cff4-4c90-b07f-7a68f06c9bc2"),
                CustomerId = new Guid("35b2c8f3-b4ae-4dd3-b18a-4c5a05b7db32"),
                Notes = "Call before delivery",
                OrderDate = new DateTime(2024, 2, 25),
                OrderStatus = "Delivered",
                ShippingAddress = "1010 Maple St, Anywhere, USA",
                TotalAmount = 901.23M
            },
            new Order
            {
                Id = new Guid("1eab0598-13e7-4097-9ec1-d89e81e5980d"),
                CustomerId = new Guid("9b135fdb-70c1-4919-b71e-c1914ed7ac46"),
                Notes = "Handle gently",
                OrderDate = new DateTime(2024, 3, 30),
                OrderStatus = "Cancelled",
                ShippingAddress = "1111 Cedar St, Yourcity, USA",
                TotalAmount = 123.45M
            },
            new Order
            {
                Id = new Guid("fcd896a2-2b6a-40f1-8856-80c60dc5c564"),
                CustomerId = new Guid("b8462fe4-9c0d-4856-83bb-72378e747f7d"),
                Notes = "Expedited shipping",
                OrderDate = new DateTime(2024, 4, 5),
                OrderStatus = "Shipped",
                ShippingAddress = "1212 Elm St, Thisplace, USA",
                TotalAmount = 234.56M
            },
            new Order
            {
                Id = new Guid("44e24863-6e07-40c7-8121-ae207cb39b52"),
                CustomerId = new Guid("8f2d21f3-ecdd-495b-b7d2-6c1cfbbdb692"),
                Notes = "Gift receipt needed",
                OrderDate = new DateTime(2024, 5, 10),
                OrderStatus = "Processing",
                ShippingAddress = "1313 Oak St, Anycity, USA",
                TotalAmount = 345.67M
            },
            new Order
            {
                Id = new Guid("d97757ee-95c7-493b-b692-d3d7f5c56d3f"),
                CustomerId = new Guid("3d2b2e21-9617-4b7f-9b49-1974f8e2dc27"),
                Notes = "Special handling instructions",
                OrderDate = new DateTime(2024, 6, 15),
                OrderStatus = "Pending",
                ShippingAddress = "1414 Pine St, Yourtown, USA",
                TotalAmount = 456.78M
            },
            new Order
            {
                Id = new Guid("eb431f53-67cc-4e6d-ba2a-285c6d946505"),
                CustomerId = new Guid("b0b2e537-54f4-4d2b-8cbb-bcc5b1ab52d1"),
                Notes = "No substitutions",
                OrderDate = new DateTime(2024, 7, 20),
                OrderStatus = "Delivered",
                ShippingAddress = "1515 Elm St, Othertown, USA",
                TotalAmount = 567.89M
            },
            new Order
            {
                Id = new Guid("8cdd9eaf-26cb-4674-85f8-c59ec1cb4185"),
                CustomerId = new Guid("f0fd20b8-5fb7-46f1-92e6-8e7c2aaadbe1"),
                Notes = "Morning delivery preferred",
                OrderDate = new DateTime(2024, 8, 25),
                OrderStatus = "Cancelled",
                ShippingAddress = "1616 Oak St, Anothercity, USA",
                TotalAmount = 678.90M
            }
        };
    }
}
