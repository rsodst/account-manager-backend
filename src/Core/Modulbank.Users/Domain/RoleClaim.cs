﻿using System;

namespace Modulbank.Users.Domain
{
    internal class RoleClaim 
    {
        public RoleClaim()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public string ClaimType { get; set; }
        public string ClaimValue { get; set; }
    }
}