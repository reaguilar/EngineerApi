using EngineerApi.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngineerApi.Core.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private RepositoryContext _repoContext;
        private IEngineerRepository _engineer;

        public IEngineerRepository Engineer
        {
            get
            {
                if (_engineer == null)
                {
                    _engineer = new EngineerRepository(_repoContext);
                }

                return _engineer;
            }
        }

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repoContext = repositoryContext;
        }
    }
}

