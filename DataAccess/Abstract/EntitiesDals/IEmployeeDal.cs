using DataAccess.Abstract.Base;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract.EntitiesDals
{
    public interface IEmployeeDal : IEntityRepository<Employee>
    {
        
    }
}
