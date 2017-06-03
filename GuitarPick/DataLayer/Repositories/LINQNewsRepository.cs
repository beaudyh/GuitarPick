using GuitarPick.DataLayer.DataModels;
using GuitarPick.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Web;

namespace GuitarPick.DataLayer.Repositories
{
    public class LINQNewsRepository : INewsRepository
    {
        private GuitarPickNewsDBDataContext _DataContext = new GuitarPickNewsDBDataContext();
        public List<News> GetList()
        {
            List<News> newsList = new List<News>();
            ISingleResult<NewDO> newDOs = _DataContext.News_GetList();
            foreach (var n in newDOs)
            {
                News news = new News();
                news.ID = n.ID;
                news.Title = n.Title;
                news.Body = n.Body;
                news.Author = n.Author;
                news.DatePosted = n.DatePosted;
                newsList.Add(news);
            }
            return newsList;
        }
        public void Insert(News news)
        {
            if (news.ID == 0)
            {
                _DataContext.News_Insert(null, news.Title, news.Body, news.Author, news.DatePosted);
            }
        }
    }
}