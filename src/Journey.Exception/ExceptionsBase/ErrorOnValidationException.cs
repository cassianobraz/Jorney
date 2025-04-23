using System.Net;

namespace Journey.Exception.ExceptionsBase;

public class ErrorOnValidationException : JourneyException
{
    public ErrorOnValidationException(string messsage) : base(messsage)
    {
    }

    public override HttpStatusCode GetStatusCode()
    {
        return HttpStatusCode.BadRequest;
    }
}
