using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngineerApi.Core.Contracts
{
    public interface IRepositoryWrapper
    {
        IEngineerRepository Engineer { get; }
    }
}
