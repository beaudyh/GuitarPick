using GuitarPick.DataLayer.DataModels;
using GuitarPick.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuitarPick.DataLayer.Repositories
{
    public class LINQConctactRepository : IContactRepository
    {
        private GuitarPickContactDBDataContext _DataContext = new GuitarPickContactDBDataContext();

        public void Insert(Contact contact)
        {
            if (contact.ContactID == 0)
            {
                _DataContext.Contact_Insert(null, contact.Email, contact.Message, contact.Name);
            }
        }
    }
}