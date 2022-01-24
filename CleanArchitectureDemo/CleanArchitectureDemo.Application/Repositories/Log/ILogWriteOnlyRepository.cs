using System.Collections.Generic;

namespace CleanArchitectureDemo.Application.Repositories.Log
{
    public interface ILogWriteOnlyRepository
    {
        int Add(Domain.Log.Log log);

        void Add(List<Domain.Log.Log> logs);
    }
}
