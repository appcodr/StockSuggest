using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.V4.App;

namespace StockSuggest.Droid
{
	public class HomeFragment : Fragment
	{

		public HomeFragment()
		{
			this.RetainInstance = true;
		}

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			base.OnCreateView (inflater, container, savedInstanceState);
			return inflater.Inflate (Resource.Layout.fragment_home, null);
		}

        public override void OnResume()
        {
            base.OnResume();
            Activity.ActionBar.Title = "Home";
        }
	}
}

