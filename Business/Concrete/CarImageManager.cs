using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage carImage)
        {
            IResult result = BusinessRules.Run(CheckIfCarHaveFiveImages(carImage.CarId));
            if (result != null)
            {
                return result;
            }

            var newImageName = GetImageName(carImage.ImagePath);
            var moveImage = MoveImage(newImageName, carImage);
            _carImageDal.Add(moveImage.Data);
            return new SuccessResult(Messages.CarImageAdded);
        }
        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeleted);
        }
        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }
        public IDataResult<List<CarImage>> GetImagesByCarId(int id)
        {
            IResult result = BusinessRules.Run(CheckIfCarImageNull(id));

            if (result != null)
            {
                return new ErrorDataResult<List<CarImage>>(result.Message);
            }

            return new SuccessDataResult<List<CarImage>>(CheckIfCarImageNull(id).Data);
        }
        public IDataResult<CarImage> Get(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(p => p.Id == id));
        }
        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImageUpdated);
        }

        //Business Rules
        private IDataResult<CarImage> MoveImage(string newImageName, CarImage carImage)
        {
            var newPath = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{newImageName}");
            try
            {
                File.Move(carImage.ImagePath, newPath);
            }
            catch (Exception exception)
            {
                return new ErrorDataResult<CarImage>(exception.Message);
            }
            return new SuccessDataResult<CarImage>(new CarImage { Id = carImage.Id, CarId = carImage.CarId, ImagePath = newPath, Date = DateTime.Now });
        }
        private IResult CheckIfCarHaveFiveImages(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId);

            if (result.Count > 5)
            {
                return new ErrorResult(Messages.ImageCountError);
            }
            return new SuccessResult();
        }
        private string GetImageName(string imagePath)
        {
            return Guid.NewGuid().ToString() + ".jpg";
        }
        private IDataResult<List<CarImage>> CheckIfCarImageNull(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Any();
            if (!result)
            {
                string path = $"wwwroot/images/default.jpg";
                List<CarImage> carImage = new List<CarImage>();
                carImage.Add(new CarImage { CarId = carId, ImagePath = path, Date = DateTime.Now });
                return new SuccessDataResult<List<CarImage>>(carImage);
            }
            return new ErrorDataResult<List<CarImage>>();
        }
    }
}
