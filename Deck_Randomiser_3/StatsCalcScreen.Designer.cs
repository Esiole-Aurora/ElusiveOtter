using System.ComponentModel;

namespace Deck_Randomiser_3;

partial class StatsCalcScreen
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        CopiesWanted = new System.Windows.Forms.TextBox();
        HandSize = new System.Windows.Forms.TextBox();
        DeckSize = new System.Windows.Forms.TextBox();
        CopiesInDeck = new System.Windows.Forms.TextBox();
        CalculateButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(40, 30);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 0;
        label1.Text = "Size of Deck:";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(0, 0);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 1;
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(40, 63);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(117, 23);
        label3.TabIndex = 2;
        label3.Text = "Copies in Deck:";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(40, 129);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(178, 23);
        label4.TabIndex = 3;
        label4.Text = "Copies Wanted in Hand:";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(40, 96);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(140, 23);
        label5.TabIndex = 4;
        label5.Text = "Cards in Opening:";
        // 
        // CopiesWanted
        // 
        CopiesWanted.Location = new System.Drawing.Point(210, 125);
        CopiesWanted.Name = "CopiesWanted";
        CopiesWanted.Size = new System.Drawing.Size(100, 27);
        CopiesWanted.TabIndex = 5;
        CopiesWanted.Text = "3";
        // 
        // HandSize
        // 
        HandSize.Location = new System.Drawing.Point(210, 92);
        HandSize.Name = "HandSize";
        HandSize.Size = new System.Drawing.Size(100, 27);
        HandSize.TabIndex = 6;
        HandSize.Text = "7";
        // 
        // DeckSize
        // 
        DeckSize.Location = new System.Drawing.Point(210, 26);
        DeckSize.Name = "DeckSize";
        DeckSize.Size = new System.Drawing.Size(100, 27);
        DeckSize.TabIndex = 7;
        DeckSize.Text = "99";
        // 
        // CopiesInDeck
        // 
        CopiesInDeck.Location = new System.Drawing.Point(210, 59);
        CopiesInDeck.Name = "CopiesInDeck";
        CopiesInDeck.Size = new System.Drawing.Size(100, 27);
        CopiesInDeck.TabIndex = 8;
        CopiesInDeck.Text = "1";
        // 
        // CalculateButton
        // 
        CalculateButton.Location = new System.Drawing.Point(40, 164);
        CalculateButton.Name = "CalculateButton";
        CalculateButton.Size = new System.Drawing.Size(270, 36);
        CalculateButton.TabIndex = 9;
        CalculateButton.Text = "CALCULATE";
        CalculateButton.UseVisualStyleBackColor = true;
        CalculateButton.Click += CalculateButton_Click;
        // 
        // StatsCalcScreen
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.LightSlateGray;
        Controls.Add(CalculateButton);
        Controls.Add(CopiesInDeck);
        Controls.Add(DeckSize);
        Controls.Add(HandSize);
        Controls.Add(CopiesWanted);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label1);
        Controls.Add(label2);
        Size = new System.Drawing.Size(637, 553);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button CalculateButton;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox CopiesWanted;
    private System.Windows.Forms.TextBox HandSize;
    private System.Windows.Forms.TextBox DeckSize;
    private System.Windows.Forms.TextBox CopiesInDeck;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    #endregion
}