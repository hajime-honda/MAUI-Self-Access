namespace MAUI学習;

public partial class CodeOnlyPage : ContentPage
{
	public CodeOnlyPage()
	{
		InitializeComponent();
		this.Loaded += this.CodeOnlyPage_Loaded;
	}

	private void CodeOnlyPage_Loaded(object sender, EventArgs e)
	{
		Button backButton = new Button()
		{
			Text = "戻る",
		};
		backButton.Clicked += async (_, _) =>
		{
			await Navigation.PopAsync();
		};

		this.Content = new ScrollView
		{
			Content = new VerticalStackLayout
			{
				Spacing = 25,
				Padding = new Thickness(30, 0),
				VerticalOptions = LayoutOptions.Center,
				Children =
				{
					new Label
					{
						FontSize = 32.0,
						HorizontalOptions = LayoutOptions.Center,
						Text = "Hello, Code Only World",
					},
					new Label
					{
						FontSize = 18,
						HorizontalOptions = LayoutOptions.Center,
						Text = "ようこそ、.NET MAUIの世界へ"
					},
					new Label { FontSize = 24, Text = "坊ちゃん" },
					new Label { FontSize = 18, Text = "夏目漱石" },
					backButton
				}
			}
		};
	}
}