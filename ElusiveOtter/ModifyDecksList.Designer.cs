using System.ComponentModel;

namespace Deck_Randomiser_3;

partial class ModifyDecksList
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
        DeckNamesBox = new System.Windows.Forms.RichTextBox();
        SaveButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // DeckNamesBox
        // 
        DeckNamesBox.Location = new System.Drawing.Point(40, 30);
        DeckNamesBox.Name = "DeckNamesBox";
        DeckNamesBox.Size = new System.Drawing.Size(412, 480);
        DeckNamesBox.TabIndex = 0;
        DeckNamesBox.Text = "";
        // 
        // SaveButton
        // 
        SaveButton.Location = new System.Drawing.Point(471, 448);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new System.Drawing.Size(147, 62);
        SaveButton.TabIndex = 1;
        SaveButton.Text = "SAVE";
        SaveButton.UseVisualStyleBackColor = true;
        SaveButton.Click += SaveButton_Click;
        // 
        // ModifyDecksList
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.LightSlateGray;
        Controls.Add(SaveButton);
        Controls.Add(DeckNamesBox);
        Size = new System.Drawing.Size(637, 533);
        Load += ModifyDecksList_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.RichTextBox DeckNamesBox;
    private System.Windows.Forms.Button SaveButton;

    #endregion
}