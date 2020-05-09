using System;
using System.Collections.Generic;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace Modulbank.Users.Models
{
    public class ApplicationRole 
    {
        public ApplicationRole()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string NormalizedName { get; set; }

        public string ConcurrencyStamp { get; set; }

        internal List<Claim> Claims { get; set; }
    }
}