using System.ComponentModel;

namespace Deck_Randomiser_3;

partial class RulingsScreen
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
        CardName = new System.Windows.Forms.TextBox();
        Rulings = new System.Windows.Forms.RichTextBox();
        SearchButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // CardName
        // 
        CardName.Location = new System.Drawing.Point(40, 65);
        CardName.Name = "CardName";
        CardName.PlaceholderText = "SET/ID";
        CardName.Size = new System.Drawing.Size(300, 27);
        CardName.TabIndex = 0;
        // 
        // Rulings
        // 
        Rulings.Location = new System.Drawing.Point(40, 98);
        Rulings.Name = "Rulings";
        Rulings.Size = new System.Drawing.Size(300, 407);
        Rulings.TabIndex = 1;
        Rulings.Text = "";
        // 
        // SearchButton
        // 
        SearchButton.Location = new System.Drawing.Point(346, 65);
        SearchButton.Name = "SearchButton";
        SearchButton.Size = new System.Drawing.Size(112, 27);
        SearchButton.TabIndex = 2;
        SearchButton.Text = "SEARCH";
        SearchButton.UseVisualStyleBackColor = true;
        SearchButton.Click += SearchButton_Click;
        // 
        // RulingsScreen
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.LightSlateGray;
        Controls.Add(SearchButton);
        Controls.Add(Rulings);
        Controls.Add(CardName);
        Size = new System.Drawing.Size(637, 533);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.RichTextBox Rulings;
    private System.Windows.Forms.Button SearchButton;

    private System.Windows.Forms.TextBox CardName;

    #endregion
}