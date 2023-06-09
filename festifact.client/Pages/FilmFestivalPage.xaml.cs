﻿using festifact.client.ViewModels;

namespace festifact.client.Pages;

public partial class FilmFestivalPage : ContentPage
{
    private readonly FilmFestivalViewModel _viewModel;

    public FilmFestivalPage(FilmFestivalViewModel viewModel)
	{
		InitializeComponent();

        this._viewModel = viewModel;
        this.BindingContext = viewModel;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await _viewModel.GetFestivalsByCategory(2);
    }

    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        _viewModel.Festivals.Clear();
    }
}
