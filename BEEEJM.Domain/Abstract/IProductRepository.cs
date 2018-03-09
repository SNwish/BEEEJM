using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BEEEJM.Domain.Entities;

namespace BEEEJM.Domain.Abstract
{
    interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
    }
}
