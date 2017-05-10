using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasFormApp
{
    interface PersonaDao
    {
        Boolean insertar (Persona persona);
        List<Persona> consultar(Persona persona);
        List<Persona> consultarTodas();
        Boolean actualizar(Persona personaActual, Persona personaNueva);
        Boolean eliminar(Persona persona);
    }
}
