namespace MAUI学習;

public partial class FormPage : ContentPage
{
	public FormPage()
	{
		InitializeComponent();
	}

    private void OnClickSubmit(object sender, EventArgs e)
    {
        this.labelMessage.Text = $"{this.textName.Text} in {this.textAddress.Text}";
    }

    private async void OnClickBack(object sender, EventArgs e)
    {
        await this.Navigation.PopAsync();
    }
}