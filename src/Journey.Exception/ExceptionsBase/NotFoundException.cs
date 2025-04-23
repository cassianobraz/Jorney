using System.Net;

namespace Journey.Exception.ExceptionsBase;

public class NotFoundException : JourneyException
{
    public NotFoundException(string messsage) : base(messsage)
    {
    }

    public override HttpStatusCode GetStatusCode()
    {
        return HttpStatusCode.NotFound;
    }
}
