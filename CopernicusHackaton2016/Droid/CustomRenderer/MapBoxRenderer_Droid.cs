//using System;
//using CopernicusHackaton2016;
//using CopernicusHackaton2016.Droid;
//using Mapbox;
//using Mapbox.Annotations;
//using Mapbox.Camera;
//using Mapbox.Geometry;
//using Mapbox.Maps;
//using Xamarin.Forms;
//using Xamarin.Forms.Platform.Android;
//using View = Android.Views.View;

//[assembly: ExportRenderer(typeof(MapBox), typeof(MapBoxRenderer_Droid))]
//namespace CopernicusHackaton2016.Droid
//{
//	public class MapBoxRenderer_Droid : ViewRenderer<MapBox, MapView>, IOnMapReadyCallback
//	{
//		private static readonly LatLng LOS_ANGELES = new LatLng(34.0539440, -118.242622);
//		private static readonly LatLng NEW_YORK = new LatLng(40.712730, -74.005953);

//		private MapView _MapView;

//		protected override void OnElementChanged(ElementChangedEventArgs<MapBox> e)
//		{
//			base.OnElementChanged(e);

//			MapboxMapOptions options = new MapboxMapOptions();
//			options.InvokeScrollGesturesEnabled(true);
//			options.InvokeRotateGesturesEnabled(true);
//			options.InvokeTiltGesturesEnabled(true);
//			options.InvokeZoomGesturesEnabled(true);

//			_MapView = new MapView(Context, options);
//			_MapView.OnCreate(null);
//			_MapView.GetMap(this);

//			SetNativeControl(_MapView);
//		}

//		public void OnMapReady(MapboxMap map)
//		{
//			var uiSettings = map.UiSettings;
//			uiSettings.SetAllGesturesEnabled(true);

//			map.AddMarker(new MarkerOptions()
//				.SetTitle("Los Angeles")
//				.SetSnippet("City Hall")
//				.SetPosition(LOS_ANGELES));

//			map.AddMarker(new MarkerOptions()
//				.SetTitle("New York")
//				.SetSnippet("City Hall")
//				.SetPosition(NEW_YORK));

//			var bounds = new LatLngBounds.Builder()
//				.Include(NEW_YORK)
//				.Include(LOS_ANGELES)
//				.Build();

//			map.MoveCamera(CameraUpdateFactory.NewLatLngBounds(bounds, 8));
//		}
//	}
//}
