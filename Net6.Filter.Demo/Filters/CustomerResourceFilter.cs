using Microsoft.AspNetCore.Mvc.Filters;

namespace Net6.Filter.Demo.Filters;

public class CustomerResourceFilter : Attribute,IResourceFilter
{
    /// <summary>
    /// 执行资源过滤器。在执行管道的其余部分后调用。
    /// </summary>
    /// <param name="context"></param>
    public void OnResourceExecuted(ResourceExecutedContext context)
    {
        Console.WriteLine("OnResourceExecuted");
    }
    /// <summary>
    /// 执行资源筛选器。 在执行管道的其余部分之前调用。
    /// </summary>
    /// <param name="context"></param>
    public void OnResourceExecuting(ResourceExecutingContext context)
    {
        Console.WriteLine("OnResourceExecuting");
    }
}
