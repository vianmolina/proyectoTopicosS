using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulatina.PruebaProyecto.Model
{
    public partial class EstudianteCurso
    {
        public string Resultado { get
        {
            string resultado = "Aplazado";
            if (Nota >= 70)
                resultado = "Aprobado";
            if (Nota < 60)
                resultado = "Reprobado";
            return resultado;
            }
        }
    }
}
