using System;

public class Product
{
	private string code;
	private string Code
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

	private double price;
	private double Price 
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

	private double iva;
	private double Iva 
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

	private string name;
	private string description;
	
	public Product(string productName, int productPrice)
	{
		this.name = productName;
		this.price = productPrice;
		this.code = this.CreateCode();
	}

	public string CreateCode()
    {
		Random rnd = new Random();
		string randomCode = rnd.Next(1, 10000).ToString();
		string newRandomCode = "";
		if(randomCode.Length < 8)
        {

			for(int i = 0; i < (8 - randomCode.Length); i++)
            {
				newRandomCode += "0";
            }
        }
		return newRandomCode + randomCode;
	}

	public double SetIva()
    {
		int iva = 22;
		double tax = (this.Price * iva) / 100;
		double finalPrice = tax + this.Price;
		return finalPrice;
    }

	public string FullName()
    {
		string productName = this.name + " " + "'" + this.code + "'";
		return productName;	
    }
}
