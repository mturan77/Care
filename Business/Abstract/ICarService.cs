using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        Car GetAll();
        void Add(List<Car> carList);
        void Update(Car car);
        void Delete(Car car);

      //  List<Car> GetByBrand(int BrandId);
    }
}
