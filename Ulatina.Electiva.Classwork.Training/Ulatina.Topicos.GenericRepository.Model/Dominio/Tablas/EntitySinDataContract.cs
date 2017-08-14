using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ulatina.Topicos.GenericRepository.Model
{
    public abstract class EntitySinDataContract<T> : IEntity<T>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T _Id { get; set; }
        object IEntity._Id
        {
            get { return this._Id; }
            set { this._Id = (T)Convert.ChangeType(value, typeof(T)); }
        }

        public string _Name { get; set; }

        private DateTime? createdDate;
        [DataType(DataType.DateTime)]
        public DateTime _CreatedDate
        {
            get { return createdDate ?? DateTime.UtcNow; }
            set { createdDate = value; }
        }

        [DataType(DataType.DateTime)]
        public DateTime? _ModifiedDate { get; set; }

        public string _CreatedBy { get; set; }

        public string _ModifiedBy { get; set; }

        [Timestamp]
        public byte[] _Version { get; set; }
    }
}