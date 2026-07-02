namespace Deck_Randomiser_3;

public partial class ModifyDecksList : UserControl
{
    private string FilePath = "DecksList.csv";
    
    public ModifyDecksList()
    {
        InitializeComponent();
    }

    private void ModifyDecksList_Load(object sender, EventArgs e)
    {
        TextReader reader = new StreamReader(FilePath);
        DeckNamesBox.Text = reader.ReadToEnd();
        reader.Close();
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        TextWriter textWriter = new StreamWriter(FilePath);
        textWriter.Write(DeckNamesBox.Text);
        textWriter.Close();
    }
}