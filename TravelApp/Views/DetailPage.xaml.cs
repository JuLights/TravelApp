using TravelApp.Models;
using TravelApp.ViewModels;

namespace TravelApp.Views;

public partial class DetailPage : ContentPage
{
	public DetailPage()
	{
		InitializeComponent();


	}

	public DetailPage(Excitements excitement)
	{
		InitializeComponent();

		BindingContext = new DetailPageViewModel(excitement);
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new GetStartedPage());
    }
}