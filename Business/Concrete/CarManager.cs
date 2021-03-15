using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.LicancePlate.Length > 2 || car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            Console.WriteLine("Licanse Plate must be more then 2 characters or daily price must be more than 0");
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public Car GetById(int id)
        {
            return _carDal.GetById(p => p.Id == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
        public Car GetCarsByBrandId(int id)
        {
            return _carDal.GetById(p => p.BrandId == id);
        }
        public Car GetCarsByColordId(int id)
        {
            return _carDal.GetById(p => p.ColorId == id);
        }
    }
}
