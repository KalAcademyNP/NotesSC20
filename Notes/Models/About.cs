using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Models
{
	internal class About
	{
		public string Title => AppInfo.Name;
		public string Version => AppInfo.VersionString;
		public string MoreInfoUrl => "https://kalacademy.org";
		public string Message => "This app is to capture notes!";

	}
}
