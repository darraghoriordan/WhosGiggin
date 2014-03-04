using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WhosGiggin.Models
{
    public class HomepageViewModel
    {
        public IEnumerable<EventModel> Events { get; set; }
    }
}