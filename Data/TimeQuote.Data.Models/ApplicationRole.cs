﻿// ReSharper disable VirtualMemberCallInConstructor
namespace TimeQuote.Data.Models
{
    using System;

    using Microsoft.AspNetCore.Identity;
    using TimeQuote.Data.Common.Models;

    public class ApplicationRole : IdentityRole, IAuditInfo, IDeletableEntity
    {
        public ApplicationRole()
            : this(null)
        {
        }

        public ApplicationRole(string name)
            : base(name)
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public int OrganizationId { get; set; }

        public virtual Organization Organization { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
