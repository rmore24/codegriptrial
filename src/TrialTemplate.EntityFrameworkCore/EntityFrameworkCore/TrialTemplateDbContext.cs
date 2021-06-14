using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using TrialTemplate.Authorization.Roles;
using TrialTemplate.Authorization.Users;
using TrialTemplate.MultiTenancy;

namespace TrialTemplate.EntityFrameworkCore
{
    public class TrialTemplateDbContext : AbpZeroDbContext<Tenant, Role, User, TrialTemplateDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public TrialTemplateDbContext(DbContextOptions<TrialTemplateDbContext> options)
            : base(options)
        {
        }
    }
}
