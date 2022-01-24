using CleanArchitectureDemo.Domain.Log;
using FluentValidation;
using System;

namespace CleanArchitectureDemo.Domain.Validator
{
    public class LogDetailValidator : AbstractValidator<LogDetail>
    {
        public LogDetailValidator()
        {
            RuleFor(r => r.Id)
                .NotNull()
                .NotEqual(new Guid());

            RuleFor(r => r.Line)
                .NotNull()
                .NotEmpty()
                .MaximumLength(2000);

            RuleFor(r => r.Message)
                .NotNull()
                .NotEmpty()
                .MaximumLength(20);
        }
    }
}
