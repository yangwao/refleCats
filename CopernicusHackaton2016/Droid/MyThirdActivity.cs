using System;
using Android.App;
using Android.OS;
using Android.Widget;

namespace CopernicusHackaton2016.Droid
{
	[Activity(Label = "MyThirdActivity")]
	public class MyThirdActivity : Activity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.MyThirdLayout);

			var button = FindViewById<Button>(Resource.Id.myButton);

			button.Click += (sender, e) =>
			{
				Finish(); // back to the previous activity
			};
		}
	}
}
