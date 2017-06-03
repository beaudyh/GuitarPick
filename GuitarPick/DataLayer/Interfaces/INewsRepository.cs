using GuitarPick.DataLayer.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarPick.DataLayer.Interfaces
{
    interface INewsRepository
    {
        List<News> GetList();
        void Insert(News news);
    }
}
