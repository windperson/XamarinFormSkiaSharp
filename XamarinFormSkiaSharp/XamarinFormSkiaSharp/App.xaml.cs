using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinFormSkiaSharp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new XamarinFormSkiaSharp.MainPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
			MobileCenter.Start("ios=9ee32471-13e7-496b-9af4-ffd31c4328a8;" +
				   "android=c898ed81-5c24-41a5-92ef-d620e994a568",
				   typeof(Analytics), typeof(Crashes));
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
