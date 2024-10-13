using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication051024_Books.Data;
using WebApplication051024_Books.Models;

namespace WebApplication051024_Books.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(StaticData.Books);
        }

        public IActionResult Details(int id)
        {
            var book = StaticData.Books.FirstOrDefault(b => b.Id == id);
            if (book == null)
                return NotFound();

            return View(book);
        }

        [HttpPost]
        public IActionResult AddComment(int bookId, string text)
        {
            var book = StaticData.Books.FirstOrDefault(b => b.Id == bookId);
            if (book == null)
                return NotFound();

            var newCommentId = StaticData.Books.SelectMany(b => b.Comments).Max(c => c.Id) + 1;
            var comment = new Comment { Id = newCommentId, BookId = bookId, Text = text };
            book.Comments.Add(comment);

            return RedirectToAction(nameof(Details), new { id = bookId });
        }
    }
}
