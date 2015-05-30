using Foundation;
using UIKit;
using Cirrious.CrossCore;
using Cirrious.MvvmCross.ViewModels;
using Cirrious.MvvmCross.Touch.Platform;

namespace PclMvx.Touch
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register ("AppDelegate")]
	public class AppDelegate : MvxApplicationDelegate
	{
		// class-level declarations

		UIWindow window ;

		public override bool FinishedLaunching (UIApplication app, NSDictionary Options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			var controller = new UIViewController();
			controller.View.BackgroundColor = UIColor.Blue;

		
			window.RootViewController = controller;
			

			var setup = new Setup (this, window);
			setup.Initialize ();
			var appstart = Mvx.Resolve<IMvxAppStart> ();
			appstart.Start ();

			window.MakeKeyAndVisible ();


			return true;
		}


	}
}


