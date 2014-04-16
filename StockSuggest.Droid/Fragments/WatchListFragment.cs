using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Support.V4.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace StockSuggest.Droid
{
	public class WatchListFragment : Fragment
	{
		public override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			// Create your fragment here
		}

        public override void OnResume()
        {
            base.OnResume();
            Activity.ActionBar.Title = "Watchlist";
        }
	}
}

