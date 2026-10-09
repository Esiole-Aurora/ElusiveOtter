using System.Diagnostics.CodeAnalysis;
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

    private Dictionary<char, double> make_spell_pip_histogram()
    {
        var total = int.Parse(W_Spell_Pips.Text) + int.Parse(U_Spell_Pips.Text) + int.Parse(B_Spell_Pips.Text) +
                    int.Parse(R_Spell_Pips.Text) + int.Parse(W_Spell_Pips.Text);
        if (total == 0) return new Dictionary<char, double>();
        var dict = new System.Collections.Generic.Dictionary<char, double>()
        {
            {'W', (double)int.Parse(W_Spell_Pips.Text) / total},
            {'U', (double)int.Parse(U_Spell_Pips.Text) / total},
            {'B', (double)int.Parse(B_Spell_Pips.Text) / total},
            {'R', (double)int.Parse(R_Spell_Pips.Text) / total},
            {'G', (double)int.Parse(W_Spell_Pips.Text) / total}
        };
        return dict;
    }
    
    private Dictionary<char, double> make_land_pip_histogram()
    {
        var total = int.Parse(W_Land_Pips.Text) + int.Parse(U_Land_Pips.Text) + int.Parse(B_Land_Pips.Text) +
                    int.Parse(R_Land_Pips.Text) + int.Parse(W_Land_Pips.Text);
        if (total == 0) return new Dictionary<char, double>();
        var dict = new System.Collections.Generic.Dictionary<char, double>()
        {
            {'W', (double)int.Parse(W_Land_Pips.Text) / total},
            {'U', (double)int.Parse(U_Land_Pips.Text) / total},
            {'B', (double)int.Parse(B_Land_Pips.Text) / total},
            {'R', (double)int.Parse(R_Land_Pips.Text) / total},
            {'G', (double)int.Parse(W_Land_Pips.Text) / total}
        };
        return dict;
    }

    private Dictionary<int, int> get_curve()
    { 
        Dictionary<int,int> curve = new Dictionary<int, int>()
        {
            { 0, int.Parse(ZeroMana.Text)},
            { 1, int.Parse(OneMana.Text)},
            { 2, int.Parse(TwoMana.Text)},
            { 3, int.Parse(ThreeMana.Text)},
            { 4, int.Parse(FourMana.Text)},
            { 5, int.Parse(FiveMana.Text)},
            { 6, int.Parse(SixMana.Text)},
            { 7, int.Parse(SevenMana.Text)}
        };
        return curve;
    }

    [SuppressMessage("ReSharper", "PossibleLossOfFraction")]
    private static Dictionary<int, double> make_mana_histogram(Dictionary<int, int> curve)
    {
        var histogram = new Dictionary<int, double>();
        var total = curve.Values.Sum();
        if (total==0) {return histogram;}
        foreach (var key in curve.Keys)
        {
            var val = (double) curve[key] / total;
            histogram.Add(key, val);
        }
        return histogram;
    }
    
    private void CalculateButton_Click(object sender, EventArgs e) 
    {
        var manaHistogram = make_mana_histogram(get_curve());
        var SpellPipHistogram = make_spell_pip_histogram();
        var LandPipHistogram = make_land_pip_histogram();
        
        _issues.Clear();
        try
        {

            if (GreaterThanEqualTo(HandSize, DeckSize, int.Parse(CopiesInDeck.Text), CopiesWanted) <= 0.5)
            {
                _issues.Add("Odds of opening 3 or more lands <= 50%: Consider more lands for consistency");
            }

            if (manaHistogram[0] + manaHistogram[1] + manaHistogram[2] < 0.3)
            {
                _issues.Add("You may be lacking plays in the early game: Consider more cheap spells.");
            }

            if (manaHistogram[0] + manaHistogram[1] + manaHistogram[2] > 0.7)
            {
                _issues.Add("You are running a lot of cheap spells, you may lack meaningful plays in the late game.");
            }

            if (manaHistogram[7] + manaHistogram[6] + manaHistogram[5] > 0.2)
            {
                _issues.Add("Your curve is potentially top-heavy: Consider playing more cheap spells.");
            }

            foreach (var key in SpellPipHistogram.Keys)
            {
                if (SpellPipHistogram[key] > LandPipHistogram[key] + 0.15)
                {
                    _issues.Add($"Not enough {key} producing Lands. \n Spell Pips : Land Pips" +
                                $" \n {SpellPipHistogram[key]} : {LandPipHistogram[key]}");
                } else if (SpellPipHistogram[key] < LandPipHistogram[key] - 0.15)
                {
                    _issues.Add($"Too many {key} producing Lands. \n Spell Pips : Land Pips" +
                                $" \n {SpellPipHistogram[key]:F3} : {LandPipHistogram[key]:F3}");
                }
            }

        }
        catch (Exception ex)
        {
            _issues.Add(ex.Message);
        }

        IssuesBox.Text = "";
        if (_issues.Count > 0)
        {
            IssuesBox.Text = string.Join("\n", _issues);
        }
        else
        {
            IssuesBox.Text = @"No issues found.";
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