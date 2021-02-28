using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CompanyCustomer : IEntity
    {
        public int CompanyCustomerId { get; set; }
        public int UserId { get; set; }
        public string CompanyName { get; set; }
    }
}
