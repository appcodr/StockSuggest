using System;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.Widget;

namespace StockSuggest.Droid
{
	[Activity (Label = "StockSuggest", MainLauncher = true)]
	public class MainActivity : FragmentActivity
	{
		ActionBarDrawerController m_drawerToggle;
		DrawerLayout m_drawer;
		String m_title;
		ListView m_drawerMenuList;
		List<NavDrawerItem> m_navItems;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			m_title = this.Title;
			m_drawer = this.FindViewById<DrawerLayout> (Resource.Id.drawer_layout);
			m_drawerMenuList = this.FindViewById<ListView> (Resource.Id.left_drawer);

			m_navItems = new List<NavDrawerItem> ();
			m_navItems.Add(new NavDrawerItem( "Home", Resource.Drawable.ic_home ) );
			m_navItems.Add(new NavDrawerItem( "Picks", Resource.Drawable.ic_picks, "+2" ) );
			m_navItems.Add(new NavDrawerItem( "WatchList", Resource.Drawable.ic_watchlist ) );
			m_navItems.Add(new NavDrawerItem( "Portfolio", Resource.Drawable.ic_portfolio ) );

			m_drawerMenuList.Adapter = new NavDrawerListAdapter (this, m_navItems );
			m_drawerMenuList.ItemClick += OnDrawerMenuListItemClicked;

			m_drawerToggle = new ActionBarDrawerController (this, m_drawer, Resource.Drawable.ic_drawer_light, Resource.String.drawer_open, Resource.String.drawer_close);
			m_drawerToggle.DrawerOpened += OnDrawerMenuToggle;
			m_drawerToggle.DrawerClosed += OnDrawerMenuToggle;
			m_drawer.SetDrawerListener (m_drawerToggle);

			if (bundle == null)
				OnDrawerMenuListItemClicked (0);

			this.ActionBar.SetDisplayHomeAsUpEnabled(true);
			this.ActionBar.SetHomeButtonEnabled(true);
		}

		private void OnDrawerMenuToggle( object sender, EventArgs EventArgs)
		{
			this.ActionBar.Title = this.m_title;
			this.InvalidateOptionsMenu();
		}

		public override void OnConfigurationChanged (Android.Content.Res.Configuration newConfig)
		{
			base.OnConfigurationChanged (newConfig);

		}

		// Pass the event to ActionBarDrawerToggle, if it returns
		// true, then it has handled the app icon touch event
		public override bool OnOptionsItemSelected(IMenuItem item)
		{
			if (this.m_drawerToggle.OnOptionsItemSelected(item))
				return true;

			return base.OnOptionsItemSelected(item);
		}

		protected override void OnPostCreate(Bundle savedInstanceState)
		{
			base.OnPostCreate(savedInstanceState);
			this.m_drawerToggle.SyncState();
		}

		void OnDrawerMenuListItemClicked (int position)
		{
			Android.Support.V4.App.Fragment fragment = null;
			switch (position) {
			case 0:
				fragment = new HomeFragment();
				break;
			case 1:
				fragment = new PicksFragment();
				break;
			case 2:
				fragment = new WatchListFragment();
				break;
			case 3:
				fragment = new PortfolioFragment ();
				break;
			}
            SupportFragmentManager.BeginTransaction ().Replace (Resource.Id.content, fragment).AddToBackStack(fragment.ToString()).Commit ();
			this.m_drawerMenuList.SetItemChecked (position, true);
			ActionBar.Title = this.m_title = m_navItems [position].Title;
			this.m_drawer.CloseDrawer (this.m_drawerMenuList);
		}

		private void OnDrawerMenuListItemClicked(object sender, AdapterView.ItemClickEventArgs args )
		{
			int position = args.Position;
			OnDrawerMenuListItemClicked (position);
		}
	}
}


