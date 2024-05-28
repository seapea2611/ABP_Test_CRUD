using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Test1.Authorization.Roles;
using Test1.Authorization.Users;
using Test1.MultiTenancy;
using Test1.Products;


namespace Test1.EntityFrameworkCore
{
    public class Test1DbContext : AbpZeroDbContext<Tenant, Role, User, Test1DbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Product> Products { get; set; }
        public Test1DbContext(DbContextOptions<Test1DbContext> options)
            : base(options)
        {
        }

    }
}
