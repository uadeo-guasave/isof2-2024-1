using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvirGilbertoDatos
{
    internal class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Domicilio Domicilio { get; set; }
        public string Teléfono { get; set; }
        public string CorreoElectrónico { get; set; }
    }
}
