//#define insert

using EFCoreInheritance.Domain.Entities;
using System;
using System.Linq;

namespace EFCoreInheritance.TablePerType
{
    class Program
    {
        static void Main(string[] args)
        {
            PolicyTemplateDbContext policyTemplateDbContext = new PolicyTemplateDbContextFactory().CreateDbContext(new string[] { "" });

#if insert

            OrganizationPolicyTemplate main = new OrganizationPolicyTemplate("Organization HR Policy", @"\\shared\policies\HrPolicy.docx", DateTime.Now, "kanjinghat");

            RegionPolicyTemplate na = new RegionPolicyTemplate("North America HR Policy", @"\\NA\shared\policies\HrPolicy.docx", DateTime.Now, "kanjinghat", 1);
            RegionPolicyTemplate asia = new RegionPolicyTemplate("Asia HR Policy", @"\\Asia\shared\policies\HrPolicy.docx", DateTime.Now, "kanjinghat", 2);

            CountryPolicyTemplate india = new CountryPolicyTemplate("India HR Policy", @"\\India\shared\policies\HrPolicy.docx", DateTime.Now, "kanjinghat", 1);
            CountryPolicyTemplate singapore = new CountryPolicyTemplate("Singapore HR Policy", @"\\Singapore\shared\policies\HrPolicy.docx", DateTime.Now, "kanjinghat", 1);
            CountryPolicyTemplate dubai = new CountryPolicyTemplate("Dubai HR Policy", @"\\Dubai\shared\policies\HrPolicy.docx", DateTime.Now, "kanjinghat", 1);

            policyTemplateDbContext.AddRange(main, na, asia, india, singapore, dubai);
            policyTemplateDbContext.SaveChanges();
#endif

            var mainPolicy = policyTemplateDbContext.OrganizationPolicyTemplates.FirstOrDefault();

            var regionalPolicies = policyTemplateDbContext.RegionPolicyTemplates.ToList();

            var countryPolicies = policyTemplateDbContext.CountryPolicyTemplates.ToList();

            if (mainPolicy != null)
            {
                Console.WriteLine("Main HR Policy Details");
                Console.WriteLine("==========================================");
                Console.WriteLine($"Name: {mainPolicy.DisplayName}, Location: {mainPolicy.Location}, Created User: {mainPolicy.CreatedUser}");
                Console.WriteLine(Environment.NewLine);
            }


            Console.WriteLine("Regional HR Policies");
            Console.WriteLine("==========================================");
            foreach(RegionPolicyTemplate region in regionalPolicies)
            {
                if(region != null)
                {
                    Console.WriteLine($"Region Id: {region.Id}, Name: {region.DisplayName}, Location: {region.Location}, Created User: {region.CreatedUser}{Environment.NewLine}");
                }
            }
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine("Country HR Policies");
            Console.WriteLine("==========================================");
            foreach (CountryPolicyTemplate country in countryPolicies)
            {
                if(country != null)
                {
                    Console.WriteLine($"Country Id: {country.Id}, Name: {country.DisplayName}, Location: {country.Location}, Created User: {country.CreatedUser}{Environment.NewLine}");
                }
                
            }
            Console.WriteLine(Environment.NewLine);
        }
    }
}
