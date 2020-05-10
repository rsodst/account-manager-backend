﻿using System;
using MediatR;
using Modulbank.Profiles.Domain;
using Modulbank.Profiles.Specification;

namespace Modulbank.Profiles.Command
{
    public class UpdatePersonDetailsCommand : IRequest<PersonDetails>, IPersonDetails
    {
        public Guid UserId { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public string MiddleName { get; set; }
    }
}