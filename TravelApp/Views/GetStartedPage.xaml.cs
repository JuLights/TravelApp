namespace TravelApp.Views;

public partial class GetStartedPage : ContentPage
{
	public GetStartedPage()
	{
		InitializeComponent();

		BindingContext = this;
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {

		await Navigation.PushAsync(new LoginPage());

    }
}