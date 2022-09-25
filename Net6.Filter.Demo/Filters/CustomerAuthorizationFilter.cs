using Microsoft.AspNetCore.Mvc.Filters;

namespace Net6.Filter.Demo.Filters;

public class CustomerAuthorizationFilter : Attribute, IAuthorizationFilter
{
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        Console.WriteLine("OnAuthorization");
    }
}
