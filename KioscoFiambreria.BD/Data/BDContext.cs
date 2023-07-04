using KioscoFiambreria.BD.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoFiambreria.BD.Data
    //Representacion de la base de datos
    {
    public class BDContext :DbContext
        {
        public DbSet<Stock> Productos { get; set; }

		public BDContext(DbContextOptions options) : base(options)
            {
            }
        }
    }
