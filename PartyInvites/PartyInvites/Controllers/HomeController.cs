﻿using System;
using System.Web.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ViewResult Index()
        {
	        var hour = DateTime.Now.Hour;
	        ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
	        return View();
        }

		[HttpGet]
		public ViewResult RsvpForm()
		{
			return View();
		}

		[HttpPost]
		public ViewResult RsvpForm(GuestResponse guestResponse)
		{
			if (ModelState.IsValid)
			{
				// TODO: Email response to the party organizer
				return View("Thanks", guestResponse); 
			}
			else
			{
				// There is a validate error
				return View();
			}
		}
    }
}
