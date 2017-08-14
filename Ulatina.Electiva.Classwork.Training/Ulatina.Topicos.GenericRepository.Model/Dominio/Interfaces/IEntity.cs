using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ulatina.Topicos.GenericRepository.Model
{
    public interface IEntity : IModifiableEntity
    {
        object _Id { get; set; }
        DateTime _CreatedDate { get; set; }
        DateTime? _ModifiedDate { get; set; }
        string _CreatedBy { get; set; }
        string _ModifiedBy { get; set; }
        byte[] _Version { get; set; }
    }

    public interface IEntity<T> : IEntity
    {
        new T _Id { get; set; }
    }
}
