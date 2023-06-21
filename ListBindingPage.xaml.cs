namespace MAUI学習;

public partial class ListBindingPage : ContentPage
{
	public ListBindingPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}