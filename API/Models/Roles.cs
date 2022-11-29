using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    public class Roles
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int AppUser { get; set; }
    
        
    }
}
