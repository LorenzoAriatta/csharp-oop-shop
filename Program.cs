// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


Product newProduct = new Product("The Matrix", 50);

newProduct.description = "The Matrix is an example of the cyberpunk subgenre of science fiction. ";

Console.WriteLine("Product name: ");
Console.WriteLine(newProduct.name);

Console.WriteLine("Product code: ");
Console.WriteLine(newProduct.code);

Console.WriteLine("Description: ");
Console.WriteLine(newProduct.description);

Console.WriteLine("Price: ");
Console.WriteLine(newProduct.price + " euro");

Console.WriteLine("Total Price: ");
Console.WriteLine(newProduct.SetIva() + " euro");