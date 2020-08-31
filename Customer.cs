using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCapp.Models
{
	public class Customer
	{
		public int CustomerID {get; set;}
		
		public string FirstName {get; set;}
		
		public string LastName {get; set;}
		
		public string Email {get; set;}
	}
}
