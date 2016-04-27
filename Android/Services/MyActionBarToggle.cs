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
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using ActionBarDrawerToggle = Android.Support.V7.App.ActionBarDrawerToggle;
using Toolbar = Android.Support.V7.Widget.Toolbar;

namespace Android.Services
{
    public class MyActionBarToggle : ActionBarDrawerToggle
    {
        private AppCompatActivity mHostAcitivy;
        private int mOpenedResource;
        private int mClosedResource;

        public MyActionBarToggle(AppCompatActivity host, DrawerLayout drawerLayout, Toolbar toolbar, int openedResource, int closedResource)
            : base(host, drawerLayout, toolbar, openedResource, closedResource)
        {
            mHostAcitivy = host;
            mOpenedResource = openedResource;
            mClosedResource = closedResource;
        }

        public override void OnDrawerOpened(View drawerView)
        {
            mHostAcitivy.SupportActionBar.SetTitle(mOpenedResource);
            base.OnDrawerOpened(drawerView);
        }

        public override void OnDrawerClosed(View drawerView)
        {
            mHostAcitivy.SupportActionBar.SetTitle(mClosedResource);
            base.OnDrawerClosed(drawerView);
        }

        public override void OnDrawerSlide(View drawerView, float slideOffset)
        {
            base.OnDrawerSlide(drawerView, slideOffset);
        }
    }
}