using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.Fasades
{
    internal interface IUpdatable<T>
    {
        void Update(T updatableItem);
    }
}
