using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASSESSMENT1PHASE3.Models;

namespace ASSESSMENT1PHASE3.Data
{
    public class DeptMasterContext : DbContext
    {
       
        public DeptMasterContext (DbContextOptions<DeptMasterContext> options)
            : base(options)
        {
        }

        public DbSet<ASSESSMENT1PHASE3.Models.DeptMaster> DeptMaster { get; set; } = default!;
    }
}
