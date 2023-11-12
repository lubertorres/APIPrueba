using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class ManejadorExcepciones : IExceptionFilter
{
    public void OnException(ExceptionContext context)
    {
        // Logica para manejar la excepción
        context.Result = new ObjectResult(new { error = "Ocurrió un error" })
        {
            StatusCode = 500
        };
        context.ExceptionHandled = true;
    }
}
