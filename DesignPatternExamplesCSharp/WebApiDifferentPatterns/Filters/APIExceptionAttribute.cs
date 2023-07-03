using Microsoft.AspNetCore.Mvc.Filters;
using WebApiDifferentPatterns.Logger;

namespace WebApiDifferentPatterns.Filters;

public class APIExceptionAttribute : ExceptionFilterAttribute
{
    private ILog _ILog;
    
    public APIExceptionAttribute()
    {
        _ILog = Log.GetInstance();
    }
    
    public override void OnException(ExceptionContext context)
    {
        _ILog.LogException(context.Exception.ToString());
        //Then set that the Exception is Handled
        context.ExceptionHandled = true;

        base.OnException(context);
    }
}