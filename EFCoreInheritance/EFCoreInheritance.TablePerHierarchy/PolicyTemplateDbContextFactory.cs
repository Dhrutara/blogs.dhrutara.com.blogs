using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreInheritance.TablePerHierarchy
{
    public class PolicyTemplateDbContextFactory : IDesignTimeDbContextFactory<PolicyTemplateDbContext>
	{
		public PolicyTemplateDbContext CreateDbContext(string[] args)
		{
			DbContextOptionsBuilder<PolicyTemplateDbContext> dbContextOptionsBuilder = new DbContextOptionsBuilder<PolicyTemplateDbContext>();
			dbContextOptionsBuilder
				.UseSqlServer("Data Source=DEVELOPMENT1\\SQL2017;Initial Catalog=EFCoreInheritanceTPH;Integrated Security=True;");

			return new PolicyTemplateDbContext(dbContextOptionsBuilder.Options);
		}
	}
}
