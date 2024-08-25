namespace Notes.Views;

public partial class AllNotesPage : ContentPage
{
	public AllNotesPage()
	{
		InitializeComponent();
		BindingContext = new Models.AllNotes();
	}

	protected override void OnAppearing()
	{
		((Models.AllNotes)BindingContext).LoadNotes();
	}
	private void ToolbarItem_Clicked(object sender, EventArgs e)
	{

    }

	private void notesCollection_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{

    }
}