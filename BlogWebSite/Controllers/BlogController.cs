﻿using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.Controllers
{
    public class BlogController : Controller
    {
        BlogManager blogManager = new BlogManager(new EfBlogRepository()); 
        public IActionResult Index()
        {
                List<BlogModel> blogList=new List<BlogModel>();

            var resultBlog = blogManager.ListAll().Where(x=>x.Status==true);
            foreach (var item in resultBlog)
            {
                item.BlogDescription = GetPreview(item.BlogDescription, 30);
                blogList.Add(item);
            }

            ViewBag.blogValue=blogList;

            return View();
        }
        public IActionResult GetByBlogId(int id)
        {
            var resultBlog=blogManager.ListAll().Where(x=>x.BlogID==id).ToList();


            ViewBag.blogId = id;
            return View(resultBlog);
        }

        public IActionResult GetLatestBlog()
        {
            return View();
        }

        //Blog açıklama yazısının bir kısmını verir 
        public string GetPreview(string description,int wordCount )
        {
			if (string.IsNullOrEmpty(description))
            {
                return description;
            };

			var words = description.Split(' ');

			if (words.Length <= wordCount)
                return description;

           description = string.Join(" ", words.Take(wordCount)) + "...";

            return description;
        }

    }
}
