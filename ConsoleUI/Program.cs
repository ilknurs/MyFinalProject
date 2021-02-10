using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle : Yeni bir özellik ekliyorsan mevcut kodlara dokunamazsın.
    class Program
    {
        static void Main(string[] args)
        {
            //Product();

            //Category();

            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
        /*
        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }*/

        static void Product()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
                     
        }
    }
}
