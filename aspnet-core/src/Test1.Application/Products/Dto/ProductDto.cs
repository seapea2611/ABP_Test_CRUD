using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1.Products
{
    [AutoMapFrom(typeof(Product))]
    public class ProductDto : EntityDto<int>
    {
        public string Name { get; set; }

        public float Price { get; set; }

        public int Stock { get; set; }
    }
}
