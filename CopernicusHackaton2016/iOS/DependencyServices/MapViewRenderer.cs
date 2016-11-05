using System;
using System.Diagnostics.Contracts;
using CopernicusHackaton2016;
using CopernicusHackaton2016.iOS;
using Mapbox;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Maps.iOS;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomMap), typeof(MapViewRenderer))]
namespace CopernicusHackaton2016.iOS
{
	public class MapViewRenderer : MapRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<View> e)
		{
			base.OnElementChanged(e);

			if (e.NewElement == null)
			{
				return;
			}

			var uiView = new UIView(new CoreGraphics.CGRect(0, 0, 500, 700));
			SetNativeControl(uiView);

			var mapView = new MapView(Control.Bounds);
			mapView.SetCenterCoordinate(new CoreLocation.CLLocationCoordinate2D(40.81, -96.68), false);
			mapView.SetZoomLevel(11, false);

			mapView.AddAnnotation(new PointAnnotation
			{
				Coordinate = new CoreLocation.CLLocationCoordinate2D(40.81, -96.68),
				Title = "Lincoln, NE",
				Subtitle = "What-what"
			});

			uiView.AddSubview(mapView);
		}
	}
}

//[assembly: Dependency(typeof(UIViewController))]
//[assembly: Dependency(typeof(UIView))]
//namespace CopernicusHackaton2016.iOS
//{

	//public interface UIViewController { UIViewController MKMapView(); }

	//interface UIView { View view { get; set; } }

	//public class Map : UIViewController, UIView
	//{
	//	public View view { get; set; }

	//	public UIViewController MKMapView(Xamarin.Forms.View def)
	//	{
	//		def = UIScreen.MainScreen.Bounds;

	//		view = def;
	//		return 
	//	} 
	//}

	//public static class MapViewExtensions
	//{
	//	public static void mkMapView(this UIViewController)
	//	{
	//		MKMapView();
	//	}
	//}

	//public static class MapExtensions
	//{
	//	public static void Stop(this IBrakable vehicle)
	//	{
	//		vehicle.brake.ApplyUntilStop();
	//	}
	//}


	//public class Main
	//{
	//	Map myMap = new Map();

	//	public void main()
	//	{
	//		var mapView = myMap.MKMapView(UIScreen.MainScreen.Bounds);
	//			myMap.view = mapView;
	//	}
	//}


	//public class Map : UIView
	//{
	//	Map()
	//	{
	//		var map = new MKMapView(UIScreen.MainScreen.Bounds);
	//	}
	//}

	//public class MapView : UIViewController
	//{
	//	MapView()
	//	{
	//		View = map;
	//	}
	//}

//}
