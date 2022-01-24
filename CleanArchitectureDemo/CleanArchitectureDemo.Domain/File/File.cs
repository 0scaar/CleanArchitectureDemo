using CleanArchitectureDemo.Domain.File.Enum;
using System;
using System.Collections.Generic;

namespace CleanArchitectureDemo.Domain.File
{
    public class File : Entity
    {
        public File(Guid id, string fileName, DateTime inclusionDate, TypeRegister type)
        {
            Id = id;
            FileName = fileName;
            InclusionDate = inclusionDate;
            Type = type;
        }

        public Guid? IdParent { get; private set; }
        public string FileName { get; private set; }
        public DateTime InclusionDate { get; private set; }
        public Status Status { get; private set; }
        public TypeRegister Type { get; private set; }
        public List<Log.Log> Logs { get; set; }

        public void SetStatus(Status status)
            => Status = status;
    }
}
