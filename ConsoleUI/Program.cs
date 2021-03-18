using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        
        
        static void Main(string[] args)
        {
            ICarService cars = new CarManager(new EfCarDal());
            IBrandService brand = new BrandManager(new EfBrandDal());
            IColorService color = new ColorManager(new EFColorDal());

            var result = cars.GetCarDetails();

            foreach (var item in result.Data)
            {
                Console.WriteLine("Licance Plate: {0} Brand: {1} Color: {2} Price: {3}",item.LicancePlate,item.BrandName,item.ColorName,item.DailyPrice);
            }
        }
    }
}
