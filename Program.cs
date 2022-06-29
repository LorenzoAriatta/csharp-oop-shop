// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//create new class Product
Product newProduct = new Product("The Matrix", 50);

//modify description of the class Product
newProduct.description = "The Matrix is an example of the cyberpunk subgenre of science fiction. ";

//print info
Console.WriteLine("Product name: ");
Console.WriteLine(newProduct.FullName());

Console.WriteLine("Description: ");
Console.WriteLine(newProduct.description);

Console.WriteLine("Price: ");
Console.WriteLine(newProduct.price + " euro");

Console.WriteLine("Total Price: ");
Console.WriteLine(newProduct.SetIva() + " euro");