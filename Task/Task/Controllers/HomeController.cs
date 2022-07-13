using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Task.DAL;
using Task.Models;
using Task.ViewModels;

namespace Task.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public ActionResult Blog()
        {
            List<Blog> blogs = _context.Blogs.Include(x => x.Comments).Include(x=>x.Author).ToList();
            return View(blogs);
        }
        public ActionResult Detail(int? id)
        {
            if (id==null || id==0)
            {
                return NotFound();
            }
            HomeVM homeVM=new HomeVM
            {
                Blog=_context.Blogs.Include(x=>x.Comments).Include(x=>x.Tags).Include(x=>x.Author).FirstOrDefault(x=>x.Id==id),
                Blogs=_context.Blogs.Where(x=>x.Id!=id).Include(x => x.Comments).Include(x => x.Tags).ToList(),
                Tags=_context.Tags.ToList()
            };
            if (homeVM.Blog==null)
            {
                return NotFound();
            }
            return View(homeVM);
        }
    }
}
