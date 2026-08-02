using System.Numerics;

namespace Deck_Randomiser_3;

public partial class StatsCalcScreen : UserControl
{
    private const int HandSize = 7;
    private const int CopiesWanted = 3;
    private const int DeckSize = 99;
    private readonly List<string> _issues = [];
    
    private static readonly Color[] ManaSwatch  =
    [
        Color.FromArgb(248, 231, 160),  // W
        Color.FromArgb(106, 173, 223),  // U
        Color.FromArgb(176, 122, 204),  // B
        Color.FromArgb(232, 120,  88),  // R
        Color.FromArgb( 88, 200, 122) // G
    ];
    public StatsCalcScreen()
    {
        InitializeComponent();
    }

    private void CalculateButton_Click(object sender, EventArgs e)
    {
        _issues.Clear();
        if (GreaterThanEqualTo(HandSize, DeckSize, int.Parse(CopiesInDeck.Text), CopiesWanted) <= 0.5)
        {
            _issues.Add("Odds of opening 3 or more lands <= 50%: Consider more lands for consistency");
        }

        IssuesBox.Text = "";
        if (_issues.Count > 0)
        {
            IssuesBox.Text = string.Join("\n", _issues);
        }
        else
        {
            IssuesBox.Text = "No issues found.";
        }
    }
    
    //ToDo Add input validation
    private static bool ValidateVals()
    {
        return true;
    }
    
    private static double GreaterThanEqualTo(int sampleSize, 
        int populationSize, 
        int successStates, 
        int successesInSample)
    {
        double probability = 0;
        for (var i = 0; i < successesInSample; i++)
        {
            probability += CalculateProbability(sampleSize, populationSize, successStates, i);
        }

        return 1 - probability;
    }
    
    private static double CalculateProbability(int sampleSize, 
        int populationSize, 
        int successStates, 
        int successesInSample)
    {
        double probability = 0;
        
        if (successStates <= 0) return probability;
        
        probability = CombinationsWithoutRepetitions(successStates, successesInSample);
        probability *= CombinationsWithoutRepetitions(populationSize - successStates, 
            sampleSize - successesInSample);
        probability /= CombinationsWithoutRepetitions(populationSize, sampleSize);
        return probability;
    }
    
    private static double CombinationsWithoutRepetitions(int n, int r)
    {
        var factN = Fact(n);
        var factR = Fact(r);
        var factNr = Fact(n-r); 
        var val = (double) BigInteger.Divide(factN, BigInteger.Multiply(factR, factNr));
        return val;
    }
    private static BigInteger Fact(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        BigInteger j = n;
        for (var i = n - 1; i >= 1; i--)
        {
            j = BigInteger.Multiply(j, i);
        }

        return j;
    }
    
}