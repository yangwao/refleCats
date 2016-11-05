using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms;

// This ExportRenderer command tells Xamarin.Forms to use this renderer
// instead of the built-in one for this page
[assembly: ExportRenderer(typeof(CopernicusHackaton2016.MapPage), typeof(CopernicusHackaton2016.MapNativePage))]

namespace CopernicusHackaton2016
{
	/// <summary>
	/// Render this page using platform-specific Android.Views controls
	/// </summary>
	public class MapNativePage : PageRenderer
	{
		Android.Views.View view;

		protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
		{
			base.OnElementChanged(e);

			var page = e.NewElement as MapPage;

			// this is a ViewGroup - so should be able to load an AXML file and FindView<>
			var activity = this.Context as Activity;

			var o = activity.LayoutInflater.Inflate(Resource.Layout.Main, this, false);
			view = o;

			var label = view.FindViewById<TextView>(Resource.Id.textView1);
			label.Text = page.Heading;

			AddView(view);
		}

		protected override void OnLayout(bool changed, int l, int t, int r, int b)
		{
			base.OnLayout(changed, l, t, r, b);
			var msw = MeasureSpec.MakeMeasureSpec(r - l, MeasureSpecMode.Exactly);
			var msh = MeasureSpec.MakeMeasureSpec(b - t, MeasureSpecMode.Exactly);
			view.Measure(msw, msh);
			view.Layout(0, 0, r - l, b - t);
		}
	}
}