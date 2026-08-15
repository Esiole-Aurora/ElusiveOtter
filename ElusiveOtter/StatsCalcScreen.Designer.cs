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
        WhiteButton = new System.Windows.Forms.CheckBox();
        idInput = new System.Windows.Forms.Panel();
        label8 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        GreenButton = new System.Windows.Forms.RadioButton();
        RedButton = new System.Windows.Forms.RadioButton();
        BlackButton = new System.Windows.Forms.RadioButton();
        BlueButton = new System.Windows.Forms.RadioButton();
        label1 = new System.Windows.Forms.Label();
        panel2 = new System.Windows.Forms.Panel();
        OutputPanel.SuspendLayout();
        InputPanel.SuspendLayout();
        idInput.SuspendLayout();
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
        InputPanel.Controls.Add(WhiteButton);
        InputPanel.Controls.Add(idInput);
        InputPanel.Controls.Add(CopiesInDeck);
        InputPanel.Controls.Add(label3);
        InputPanel.Controls.Add(CalculateButton);
        InputPanel.Dock = System.Windows.Forms.DockStyle.Left;
        InputPanel.Location = new System.Drawing.Point(0, 0);
        InputPanel.Name = "InputPanel";
        InputPanel.Size = new System.Drawing.Size(321, 553);
        InputPanel.TabIndex = 11;
        // 
        // WhiteButton
        // 
        WhiteButton.Location = new System.Drawing.Point(139, 20);
        WhiteButton.Name = "WhiteButton";
        WhiteButton.Size = new System.Drawing.Size(21, 24);
        WhiteButton.TabIndex = 11;
        WhiteButton.UseVisualStyleBackColor = true;
        // 
        // idInput
        // 
        idInput.Controls.Add(label8);
        idInput.Controls.Add(label7);
        idInput.Controls.Add(label6);
        idInput.Controls.Add(label5);
        idInput.Controls.Add(label4);
        idInput.Controls.Add(GreenButton);
        idInput.Controls.Add(RedButton);
        idInput.Controls.Add(BlackButton);
        idInput.Controls.Add(BlueButton);
        idInput.Controls.Add(label1);
        idInput.Controls.Add(panel2);
        idInput.Location = new System.Drawing.Point(0, 0);
        idInput.Name = "idInput";
        idInput.Size = new System.Drawing.Size(321, 75);
        idInput.TabIndex = 10;
        // 
        // label8
        // 
        label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label8.ForeColor = System.Drawing.Color.White;
        label8.Location = new System.Drawing.Point(241, 47);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(22, 23);
        label8.TabIndex = 18;
        label8.Text = "G";
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.ForeColor = System.Drawing.Color.White;
        label7.Location = new System.Drawing.Point(215, 47);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(22, 23);
        label7.TabIndex = 18;
        label7.Text = "R";
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.ForeColor = System.Drawing.Color.White;
        label6.Location = new System.Drawing.Point(189, 47);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(22, 23);
        label6.TabIndex = 18;
        label6.Text = "B";
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.ForeColor = System.Drawing.Color.White;
        label5.Location = new System.Drawing.Point(163, 47);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(22, 23);
        label5.TabIndex = 18;
        label5.Text = "U";
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.Color.White;
        label4.Location = new System.Drawing.Point(137, 47);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(22, 23);
        label4.TabIndex = 17;
        label4.Text = "W";
        // 
        // GreenButton
        // 
        GreenButton.Location = new System.Drawing.Point(243, 20);
        GreenButton.Name = "GreenButton";
        GreenButton.Size = new System.Drawing.Size(20, 24);
        GreenButton.TabIndex = 16;
        GreenButton.TabStop = true;
        GreenButton.UseVisualStyleBackColor = true;
        // 
        // RedButton
        // 
        RedButton.Location = new System.Drawing.Point(217, 20);
        RedButton.Name = "RedButton";
        RedButton.Size = new System.Drawing.Size(20, 24);
        RedButton.TabIndex = 16;
        RedButton.TabStop = true;
        RedButton.UseVisualStyleBackColor = true;
        // 
        // BlackButton
        // 
        BlackButton.Location = new System.Drawing.Point(191, 20);
        BlackButton.Name = "BlackButton";
        BlackButton.Size = new System.Drawing.Size(20, 24);
        BlackButton.TabIndex = 15;
        BlackButton.TabStop = true;
        BlackButton.UseVisualStyleBackColor = true;
        // 
        // BlueButton
        // 
        BlueButton.Location = new System.Drawing.Point(165, 20);
        BlueButton.Name = "BlueButton";
        BlueButton.Size = new System.Drawing.Size(20, 24);
        BlueButton.TabIndex = 14;
        BlueButton.TabStop = true;
        BlueButton.UseVisualStyleBackColor = true;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.White;
        label1.Location = new System.Drawing.Point(13, 20);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(120, 23);
        label1.TabIndex = 12;
        label1.Text = "Colour Identity: ";
        // 
        // panel2
        // 
        panel2.Location = new System.Drawing.Point(0, 93);
        panel2.Name = "panel2";
        panel2.Size = new System.Drawing.Size(321, 87);
        panel2.TabIndex = 11;
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
        idInput.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.CheckBox WhiteButton;

    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;


    private System.Windows.Forms.RadioButton BlueButton;
    private System.Windows.Forms.RadioButton BlackButton;
    private System.Windows.Forms.RadioButton RedButton;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.RadioButton GreenButton;

    private System.Windows.Forms.Panel idInput;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.RichTextBox IssuesBox;

    private System.Windows.Forms.Panel InputPanel;

    private System.Windows.Forms.Panel OutputPanel;

    private System.Windows.Forms.Button CalculateButton;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox CopiesInDeck;

    private System.Windows.Forms.Label label2;

    #endregion
}