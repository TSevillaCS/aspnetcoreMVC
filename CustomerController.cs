using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCapp.Controllers
{
	public class CustomerController : Controller
	{
		private StoreContext storeContext;
		
		public CustomerController(CustomerContext customerObject)
		{
			storeContext = customerObject;
		}
		
		public IActionResult Index()
		{
			return view();
		}
		
		[HttpPost]
		public IActionResult Insert(Customer customer)
		{
			if(ModelState.isValid)
			{
				storeContext.Customer.Add(customer);
				storeContext.SaveChanges();
				return RedirectToAction("Index");
			}
			else
				return View();		
		}
	}
}
