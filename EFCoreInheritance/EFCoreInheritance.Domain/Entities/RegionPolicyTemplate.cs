using System;

namespace EFCoreInheritance.Domain.Entities
{
    public record RegionPolicyTemplate : PolicyTemplate
    {
        public RegionPolicyTemplate(string displayName, string location, DateTime createdDate, string createdUser, int regionId) 
            : base(PolicyTemplateHierarchy.Region, displayName, location, createdDate, createdUser)
        {
            this.RegionId = regionId;
        }

        public int RegionId { get; init; }
    }
}
