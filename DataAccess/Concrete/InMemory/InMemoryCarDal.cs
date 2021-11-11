using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=150,ModelYear=2019,Description="1.8 Hp 250 Km "},
                new Car{Id=2,BrandId=2,ColorId=5,DailyPrice=350,ModelYear=2009,Description="2.2 Hp 240 Km "},
                new Car{Id=3,BrandId=4,ColorId=2,DailyPrice=250,ModelYear=2011,Description="1.4 Hp 200 Km "},
                new Car{Id=4,BrandId=5,ColorId=3,DailyPrice=250,ModelYear=2014,Description="1.4 Hp 190 Km "},
                new Car{Id=5,BrandId=2,ColorId=3,DailyPrice=450,ModelYear=2015,Description="2.7 Hp 300 Km "},
                new Car{Id=6,BrandId=2,ColorId=1,DailyPrice=350,ModelYear=2012,Description="1.7 Hp 230 Km "},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.Id==car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrand(int brandId)
        {
            return _cars.Where(c=>c.BrandId==brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
