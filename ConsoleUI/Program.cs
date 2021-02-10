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

            foreach (ProductDetailDto productDetail in productManager.GetProductDetails())
            {
                Console.WriteLine(productDetail.ProductName + "/" + productDetail.CategoryName);
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


            foreach (Product p in productManager.GetByUnitPrice(40, 100))
            {
                Console.WriteLine(p.ProductName);
            }
        }
    }
}
