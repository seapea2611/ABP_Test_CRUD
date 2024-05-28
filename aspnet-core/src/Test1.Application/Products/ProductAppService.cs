using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test1.Authorization;

namespace Test1.Products
{
    [AbpAuthorize(PermissionNames.Pages_Products)]
    public class ProductsAppService : AsyncCrudAppService<Product, ProductDto>
    {
        public ProductsAppService(IRepository<Product, int> repository) : base(repository)
        {
        }
    }
}
