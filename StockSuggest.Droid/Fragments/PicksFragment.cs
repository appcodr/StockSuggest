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
using StockSuggest.Core;

namespace StockSuggest.Droid
{
	public class PicksFragment : Fragment
	{
        Android.App.ProgressDialog m_progressDialog;

		public override View OnCreateView (LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
		{
			base.OnCreateView (inflater, container, savedInstanceState);
			View view = inflater.Inflate(Resource.Layout.fragment_picks, null);

            UpdateListView(view);
			return view;
		}

        async void UpdateListView(View view)
        {
            ListView picksView = view.FindViewById<ListView>(Resource.Id.listViewPicks);
            ShowProgressDialog("Fetching stocks");
            List<Stock> hotStocks = await Stocks.GetHotStocks();
            DismissProgressDialog();
            picksView.Adapter = new PicksAdapter(Activity, hotStocks);
        }

        void ShowProgressDialog(string message)
        {
            m_progressDialog = new Android.App.ProgressDialog(Activity);
            m_progressDialog.SetMessage(message);
            m_progressDialog.Show();
        }

        void DismissProgressDialog()
        {
            if (m_progressDialog != null)
                m_progressDialog.Dismiss();
        }

        public override void OnResume()
        {
            base.OnResume();
            Activity.ActionBar.Title = "Picks";
        }
	}
}

