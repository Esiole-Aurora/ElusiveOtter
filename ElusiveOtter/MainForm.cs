namespace Deck_Randomiser_3;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        SetupLayout();
    }


    private void SetupLayout()
    {
        DeckSelectorButton.Click += (s, e) => NavigateTo(new DeckSelectorScreen());
        StatsButton.Click += (s, e) => NavigateTo(new StatsCalcScreen());
        RandomCardButton.Click += (s, e) => NavigateTo(new RandomCard());
        ModifyDecksButton.Click += (s, e) => NavigateTo(new ModifyDecksList());
        RulingsButton.Click+= (s, e) => NavigateTo(new RulingsScreen());
    }

    private void NavigateTo(UserControl screen)
    {
        ContentPanel.Controls.Clear();
        screen.Dock = DockStyle.Fill;
        ContentPanel.Controls.Add(screen);

        if (screen is DeckSelectorScreen)
        {
            HighlightButton(DeckSelectorButton);
        }
    }

    private void HighlightButton(Button button)
    {
        DeckSelectorButton.BackColor = Color.Transparent;
        StatsButton.BackColor= Color.Transparent;
        RandomCardButton.BackColor = Color.Transparent;
        ModifyDecksButton.BackColor = Color.Transparent;
        RulingsButton.BackColor = Color.Transparent;
        button.BackColor = Color.LightGray;
    }
}