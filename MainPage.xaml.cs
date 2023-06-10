namespace MAUI学習;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void CurrentDateTime_Clicked(object sender, EventArgs e)
	{
		this.CurrentDateTimeLabel.Text =
			DateTime.Now.ToString();
	}

	private void OnClickSubmit(object sender, EventArgs e)
	{
		this.labelMessage.Text = $"{this.textName.Text} in {this.textAddress.Text}";
	}

	private async void OnClickRotation(object sender, EventArgs e)
	{
		await imageNet.RotateTo(360, 2000);
		imageNet.Rotation = 0;
	}

	private async void OnNextClicked(object sender, EventArgs e)
	{
		await Navigation.PushModalAsync(new NextPage());
	}

	private async void OnClickPopup(object sender, EventArgs e)
	{
		await DisplayAlert(".NET MAUIサンプル", "メッセージを表示します。", "CLOSE");
	}
}

