using Domain.Models;
using Domain.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace Domain.Configs.Seeding
{
    public static class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            SeedCategories(modelBuilder);
            SeedProducts(modelBuilder);
            SeedClients(modelBuilder);
            SeedOrders(modelBuilder);
            SeedOrderProducts(modelBuilder);
        }

        private static void SeedOrders(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order
                {
                    Id = 1,
                    OrderNumber = "ORD-001",
                    OrderValue = 89.98m,
                    Currency = SupportedCurrencies.USD,
                    ClientId = 1,
                },
                new Order
                {
                    Id = 2,
                    OrderNumber = "ORD-002",
                    OrderValue = 29.00m,
                    Currency = SupportedCurrencies.USD,
                    ClientId = 2,
                },
                new Order
                {
                    Id = 3,
                    OrderNumber = "ORD-003",
                    OrderValue = 303.70m,
                    Currency = SupportedCurrencies.USD,
                    ClientId = 3
                },
                new Order
                {
                    Id = 4,
                    OrderNumber = "ORD-004",
                    OrderValue = 29.99m,
                    Currency = SupportedCurrencies.USD,
                    ClientId = 4
                },
                new Order
                {
                    Id = 5,
                    OrderNumber = "ORD-005",
                    OrderValue = 39.98m,
                    Currency = SupportedCurrencies.USD,
                    ClientId = 5
                },
                new Order
                {
                    Id = 6,
                    OrderNumber = "ORD-001",
                    OrderValue = 89.98m,
                    Currency = SupportedCurrencies.USD,
                    ClientId = 1,
                    CreateDate = DateTime.UtcNow.AddDays(-50)
                },
                new Order
                {
                    Id = 7,
                    OrderNumber = "ORD-002",
                    OrderValue = 29.00m,
                    Currency = SupportedCurrencies.USD,
                    ClientId = 2,
                    CreateDate = DateTime.UtcNow.AddDays(-40)
                },
                new Order
                {
                    Id = 8,
                    OrderNumber = "ORD-003",
                    OrderValue = 303.70m,
                    Currency = SupportedCurrencies.USD,
                    ClientId = 3,
                    CreateDate = DateTime.UtcNow.AddDays(-30)
                },
                new Order
                {
                    Id = 9,
                    OrderNumber = "ORD-004",
                    OrderValue = 29.99m,
                    Currency = SupportedCurrencies.USD,
                    ClientId = 4,
                    CreateDate = DateTime.UtcNow.AddDays(-20)
                },
                new Order
                {
                    Id = 10,
                    OrderNumber = "ORD-005",
                    OrderValue = 39.98m,
                    Currency = SupportedCurrencies.USD,
                    ClientId = 5,
                    CreateDate = DateTime.UtcNow.AddDays(-10)
                }
            );
        }

        private static void SeedProducts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                 new Product
                 {
                     Id = 1,
                     ProductTitle = "Wireless Mouse",
                     ProductDeclarationName = "Ergonomic Wireless Mouse",
                     Price = 29.99m,
                     Currency = SupportedCurrencies.USD,
                     SKU = "SKU-MOUSE-001",
                     CategoryId = 2
                 },
                new Product
                {
                    Id = 2,
                    ProductTitle = "Bluetooth Headphones",
                    ProductDeclarationName = "Over-Ear Bluetooth Headphones",
                    Price = 59.99m,
                    Currency = SupportedCurrencies.USD,
                    SKU = "SKU-HEAD-002",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 3,
                    ProductTitle = "Smartphone Stand",
                    ProductDeclarationName = "Adjustable Smartphone Desk Stand",
                    Price = 14.50m,
                    Currency = SupportedCurrencies.USD,
                    SKU = "SKU-STAND-003",
                    CategoryId = 2
                },
                new Product
                {
                    Id = 4,
                    ProductTitle = "Building Blocks Set",
                    ProductDeclarationName = "Creative Kids Building Blocks",
                    Price = 19.99m,
                    Currency = SupportedCurrencies.USD,
                    SKU = "SKU-BLOCKS-004",
                    CategoryId = 1
                },
                new Product
                {
                    Id = 5,
                    ProductTitle = "Educational Puzzle",
                    ProductDeclarationName = "Wooden Animal Puzzle for Kids",
                    Price = 11.25m,
                    Currency = SupportedCurrencies.USD,
                    SKU = "SKU-PUZZLE-005",
                    CategoryId = 1
                }
            );
        }

        private static void SeedClients(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>().HasData(
                    new Client
                    {
                        Id = 1,
                        FullName = "John Doe",
                        FirstName = "John",
                        LastName = "Doe",
                        BirthDate = new DateTime(1990, 1, 1),
                        RegistrationDate = DateTime.UtcNow
                    },
                    new Client
                    {
                        Id = 2,
                        FullName = "Jane Smith",
                        FirstName = "Jane",
                        LastName = "Smith",
                        BirthDate = new DateTime(1985, 5, 15),
                        RegistrationDate = DateTime.UtcNow.AddDays(-15)
                    },
                    new Client
                    {
                        Id = 3,
                        FullName = "Alice Johnson",
                        FirstName = "Alice",
                        LastName = "Johnson",
                        BirthDate = new DateTime(1992, 8, 10),
                        RegistrationDate = DateTime.UtcNow.AddDays(-30)
                    },
                    new Client
                    {
                        Id = 4,
                        FullName = "Bob Williams",
                        FirstName = "Bob",
                        LastName = "Williams",
                        BirthDate = new DateTime(1988, 3, 22),
                        RegistrationDate = DateTime.UtcNow.AddDays(-35)
                    },
                    new Client
                    {
                        Id = 5,
                        FullName = "Emma Brown",
                        FirstName = "Emma",
                        LastName = "Brown",
                        BirthDate = new DateTime(1995, 12, 5),
                        RegistrationDate = DateTime.UtcNow.AddDays(-50)
                    }
            );
        }

        private static void SeedCategories(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Toys" },
                new Category { Id = 2, CategoryName = "Electronics" },
                new Category { Id = 3, CategoryName = "Books" },
                new Category { Id = 4, CategoryName = "Clothing" }
            );
        }

        private static void SeedOrderProducts(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderProduct>().HasData(
               new OrderProduct { OrderId = 1, ProductId = 1, UnitPrice = 29.99m, Currency = SupportedCurrencies.USD, Quantity = 1 },
               new OrderProduct { OrderId = 1, ProductId = 2, UnitPrice = 59.99m, Currency = SupportedCurrencies.USD, Quantity = 1 },
               
               new OrderProduct { OrderId = 2, ProductId = 3, UnitPrice = 14.50m, Currency = SupportedCurrencies.USD, Quantity = 2 },

               new OrderProduct { OrderId = 3, ProductId = 5, UnitPrice = 11.25m, Currency = SupportedCurrencies.USD, Quantity = 3 },
               new OrderProduct { OrderId = 3, ProductId = 1, UnitPrice = 29.99m, Currency = SupportedCurrencies.USD, Quantity = 1 },
               new OrderProduct { OrderId = 3, ProductId = 2, UnitPrice = 59.99m, Currency = SupportedCurrencies.USD, Quantity = 4 },

               new OrderProduct { OrderId = 4, ProductId = 1, UnitPrice = 29.99m, Currency = SupportedCurrencies.USD, Quantity = 1 },

               new OrderProduct { OrderId = 5, ProductId = 4, UnitPrice = 19.99m, Currency = SupportedCurrencies.USD, Quantity = 2 }
           );
        }
    }
}
