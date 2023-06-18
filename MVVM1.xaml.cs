namespace MAUI学習;

public partial class MVVM1 : ContentPage
{
	public MVVM1()
	{
		InitializeComponent();
		this.Loaded += (_, _) =>
		{
			// BindingContextをcsで設定する場合
			this.BindingContext = _vm;
		};
	}

	MyViewModel _vm = new MyViewModel();

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}