using Ecommerce.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models.Adp
{
    public class Adaptor : ISql<Category>
    {
        bool ISql<Category>.Add()
        {
            
            
            //EKLEME
            return true;
        }

        bool ISql<Category>.Delete()
        {
            //SİLME
            return true;
        }

        List<Category> ISql<Category>.GetAll()
        {
            throw new NotImplementedException();
        }

        Category ISql<Category>.GetById(int Id)
        {
            throw new NotImplementedException();
        }

        bool ISql<Category>.Update()
        {
            throw new NotImplementedException();
        }
    }
}