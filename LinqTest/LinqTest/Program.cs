// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var colors = new List<string> {"green", "brown", "blue", "red" };
var query = colors.Where(c => c.Length == 3).ToList();
colors.Remove("red");
Console.WriteLine(query.Count());