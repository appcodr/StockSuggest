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
using StockSuggest.Core;

namespace StockSuggest.Droid
{
	class PicksAdapter : BaseAdapter<Stock>
	{
		Activity m_context;
		List<Stock> m_stocks;

		public PicksAdapter(Activity context, List<Stock> stocks)
		{
			m_context = context;
			m_stocks = stocks;
		}
		#region implemented abstract members of BaseAdapter
		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			if (convertView == null) 
				convertView = m_context.LayoutInflater.Inflate (Resource.Layout.listview_picks, null);
			Stock stock = m_stocks [position];
			TextView textStockName = (TextView)convertView.FindViewById (Resource.Id.textStockName);
			TextView textStockPrice = (TextView)convertView.FindViewById (Resource.Id.textStockPrice);
			TextView textSymbol = (TextView)convertView.FindViewById (Resource.Id.textSymbol);
			TextView textExchange = (TextView)convertView.FindViewById (Resource.Id.textExchange);
			TextView textChange = (TextView)convertView.FindViewById (Resource.Id.textChange);
			textStockName.Text = stock.Name;
			textStockPrice.Text = stock.LastTradePriceOnly;
			textSymbol.Text = stock.symbol;
			textExchange.Text = stock.StockExchange;
			textChange.Text = stock.Change;
			if (stock.Change.StartsWith ("+"))
				textChange.SetTextColor (Android.Graphics.Color.Green);
			else
				textChange.SetTextColor (Android.Graphics.Color.Red);
			return convertView;
		}

		public override int Count 
		{
			get 
			{
				return m_stocks.Count;
			}
		}
		#endregion
		#region implemented abstract members of BaseAdapter
		public override Stock this [int index] 
		{
			get 
			{
				return m_stocks[index];
			}
		}
		#endregion
	}
}

