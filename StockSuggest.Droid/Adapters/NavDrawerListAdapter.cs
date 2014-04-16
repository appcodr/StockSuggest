using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace StockSuggest.Droid
{
	class NavDrawerListAdapter : BaseAdapter
	{
		Context m_context;
		List<NavDrawerItem> m_items;

		public NavDrawerListAdapter(Context context, List<NavDrawerItem> navDrawerItems)
		{
			m_context = context;
			m_items = navDrawerItems;
		}

		public override int Count 
		{
			get
			{
				return m_items.Count;
			}
		}

		public override Java.Lang.Object GetItem (int position)
		{
			return m_items [position];
		}

		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			if (convertView == null) 
			{
				LayoutInflater inflater = (LayoutInflater)m_context.GetSystemService (Activity.LayoutInflaterService);
				convertView = inflater.Inflate (Resource.Layout.listmenu, null);
			}

			ImageView imgIcon = (ImageView)convertView.FindViewById (Resource.Id.listicon);
			TextView txtTitle = (TextView)convertView.FindViewById (Resource.Id.title);
			TextView txtCount = (TextView)convertView.FindViewById (Resource.Id.counter);
			NavDrawerItem navItem = m_items [position];
			imgIcon.SetImageResource (navItem.Icon);
			txtTitle.Text =  navItem.Title;
			if (navItem.CounterVisible)
				txtCount.Text = navItem.Count;
			else
				txtCount.Visibility = ViewStates.Gone;
			return convertView;
		}
	}
}

