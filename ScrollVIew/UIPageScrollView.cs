using System;
using System.Drawing;
using MonoTouch.UIKit;
using MonoTouch.Foundation;

namespace ScrollVIew 
{
	[Register("UIPageScrollView")]
	public class UIPageScrollView:UIView
	{
		UIViewController   Controller1, Controller2;
		Direction ScrollDirection;
		public UIPageScrollView (RectangleF frame ,UIViewController controller1, UIViewController controller2, Direction scrollDirection):base(frame)
		{
			Controller1 = controller1;
			Controller2 = controller2;
			ScrollDirection = scrollDirection;
			this.Initialize ();
		}
		public UIPageScrollView (IntPtr handle) : base(handle)
		{
			this.Initialize ();
		}

		private void Initialize()
		{
			var scoll = new UIScrollView (this.Frame);
			Add (scoll);
			var b = Controller1;
			var c = Controller2;
			b.View.Frame = this.Frame;
			c.View.Frame = this.Frame;
			scoll.Frame = this.Frame;
			scoll.Add (b.View);
			scoll.Add (c.View);
			var cframe = b.View.Frame;
			float scollwidth; 
			float scollhight;
			if (ScrollDirection == Direction.Vertical) {
				cframe.Y = cframe.Height;
				scollwidth = this.Frame.Width;
				scollhight = 2 * scoll.Frame.Height;
			} else {
				cframe.X = cframe.Width;
				scollwidth =2* this.Frame.Width;
				scollhight =  scoll.Frame.Height;
			}
			c.View.Frame = cframe;
			scoll.ContentSize = new SizeF (scollwidth, scollhight);
			scoll.Bounces = false;
			scoll.PagingEnabled = true;
			scoll.ShowsHorizontalScrollIndicator = false;
			scoll.ShowsVerticalScrollIndicator = false;
		}
	}
	public enum Direction
	{
		Vertical,
		Horizontal,
	}
}

