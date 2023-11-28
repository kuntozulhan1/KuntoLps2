using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using KuntoLps2.Authorization.Roles;
using KuntoLps2.Authorization.Users;
using KuntoLps2.MultiTenancy;
using KuntoLps2.Dokumen;

namespace KuntoLps2.EntityFrameworkCore
{
    public class KuntoLps2DbContext : AbpZeroDbContext<Tenant, Role, User, KuntoLps2DbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<UploadFile> UploadFiles { get; set; }
        public KuntoLps2DbContext(DbContextOptions<KuntoLps2DbContext> options)
            : base(options)
        {

        }
    }
}
