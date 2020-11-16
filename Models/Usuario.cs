using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace NotasIdentity.Models
{
    public class Usuario : IdentityUser
    {        
        public List<Nota> Notas { get; set; }
    }
}