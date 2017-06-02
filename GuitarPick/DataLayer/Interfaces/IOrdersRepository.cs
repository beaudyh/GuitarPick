using GuitarPick.DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarPick.DataLayer.Interfaces
{
    interface IOrdersRepository
    {
        Orders Get(string username);

        void SaveOrders(Orders orders);
    }
}
