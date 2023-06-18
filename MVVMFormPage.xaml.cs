namespace MAUI学習;

public partial class MVVMFormPage : ContentPage
{
	public MVVMFormPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}