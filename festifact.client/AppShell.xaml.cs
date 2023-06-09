﻿using festifact.client.Pages;
using festifact.client.ViewModels;

namespace festifact.client;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(HomeDetailsPage), typeof(HomeDetailsPage));
		Routing.RegisterRoute(nameof(ShoppingCartPage), typeof(ShoppingCartPage));
		Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
		Routing.RegisterRoute(nameof(ContactPage), typeof(ContactPage));
		Routing.RegisterRoute(nameof(AddVisitorPage), typeof(AddVisitorPage));
		Routing.RegisterRoute(nameof(EditVisitorPage), typeof(EditVisitorPage));
	}

    async void MenuItem_Clicked(System.Object sender, System.EventArgs e)
    {
        await Launcher.OpenAsync("https://learn.microsoft.com/en-us/dotnet/maui/");
    }

    async void MenuItem_Clicked_1(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(ContactPage));
    }
}


