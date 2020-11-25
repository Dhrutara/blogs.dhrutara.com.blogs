using System;

namespace EFCoreInheritance.Domain.Entities
{
    public abstract record PolicyTemplate
    {
        public PolicyTemplate(PolicyTemplateHierarchy policyTemplateHierarchy, string displayName, string location, DateTime createdDate, string createdUser)
        {
            this.PolicyTemplateHierarchy = policyTemplateHierarchy;
            this.DisplayName = (string.IsNullOrWhiteSpace(displayName) ? null : displayName) ?? throw new ArgumentNullException(nameof(displayName));
            this.Location = (string.IsNullOrWhiteSpace(location) ? null : location) ?? throw new ArgumentNullException(nameof(location));
            this.CreatedDate = createdDate;
            this.CreatedUser = (string.IsNullOrWhiteSpace(createdUser) ? null : createdUser) ?? throw new ArgumentNullException(nameof(createdUser));
        }
        public int Id { get; init; }
        public PolicyTemplateHierarchy PolicyTemplateHierarchy { get; init; }
        public string DisplayName { get; init; }
        public string Location { get; init; }
        public DateTime CreatedDate { get; init; }
        public string CreatedUser { get; init; }
    }
}
