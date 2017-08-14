using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulatina.Topicos.GenericRepository.Model
{
    public interface IModifiableEntity
    {
        string _Name { get; set; }
    }
}
