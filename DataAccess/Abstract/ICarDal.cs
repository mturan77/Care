﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        void Add(List<Car> car);
        void Update(Car car, Car carToUpdate);
        void Delete(Car car);

        List<Car> GetByBrand(int BrandId);

    }
}
