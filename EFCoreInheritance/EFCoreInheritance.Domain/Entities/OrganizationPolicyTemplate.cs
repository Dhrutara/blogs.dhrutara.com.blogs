using System;

namespace EFCoreInheritance.Domain.Entities
{
    public record OrganizationPolicyTemplate : PolicyTemplate
    {
        public OrganizationPolicyTemplate(string displayName, string location, DateTime createdDate, string createdUser)
            : base(PolicyTemplateHierarchy.Organization, displayName, location, createdDate, createdUser)
        {

        }
    }
}
