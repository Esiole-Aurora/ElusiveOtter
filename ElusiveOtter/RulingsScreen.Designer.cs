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
        CardName.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        CardName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        CardName.Dock = System.Windows.Forms.DockStyle.Left;
        CardName.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        CardName.Location = new System.Drawing.Point(0, 0);
        CardName.Name = "CardName";
        CardName.PlaceholderText = "SET/ID";
        CardName.Size = new System.Drawing.Size(455, 27);
        CardName.TabIndex = 0;
        // 
        // Rulings
        // 
        Rulings.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        Rulings.BorderStyle = System.Windows.Forms.BorderStyle.None;
        Rulings.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        Rulings.Location = new System.Drawing.Point(0, 27);
        Rulings.Name = "Rulings";
        Rulings.ReadOnly = true;
        Rulings.Size = new System.Drawing.Size(333, 526);
        Rulings.TabIndex = 1;
        Rulings.TabStop = false;
        Rulings.Text = "";
        // 
        // SearchButton
        // 
        SearchButton.BackColor = System.Drawing.Color.FromArgb(((int)((byte)91)), ((int)((byte)106)), ((int)((byte)240)));
        SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
        SearchButton.Dock = System.Windows.Forms.DockStyle.Top;
        SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)91)), ((int)((byte)106)), ((int)((byte)240)));
        SearchButton.FlatAppearance.BorderSize = 0;
        SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)70)), ((int)((byte)88)), ((int)((byte)210)));
        SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)120)), ((int)((byte)248)));
        SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        SearchButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        SearchButton.ForeColor = System.Drawing.Color.White;
        SearchButton.Location = new System.Drawing.Point(455, 0);
        SearchButton.Name = "SearchButton";
        SearchButton.Size = new System.Drawing.Size(182, 27);
        SearchButton.TabIndex = 2;
        SearchButton.Text = "SEARCH";
        SearchButton.UseVisualStyleBackColor = false;
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
        Size = new System.Drawing.Size(637, 553);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.RichTextBox Rulings;
    private System.Windows.Forms.Button SearchButton;

    private System.Windows.Forms.TextBox CardName;

    #endregion
}