using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Tesis.AdminFutbol.Authorization.Roles;
using Tesis.AdminFutbol.Authorization.Users;
using Tesis.AdminFutbol.MultiTenancy;

namespace Tesis.AdminFutbol.EntityFrameworkCore
{
    public class AdminFutbolDbContext : AbpZeroDbContext<Tenant, Role, User, AdminFutbolDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AdminFutbolDbContext(DbContextOptions<AdminFutbolDbContext> options)
            : base(options)
        {
        }
    }
}
