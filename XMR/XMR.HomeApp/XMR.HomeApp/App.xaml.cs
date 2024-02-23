﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XMR.HomeApp.Pages;

namespace XMR.HomeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MergeGridPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
