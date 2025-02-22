using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Warehouse.Fasades
{
    internal interface IDataFacade<T>
    {
        List<T> SelectAll();

        T GetById(int id);

        void Insert(T insertableItem);
        void Delete(int deletableItemId);
    }
}
