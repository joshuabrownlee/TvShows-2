using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TvShow2.Data.Models;
using TvShow2.Web.Adapters;
using TvShow2.Web.Adapters.Interfaces;
using TvShow2.Web.Models;

namespace TvShow2.Web.Controllers
{
    public class apiTvShowController : ApiController
    {
        private ITvShow _adapter;
        public apiTvShowController()
        {
            _adapter = new TvShowAdapter();
        }
        [HttpGet]
        public IHttpActionResult Get(int id = -1)
        {
            if (id == -1)
            {
                return Ok(_adapter.GetShows());
            }
            else
            {
                return Ok(_adapter.GetShow(id));
            }
           
        }
        [HttpPost]
        public IHttpActionResult Post(TvShow show)
        {
            _adapter.CreateShow(show);
            return Ok();
        }
        [HttpPut]
        public IHttpActionResult Put(int id, TvShow show)
        {
            _adapter.UpdateShow(id, show);
            return Ok();
        }
        [HttpDelete]
        public IHttpActionResult Delete(DeleteShowVM VM)
        {
            _adapter.Delete(VM.Id);
            return Ok();
        }
    }

}
