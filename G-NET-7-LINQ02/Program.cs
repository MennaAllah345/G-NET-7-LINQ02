using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List Of  Products
            var products = new List<Product>
{
    new Product { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18, UnitsInStock = 10 },
    new Product { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19, UnitsInStock = 0 },
    new Product { ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10, UnitsInStock = 5 },
    new Product { ProductID = 4, ProductName = "Chef Anton", Category = "Condiments", UnitPrice = 22, UnitsInStock = 3 },
    new Product { ProductID = 5, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31, UnitsInStock = 20 },
    new Product { ProductID = 6, ProductName = "Konbu", Category = "Seafood", UnitPrice = 6, UnitsInStock = 15 },
    new Product { ProductID = 7, ProductName = "Tofu", Category = "Produce", UnitPrice = 23, UnitsInStock = 8 },
    new Product { ProductID = 8, ProductName = "Pavlova", Category = "Desserts", UnitPrice = 17, UnitsInStock = 12 },
    new Product { ProductID = 9, ProductName = "Alice Mutton", Category = "Meat", UnitPrice = 39, UnitsInStock = 0 },
    new Product { ProductID = 10, ProductName = "Carnarvon Tigers", Category = "Seafood", UnitPrice = 62, UnitsInStock = 4 },
    new Product { ProductID = 18, ProductName = "Côte de Blaye", Category = "Beverages", UnitPrice = 263, UnitsInStock = 17 }
};

            #endregion


            #region List Of Customers
            var customers = new List<Customer>
{
    new Customer
    {
        CompanyName = "ABC Corp",
        Country = "Germany",
        Orders = new List<Order>
        {
            new Order { Total = 100 },
            new Order { Total = 200 }
        }
    },
    new Customer
    {
        CompanyName = "XYZ Ltd",
        Country = "France",
        Orders = new List<Order>
        {
            new Order { Total = 150 }
        }
    },
    new Customer
    {
        CompanyName = "Tech Co",
        Country = "Germany",
        Orders = new List<Order>
        {
            new Order { Total = 300 }
        }
    },
    new Customer
    {
        CompanyName = "Shop Co",
        Country = "UK",
        Orders = new List<Order>
        {
            new Order { Total = 50 }
        }
    }
};
            #endregion

            #region Q1 :
            var top3 = products
    .OrderByDescending(p => p.UnitPrice)
    .Take(3);
            #endregion

            #region Q2 :
            //        var page2 = products
            //.Skip(5)
            //.Take(5);
            #endregion

            #region Q3 :
            //        var result = products
            //.OrderBy(p => p.UnitPrice)
            //.TakeWhile(p => p.UnitPrice < 25);
            #endregion

            #region Q4 :
            //        bool allInStock = products
            //.Where(p => p.Category == "Seafood")
            //.All(p => p.UnitsInStock > 0);
            #endregion

            #region Q5 :
            //int[] ids = { 3, 9, 13, 18 };

            //bool contains9 = ids.Contains(9);
            #endregion

            #region Q6:
            //        var grouped = products
            //.GroupBy(p => p.Category);

            //        foreach (var group in grouped)
            //        {
            //            Console.WriteLine($"{group.Key} - Count: {group.Count()}");
            //        }
            #endregion

            #region Q7 :
            //        var groupedNames = products
            //.GroupBy(p => p.Category)
            //.Select(g => new
            //{
            //    Category = g.Key,
            //    Names = g.Select(p => p.ProductName)
            //});
            #endregion

            #region Q8 :
            //        var categories = products
            //.GroupBy(p => p.Category)
            //.Where(g => g.Count() > 3)
            //.Select(g => g.Key);
            #endregion

            #region Q9 :
            //var result = from c in customers
            //             group c by c.Country into g
            //             select new
            //             {
            //                 Country = g.Key,
            //                 Count = g.Count(),
            //                 TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //             };
            #endregion

            #region Q10 :
            //int totalUnits = products.Sum(p => p.UnitsInStock);
            #endregion

            #region Q11 :
            //var minPrice = products.Min(p => p.UnitPrice);
            //var maxPrice = products.Max(p => p.UnitPrice);
            #endregion

            #region Q12 :
            //        var categories = products
            //.Select(p => p.Category)
            //.Distinct();
            #endregion

            #region Q13 :
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);
            #endregion

            #region Q14 :
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1
            //    .Except(list2, StringComparer.OrdinalIgnoreCase);
            #endregion

            #region Q15 :
            //var dict = products.ToDictionary(p => p.ProductID);

            //if (dict.TryGetValue(18, out var product))
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            #endregion

            #region Q16 :
            //var product = products.First(p => p.UnitPrice > 50);
            #endregion

            #region Q17 :
            //var product = products.FirstOrDefault(p => p.UnitPrice > 500);
            #endregion

            #region Q18 :
            //        var table = Enumerable.Range(1, 10)
            //.Select(x => 7 * x);
            #endregion

            #region Q19 :
            //        var evens = Enumerable.Range(1, 30)
            //.Where(x => x % 2 == 0);
            #endregion

            #region Q20 :
            //        var result = products.Take(3).Select(p => p.ProductName)
            //.Concat(customers.Take(3).Select(c => c.CompanyName));
            #endregion

            #region Q21 :
    //        var result = products.Zip(customers, (p, c) =>
    //$"{p.ProductName} sold to {c.CompanyName}");
            #endregion
        }
    }
}
