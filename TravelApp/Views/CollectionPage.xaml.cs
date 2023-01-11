using TravelApp.Models;
using TravelApp.ViewModels;

namespace TravelApp.Views;

public partial class CollectionPage : ContentPage
{
	public CollectionPage()
	{
		InitializeComponent();

        collView.SelectionChanged += CollView_SelectionChanged;
        BindingContext = new CollectionPageViewModel();
	}

    private async void CollView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        string previous = (e.PreviousSelection.FirstOrDefault() as Excitements)?.Name;
        string current = (e.CurrentSelection.FirstOrDefault() as Excitements)?.Name;

        var excitement = e.CurrentSelection.FirstOrDefault() as Excitements;

        //collView.SelectedItem = null;
        await Navigation.PushAsync(new DetailPage(excitement));

        
    }
}