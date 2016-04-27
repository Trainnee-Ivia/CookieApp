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
using Android.Services;
using Android.Util;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using SupportToolbar = Android.Support.V7.Widget.Toolbar;
using SupportFragment = Android.Support.V4.App.Fragment;
using SupportFragmentTransaction = Android.Support.V4.App.FragmentTransaction;
using Android.Controllers.Fragments;
using Infraestrutura.Repositories;
using Domain.Mobile.Entities;

namespace Android.Controllers.Activities
{
    [Activity(Label = "Cookeriat", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/MyTheme")]
    public class MainActivity : AppCompatActivity
    {

        private SupportToolbar mToolbar;
        private DrawerLayout mDrawerLayout;
        private MyActionBarToggle mDrawerToggle;
        private FrameLayout mLeftDrawer;
        private SupportFragmentTransaction mFragmentTransaction;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            // Iniciando todos os componentes
                SetupUI();

            // Carregando o Toolbar
                SetupToolbar();

            // Carregando Drawer Layout
                SetupDrawerLayout();

            // Verificar o estado do Bundle
                VerifyBundle(bundle);

            var produtoRepository = new Repository<Produto>("api/produtos/");
            var produtos = produtoRepository.GetAll();
            foreach (var item in produtos)
            {
                Toast.MakeText(this, "Id: " + item.Id + " Nome: " + item.Nome, ToastLength.Short).Show();
            }

        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            outState.PutBoolean("DrawerLeftOpen", mDrawerLayout.IsDrawerOpen((int)GravityFlags.Left));
            base.OnSaveInstanceState(outState);
        }

        private void SetupUI()
        {
            mToolbar = FindViewById<SupportToolbar>(Resource.Id.toolbar);
            mDrawerLayout = FindViewById<DrawerLayout>(Resource.Id.drawer_layout);
            mLeftDrawer = FindViewById<FrameLayout>(Resource.Id.left_drawer);
        }

        private void SetupToolbar()
        {
            SetSupportActionBar(mToolbar);
            SupportActionBar.Title = "Cookeria";
            Log.Info("SETUP", "Toolbar criado e carregado!");
        }

        private void SetupDrawerLayout()
        {
            mFragmentTransaction = SupportFragmentManager.BeginTransaction();
            mFragmentTransaction.Add(Resource.Id.left_drawer, new LeftDrawerFragment());
            mFragmentTransaction.Commit();

            mDrawerToggle = new MyActionBarToggle(
                this,
                mDrawerLayout,
                mToolbar,
                Resource.String.openDrawer,
                Resource.String.closeDrawer);

            mDrawerLayout.SetDrawerListener(mDrawerToggle);
            mDrawerToggle.SyncState();
            SupportActionBar.SetHomeButtonEnabled(true);
            SupportActionBar.SetDisplayShowTitleEnabled(true);

            Log.Info("SETUP", "Drawer Layout criado e carregado!");
        }

        private void VerifyBundle(Bundle bundle)
        {
            if (bundle == null)
            {
                Log.Info("BUNDLE", "Primeira vez que a activity foi aberta!");
                mToolbar.SetTitle(Resource.String.closeDrawer);
            }
            else
            {
                bool isDrawerLeftOpen = bundle.GetBoolean("DrawerLeftOpen");

                Log.Info("BUNDLE", "Drawer Layout Left 'isOpen(" + isDrawerLeftOpen + ")");

                if (isDrawerLeftOpen)
                {
                    mToolbar.SetTitle(Resource.String.openDrawer);
                }
                else
                {
                    mToolbar.SetTitle(Resource.String.closeDrawer);
                }
            }
        }

    }
}