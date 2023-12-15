using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using System.Security.Claims;

namespace Blog.Server.Authorization
{
    public class OwnerAuthorizationHandler : AuthorizationHandler<OperationAuthorizationRequirement, IOwnerObject>
    {
        private readonly AuthenticationStateProvider _authenticationStateProvider;

        public OwnerAuthorizationHandler(AuthenticationStateProvider authenticationStateProvider)
        {
            _authenticationStateProvider = authenticationStateProvider;
        }
        protected override async Task<Task> HandleRequirementAsync(AuthorizationHandlerContext context,
            OperationAuthorizationRequirement requirement,
            IOwnerObject resource)
        {
            var state = await _authenticationStateProvider.GetAuthenticationStateAsync();

            if (state.User == null || resource == null)
            {
                return Task.CompletedTask;
            }

            if (requirement.Name != Constants.DeleteOperationName)
            {
                return Task.CompletedTask;
            }

            if (!state.User.Identities.First().Claims.Any())
            {
                return Task.CompletedTask;
            }

            var userId = state.User.Identities.First()
                .Claims.ElementAt(1).Value;

            if (resource.ObjectOwnerId == userId)
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}
