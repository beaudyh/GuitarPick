using GuitarPick.DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarPick.DataLayer.Interfaces
{
    interface IProductRepository
    {
        Product Get(int id);
        List<Product> GetList();
        void Save(Product product);
    }
}