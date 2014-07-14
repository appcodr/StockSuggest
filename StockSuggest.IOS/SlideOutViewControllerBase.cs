using System;
using MonoTouch.UIKit;

namespace StockSuggest
{
	public class SlideOutViewControllerBase : UIViewController
	{
        public SlideOutViewControllerBase (IntPtr handle) : base (handle)
		{
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			UIBarButtonItem menuIndicator = new UIBarButtonItem (UIImage.FromBundle ("images/slideout.png"), UIBarButtonItemStyle.Plain, (sender, e) => {
				AppDelegate.FlyoutNavigation.ToggleMenu ();
			});
			NavigationItem.SetLeftBarButtonItem (menuIndicator, false);
		}
	}
}

