var v = new { Amount = 108, Massage = "Hi" };

class Product
{
    public string? Color { get; set; }
    public decimal Price { get; set; }
    public string? Name { get; set; }
    public string? Category { get; set; }

    public string? Size { get; set; }

}

var productQuery = from prod in products select new { prod.color, prod.price };

foreach (var v in productQuery)
{
    Console.WriteLine("Color={0}, Price={1}", v.Color, v.Price);
}

var product = new Product();
var bonus = new { note = "You Won!" };
var shipment = new { address = "Nowhere St.", product };
var shipmentWithBonus = new { address = "SomeWhere St.", product, bonus };


var anonArray = new[] { new { name = "Chickin", diam = 1 }, new { name = "grape", diam = 1 } };

var apple = new { Item = "apples", Price = 1.35 };
var onSale = apple with { Price = 0.50 };
Console.WriteLine(apple);
Console.WriteLine(onSale);

var v = new { Title = "Hello", Age = 24 };

Console.WriteLine(v.ToString());