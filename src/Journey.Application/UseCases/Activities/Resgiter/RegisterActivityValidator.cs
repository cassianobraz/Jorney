using FluentValidation;
using Journey.Communication.Requests;
using Journey.Exception.ExceptionsBase;

namespace Journey.Application.UseCases.Activities.Resgiter;

public class RegisterActivityValidator : AbstractValidator<RequestRegisterActivityJson>
{
    public RegisterActivityValidator()
    {
        RuleFor(request => request.Name).NotEmpty().WithMessage(ResourceErrorMessages.NAME_EMPTY);
    }
}
