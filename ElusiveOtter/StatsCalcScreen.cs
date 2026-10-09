using System.Diagnostics.CodeAnalysis;

namespace Deck_Randomiser_3;

public partial class StatsCalcScreen : UserControl
{
    private const int HandSize = 7;
    private const int CopiesWanted = 3;
    private const int DeckSize = 99;
    private readonly List<string> _issues = [];

    private static readonly Color[] ManaSwatch =
    [
        Color.FromArgb(248, 231, 160), // W
        Color.FromArgb(106, 173, 223), // U
        Color.FromArgb(176, 122, 204), // B
        Color.FromArgb(232, 120, 88), // R
        Color.FromArgb(88, 200, 122) // G
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
            { 'W', (double)int.Parse(W_Spell_Pips.Text) / total },
            { 'U', (double)int.Parse(U_Spell_Pips.Text) / total },
            { 'B', (double)int.Parse(B_Spell_Pips.Text) / total },
            { 'R', (double)int.Parse(R_Spell_Pips.Text) / total },
            { 'G', (double)int.Parse(W_Spell_Pips.Text) / total }
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
            { 'W', (double)int.Parse(W_Land_Pips.Text) / total },
            { 'U', (double)int.Parse(U_Land_Pips.Text) / total },
            { 'B', (double)int.Parse(B_Land_Pips.Text) / total },
            { 'R', (double)int.Parse(R_Land_Pips.Text) / total },
            { 'G', (double)int.Parse(W_Land_Pips.Text) / total }
        };
        return dict;
    }

    private Dictionary<int, int> get_curve()
    {
        Dictionary<int, int> curve = new Dictionary<int, int>()
        {
            { 0, int.Parse(ZeroMana.Text) },
            { 1, int.Parse(OneMana.Text) },
            { 2, int.Parse(TwoMana.Text) },
            { 3, int.Parse(ThreeMana.Text) },
            { 4, int.Parse(FourMana.Text) },
            { 5, int.Parse(FiveMana.Text) },
            { 6, int.Parse(SixMana.Text) },
            { 7, int.Parse(SevenMana.Text) }
        };
        return curve;
    }

    [SuppressMessage("ReSharper", "PossibleLossOfFraction")]
    private static Dictionary<int, double> make_mana_histogram(Dictionary<int, int> curve)
    {
        var histogram = new Dictionary<int, double>();
        var total = curve.Values.Sum();
        if (total == 0)
        {
            return histogram;
        }

        foreach (var key in curve.Keys)
        {
            var val = (double)curve[key] / total;
            histogram.Add(key, val);
        }

        return histogram;
    }

    private void CalculateButton_Click(object sender, EventArgs e)
    {
        var curve = get_curve();
        var manaHistogram = make_mana_histogram(curve);
        var spellPipHistogram = make_spell_pip_histogram();
        var landPipHistogram = make_land_pip_histogram();

        _issues.Clear();
        try
        {
            var avgMv = 0;
            var total = 0;
            var landCount = int.Parse(CopiesInDeck.Text);
            var rampCount = int.Parse(RampInDeck.Text);

            foreach (var key in curve.Keys)
            {
                avgMv += curve[key] * key;
                total += curve[key];
            }

            var startPoint = 31.42;
            var commandCost = int.Parse(CommanderCost.Text);
            //ToDo: Play with numbers here, find optimal values
            startPoint += commandCost / 3;
            // ReSharper disable once IntDivisionByZero
            avgMv /= total;
            var recommendedLands = startPoint + (3.13 * avgMv) - (0.28 * rampCount);

            if (landCount < recommendedLands)
            {
                _issues.Add($"Land count is below recommended amount of {recommendedLands:F3}");
            }

            if (landCount > recommendedLands + 3)
            {
                _issues.Add(
                    $"Land count is significantly over recommended amount of {recommendedLands:F3}, it is likely that you may flood");
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

            foreach (var key in spellPipHistogram.Keys)
            {
                if (spellPipHistogram[key] > landPipHistogram[key] + 0.15)
                {
                    _issues.Add($"Not enough {key} producing Lands. \n Spell Pips : Land Pips" +
                                $"\n{spellPipHistogram[key]} : {landPipHistogram[key]}");
                }
                else if (spellPipHistogram[key] < landPipHistogram[key] - 0.15)
                {
                    _issues.Add($"Too many {key} producing Lands. \n Spell Pips : Land Pips" +
                                $"\n{spellPipHistogram[key]:F3} : {landPipHistogram[key]:F3}");
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
}