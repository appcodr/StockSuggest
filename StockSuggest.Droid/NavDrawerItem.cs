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
	class NavDrawerItem : Java.Lang.Object
	{
		string m_title;
		int m_icon;
		string m_count = "0";
		bool m_counterVisible = false;

		public NavDrawerItem(String title, int icon)
		{
			m_title = title;
			m_icon = icon;
		}

		public NavDrawerItem(String title, int icon, String count)
			:this(title,icon)
		{
			m_counterVisible = true;
			m_count = count;
		}

		public String Title { get { return m_title; } }
		public int Icon { get{ return m_icon; } }
		public String Count { get { return m_count; } }
		public bool CounterVisible { get { return m_counterVisible; }}
	}
}

