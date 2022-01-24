using FluentValidation;
using System;

namespace CleanArchitectureDemo.Domain.Validator
{
    public class LogValidator : AbstractValidator<Log.Log>
    {
        public LogValidator()
        {
            RuleFor(r => r.Id)
                .NotNull()
                .NotEqual(new Guid());

            RuleFor(r => r.Service)
                .NotNull()
                .NotEmpty()
                .MaximumLength(50);

            RuleFor(r => r.Message)
                .NotNull()
                .NotEmpty()
                .MaximumLength(400);

            RuleFor(r => r.DateLog)
                .NotEqual(default(DateTime));

            RuleFor(r => r.TypeLog)
                .IsInEnum();

            When(w => !string.IsNullOrEmpty(w.StackTrace), () =>
            {
                RuleFor(r => r.StackTrace)
                    .NotNull()
                    .NotEmpty()
                    .MaximumLength(3000);
            });

            When(w => w.FileId != null, () =>
            {
                RuleFor(r => r.FileId)
                    .NotEqual(new Guid());
            });

            When(w => w.LogDetails.Count > 0, () =>
            {
                RuleFor(r => r.LogDetails)
                    .ForEach(log =>
                    {
                        log.SetValidator(new LogDetailValidator());
                    });
            });
        }
    }
}
