using EngineerApi.Core.Contracts;
using EngineerApi.Core.Entities.Extensions;
using EngineerApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EngineerApi.Core.Repository
{
    public class EngineerRepository : RepositoryBase<Engineer>, IEngineerRepository
    {
        public EngineerRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Engineer> GetAllEngineers()
        {
            return FindAll()
                .OrderBy(engineer => engineer.FirstName);
        }

        public Engineer GetEngineerById(Guid engineerId)
        {
            return FindByCondition(engineer => engineer.Id.Equals(engineerId))
                .DefaultIfEmpty(new Engineer())
                .FirstOrDefault();
        }

        public void CreateEngineer(Engineer engineer)
        {
            engineer.Id = Guid.NewGuid();
            Create(engineer);
            Save();
        }

        public void UpdateEngineer(Engineer dbEngineer, Engineer engineer)
        {
            dbEngineer.Map(engineer);
            Update(dbEngineer);
            Save();
        }

        public void DeleteEngineer(Engineer engineer)
        {
            Delete(engineer);
            Save();
        }
    }
}
