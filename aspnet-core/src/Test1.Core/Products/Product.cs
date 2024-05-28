using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Products
{
    

    public class Product : Entity<int>
    {
        public string Name { get; set; }

        public float Price { get; set; }

        public int Stock { get; set; }
    }
}
