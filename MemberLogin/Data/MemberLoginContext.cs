using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MemberLogin.Models;

namespace MemberLogin.Models
{
    public class MemberLoginContext : DbContext
    {
        public MemberLoginContext (DbContextOptions<MemberLoginContext> options)
            : base(options)
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<Branch> Branches { get; set; }
    }

    class MemberLoginContextFactory
    {
        public static MemberLoginContext Create(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<MemberLoginContext>();
            optionsBuilder.UseMySql(connectionString);
            var memberLoginContext = new MemberLoginContext(optionsBuilder.Options);
            return memberLoginContext;
        }
    }
}
