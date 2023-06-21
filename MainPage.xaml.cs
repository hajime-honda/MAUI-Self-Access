namespace MAUI学習;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		this.Loaded += CreatePickerItems;
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

	private async void OnClickGraphicsView(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new GraphicsViewPage());
	}

	private void OnClickChangeTheme(object sender, EventArgs e)
	{
		Application.Current.UserAppTheme = Application.Current.UserAppTheme == AppTheme.Light ? AppTheme.Dark : AppTheme.Light;
	}

	private async void OnClickListView(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ListViewPage());
	}


	private void CreatePickerItems(object sender, EventArgs e)
	{
		var lst = new List<string>();
		lst.Add("選択してください。");
		lst.Add("C#");
		lst.Add("Visual Basic");
		lst.Add("F#");
		picker.ItemsSource = lst;
		picker.SelectedIndex = 0;
	}

	private void OnChange_Picker(object sender, EventArgs e)
	{
		if (this.picker.SelectedIndex != -1)
		{
			this.lblPicker.Text = "ピッカー：" + this.picker.SelectedItem as string;
		}
	}

	private void OnChange_Switch(object sender, EventArgs e)
	{
		lblSwitch.IsVisible = sw.IsToggled;
	}

	private void OnChange_DatePicker(object sender, DateChangedEventArgs e)
	{
		lblDatePicker.Text = datePicker.Date.ToString();
	}

	private async void OnClickFirstMVVM(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new MVVM1());
    }

	private async void OnClickMVVMForm(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new MVVMFormPage());
	}

	private async void OnClickListMVVM(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ListBindingPage());
	}

    private async void OnClickCodeOnly(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CodeOnlyPage());
    }
}

