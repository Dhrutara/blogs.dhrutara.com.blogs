using System;

namespace EFCoreInheritance.Domain.Entities
{
    public record RegionPolicyTemplate : OrganizationPolicyTemplate
    {
        protected RegionPolicyTemplate(PolicyTemplateHierarchy policyTemplateHierarchy, string displayName, string location, DateTime createdDate, string createdUser, int regionId)
            : base(policyTemplateHierarchy, displayName, location, createdDate, createdUser)
        {
            this.RegionId = regionId;
        }

        public RegionPolicyTemplate(string displayName, string location, DateTime createdDate, string createdUser, int regionId) 
            : this(PolicyTemplateHierarchy.Region, displayName, location, createdDate, createdUser, regionId)
        {
        }

        public int RegionId { get; init; }
    }
}
