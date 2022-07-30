using Ecommerce.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Models.Interface
{
    internal interface ISql<T> where T : ModelBase
    {
        List<T> GetAll();
        T GetById(int Id);
        bool Add();
        bool Delete();
        bool Update();

    }
}
