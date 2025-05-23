﻿using System.Net;

namespace Journey.Exception.ExceptionsBase;

public class ErrorOnValidationException : JourneyException
{
    private readonly IList<string> _errors;
    public ErrorOnValidationException(IList<string> messsages) : base(string.Empty)
    {
        _errors = messsages;
    }

    public override IList<string> GetErrorMessages()
    {
        return _errors;
    }

    public override HttpStatusCode GetStatusCode()
    {
        return HttpStatusCode.BadRequest;
    }
}
