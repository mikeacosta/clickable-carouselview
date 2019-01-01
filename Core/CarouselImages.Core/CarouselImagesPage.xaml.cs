using Xamarin.Forms;

namespace CarouselImages.Core
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
