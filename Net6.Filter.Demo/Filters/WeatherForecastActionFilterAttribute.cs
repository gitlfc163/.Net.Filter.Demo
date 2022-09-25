using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Text.Json;

namespace Net6.Filter.Demo.Filters;

/// <summary>
/// WeatherForecast的 Action Filter
/// </summary>
public class WeatherForecastActionFilterAttribute:ActionFilterAttribute
{
    /// <summary>
    /// Action方法调用之前执行
    /// </summary>
    /// <param name="context"></param>
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var descriptor = context.ActionDescriptor as ControllerActionDescriptor;

        string param = string.Empty;
        string globalParam = string.Empty;

        foreach (var arg in context.ActionArguments)
        {
            string value = JsonSerializer.Serialize(arg.Value);
            param += $"{arg.Key} : {value} \r\n";
            globalParam += value;
        }
        Console.WriteLine("OnActionExecuting,Action 方法调用之前执行");
        //Console.WriteLine($"webapi方法名称:【{descriptor.ActionName}】接收到参数为：{param}");
    }
    /// <summary>
    /// Action 方法调用后，Result 方法调用前执行
    /// </summary>
    /// <param name="context"></param>
    public override void OnActionExecuted(ActionExecutedContext context) {
        Console.WriteLine("OnActionExecuted,Action 方法调用后，Result 方法调用前执行");
    }
    /// <summary>
    /// Result 方法调用前执行
    /// </summary>
    /// <param name="context"></param>
    public override void OnResultExecuting(ResultExecutingContext context) {
        Console.WriteLine("OnResultExecuting,Result 方法调用前执行");
    }
    /// <summary>
    /// Result 方法调用后执行
    /// </summary>
    /// <param name="context"></param>
    public override void OnResultExecuted(ResultExecutedContext context)
    {
        var descriptor = context.ActionDescriptor as ControllerActionDescriptor;

        string result = string.Empty;
        if (context.Result is ObjectResult)
        {
            result = JsonSerializer.Serialize(((ObjectResult)context.Result).Value);
        }
        Console.WriteLine("OnResultExecuted,Result 方法调用后执行");
        //Console.WriteLine($"webapi方法名称【{descriptor.ActionName}】执行的返回值 :  {result}");
    }
}
