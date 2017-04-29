using Xamarin.Forms;

namespace CarouselImages
{
	public partial class CarouselImagesPage : ContentPage
	{
		public CarouselImagesPage()
		{
			InitializeComponent();

			BindingContext = new ImagesViewModel();
		}
	}
}
