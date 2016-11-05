using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace CopernicusHackaton2016
{
	public partial class MapPage : ContentPage
	{
		public String Heading;
		public MapPage()
		{
			
			Title = "MapPage";

			Heading = "This is the map page";

			// rendering of this page is done natively on each platform
		}
	}
}
