using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Abstract.EntitiesDals;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void AddBrand(Brand brandName)
        {
            _brandDal.Add(brandName);
        }

        public void DeleteBrand(Brand brandName)
        {
            _brandDal.Delete(brandName);
        }

        public List<Brand> GetAllBrand()
        {
            return _brandDal.GetAll();
        }

        public void UpdateBrand(Brand brandName)
        {
            _brandDal.Update(brandName);
        }
    }
}
