using Cibertec.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CibertecAPI.Models
{
    public class ProductoResponse
    {
        public IEnumerable<Producto> Items { get; set; }
    }
}
