namespace Notes.Views;

public partial class NotePage : ContentPage
{
	public NotePage()
	{
		InitializeComponent();
		var randomFileName = $"{Path.GetRandomFileName()}.notes.txt";
		LoadNote(Path.Combine(FileSystem.AppDataDirectory, randomFileName));
	}

	private void SaveButton_Clicked(object sender, EventArgs e)
	{
		File.WriteAllText(fileName, TextEditor.Text);
    }

	private void DeleteButton_Clicked(object sender, EventArgs e)
	{
		if (File.Exists(fileName))
			File.Delete(fileName);

		TextEditor.Text = string.Empty;
    }

	private void LoadNote(string fileName)
	{
		var noteModel = new Models.Note();
		noteModel.Filename = fileName;

		if (File.Exists(fileName))
		{
			noteModel.Date = File.GetCreationTime(fileName);
			noteModel.Text = File.ReadAllText(fileName);
		}

		BindingContext = noteModel;
	}
}