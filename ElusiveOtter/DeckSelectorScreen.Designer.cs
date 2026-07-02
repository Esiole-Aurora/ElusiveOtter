using System.ComponentModel;

namespace Deck_Randomiser_3;

partial class DeckSelectorScreen
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
        NoOfDecks = new System.Windows.Forms.Label();
        NoSelectBox = new System.Windows.Forms.TextBox();
        SelectButton = new System.Windows.Forms.Button();
        RerollButton = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        MaxBracket = new System.Windows.Forms.TextBox();
        MinBracket = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // NoOfDecks
        // 
        NoOfDecks.Location = new System.Drawing.Point(40, 30);
        NoOfDecks.Name = "NoOfDecks";
        NoOfDecks.Size = new System.Drawing.Size(160, 23);
        NoOfDecks.TabIndex = 0;
        NoOfDecks.Text = "Number of Decks:";
        // 
        // NoSelectBox
        // 
        NoSelectBox.Location = new System.Drawing.Point(167, 26);
        NoSelectBox.Name = "NoSelectBox";
        NoSelectBox.Size = new System.Drawing.Size(100, 27);
        NoSelectBox.TabIndex = 1;
        // 
        // SelectButton
        // 
        SelectButton.Location = new System.Drawing.Point(273, 22);
        SelectButton.Name = "SelectButton";
        SelectButton.Size = new System.Drawing.Size(79, 31);
        SelectButton.TabIndex = 2;
        SelectButton.Text = "SELECT";
        SelectButton.UseVisualStyleBackColor = true;
        SelectButton.Click += SelectButton_Click;
        // 
        // RerollButton
        // 
        RerollButton.Location = new System.Drawing.Point(358, 22);
        RerollButton.Name = "RerollButton";
        RerollButton.Size = new System.Drawing.Size(79, 31);
        RerollButton.TabIndex = 3;
        RerollButton.Text = "REROLL";
        RerollButton.UseVisualStyleBackColor = true;
        RerollButton.Click += RerollButton_Click;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(444, 423);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 4;
        label1.Text = "Min Bracket: ";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(444, 471);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 5;
        label2.Text = "Max Bracket: ";
        // 
        // MaxBracket
        // 
        MaxBracket.Location = new System.Drawing.Point(537, 467);
        MaxBracket.Name = "MaxBracket";
        MaxBracket.Size = new System.Drawing.Size(70, 27);
        MaxBracket.TabIndex = 7;
        MaxBracket.Text = "5";
        MaxBracket.TextChanged += MaxBracket_TextChanged;
        // 
        // MinBracket
        // 
        MinBracket.Location = new System.Drawing.Point(537, 419);
        MinBracket.Name = "MinBracket";
        MinBracket.Size = new System.Drawing.Size(70, 27);
        MinBracket.TabIndex = 8;
        MinBracket.Text = "1";
        MinBracket.TextChanged += MinBracket_TextChanged;
        // 
        // DeckSelectorScreen
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.LightSlateGray;
        Controls.Add(MinBracket);
        Controls.Add(MaxBracket);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(RerollButton);
        Controls.Add(SelectButton);
        Controls.Add(NoSelectBox);
        Controls.Add(NoOfDecks);
        Size = new System.Drawing.Size(637, 553);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox MinBracket;

    private System.Windows.Forms.TextBox MaxBracket;

    private System.Windows.Forms.TextBox NoSelectBox;
    private System.Windows.Forms.Button SelectButton;
    private System.Windows.Forms.Button RerollButton;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label NoOfDecks;

    #endregion
}