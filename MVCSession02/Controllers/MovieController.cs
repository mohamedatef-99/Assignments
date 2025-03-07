using Microsoft.AspNetCore.Mvc;
using MVCSession02.Models;

namespace MVCSession02.Controllers
{
    public class MovieController : Controller
    {
        // Actions: Public non-static method
        // Actions: Have special return types
        //public ContentResult GetMovie(int id)
        //{
        //    var contentResult = new ContentResult()
        //    {
        //        Content = $"Get Movie Wit Id: {id}",
        //        ContentType = "text/html",
        //        StatusCode = 200
        //    };
        //    return contentResult;
        //}

        //public RedirectResult GetMovie(int id)
        //{
        //    var redirectResult = new RedirectResult("https://google.com");
        //    return redirectResult;
        //}

        //public RedirectToActionResult GetMovie(int id)
        //{
        //    var redirectToActionResult = new RedirectToActionResult("AddMovie","Movie", id);
        //    return redirectToActionResult;
        //}

        //[ActionName("GetMovie")]
        //[HttpGet]
        //public IActionResult GetMovieByIdWithCategoryDramaAndPoster(int id)
        //{
        //    if (id == 1)
        //    {
        //        //return new ContentResult() { Content = $"Get Movie Wit Id: {id}", ContentType = "text/html" };
        //        return Content($"Get Movie Wit Id: {id}", "text/html");
        //    } else if (id == 2)
        //    {
        //        //return new ContentResult() { Content = $"Get Movie Wit Id: {id}", ContentType = "object/pdf" };
        //        return Content($"Get Movie Wit Id: {id}", "object/pdf");
        //    }
        //    else if(id == 3) { 
        //        //return new RedirectResult("https://google.com");
        //        return Redirect("https://google.com");
        //    }
        //    else
        //    {
        //        //return new RedirectToActionResult("AddMovie", "Movie", new { id = 133 });
        //        return RedirectToAction("AddMovie", "Movie", new { id = 133 });
        //    }
        //}

        //public string AddMovie(int id)
        //{
        //    return $"Add Movie Wit Id: {id}";
        //}

        // Actions Parameter Binding
        // 1. Form
        // 2. Segment
        // 3. Query Param
        // 4. Files

        //public IActionResult GetMovie(Movie movie)
        //{
        //    return Content($"Get Movie Wit Id: {movie.Id}, Name: {movie.Name}", "text/html");
        //}
    }
}
