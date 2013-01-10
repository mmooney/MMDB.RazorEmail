using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MMDB.RazorEmail
{
	public class EmailServerSettings
	{
		public string Host { get; set; }
		public int? Port { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
	}
}
