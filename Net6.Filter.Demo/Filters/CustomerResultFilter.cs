using Microsoft.AspNetCore.Mvc.Filters;

namespace Net6.Filter.Demo.Filters;

public class CustomerResultFilter : ResultFilterAttribute
{
    public override void OnResultExecuted(Microsoft.AspNetCore.Mvc.Filters.ResultExecutedContext context) {
        Console.WriteLine("OnResultExecuted");
    }

    public override void OnResultExecuting(Microsoft.AspNetCore.Mvc.Filters.ResultExecutingContext context) {
        Console.WriteLine("OnResultExecuting");
    }

}
