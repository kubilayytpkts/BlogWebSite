﻿using BlogWebSite.DataAccess.EntityFramework;
using BlogWebSite_BussinessLayer.Manager;
using BlogWebSite_Entity;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebSite.ViewComponents.About
{
	public class AboutComponent : ViewComponent
	{
		AboutManager aboutManager = new AboutManager(new EfAboutRepository());
		public IViewComponentResult Invoke()
		{
			var mainAboutvalue = aboutManager.GetById(13);

			ViewBag.aboutValue = new List<AboutModel> { mainAboutvalue };

			var articleValue = aboutManager.GetById(14);

			if(articleValue.AboutText != null && articleValue.AboutTitle !=null && articleValue.Status !=false ) 
			{
				ViewBag.aboutValue1 = new List<AboutModel> { articleValue};
			}

			return View();
		}
	}
}
