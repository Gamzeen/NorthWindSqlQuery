using NorthWindSqlQuery.Entities;
using System;
using System.Linq;

namespace NorthWindSqlQuery
{
    class Program
    {
        private static NortWindContext _db;

        static void Main(string[] args)
        {
            _db = new NortWindContext();

            //Query1();

            //Query2();

            //Query3();

            //Query4();

            //Query5();

            //Query6();

            //Query7();

            //Query8();

            //Query9();

            //Query10();

            //Query11();

            Query12();

            Console.Read();
        }

        public static void Query1()
        {
            //1.Create a report that shows the CategoryName and Description from the categories table sorted by CategoryName.

            Console.WriteLine("Query1\n");

            var result = _db.Categories.Select(x => new
            {
                CategoryName = x.CategoryName,
                Description = x.Description

            }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query2()
        {
            //2. Create a report that shows the ContactName, CompanyName, ContactTitle and Phone number from the customers table
            //sorted by Phone.

            Console.WriteLine("Query2\n");

            var result = _db.Customers.Select(x => new
            {
                ContactName = x.ContactName,
                CompanyName = x.CompanyName,
                ContactTitle = x.ContactTitle,
                PhoneNumber = x.Phone
            }).OrderBy(x => x.PhoneNumber).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }
        public static void Query3()
        {
            //3.Create a report that shows the capitalized FirstName and capitalized LastName renamed as FirstName and Lastname
            //respectively and HireDate from the employees table sorted from the newest to the oldest employee.

            Console.WriteLine("Query3\n");

            var result = _db.Employees.Select(x => new
            {
                FirstName = x.FirstName.ToUpper(),
                LastName = x.LastName.ToUpper(),
                HireDate = x.HireDate
            }
            ).OrderByDescending(x => x.HireDate).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query4()
        {
            //4.Create a report that shows the top 10 OrderID, OrderDate, ShippedDate, CustomerID, Freight from the orders table sorted
            //by Freight in descending order

            Console.WriteLine("Query4\n");

            var result = _db.Orders.Select(x => new
            {
                OrderID = x.OrderId,
                OrderDate = x.OrderDate,
                ShippedDate = x.ShippedDate,
                CustomerID = x.CustomerId,
                Freight = x.Freight
            }
            ).OrderByDescending(x => x.Freight).Take(10).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query5()
        {
            //5.Create a report that shows all the CustomerID in lowercase letter and renamed as ID from the customers table.
            Console.WriteLine("Query5\n");
            var result = _db.Customers.Select(x => new
            {
                ID = x.CustomerId.ToLower(),
            }
            ).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(result.ToString());
            }
        }

        public static void Query6()
        {
            // 6.Create a report that shows the CompanyName, Fax, Phone, Country, HomePage from the suppliers table sorted by the
            // Country in descending order then by CompanyName in ascending order.
            Console.WriteLine("Query6\n");
            var result = _db.Suppliers.Select(x => new
            {
                CompanyName = x.CompanyName,
                Fax = x.Fax,
                Phone = x.Phone,
                HomePage = x.HomePage,
                Country = x.Country
            }
            ).OrderByDescending(x => x.Country).OrderBy(x => x.Country);
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query7()
        {
            //7.Create a report that shows CompanyName, ContactName of all customers from ‘Buenos Aires' only.
            Console.WriteLine("Query7\n");

            var result = _db.Customers.Where(x => x.City == "Buenos Aires").Select(x => new
            {
                CompanyName = x.CompanyName,
                ContactName = x.ContactName,
                City = x.City
            }
            ).ToList(); //i selected city for control it

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query8()
        {
            //8. Create a report showing ProductName, UnitPrice, QuantityPerUnit of products that are out of stock
            Console.WriteLine("Query8\n");

            var result = _db.Products.Where(x => x.UnitsInStock == 0).Select(x => new
            {
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice,
                QuantityPerUnit = x.QuantityPerUnit,
                UnitsInStock = x.UnitsInStock
            }
            ).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query9()
        {
            //Create a report showing all the ContactName, Address, City of all customers not from Germany, Mexico, Spain.
            Console.WriteLine("Query9\n");


            var result = _db.Customers.Select(x => new
            {
                ContactName = x.ContactName,
                Address = x.Address,
                City = x.City,
                Country = x.Country
            }
            ).Where(x => !x.Country.Contains("Mexico"))
            .Where(x => !x.Country.Contains("Germany"))
            .Where(x => !x.Country.Contains("Spain"))
            .ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query10()
        {
            //10.Create a report showing OrderDate, ShippedDate, CustomerID, Freight of all orders placed on 21 May 1996.
            Console.WriteLine("Query10\n");

            string dtString = "07.05.1996";

            var result = _db.Orders.Select(x => new
            {
                OrderDate = x.OrderDate,
                ShippedDate = x.ShippedDate,
                CustomerID = x.CustomerId,
                Freight = x.Freight
            }
            ).Where(x => x.OrderDate == Convert.ToDateTime(dtString)).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query11()
        {
            //11. Create a report showing FirstName, LastName, Country from the employees not from United States.
            Console.WriteLine("Query11\n");

            var result = _db.Employees.Where(x => !x.Country.Contains("USA"))
                .Select(x => new
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    Country = x.Country
                }
                ).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query12()
        {
            //12.Create a report that shows the EmployeeID, OrderID, CustomerID, RequiredDate, ShippedDate 
            //from all orders shipped later than the required date.
            Console.WriteLine("Query12\n");
            
            var result = _db.Orders.Select(x => new
            {
                EmployeeId = x.EmployeeId,
                OrderId = x.OrderId,
                CustomerId = x.CustomerId,
                RequiredDate = x.RequiredDate,
                ShippedDate = x.ShippedDate
            }
            ).Where(x => x.ShippedDate > x.RequiredDate).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }
    }




    //
    //TODO: buna konuyu daha sonra işleyeceğiz.
    //public static class StringExtensions
    //{
    //    public static bool ContainsAny(this string str, params string[] values)
    //    {
    //        if (!string.IsNullOrEmpty(str) || values.Length > 0)
    //        {
    //            foreach (string value in values)
    //            {
    //                if (str.Contains(value))
    //                    return true;
    //            }
    //        }

    //        return false;
    //    }
    //}

}
