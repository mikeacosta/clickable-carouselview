using System;
using Xamarin.Forms;

namespace CarouselImages
{
	public class Image
	{
		public string Name { get; set; }
		public string Caption { get; set; }

		public Command TapCommand { get; set; }

		public EventHandler TapClickEventHandler;

		public Image()
		{
			TapCommand = new Command(() => OnImageClicked());
		}

		public void OnImageClicked()
		{
			TapClickEventHandler?.Invoke(this, EventArgs.Empty);
		}
	}
}
