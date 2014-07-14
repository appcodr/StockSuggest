using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;

namespace StockSuggest
{
	partial class LoginViewController : UIViewController
	{
		public LoginViewController (IntPtr handle) : base (handle)
		{
		}

        partial void OnLoginButtonClicked (UIButton sender)
        {
            UIViewController flyoutVC = (UIViewController)this.Storyboard.InstantiateViewController("FlyoutViewController");
            PresentViewController(flyoutVC, true, null);
        }
	}
}
