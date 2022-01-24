using CleanArchitectureDemo.Application.Repositories;
using CleanArchitectureDemo.Application.UseCases.Customer.Get;
using CleanArchitectureDemo.Domain.Log.Enum;
using CleanArchitectureDemo.Tests.Builders;
using CleanArchitectureDemo.Tests.TestCaseOrdering;
using FluentAssertions;
using System;
using System.Linq;
using Xunit;
using Xunit.Frameworks.Autofac;

namespace CleanArchitectureDemo.Tests.Cases.Application.Customer.Get
{
    [UseAutofacTestFramework]
    [TestCaseOrderer("CleanArchitectureDemo.Tests.TestCaseOrdering.PriorityOrderer", "CleanArchitectureDemo.Tests")]
    public class CustomerGetUseCaseTests
    {
        private readonly ICustomerGetUseCase customerGetUseCase;
        private readonly ICustomerWriteOnlyRepository customerWriteOnlyRepository;
        private static Guid CustomerId;

        public CustomerGetUseCaseTests(
            ICustomerGetUseCase customerGetUseCase,
            ICustomerWriteOnlyRepository customerWriteOnlyRepository)
        {
            this.customerGetUseCase = customerGetUseCase;
            this.customerWriteOnlyRepository = customerWriteOnlyRepository;
        }

        [Fact]
        [TestPriority(0)]
        public void ShouldAddSomeCustomer()
        {
            var model = CustomerBuilder.New().Build();
            CustomerId = model.Id;

            var ret = customerWriteOnlyRepository.Add(model);
            ret.Should().Be(1);
        }

        [Fact]
        [TestPriority(1)]
        public void ShoudGetCustomerById()
        {
            var request = new CustomerGetRequest(CustomerId);
            customerGetUseCase.Execute(request);

            request.Logs.Any(a => a.TypeLog == TypeLog.Error || a.TypeLog == TypeLog.NotFound)
                .Should()
                .BeFalse();
        }

        [Fact]
        [TestPriority(2)]
        public void ShouldNotGetCustomerById()
        {
            var request = new CustomerGetRequest(Guid.NewGuid());
            customerGetUseCase.Execute(request);

            request.Logs.Any(a => a.TypeLog == TypeLog.NotFound)
                .Should()
                .BeTrue();
        }
    }
}
