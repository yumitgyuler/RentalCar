using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(Car car)
        {
            if (car.LicancePlate.Length > 2 || car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.Added);
            }
            return new ErrorResult(Messages.AddedFailCar);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.Deleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.GetAll);
        }

        public IDataResult<Car> Get(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == id),Messages.Get);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.Updated);
        }
        public IDataResult<Car> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.BrandId == id), Messages.Get);
        }
        public IDataResult<Car> GetCarsByColordId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.ColorId == id), Messages.Get);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.Get);
        }
    }
}
