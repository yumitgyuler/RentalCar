//using DataAccess.Abstract;
//using Entities.Concrete;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//namespace DataAccess.Concrete.InMemory
//{
//    public class InMemoryCarDal : ICarDal
//    {
//        List<Car> _cars;
//        public InMemoryCarDal()
//        {
//            _cars = new List<Car>
//            {
//                //new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=300,ModelYear=2020,Description="This is test description"}
//            };
//        }
//        public void Add(Car car)
//        {
//            _cars.Add(car);
//        }

//        public void Delete(Car car)
//        {
//            Car carToDelete = _cars.SingleOrDefault(p => p.Id == car.Id);
//            _cars.Remove(carToDelete);
//        }

//        public List<Car> GetAll()
//        {
//            return _cars;
//        }

//        public Car Get(int id)
//        {
//            return _cars.SingleOrDefault(p => p.Id == id);
//        }

//        public void Update(Car car)
//        {
//            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == car.Id);
//        }
//    }
//}
