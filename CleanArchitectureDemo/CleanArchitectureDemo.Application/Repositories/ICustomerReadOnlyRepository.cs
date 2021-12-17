using CleanArchitectureDemo.Domain.Customer;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CleanArchitectureDemo.Application.Repositories
{
    public interface ICustomerReadOnlyRepository
    {
        Customer GetById(Guid id);
        IList<Customer> GetByFilter(Expression<Func<Customer, bool>> filter);
        IList<Customer> GetAll();
    }
}
