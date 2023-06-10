namespace MAUI学習;

public partial class NextPage : ContentPage
{
	public NextPage()
	{
		InitializeComponent();
	}

	private async void OnBackClick(object sender, EventArgs e)
	{
		await Navigation.PopModalAsync();
	}
}