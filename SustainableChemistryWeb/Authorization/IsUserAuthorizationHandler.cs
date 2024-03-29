﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;
using SustainableChemistryWeb.Models;
using System.Threading.Tasks;

namespace SustainableChemistryWeb.Authorization
{
    public class IsUserAuthorizationHandler : AuthorizationHandler<OperationAuthorizationRequirement, FunctionalGroup>
    {
        UserManager<SustainableChemistryWeb.Areas.Identity.Data.ApplicationUser> _userManager;

        public IsUserAuthorizationHandler(UserManager<SustainableChemistryWeb.Areas.Identity.Data.ApplicationUser>
            userManager)
        {
            _userManager = userManager;
        }

        protected override Task
            HandleRequirementAsync(AuthorizationHandlerContext context,
                                   OperationAuthorizationRequirement requirement,
                                   FunctionalGroup resource)
        {
            if (context.User == null || resource == null)
            {
                // Return Task.FromResult(0) if targeting a version of
                // .NET Framework older than 4.6:
                return Task.CompletedTask;
            }

            // If we're not asking for CRUD permission, return.

            if (requirement.Name != Constants.CreateOperationName &&
                requirement.Name != Constants.ReadOperationName &&
                requirement.Name != Constants.UpdateOperationName &&
                requirement.Name != Constants.DeleteOperationName)
            {
                return Task.CompletedTask;
            }

            if (context.User != null)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
