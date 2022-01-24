﻿using System;

namespace CleanArchitectureDemo.Application.UseCases.Customer.Get
{
    public class CustomerGetRequest : RequestBase
    {
        public Guid Id { get; private set; }

        public CustomerGetRequest(Guid id)
        {
            Id = id;
        }

        
    }
}
