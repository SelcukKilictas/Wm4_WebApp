using ItServiceApp.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ItServiceApp.Models.Entities.Identity
{
    public class ApplicationUser:IdentityUser
    {
        [StringLength(50)]
        public string  Name { get; set; }
        
        [StringLength(250)]
        public string Surname { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;



    }
}
