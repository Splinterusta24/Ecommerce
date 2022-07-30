using Ecommerce.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.Models
{
    public class Category:ModelBase
    {
        public string Name { get; set; } = ""; //ctorda da default değer atıyoruz.

    }
}