using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using Mapbox;
using UIKit;

namespace CopernicusHackaton2016.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			XFGloss.iOS.Library.Init();

			AccountManager.AccessToken = "pk.eyJ1IjoibWljaGFlbGtuYXZlIiwiYSI6ImNpdjR5b2kxbzAwMDgyenJ0YWZocm1vcG4ifQ.4nzlHqYKHoFk09WjT0Z5Cg";

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
