using Microsoft.AspNetCore.Authorization.Infrastructure;

namespace Blog.Server.Authorization
{
    public class AuthorizationOperations
    {
        public static OperationAuthorizationRequirement Delete =
            new OperationAuthorizationRequirement { Name = Constants.DeleteOperationName };
    }

    public class Constants
    {
        public static readonly string DeleteOperationName = "Delete";
    }
}
