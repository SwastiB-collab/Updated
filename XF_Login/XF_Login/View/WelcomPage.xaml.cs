﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF_Login.ViewModel;

namespace XF_Login.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WelcomPage : ContentPage
	{
        WelcomePageVM welcomePageVM;
		public WelcomPage (string email)
		{
			InitializeComponent (); 
            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    Url = "https://en.humsub.com.pk/",
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            this.Content = new StackLayout
            {
                Children =
                {
                    webView
                }
            };

            welcomePageVM = new WelcomePageVM(email);
            BindingContext = welcomePageVM;

          
        }
	}
}