using FluentValidation;

namespace CleanArchitectureDemo.Domain.Validator
{
    public class CustomerValidator : AbstractValidator<Customer.Customer>
    {
        public CustomerValidator()
        {

        }
    }
}
