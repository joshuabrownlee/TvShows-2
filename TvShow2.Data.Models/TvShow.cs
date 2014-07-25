using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TvShow2.Data.Models
{
    public class TvShow
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TvShow() { }
        public TvShow(string title, string description)
        {
            Title = title;
            Description = description;

        }
    }
}
