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
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        CopiesInDeck = new System.Windows.Forms.TextBox();
        CalculateButton = new System.Windows.Forms.Button();
        OutputPanel = new System.Windows.Forms.Panel();
        IssuesBox = new System.Windows.Forms.RichTextBox();
        InputPanel = new System.Windows.Forms.Panel();
        OutputPanel.SuspendLayout();
        InputPanel.SuspendLayout();
        SuspendLayout();
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
        label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.ForeColor = System.Drawing.Color.White;
        label3.Location = new System.Drawing.Point(3, 413);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(117, 23);
        label3.TabIndex = 2;
        label3.Text = "Lands in Deck: ";
        // 
        // CopiesInDeck
        // 
        CopiesInDeck.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        CopiesInDeck.BorderStyle = System.Windows.Forms.BorderStyle.None;
        CopiesInDeck.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        CopiesInDeck.Location = new System.Drawing.Point(113, 413);
        CopiesInDeck.Name = "CopiesInDeck";
        CopiesInDeck.Size = new System.Drawing.Size(100, 20);
        CopiesInDeck.TabIndex = 8;
        CopiesInDeck.Text = "1";
        // 
        // CalculateButton
        // 
        CalculateButton.BackColor = System.Drawing.Color.FromArgb(((int)((byte)91)), ((int)((byte)106)), ((int)((byte)240)));
        CalculateButton.Cursor = System.Windows.Forms.Cursors.Hand;
        CalculateButton.Dock = System.Windows.Forms.DockStyle.Bottom;
        CalculateButton.FlatAppearance.BorderSize = 0;
        CalculateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)70)), ((int)((byte)88)), ((int)((byte)210)));
        CalculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)120)), ((int)((byte)248)));
        CalculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        CalculateButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        CalculateButton.ForeColor = System.Drawing.Color.White;
        CalculateButton.Location = new System.Drawing.Point(0, 491);
        CalculateButton.Name = "CalculateButton";
        CalculateButton.Size = new System.Drawing.Size(321, 62);
        CalculateButton.TabIndex = 9;
        CalculateButton.Text = "CALCULATE";
        CalculateButton.UseVisualStyleBackColor = false;
        CalculateButton.Click += CalculateButton_Click;
        // 
        // OutputPanel
        // 
        OutputPanel.BackColor = System.Drawing.Color.LightSlateGray;
        OutputPanel.Controls.Add(IssuesBox);
        OutputPanel.Dock = System.Windows.Forms.DockStyle.Right;
        OutputPanel.Location = new System.Drawing.Point(321, 0);
        OutputPanel.Name = "OutputPanel";
        OutputPanel.Size = new System.Drawing.Size(316, 553);
        OutputPanel.TabIndex = 10;
        // 
        // IssuesBox
        // 
        IssuesBox.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        IssuesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
        IssuesBox.Dock = System.Windows.Forms.DockStyle.Bottom;
        IssuesBox.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        IssuesBox.Location = new System.Drawing.Point(0, 406);
        IssuesBox.Name = "IssuesBox";
        IssuesBox.ReadOnly = true;
        IssuesBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
        IssuesBox.Size = new System.Drawing.Size(316, 147);
        IssuesBox.TabIndex = 0;
        IssuesBox.TabStop = false;
        IssuesBox.Text = "";
        // 
        // InputPanel
        // 
        InputPanel.BackColor = System.Drawing.Color.LightSlateGray;
        InputPanel.Controls.Add(CopiesInDeck);
        InputPanel.Controls.Add(label3);
        InputPanel.Controls.Add(CalculateButton);
        InputPanel.Dock = System.Windows.Forms.DockStyle.Left;
        InputPanel.Location = new System.Drawing.Point(0, 0);
        InputPanel.Name = "InputPanel";
        InputPanel.Size = new System.Drawing.Size(321, 553);
        InputPanel.TabIndex = 11;
        // 
        // StatsCalcScreen
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.LightSlateGray;
        Controls.Add(InputPanel);
        Controls.Add(OutputPanel);
        Controls.Add(label2);
        Size = new System.Drawing.Size(637, 553);
        OutputPanel.ResumeLayout(false);
        InputPanel.ResumeLayout(false);
        InputPanel.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.RichTextBox IssuesBox;

    private System.Windows.Forms.Panel InputPanel;

    private System.Windows.Forms.Panel OutputPanel;

    private System.Windows.Forms.Button CalculateButton;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox CopiesInDeck;

    private System.Windows.Forms.Label label2;

    #endregion
}