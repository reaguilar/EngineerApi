using EngineerApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngineerApi.Core.Entities.Extensions
{
    public static class IEntityExtensions
    {

        public static bool IsObjectNull(this IEntity entity)
        {
            return entity == null;
        }

        public static bool IsEmptyObject(this IEntity entity)
        {
            return entity.Id.Equals(Guid.Empty);
        }
    }
}
