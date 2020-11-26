using System;

namespace EFCoreInheritance.Domain.Entities
{
    public record CountryPolicyTemplate : RegionPolicyTemplate
    {
        public CountryPolicyTemplate(string displayName, string location, DateTime createdDate, string createdUser, int regionId, int countryId)
            : base(PolicyTemplateHierarchy.Country, displayName, location, createdDate, createdUser, regionId)
        {
            this.CountryId = countryId;
        }

        public int CountryId { get; init; }
    }
}
