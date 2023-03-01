using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{

			ProductManager manager = new ProductManager(new EfProductDal());

			var result = manager.GetAllByCategoryId(2);
			var result2 = manager.GetAllByUnitPrice(10, 100);
			foreach (var r in result2)
			{
				Console.WriteLine(r.ProductName);
			}
           
		}
	}
}