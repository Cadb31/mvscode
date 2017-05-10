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
        Boolean consultar(Persona persona);
        Boolean consultarTodas();
        Boolean actualizar(Persona personaActual, Persona personaNueva);
        Boolean eliminar(Persona persona);
    }
}
