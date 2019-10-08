using EngineerApi.Core.Entities.ExtendedModels;
using EngineerApi.Core.Models;
using System;
using System.Collections.Generic;
namespace EngineerApi.Core.Contracts
{
    public interface IEngineerRepository : IRepositoryBase<Engineer>
    {
        IEnumerable<Engineer> GetAllEngineers();
        Engineer GetEngineerById(Guid engineerId);
        void CreateEngineer(Engineer engineer);
        void UpdateEngineer(Engineer dbEngineer, Engineer engineer);
        void DeleteEngineer(Engineer engineer);
    }
}
