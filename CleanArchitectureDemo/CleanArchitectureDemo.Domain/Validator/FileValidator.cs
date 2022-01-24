using FluentValidation;
using System;

namespace CleanArchitectureDemo.Domain.Validator
{
    public class FileValidator : AbstractValidator<File.File>
    {
        public FileValidator()
        {
            RuleFor(r => r.Id)
                .NotNull()
                .NotEqual(new Guid());

            RuleFor(r => r.FileName)
                .NotEmpty()
                .NotNull()
                .MaximumLength(200);

            RuleFor(r => r.InclusionDate)
                .NotEqual(default(DateTime));

            RuleFor(r => r.Status)
                .IsInEnum();

            RuleFor(r => r.Type)
                .IsInEnum();

            When(w => w.IdParent != null, () =>
            {
                RuleFor(r => r.IdParent)
                    .NotNull()
                    .NotEqual(new Guid());
            });

            When(w => w.Logs.Count > 0, () =>
            {
                RuleFor(r => r.Logs)
                    .ForEach(log =>
                    {
                        log.SetValidator(new LogValidator());
                    });
            });
        }
    }
}
