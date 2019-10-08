using EngineerApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngineerApi.Core.Entities.Extensions
{
    public static class EngineerExtensions
    {
        public static void Map(this Engineer dbEngineer, Engineer engineer)
        {
            dbEngineer.FirstName = engineer.FirstName;
            dbEngineer.LastName = engineer.LastName;
            dbEngineer.Address = engineer.Address;
            dbEngineer.Email = engineer.Email;
            dbEngineer.PhoneMovil = engineer.PhoneMovil;
            dbEngineer.Photo = engineer.Photo;
        }
    }
}
