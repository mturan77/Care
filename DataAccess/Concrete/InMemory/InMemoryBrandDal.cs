using DataAccess.Abstract;
using DataAccess.Abstract.EntitiesDals;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryBrandDal : IBrandDal
    {
        List<Brand> _brand;
        public InMemoryBrandDal()
        {
            _brand = new List<Brand> { new Brand { BrandId = 1, BrandName = "Audi" }, new Brand { BrandId = 2, BrandName = "Fiat" } };
        }

        public void Add(Brand entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Brand entity)
        {
            throw new NotImplementedException();
        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            return _brand;
        }

        public void Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
