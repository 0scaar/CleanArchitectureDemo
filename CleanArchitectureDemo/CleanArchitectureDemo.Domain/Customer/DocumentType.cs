using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace CleanArchitectureDemo.Domain.Customer
{
    public enum DocumentType
    {
        [EnumMember(Value = "PASSPORT")]
        Passport = 1,

        [EnumMember(Value = "NID")]
        NationalIdentityDocument = 2,

        [EnumMember(Value = "IC")]
        ImmigrationCard = 3
    }
}
