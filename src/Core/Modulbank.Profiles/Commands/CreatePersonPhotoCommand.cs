﻿using System;
using MediatR;
using Modulbank.Profiles.Domain;

namespace Modulbank.Profiles.Commands
{
    public class CreatePersonPhotoCommand : IRequest<PersonPhoto>
    {
        public Guid UserId { get; set; }
        
        public string FileName { get; set; }
    }
}