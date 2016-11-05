using System;
using Xamarin.Forms;

namespace CopernicusHackaton2016
{
	public class NativeNavigationArgs
	{
		public Page Page { get; private set; }

		public NativeNavigationArgs(Page page)
		{
			Page = page;
		}
	}
}
