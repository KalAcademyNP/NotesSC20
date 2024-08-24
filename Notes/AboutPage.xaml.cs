namespace Notes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	private async void LearnMoreBtn_Clicked(object sender, EventArgs e)
	{
		await Launcher.Default.OpenAsync("https://kalacademy.org");
    }
}