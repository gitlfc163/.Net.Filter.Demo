using Microsoft.AspNetCore.Mvc.Filters;

namespace Net6.Filter.Demo.Filters;

public class CustomerExceptionFilter : ExceptionFilterAttribute
{
    public void OnException(ExceptionContext context)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("发生了异常：{0}", context.Exception.Message);
        Console.ForegroundColor = ConsoleColor.Gray;
    }
}
