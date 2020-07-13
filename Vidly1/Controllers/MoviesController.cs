using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly1.Models;
using Vidly1.ViewModels;

namespace Vidly1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies


        /*The name of this type of method is action result (result of our action) but we are 
         actually returning a view which is inherited from the controller class*/

        public ActionResult Random() //changed from Index to Random
        {
            //creating instance of model
            var movie = new Movie() { Name = "Shrek!" };

            var customers = new List<Customer> {

                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}

            };
            //view model object
            var viewModel = new RandomMovieViewModel {
                
                Movie = movie,
                Customers = customers
            };

           
            return View(viewModel);
        }


        /*

       //return RedirectToAction("NameOfAction","ControllerNmae","AnonymousObjectForPassing");
       // return View(movie); //puts movie model in our view to render it
       //return Content("Hi");
       // return HttpNotFound();

   }

   public ActionResult Edit(int id) {

       return Content("id=" + id);
   }


   public ActionResult Index(int? pageIndex, string sortBy)
   {
       if (!pageIndex.HasValue) {
           pageIndex = 1;
       }

       if (String.IsNullOrWhiteSpace(sortBy)) {
           sortBy = "Name";
       }

       return Content(string.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy ));
   }



   //attribute routes
   [Route("movies/released/{year}/{month:regex(\\d{4}:range(1,12))}")]
   public ActionResult ByRealeaseDate(int year, byte month) {
       return Content(year + "/" + month);
   }

   */



    }
}

/*
 
He seems to have glossed over something. In your MoviesController.cs remember to return the model in the view like so:
// GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!", Id = 1};
            return View(movie);// NOT just View()
        }
Otherwise, you will get a null exception when trying to access the model's properties.
 
 */
