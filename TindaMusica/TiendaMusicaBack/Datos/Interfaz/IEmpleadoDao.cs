using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMusicaBack.Enitidades;

namespace TiendaMusicaBack.Datos.Interfaz
{
    public interface IEmpleadoDao
    {
        bool CargarEmpleado(Empleado oEmpleado);
        List<Puesto> ConsultarPuestos();
        List<Sede> ConsultarSedes();
    }
}
