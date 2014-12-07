using System;
using System.Collections.Generic;
using System.Linq;
using ScrollVIew;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Drawing;

namespace Demo
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations
		UIWindow window;

		//
		// This method is invoked when the application has loaded and is ready to run. In this
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			// create a new window instance based on the screen size
			window = new UIWindow (UIScreen.MainScreen.Bounds);
			
			// If you have defined a root view controller, set it here:
			window.RootViewController = new Demo();
			
			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}

	public class Demo: UIViewController
	{
		public Demo (IntPtr handle):base(handle)
		{

		}
		public Demo ()
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			var scroll= new UIPageScrollView(this.View.Frame,new b(),new c(),Direction.Vertical);
			Add (scroll);
		}
	}
	public class b: UIViewController
	{
		public b (IntPtr handle):base(handle)
		{

		}
		public b ()
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			var Button = new UIButton (new RectangleF (10, 10, 300, 100));
			Button.SetTitle ("first", UIControlState.Normal);
			Add (Button);
			View.BackgroundColor = UIColor.Blue;
		}
	}
	public class c: UIViewController
	{
		public c (IntPtr handle):base(handle)
		{

		}
		public c ()
		{
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			var Button = new UIButton (new RectangleF (10, 10, 300, 100));
			Button.SetTitle ("second", UIControlState.Normal);
			Add (Button);
			View.BackgroundColor = UIColor.Red;
		}
	}

}

