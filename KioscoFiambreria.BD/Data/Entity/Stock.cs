using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoFiambreria.BD.Data.Entity
    {
    public class Stock
        {

        [Required]
        public int Id { get; set; }

        public string Producto { get; set; }

        public int Unidad { get; set; }

        }
    }
