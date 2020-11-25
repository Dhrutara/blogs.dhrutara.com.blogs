using System;

namespace EFCoreInheritance.Domain.Entities
{
    public record CountryPolicyTemplate : PolicyTemplate
    {
        public CountryPolicyTemplate(string displayName, string location, DateTime createdDate, string createdUser, int countryId)
            : base(PolicyTemplateHierarchy.Country, displayName, location, createdDate, createdUser)
        {
            this.CountryId = countryId;
        }

        public int CountryId { get; init; }
    }
}
