using FluentValidation;
using FluentValidation.Results;
using System;

namespace CleanArchitectureDemo.Domain.Validator
{
    public abstract class Validator<TEntity, TValidator> 
        where TEntity: class 
        where TValidator : AbstractValidator<TEntity>
    {
        public ValidationResult Validate(TEntity entity)
            => GetValidator().Validate(entity);

        public AbstractValidator<TEntity> GetValidator() 
            => Activator.CreateInstance<TValidator>();
    }
}
