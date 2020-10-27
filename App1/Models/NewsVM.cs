using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App1.Models
{
    public static class NewsVM
    {
        public static List<News> data = new List<News>()
        {
            new News()
            {
                Id=1,
                Title="title1",
                Description="description1",
                Tumb="1.png"
            },
            new News()
            {
                Id=2,
                Title="title2",
                Description="description2",
                Tumb="2.png"
            },
            new News()
            {
                Id=3,
                Title="title3",
                Description="description3",
                Tumb="3.png"
            },
        };
    }
}
