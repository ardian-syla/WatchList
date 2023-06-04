using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult GetPopularMovies()
        {
            string url = "https://api.themoviedb.org/3/movie/popular?language=en-US&page=1";
            string apiKey = "eyJhbGciOiJIUzI1NiJ9.eyJhdWQiOiIxYjUzODhiMGRiYWE0MzJkOGI2MTEzZDU1ODNlZWI5YSIsInN1YiI6IjY0N2NjOGQ1MjYzNDYyMDExNjYxOWYyOSIsInNjb3BlcyI6WyJhcGlfcmVhZCJdLCJ2ZXJzaW9uIjoxfQ.5IQedaLleYq_n90jh5g0UfWMhz3uhSbbjFjt49nWQNE";

            using (WebClient client = new WebClient())
            {
                client.Headers.Add("Accept", "application/json");
                client.Headers.Add("Authorization", "Bearer " + apiKey);

                string json = client.DownloadString(url);

                return Content(json, "application/json");
            }
        }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}