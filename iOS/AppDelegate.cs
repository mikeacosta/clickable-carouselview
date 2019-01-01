using System;
using System.Collections.Generic;
using System.Linq;
using CarouselImages.Core;
using CarouselView.FormsPlugin.iOS;
using Foundation;
using UIKit;

namespace CarouselImages.iOS
{
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();

			CarouselViewRenderer.Init();

			LoadApplication(new App());

			return base.FinishedLaunching(app, options);
		}
	}
}
