using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TvShow2.Data.Models;

namespace TvShow2.Web.Adapters.Interfaces
{
    public interface ITvShow
    {
        TvShow GetShow(int id);
        List<TvShow> GetShows();
        void CreateShow(TvShow show);
        void UpdateShow(int id, TvShow show);
        void Delete(int id);
    }
}
