using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace Ulatina.Topicos.GenericRepository.Model
{
    [DataContract]
    public abstract class Entity<T> : IEntity<T>
    {
        [DataMember]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public T _Id { get; set; }

        [DataMember]
        object IEntity._Id
        {
            get { return this._Id; }
            set { this._Id = (T)Convert.ChangeType(value, typeof(T)); }
        }

        [DataMember]
        public string _Name { get; set; }

        [DataMember]
        private DateTime? createdDate;

        [DataMember]
        [DataType(DataType.DateTime)]
        public DateTime _CreatedDate
        {
            get { return createdDate ?? DateTime.UtcNow; }
            set { createdDate = value; }
        }

        [DataMember]
        [DataType(DataType.DateTime)]
        public DateTime? _ModifiedDate { get; set; }

        [DataMember]
        public string _CreatedBy { get; set; }

        [DataMember]
        public string _ModifiedBy { get; set; }

        [DataMember]
        [Timestamp]
        public byte[] _Version { get; set; }
    }
}