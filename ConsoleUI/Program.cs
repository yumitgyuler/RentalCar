using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarService cars = new CarManager(new InMemoryCarDal());

            foreach (var item in cars.GetAll())
            {
                Console.WriteLine(item.BrandId); 
            }
        }
    }
}
