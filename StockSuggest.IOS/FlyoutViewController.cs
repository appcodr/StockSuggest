using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;
using FlyoutNavigation;
using MonoTouch.Dialog;

namespace StockSuggest
{
	partial class FlyoutViewController : UIViewController
	{
		public FlyoutViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {

            AppDelegate.FlyoutNavigation = new FlyoutNavigationController {//this will create a new instance of the FlyoutComponent
                NavigationRoot = new RootElement("Navigation"){ //Here we create the root of the alements
                    new Section(){
                        new ImageStringElement("Picks",UIImage.FromBundle("images/Icon-schedule.png")),
                        new StyledStringElement("Watchlist"),
                        new StyledStringElement("Portfolio"),
                    },

                },
                ViewControllers =  new UIViewController[]  {//here we link Controllers
                    new UINavigationController ((PicksController)this.Storyboard.InstantiateViewController("PicksController")),//here we create the instances for the Controllers
                    new UINavigationController ((WatchListController)this.Storyboard.InstantiateViewController("WatchListController")),
                    new UINavigationController ((PortfolioController)this.Storyboard.InstantiateViewController("PortfolioController")),
                }
            };
            this.Add(AppDelegate.FlyoutNavigation.View);
        }
	}
}
