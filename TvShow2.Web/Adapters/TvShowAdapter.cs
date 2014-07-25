using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TvShow2.Data;
using TvShow2.Data.Models;
using TvShow2.Web.Adapters.Interfaces;

namespace TvShow2.Web.Adapters
{
    public class TvShowAdapter: ITvShow
    {
        public TvShow GetShow(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            TvShow Show = Db.TvShows.Where(s => s.Id == id).FirstOrDefault();
            return Show;
        }

        public List<TvShow> GetShows()
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            List<TvShow> TvShows = Db.TvShows.ToList();
                return TvShows;
        }

        public void CreateShow(TvShow show)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            Db.TvShows.Add(show);
            Db.SaveChanges();
        }

        public void UpdateShow(int id, TvShow show)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            TvShow Show = Db.TvShows.Where(s => s.Id == id).FirstOrDefault();
            Show.Title = show.Title;
            Show.Description = show.Description;
            Db.SaveChanges();
        }

        public void Delete(int id)
        {
            ApplicationDbContext Db = new ApplicationDbContext();
            TvShow Show = Db.TvShows.Where(s => s.Id == id).FirstOrDefault();
            Db.TvShows.Remove(Show);
            Db.SaveChanges();
        }
    }
}