using FluentValidation;

namespace CleanArchitectureDemo.Domain.Validator
{
    public class CustomerValidator : AbstractValidator<Customer.Customer>
    {
        public CustomerValidator()
        {
            RuleFor(r => r.Id)
                .NotNull()
                .NotEqual(new System.Guid());

            RuleFor(r => r.DocumentType)
                .IsInEnum();

            RuleFor(r => r.DocumentNumber)
                .NotNull()
                .NotEmpty()
                .MaximumLength(10);

            RuleFor(r => r.Name)
                .NotNull()
                .NotEmpty()
                .MaximumLength(200);

            RuleFor(r => r.Age)
                .NotNull()
                .InclusiveBetween(1,150)
                .GreaterThan(0);

            RuleFor(r => r.Email)
                .NotNull()
                .NotEmpty()
                .EmailAddress()
                .MaximumLength(100);
        }
    }
}
