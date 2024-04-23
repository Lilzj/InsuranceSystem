using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Application.Exceptions
{
    public class ValidationExceptions : ApplicationException
    {
        public ValidationExceptions(IReadOnlyDictionary<string, string[]> errorsDictionary)
                : base("Validation Failure", "One or more validation errors occurred")
                 => ErrorsDictionary = errorsDictionary;

        public IReadOnlyDictionary<string, string[]> ErrorsDictionary { get; }
    }
}
