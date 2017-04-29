using System;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace CarouselImages
{
	public class ImagesViewModel
	{
		public ObservableCollection<Image> Images { get; set; }

		public ImagesViewModel()
		{
	        Images = new ObservableCollection<Image>
	        {
	            new Image
	            {
	                Name = "sanfrancisco.jpg",
	                Caption = "San Francisco",
					TapClickEventHandler = OnTapped
						
	            },
	                new Image
	            {
	                Name = "alameda.jpg",
	                Caption = "Alameda",
					TapClickEventHandler = OnTapped
	            },
	            new Image
	            {
	                Name = "sanleandro.jpg",
	                Caption = "San Leandro",
					TapClickEventHandler = OnTapped
	            }
	        };			
		}

		int taps = 0;

		void OnTapped(object sender, EventArgs e)
		{
			taps++;
			var img = (Image)sender;
			Debug.WriteLine($"tapped: {taps}  {img.Name}");
		}
	}
}
