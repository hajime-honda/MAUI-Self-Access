namespace MAUI学習;

public partial class ListViewPage : ContentPage
{
	public ListViewPage()
	{
		InitializeComponent();
		this.Loaded += ListViewPage_Loaded;
	}

	private void ListViewPage_Loaded(object sender, EventArgs e)
	{
        var lst = new List<Card>
        {
            new Card { Name = "C#" },
            new Card { Name = "Visual Basic" },
            new Card { Name = "F#" }
        };
        this.lv.ItemsSource = lst;
    }

	public class Card
	{
		public string ImageUrl { get; set; } = "";
		public string Name { get; set; } = "";
		public string Location { get; set; } = "";
	}

    private async void OnClickBack(object sender, EventArgs e)
    {
        await this.Navigation.PopAsync();
    }
}