﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicLibrary.Persistance.Entities
{
    public class Role : BaseEntity<Guid>
    {
        public string Name { get; set; }
        
        public virtual IEnumerable<User> Users { get; set; }

    }
}