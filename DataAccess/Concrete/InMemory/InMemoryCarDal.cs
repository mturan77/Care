using DataAccess.Abstract;
using DataAccess.Abstract.EntitiesDals;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            { 
            new Car{CarId=1,BrandId=1,CarName="Araç1",ColorId=1,DailyPrice=100,Description="",ModelId=1,ModelYear=1989 },
            new Car{CarId=2,BrandId=2,CarName="Araç2",ColorId=2,DailyPrice=150,Description="",ModelYear=2005,ModelId=1},
            new Car{CarId=3,BrandId=2,CarName="Araç3",ColorId=3,DailyPrice=200,ModelId=2,ModelYear=2015,Description=""}
            };
        }

        public void Add(Car entity)
        {
            _car.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car CarToDelete = null;
            CarToDelete = _car.SingleOrDefault(p => p.CarId == entity.CarId);
            _car.Remove(CarToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _car;
        }

        public void Update(Car entity, Car CarToUpdate)
        {
            Car CarTemp = _car.SingleOrDefault(p => p.CarId == entity.CarId);
            CarToUpdate = _car.SingleOrDefault(p => p.CarId == CarToUpdate.CarId);
            CarToUpdate.CarId = CarTemp.CarId;
            CarToUpdate.CarName = CarTemp.CarName;
            CarToUpdate.BrandId = CarTemp.BrandId;
            CarToUpdate.ColorId = CarTemp.ColorId;
            CarToUpdate.DailyPrice = CarTemp.DailyPrice;
            CarToUpdate.ModelId = CarTemp.ModelId;
            CarToUpdate.ModelYear = CarTemp.ModelYear;
            CarToUpdate.Description = CarTemp.Description;
        }
        public List<Car> GetByBrand(int BrandId)
        {
            return _car.Where(p => p.BrandId == BrandId).ToList();
        }

        public void Update(Car entity)
        {
            throw new NotImplementedException();
        }
    }
}
