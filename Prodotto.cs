using System;

public class Product
{
	public int code;
	public int Code
	{
		get
		{
			return code;
		}
		set
		{
			code = this.CreateCode();
		}
	}

	public double price;
	public double Price 
	{ 
		get
		{
			return price;
		}
		set 
		{
			price = Price;
		} 
	}

	public double iva;
	public double Iva 
	{ 
		get 
		{ 
			return iva; 
		} 
		set 
		{
			iva = this.SetIva(); 
		} 
	}	

	public string name;
	public string description;
	
	public Product(string productName, int productPrice)
	{
		this.name = productName;
		this.price = productPrice;
		this.code = this.CreateCode();
	}

	public int CreateCode()
    {
		Random rnd = new Random();
		int randomCode = rnd.Next(1, 99999999);
		return randomCode;
	}

	public double SetIva()
    {
		int iva = 22;
		double tax = (this.Price * iva) / 100;
		double finalPrice = tax + this.Price;
		return finalPrice;
    }
}
