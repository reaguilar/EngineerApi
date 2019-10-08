using EngineerApi.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EngineerApi.Core.Entities.ExtendedModels
{
    public class EngineerExtended : IEntity
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }
        public string PhoneMovil { get; set; }
        public string Photo { get; set; }
       
        public EngineerExtended()
        {
        }

        public EngineerExtended(Engineer engineer)
        {
            Id = engineer.Id;
            FirstName = engineer.FirstName;
            LastName = engineer.LastName;
            Address = engineer.Address;
            Email = engineer.Email;
            PhoneMovil = engineer.PhoneMovil;
            Photo = engineer.Photo;
        }
    }
}
