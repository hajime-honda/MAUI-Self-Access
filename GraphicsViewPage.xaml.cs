namespace MAUI学習;

public partial class GraphicsViewPage : ContentPage
{
    public GraphicsViewPage()
	{
		InitializeComponent();
	}
	
	private async void OnClickBack(object sender, EventArgs e)
	{
		await Navigation.PopAsync();
	}
}