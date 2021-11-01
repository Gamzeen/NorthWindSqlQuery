using Microsoft.EntityFrameworkCore;
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
            //Method1();

            //Query2();
            //Method2();

            //Query3();
            //Method3();

            //Query4();
            //Method4();

            //Query5();
            //Method5();

            //Query6();
            //Method6();

            //Query7();
            //Method7();

            //Query8();
            //Method8();

            //Query9();
            //Method9();

            //Query10();
            //Method10();

            //Query11();
            //Method11();

            //Query12();
            //Method12();

            //Query13();
            //Method13();

            //Query14();
            //Method14();

            //Query15();
            //Method15();

            //Query16();
            //Method16();

            //Query17();
            //Method17();

            //Query18();
            //Method18();

            //Query19();
            //Method19();

            //Query20();
            //Method20();

            //Query21();
            //Method21();

            //Query22();
            //Method22();

            //Query23();
            //Method23();

            Query24();
            Method24();

            //Query25();

            //Query26();

            //Query27();

            //Query28();

            //Query29();

            //Query30();

            //Query31();

            //Query32();

            //Query33();

            //Query34();

            //Query35();

            //Query36();

            //Query37();

            //Query38();
            Console.Read();
        }

        public static void Method1()
        {
            //1.Create a report that shows the CategoryName and Description from the categories table sorted by CategoryName.

            Console.WriteLine("Method1\n");

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

        public static void Query1()
        {
            //1.Create a report that shows the CategoryName and Description from the categories table sorted by CategoryName.
            Console.WriteLine("Query1\n");
            var result = (from c in _db.Categories
                          select new
                          {
                              CategoryName = c.CategoryName,
                              Description = c.Description
                          }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method2()
        {
            //2. Create a report that shows the ContactName, CompanyName, ContactTitle and Phone number from the customers table
            //sorted by Phone.

            Console.WriteLine("Method2\n");

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

        public static void Query2()
        {
            //2. Create a report that shows the ContactName, CompanyName, ContactTitle and Phone number from the customers table
            //sorted by Phone.

            Console.WriteLine("Query2\n");

            var result = (from c in _db.Customers
                          orderby c.Phone
                          select new
                          {
                              ContactName = c.ContactName,
                              CompanyName = c.CompanyName,
                              ContactTitle = c.ContactTitle,
                              Phone = c.Phone
                          }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method3()
        {
            //3.Create a report that shows the capitalized FirstName and capitalized LastName renamed as FirstName and Lastname
            //respectively and HireDate from the employees table sorted from the newest to the oldest employee.

            Console.WriteLine("Method3\n");

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

        public static void Query3()
        {
            //3.Create a report that shows the capitalized FirstName and capitalized LastName renamed as FirstName and Lastname
            //respectively and HireDate from the employees table sorted from the newest to the oldest employee.

            Console.WriteLine("Query3\n");

            var result = (from e in _db.Employees
                          orderby e.HireDate descending
                          select new
                          {
                              FirstName = e.FirstName.ToUpper(),
                              LastName = e.LastName.ToUpper(),
                              HireDate = e.HireDate

                          }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public static void Method4()

        {
            //4.Create a report that shows the top 10 OrderID, OrderDate, ShippedDate, CustomerID, Freight from the orders table sorted
            //by Freight in descending order
            Console.WriteLine("Method4\n");
            Console.WriteLine("\n");

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

        public static void Query4()
        {
            //4.Create a report that shows the top 10 OrderID, OrderDate, ShippedDate, CustomerID, Freight from the orders table sorted
            //by Freight in descending order

            Console.WriteLine("Query4\n");

            var result = (from o in _db.Orders
                          orderby o.Freight descending
                          select new
                          {
                              OrderID = o.OrderId,
                              OrderDate = o.OrderDate,
                              ShippedDate = o.ShippedDate,
                              CustomerID = o.CustomerId,
                              Freight = o.Freight
                          }).ToList().Take(10);
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public static void Method5()
        {
            //5.Create a report that shows all the CustomerID in lowercase letter and renamed as ID from the customers table.
            Console.WriteLine("Method5\n");
            var result = _db.Customers.Select(x => new
            {
                ID = x.CustomerId.ToLower(),
            }
            ).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query5()
        {
            //5.Create a report that shows all the CustomerID in lowercase letter and renamed as ID from the customers table.
            Console.WriteLine("Query5\n");
            var result = (from c in _db.Customers
                          select new
                          {
                              CustomerID = c.CustomerId.ToLower()
                          }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method6()
        {
            // 6.Create a report that shows the CompanyName, Fax, Phone, Country, HomePage from the suppliers table sorted by the
            // Country in descending order then by CompanyName in ascending order.
            Console.WriteLine("Method6\n");
            var result = _db.Suppliers.Select(x => new
            {
                CompanyName = x.CompanyName,
                Fax = x.Fax,
                Phone = x.Phone,
                HomePage = x.HomePage,
                Country = x.Country
            }
            ).OrderByDescending(x => x.Country).OrderBy(x => x.CompanyName);
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query6()
        {
            // 6.Create a report that shows the CompanyName, Fax, Phone, Country, HomePage from the suppliers table sorted by the
            // Country in descending order then by CompanyName in ascending order.
            Console.WriteLine("Query6\n");

            var result = (from s in _db.Suppliers
                          orderby s.Country descending
                          orderby s.CompanyName
                          select new
                          {
                              CompanyName = s.CompanyName,
                              Fax = s.Fax,
                              Phone = s.Phone,
                              Country = s.Country,
                              HomePage = s.HomePage,

                          }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public static void Method7()
        {
            //7.Create a report that shows CompanyName, ContactName of all customers from ‘Buenos Aires' only.
            Console.WriteLine("Method7\n");

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

        public static void Query7()
        {
            //7.Create a report that shows CompanyName, ContactName of all customers from ‘Buenos Aires' only.
            Console.WriteLine("Query7\n");
            var result = (from c in _db.Customers
                          where c.City == "Buenos Aires"
                          select new
                          {
                              CompanyName = c.CompanyName,
                              ContactName = c.ContactName
                          }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method8()
        {
            //8. Create a report showing ProductName, UnitPrice, QuantityPerUnit of products that are out of stock
            Console.WriteLine("Method8\n");

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

        public static void Query8()
        {
            //8. Create a report showing ProductName, UnitPrice, QuantityPerUnit of products that are out of stock
            Console.WriteLine("Query8\n");

            var result = (from p in _db.Products
                          where p.UnitsInStock == 0
                          select new
                          {
                              ProductName = p.ProductName,
                              UnitPrice = p.UnitPrice,
                              QuantityPerUnit = p.QuantityPerUnit
                          }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public static void Method9()
        {
            //Create a report showing all the ContactName, Address, City of all customers not from Germany, Mexico, Spain.
            Console.WriteLine("Method9\n");


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

        public static void Query9()
        {
            //Create a report showing all the ContactName, Address, City of all customers not from Germany, Mexico, Spain.
            Console.WriteLine("Query9\n");
            var result = (from c in _db.Customers
                          where !c.Country.Contains("Mexico")
                          where !c.Country.Contains("Germany")
                          where !c.Country.Contains("Spain")
                          select new
                          {
                              ContactName = c.ContactName,
                              Address = c.Address,
                              City = c.City,
                              Country = c.Country
                          }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method10()
        {
            //10.Create a report showing OrderDate, ShippedDate, CustomerID, Freight of all orders placed on 21 May 1996.
            Console.WriteLine("Method10\n");

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

        public static void Query10()
        {
            //10.Create a report showing OrderDate, ShippedDate, CustomerID, Freight of all orders placed on 21 May 1996.
            Console.WriteLine("Query10\n");

            string dtString = "07.05.1996";
            DateTime dt = Convert.ToDateTime(dtString);
            var result = (from o in _db.Orders
                          where o.OrderDate == dt
                          select new
                          {
                              OrderDate = o.OrderDate,
                              ShippedDate = o.ShippedDate,
                              CustomerID = o.CustomerId,
                              Freight = o.Freight
                          }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method11()
        {
            //11. Create a report showing FirstName, LastName, Country from the employees not from United States.
            Console.WriteLine("Method11\n");

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

        public static void Query11()
        {
            //11. Create a report showing FirstName, LastName, Country from the employees not from United States.
            Console.WriteLine("Query11\n");

            var result = (from e in _db.Employees
                          where e.Country != "USA"
                          select new
                          {
                              FirstName = e.FirstName,
                              LastName = e.LastName,
                              Country = e.Country
                          }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method12()
        {
            //12.Create a report that shows the EmployeeID, OrderID, CustomerID, RequiredDate, ShippedDate 
            //from all orders shipped later than the required date.
            Console.WriteLine("Method12\n");

            var result = _db.Orders.Where(x => x.ShippedDate > x.RequiredDate)
                .Select(x => new
                {
                    EmployeeId = x.EmployeeId,
                    OrderId = x.OrderId,
                    CustomerId = x.CustomerId,
                    RequiredDate = x.RequiredDate,
                    ShippedDate = x.ShippedDate
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

            var result = (from o in _db.Orders
                          where o.RequiredDate < o.ShippedDate
                          select new
                          {
                              EmployeeID = o.EmployeeId,
                              OrderID = o.OrderId,
                              CustomerID = o.CustomerId,
                              RequiredDate = o.RequiredDate,
                              ShippedDate = o.ShippedDate
                          }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public static void MethodHard()
        {
            // For each order, calculate a subtotal for each Order (identified by OrderID).
            // This is a simple query using GROUP BY to aggregate data for each order.
        }

        public static void Method13()
        {
            //13.Create a report that shows the City, CompanyName, ContactName of customers from cities starting with A or B.

            Console.WriteLine("Method13\n");
            var result = _db.Customers.Where(x => x.City.StartsWith("A") || x.City.StartsWith("B"))
                .Select(x => new
                {
                    City = x.City,
                    CompanyName = x.CompanyName,
                    ContactName = x.ContactName,
                }
                ).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query13()
        {
            //13.Create a report that shows the City, CompanyName, ContactName of customers from cities starting with A or B.
            Console.WriteLine("Query13\n");

            var result = (from c in _db.Customers
                          where c.City.StartsWith("B") || c.City.StartsWith("A")
                          select new
                          {
                              City = c.City,
                              CompanyName = c.CompanyName,
                              ContactName = c.ContactName
                          }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public static void Method14()
        {
            Console.WriteLine("Method14\n");
            //14.Create a report showing all the even numbers of OrderID from the orders table.
            var result = _db.Orders.Where(x => x.OrderId % 2 == 0).Select(x => x.OrderId).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query14()
        {
            Console.WriteLine("Query14\n");
            //14.Create a report showing all the even numbers of OrderID from the orders table.

            var result = (from p in _db.Orders
                          where p.OrderId % 2 == 0
                          select new
                          {
                              OrderID = p.OrderId
                          }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method15()
        {
            Console.WriteLine("Method15\n");
            //15.Create a report that shows all the orders where the freight cost more than $500.
            var result = _db.Orders.Where(x => x.Freight > 500).Select(x => x.OrderId).ToList();
            foreach (var item in result)
            {
                Console.WriteLine($"Order ID: {item.ToString()}");
            }
        }

        public static void Query15()
        {
            Console.WriteLine("Query15\n");
            //15.Create a report that shows all the orders where the freight cost more than $500.
            var result = (from p in _db.Orders
                          where p.Freight > 500
                          select new
                          {
                              OrderId = p.OrderId
                          }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method16()
        {
            Console.WriteLine("Method16\n");
            //16. Create a report that shows the ProductName, UnitsInStock, UnitsOnOrder, ReorderLevel
            //of all products that are up for reorder.

            var result = _db.Products.Where(x => x.ReorderLevel != 0)
                .Select(x => new
                {
                    ProductName = x.ProductName,
                    UnitsInStock = x.UnitsInStock,
                    UnitsOnOrder = x.UnitsOnOrder,
                    ReorderLevel = x.ReorderLevel
                }
            ).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query16()
        {
            Console.WriteLine("Query16\n");
            //16. Create a report that shows the ProductName, UnitsInStock, UnitsOnOrder, ReorderLevel
            //of all products that are up for reorder.
            var result = (from p in _db.Products
                          where p.UnitsInStock != 0
                          select new
                          {
                              ProductName = p.ProductName,
                              UnitsInStock = p.UnitsInStock,
                              UnitsOnOrder = p.UnitsOnOrder,
                              ReorderLevel = p.ReorderLevel
                          }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method17()
        {
            Console.WriteLine("Method17\n");
            //17.Create a report that shows the CompanyName, ContactName number of all customer that have no fax number.
            var result = _db.Customers.Where(x => x.Fax == null || x.Fax == "").Select(x => new
            {
                CompanyName = x.CompanyName,
                ContactName = x.ContactName
            }
            ).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query17()
        {
            Console.WriteLine("Query17\n");
            //17.Create a report that shows the CompanyName, ContactName number of all customer that have no fax number.

            var result = (from p in _db.Customers
                          where p.Fax == null
                          select new
                          {
                              CompanyName = p.CompanyName,
                              ContactName = p.ContactName
                          }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method18()
        {
            Console.WriteLine("Method18\n");
            //18. Create a report that shows the FirstName, LastName of all employees that do not report to anybody.
            var result = _db.Employees.Where(x => x.ReportsTo == null || x.ReportsTo == 0)
                .Select(x => new
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName
                }
                ).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query18()
        {
            Console.WriteLine("Query18\n");
            //18. Create a report that shows the FirstName, LastName of all employees that do not report to anybody.
            var result = (from p in _db.Employees
                          where p.ReportsTo == null
                          select new
                          {
                              FirstName = p.FirstName,
                              LastName = p.LastName
                          }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method19()
        {
            Console.WriteLine("Method19\n");
            //19.Create a report showing all the odd numbers of OrderID from the orders table.
            var result = _db.Orders.Where(x => x.OrderId % 2 != 0)
                .Select(x => new
                {
                    OrderId = x.OrderId,
                    OrderDate = x.OrderDate,
                }
                    ).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query19()
        {
            Console.WriteLine("Query19\n");
            //19.Create a report showing all the odd numbers of OrderID from the orders table.

            var result = (from p in _db.Orders
                          where p.OrderId % 2 != 0
                          select new
                          {
                              CustomerId = p.CustomerId,
                              OrderDate = p.OrderDate
                          }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method20()
        {
            Console.WriteLine("Query20\n");
            //20. Create a report that shows the CompanyName, ContactName, Fax of all customers
            //that do not have Fax number and sorted by ContactName.

            var result = _db.Customers.Where(x => x.Fax == null).Select(x => new
            {
                CompanyName = x.CompanyName,
                ContactName = x.ContactName,
                Fax = x.Fax
            }
            ).OrderBy(x => x.ContactName).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query20()
        {
            Console.WriteLine("Query20\n");
            //20. Create a report that shows the CompanyName, ContactName, Fax of all customers
            //that do not have Fax number and sorted by ContactName.

            var result = (from p in _db.Customers
                          orderby p.ContactName
                          where p.Fax == null
                          select new
                          {
                              CompanyName = p.CompanyName,
                              ContactName = p.ContactName,
                              Fax = p.Fax
                          }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public static void Method21()
        {
            //21. Create a report that shows the City, CompanyName, ContactName of customers from cities that has letter L in the name
            //sorted by ContactName
            Console.WriteLine("Method21\n");
            var result = _db.Customers.Where(x => x.City.Contains("L")).OrderBy(x => x.ContactName)
                .Select(x => new
                {
                    City = x.City,
                    CompanyName = x.CompanyName,
                    ContactName = x.ContactName
                }
                ).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public static void Query21()
        {
            //21. Create a report that shows the City, CompanyName, ContactName of customers from cities that has letter L in the name
            //sorted by ContactName
            Console.WriteLine("Query21\n");

            var result = (from p in _db.Customers
                          where p.City.Contains("L")
                          orderby p.ContactName
                          select new
                          {
                              City = p.City,
                              CompanyName = p.CompanyName,
                              ContactName = p.ContactName
                          }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method22()
        {
            //22.Create a report that shows the FirstName, LastName, BirthDate of employees born in the 1950s.
            Console.WriteLine("Query22\n");
            string dtString1 = "01.01.1950";
            string dtString2 = "01.01.1960";
            var result = _db.Employees
                .Where(x => x.BirthDate.Value.Year >= Convert.ToDateTime(dtString1).Year && x.BirthDate.Value.Year < Convert.ToDateTime(dtString2).Year)
                .Select(x => new
                {
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    BirthDate = x.BirthDate
                }
                ).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query22()
        {
            //22.Create a report that shows the FirstName, LastName, BirthDate of employees born in the 1950s.
            Console.WriteLine("Query22\n");

            string dtString1 = "01.01.1950";
            string dtString2 = "01.01.1960";
            DateTime dt1 = Convert.ToDateTime(dtString1);
            DateTime dt2 = Convert.ToDateTime(dtString2);

            var result = (from p in _db.Employees
                          where p.BirthDate<dt2 && p.BirthDate>dt1
                          select new
                          {
                              FirstName=p.FirstName,
                              LastName=p.LastName,
                              BirthDate =p.BirthDate
                          }
                         ).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method23()
        {
            //23. Create a report that shows the FirstName, LastName, the year of Birthdate as birth year from the employees table.
            Console.WriteLine("Method23\n");
            var result = _db.Employees.Select(x => new
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                BirthDate = x.BirthDate.Value.Year
            }).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query23()
        {
            //23. Create a report that shows the FirstName, LastName, the year of Birthdate as birth year from the employees table.
            Console.WriteLine("Qery23\n");
            var result = (from p in _db.Employees
                          select new
                          {
                              FirstName = p.FirstName,
                              LastName = p.LastName,
                              Birthdate = p.BirthDate.Value.Year
                          }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method24()
        {
            //24. Create a report showing OrderID, total number of Order ID as NumberofOrders from the orderdetails table grouped by
            // OrderID and sorted by NumberofOrders in descending order. HINT: you will need to use a Groupby statement.
            Console.WriteLine("Method24\n");

            var result = _db.OrderDetails.GroupBy(x => x.OrderId)
                .Select(x => new { orderId = x.Key, NumberofOrders = x.Count() })
               
                .OrderByDescending(x => x.NumberofOrders).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query24()
        {
            //24. Create a report showing OrderID, total number of Order ID as NumberofOrders from the orderdetails table grouped by
            // OrderID and sorted by NumberofOrders in descending order. HINT: you will need to use a Groupby statement.
            Console.WriteLine("Query24\n");
            //TODO: count'u  let yöntemi ile denemen gerekli, bu yöntem de çaalışıyor.

            var result = (from p in _db.OrderDetails
                          group p by p.OrderId into pgroup
                          orderby pgroup.Count() descending 
                          select new
                          {
                              OrderID = pgroup.Key,
                              NumberofOrders = pgroup.Count()


                          })
                          .ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public static void Method25()
        {
            //TODO: JOIN
            //25. Create a report that shows the SupplierID, ProductName, CompanyName from all product Supplied by Exotic Liquids,
            //Specialty Biscuits, Ltd., Escargots Nouveaux sorted by the supplier ID
            Console.WriteLine("Query25\n");

            var result = _db.Products.Include("Supplier").Select(x => new
            {
                SupplierID = x.SupplierId,
                ProductName = x.ProductName,
                CompanyName = x.Supplier.CompanyName
            }
            ).Where(x => x.CompanyName.Contains("Exotic Liquids") || x.CompanyName.Contains("Specialty Biscuits") || x.CompanyName.Contains(" Ltd.") || x.CompanyName.Contains("Escargots Nouveaux"))
            .OrderBy(x => x.SupplierID).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }


        public static void Method26()
        {
            //26.Create a report that shows the ShipPostalCode, OrderID, OrderDate, RequiredDate, ShippedDate, ShipAddress of all orders
            //with ShipPostalCode beginning with "98124".

            Console.WriteLine("Query26\n");
            var result = _db.Orders.Where(x => x.ShipPostalCode.StartsWith("98124")).Select(x => new
            {
                ShipPostalCode = x.ShipPostalCode,
                OrderID = x.OrderId,
                OrderDate = x.OrderDate,
                RequiredDate = x.RequiredDate,
                ShippedDate = x.ShippedDate,
                ShipAddress = x.ShipAddress
            }
            ).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method27()
        {
            //27. Create a report that shows the ContactName, ContactTitle, CompanyName of customers that
            //the has no "Sales" in their ContactTitle.
            Console.WriteLine("Query27\n");
            var result = _db.Customers.Where(x => x.ContactTitle.Contains("Sales")).Select(x => new
            {
                ContactName = x.ContactName,
                ContactTitle = x.ContactTitle,
                CompanyName = x.CompanyName
            }
            ).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public static void Method28()
        {
            Console.WriteLine("Query28\n");
            //28.Create a report that shows the LastName, FirstName, City of employees in cities other "Seattle";
            var result = _db.Employees.Where(x => !x.City.Contains("Seattle")).Select(x => new
            {
                LastName = x.LastName,
                FirstName = x.FirstName,
                City = x.City
            }
            ).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }


        public static void Method29()
        {
            Console.WriteLine("Query29"); //x.Country == "Mexico" || 
            //29. Create a report that shows the CompanyName, ContactTitle, City, Country of all customers
            //in any city in Mexico or other cities in Spain other than Madrid.

            var result = _db.Customers.Where(x => x.Country == "Spain" && x.City != "Madrid" || x.Country == "Mexico").Select(x => new
            {
                CompanyName = x.CompanyName,
                ContactTitle = x.ContactTitle,
                City = x.City,
                Country = x.Country,
            }
            ).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method30()
        {   //30. Create a select statement that outputs the following:
            Console.WriteLine("Query30\n");
            var result = _db.Employees.Select(x => new
            {
                FirstName = x.FirstName,
                LastName = x.LastName,
                Extension = x.Extension
            }
            ).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + "can be reached at x" + item.Extension);
            }
        }

        public static void Method31()
        {
            //TODO: Linq Like kullanımda karşılaştığımız problem ilgili cümlenin sondan ikinci
            //karakterine göre like işlemini yapamıyoruz, daha sonra bakılacak.


            //31. Create a report that shows the ContactName of all customers that do not have letter A
            //as the second alphabet in their Contactname.
            Console.WriteLine("Query31\n");
            var result = _db.Customers.Where(x => !x.ContactName.Contains("%rs")).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method32()
        {
            //32. Create a report that shows the average UnitPrice rounded to the next whole number,   .Average(x => x.UnitPrice);
            //total price of UnitsInStock and x => x.UnitsInStock * y=> y.UnitPrice  .Aggregate((UnitsInStock, UnitPrice) => UnitsInStock * UnitPrice)
            //maximum number of orders from the products table.  Max(x=>x.unitororder)
            //All saved as AveragePrice, TotalStock and MaxOrder respectively. 
            Console.WriteLine("Query32\n");
            var result = _db.Products.GroupBy(i => 1).Select(x => new
            {
                AveragePrice = Math.Round(Convert.ToDecimal((x.Average(i => i.UnitPrice)))),
                TotalStock = x.Sum(i => i.UnitsInStock),
                MaxOrder = x.Max(i => i.UnitsOnOrder)
            }
            ).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }


        public static void Method33()
        {
            //33. Create a report that shows the SupplierID, CompanyName, CategoryName, ProductName and UnitPrice from the products,
            //suppliers and categories table.
            Console.WriteLine("Query33\n");
            var result = _db.Products.Include("Category").Include("Supplier").Select(x => new
            {
                SupplierID = x.SupplierId,
                CompanyName = x.Supplier.CompanyName,
                CategoryName = x.Category.CategoryName,
                ProductName = x.ProductName,
                UnitPrice = x.UnitPrice
            }
            ).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public static void Method34()
        {
            //34. Create a report that shows the CustomerID, sum of Freight, from the orders table with sum of freight
            //greater $200, grouped by CustomerID. HINT: you will need to use a Groupby and a Having statement

            Console.WriteLine("Query34\n");

            var result = _db.Orders.Include("Customer").GroupBy(x => x.CustomerId).Select(x => new
            {
                Freight = x.Sum(i => i.Freight),
                CustomerID = x.Key
            }
            ).Where(x => x.Freight > 200).OrderBy(x => x.Freight).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Method35()
        {
            //35. Create a report that shows the OrderID ContactName, UnitPrice, Quantity, Discount from the order details, orders and
            //customers table with discount given on every purchase.
            Console.WriteLine("Query35\n");

            var result = _db.OrderDetails
                .Include(o => o.Order)
                .Include(c => c.Order.Customer)
                .Where(x => x.Discount != 0)
                   .Select(x => new
                   {
                       OrderID = x.OrderId,
                       ContactName = x.Order.Customer.ContactName,
                       UnitPrice = x.UnitPrice,
                       Quantity = x.Quantity,
                       Discount = x.Discount
                   })
                 .OrderBy(x => x.OrderID).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }



        }


        public static void Method36()
        {
            //36.Create a report that shows the EmployeeID, the LastName and FirstName as employee, and the LastName and FirstName of
            //who they report to as manager from the employees table sorted by Employee ID. HINT: This is a SelfJoin.
            Console.WriteLine("Query36\n");


            var result = (from m in _db.Employees
                          join e in _db.Employees on m.ReportsTo equals e.EmployeeId
                          select new
                          {
                              Employee = (m.FirstName + " " + m.LastName),
                              Manager = (e.FirstName + " " + e.LastName)
                          }
                          ).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }

        }

        public static void Method37()
        {
            //37.Create a report that shows the average, minimum and maximum UnitPrice of all products as AveragePrice, MinimumPrice
            //and MaximumPrice respectively.
            Console.WriteLine("Query37\n");
            var result = (from p in _db.Products
                          group p by 1 into g
                          select new
                          {
                              Key = g.Key,
                              TotalUnitPrice = g.Sum(x => x.UnitPrice),
                              Average = g.Average(x => x.UnitPrice),
                              MinUnitPrice = g.Min(x => x.UnitPrice),
                              MaxUnitPrice = g.Max(x => x.UnitPrice)
                          }).ToList();

            foreach (var item in result)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public static void Query38()
        {
            //38.Create a view named CustomerInfo that shows the CustomerID, CompanyName, ContactName, ContactTitle, Address, City,
            //Country, Phone, OrderDate, RequiredDate, ShippedDate from the customers and orders table. HINT: Create a View.
            var result = (from c in _db.Customers
                          join o in _db.Orders on c.CustomerId equals o.CustomerId
                          select new
                          {
                              customer = c,
                              order = o,
                          }
                          ).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item.order.Customer.ToString());
            }
        }

        public static void Query39()
        {
            //39. Change the name of the view you created from customerinfo to customer details.


        }


        //
        //TODO: Extensions 
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
}
