using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EngineerApi.Core.Models
{
    [Table("engineer")]
    public class Engineer : IEntity
    {
        [Key]
        [Column("EngineerId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Date created is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Date created is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date created is required")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Date created is required")]
        public string Email { get; set; }
        public string PhoneMovil { get; set; }
        public string Photo { get; set; }
    }
}
