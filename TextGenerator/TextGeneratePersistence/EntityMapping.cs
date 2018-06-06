using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextGeneratePersistence
{
    public class EntityMapping<T> : ClassMapping<T> where T : Entity
    {
        public EntityMapping()
        {
            Id(u => u.Id);
        }
    }
}
