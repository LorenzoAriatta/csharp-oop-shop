using System;

public class Product
{
	public int Code
	{
		get
		{
			return Code;
		}
		set
		{
			Code = this.CreateCode();
		}
	}

	public uint Price 
	{ 
		get
		{
			return Price;
		}
		set 
		{
			Price = this.SetPrice();
		} 
	}

	public int Iva 
	{ 
		get 
		{ 
			return Iva; 
		} 
		set 
		{ 
			Iva = value; 
		} 
	}	

	public string name;
	public int description;
	
	public Product()
	{
		
	}

	public int CreateCode()
    {
		Random rnd = new Random();
		int randomCode = rnd.Next(1, 99999999);
		return randomCode;
	}

	public uint SetPrice()
    {
		Random random = new Random();
		uint randomPrice = (uint)random.Next(0, 1000000);
		return randomPrice;
    }
}
