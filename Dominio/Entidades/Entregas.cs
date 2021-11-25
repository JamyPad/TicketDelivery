using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Entregas
    {
        public string Codigo { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Departamento { get; set; }
        public string CodigoDepartamento { get; set; }
        public string Empresa { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaEntrega { get; set; }
    }
}
