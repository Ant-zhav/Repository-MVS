﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Complex742.Models.Equipments;

namespace Complex742.Data
{
    public class Complex742Context : DbContext
    {
        public Complex742Context()
            
        {
        }

        public Complex742Context (DbContextOptions<Complex742Context> options) : base(options)
        {
        }
        
        public DbSet<Complex742.Models.Equipments.Equipment>? Equipment { get; set; }
    }
}
