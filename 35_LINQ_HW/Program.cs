namespace _35_LINQ_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create sample data for Categories and Products
            Category electronics = new Category { Name = "Electronics" };
            Category furniture = new Category { Name = "Furniture" };
            Category clothing = new Category { Name = "Clothing" };

            List<Product> products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1200, ManufactureDate = new DateTime(2025, 1, 1), CountryOfOrigin = "USA", Category = electronics },
            new Product { Name = "Chair", Price = 150, ManufactureDate = new DateTime(2024, 6, 1), CountryOfOrigin = "Ukraine", Category = furniture },
            new Product { Name = "Shirt", Price = 30, ManufactureDate = new DateTime(2025, 3, 10), CountryOfOrigin = "Italy", Category = clothing },
            new Product { Name = "Phone", Price = 800, ManufactureDate = new DateTime(2025, 1, 15), CountryOfOrigin = "China", Category = electronics },
            new Product { Name = "Table", Price = 200, ManufactureDate = new DateTime(2024, 11, 30), CountryOfOrigin = "Ukraine", Category = furniture }
        };

            //1
            List<Product> productsThisYear = products
                .Where(p => p.ManufactureDate.Year == DateTime.Now.Year)
                .OrderByDescending(p => p.Price)
                .ToList();

            Console.WriteLine("\t\tN1:\n\t Products manufactured this year, sorted by price (highest to lowest):");
            foreach (Product product in productsThisYear)
            {
                Console.WriteLine($"{product.Name} - {product.Price}");
            }

            //2
            string selectedCountry = "Ukraine";
            int countByCountry = products.Count(p => p.CountryOfOrigin == selectedCountry);
            Console.WriteLine($"\t\tN2:\n\t Number of products made in {selectedCountry}: {countByCountry}");

            //3
            Category selectedCategory = electronics;
            List<Product> categoryProducts = products.Where(p => p.Category == selectedCategory).ToList();
            Product maxPriceProduct = categoryProducts.OrderByDescending(p => p.Price).FirstOrDefault();
            Product minPriceProduct = categoryProducts.OrderBy(p => p.Price).FirstOrDefault();
            Console.WriteLine("\t\tN3:\n\tMost expensive and cheapest products in the selected category:");
            Console.WriteLine($"\tMost expensive: {maxPriceProduct?.Name} - {maxPriceProduct?.Price}");
            Console.WriteLine($"\tCheapest: {minPriceProduct?.Name} - {minPriceProduct?.Price}");

            //4
            var categoriesNotMadeInUkraine = products
                .Where(p => p.CountryOfOrigin != "Ukraine")
                .GroupBy(p => p.Category)
                .Select(g => g.Key.Name)
                .Distinct()
                .ToList();
            Console.WriteLine("\t\tN4:\n\t Categories with products not made in Ukraine:");
            foreach (var category in categoriesNotMadeInUkraine)
            {
                Console.WriteLine(category);
            }

            //5
            var categoryProductCounts = products
                .GroupBy(p => p.Category)
                .Select(g => new { Category = g.Key.Name, ProductCount = g.Count() })
                .ToList();
            Console.WriteLine("\t\tN5:\n\t Product count per category:");
            foreach (var categoryCount in categoryProductCounts)
            {
                Console.WriteLine($"{categoryCount.Category}: {categoryCount.ProductCount} products");
            }

            //6
            var groupedByCategory = products
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key.Name,
                    Products = g.OrderBy(p => p.ManufactureDate).ToList()
                })
                .ToList();

            Console.WriteLine("\t\tN6:\n\t Products grouped by category and sorted by manufacture date:");
            foreach (var group in groupedByCategory)
            {
                Console.WriteLine($"Category: {group.Category}");
                foreach (var product in group.Products)
                {
                    Console.WriteLine($"  {product.Name} - {product.ManufactureDate.ToShortDateString()}");
                }
            }
        }
    }
}
