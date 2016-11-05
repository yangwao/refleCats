using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace CopernicusHackaton2016
{
	public class CarouselData
	{
		public string Title
		{
			get;
			set;
		}

	}

	public class IntroViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public ObservableCollection<CarouselData> CarouselDataSource
		{
			get;
			set;
		}

		public IntroViewModel()
		{
			CarouselDataSource = new ObservableCollection<CarouselData>
			{
				new CarouselData ()
				{
					Title = "title1"
				},
				new CarouselData ()
				{
					Title = "title2"
				},
				new CarouselData ()
				{
					Title = "title3"
				}
			};
		}
	}
}
