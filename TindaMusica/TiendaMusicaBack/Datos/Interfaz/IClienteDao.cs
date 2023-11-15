using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMusicaBack.Enitidades;

namespace TiendaMusicaBack.Datos.Interfaz
{
    public interface IClienteDao
    {
        bool CargarCliente(Cliente oCliente);
        List<Barrio> ConsultarBarrios();
    }
}
