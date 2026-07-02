using System.Collections;
using System.Numerics;

namespace Deck_Randomiser_3;

public partial class StatsCalcScreen : UserControl
{
    
    private readonly ArrayList _labels = new ArrayList();
    
    public StatsCalcScreen()
    {
        InitializeComponent();
    }

    private void CalculateButton_Click(object sender, EventArgs e)
    {
        foreach (Label label in _labels)
        {
            this.Controls.Remove(label);
        }

        _labels.Clear();

        if (!ValidateVals()) return;
        
        for (var i = int.Parse(HandSize.Text); i < int.Parse(HandSize.Text) + 4; i++)
        {
            var label = new Label();
            label.Text = "Probability after " + i.ToString() + " draws: " +
                         (GreaterThanEqualTo(i,int.Parse(DeckSize.Text), 
                             int.Parse(CopiesInDeck.Text), int.Parse(CopiesWanted.Text)).ToString("0.##"));
            label.AutoSize = true;
            label.Location = new Point(30, ((i - int.Parse(HandSize.Text)) * 20) + 200);
            _labels.Add(label);
            this.Controls.Add(label);

        }
    }
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
        BigInteger factN = Fact(n);
        BigInteger factR = Fact(r);
        BigInteger factNr = Fact(n-r); 
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