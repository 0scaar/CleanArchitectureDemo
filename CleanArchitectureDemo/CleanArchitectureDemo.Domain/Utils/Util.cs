using System;
using System.Linq;

namespace CleanArchitectureDemo.Domain.Utils
{
    public static class Util
    {
        public static string GetLastNameSpace(this Type type) => type.Namespace.Split('.').ToList().Last();
    }
}
