﻿using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Modulbank.Accounts.Queries;
using Swashbuckle.AspNetCore.Annotations;

namespace Modulbank.App.Api.Controllers.Accounts
{
    [Route("accounts/{accountId}")]
    [ApiController]
    [Authorize("NotLockoutRequirement")]
    [Authorize("ProfileConfirmedRequirement")]
    public class AccountActionsController : AppController
    {
        private readonly IMediator _mediator;

        public AccountActionsController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }

        [HttpGet("actions/{skip}/{take}")]
        [SwaggerOperation(Tags = new[] {"Account"})]
        public async Task<IActionResult> GetList(Guid accountId, int skip, int take)
        {
            var query = new GetAccountActionsQuery
            {
                UserId = CurrentUserId,
                AccountId = accountId,
                Skip = skip,
                Take = take
            };

            return Ok(await _mediator.Send(query));
        }
    }
}