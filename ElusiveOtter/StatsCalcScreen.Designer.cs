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
        CMC_Input_Panel = new System.Windows.Forms.Panel();
        label11 = new System.Windows.Forms.Label();
        label10 = new System.Windows.Forms.Label();
        label9 = new System.Windows.Forms.Label();
        label8 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        label4 = new System.Windows.Forms.Label();
        label1 = new System.Windows.Forms.Label();
        SevenMana = new System.Windows.Forms.TextBox();
        SixMana = new System.Windows.Forms.TextBox();
        FiveMana = new System.Windows.Forms.TextBox();
        FourMana = new System.Windows.Forms.TextBox();
        ThreeMana = new System.Windows.Forms.TextBox();
        TwoMana = new System.Windows.Forms.TextBox();
        OneMana = new System.Windows.Forms.TextBox();
        ZeroMana = new System.Windows.Forms.TextBox();
        panel1 = new System.Windows.Forms.Panel();
        textBox1 = new System.Windows.Forms.TextBox();
        textBox2 = new System.Windows.Forms.TextBox();
        textBox3 = new System.Windows.Forms.TextBox();
        textBox4 = new System.Windows.Forms.TextBox();
        textBox5 = new System.Windows.Forms.TextBox();
        label12 = new System.Windows.Forms.Label();
        OutputPanel.SuspendLayout();
        InputPanel.SuspendLayout();
        CMC_Input_Panel.SuspendLayout();
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
        label3.Location = new System.Drawing.Point(14, 24);
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
        CopiesInDeck.Location = new System.Drawing.Point(124, 24);
        CopiesInDeck.Name = "CopiesInDeck";
        CopiesInDeck.Size = new System.Drawing.Size(100, 20);
        CopiesInDeck.TabIndex = 8;
        CopiesInDeck.Text = "36";
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
        InputPanel.Controls.Add(label12);
        InputPanel.Controls.Add(textBox5);
        InputPanel.Controls.Add(textBox4);
        InputPanel.Controls.Add(textBox3);
        InputPanel.Controls.Add(textBox2);
        InputPanel.Controls.Add(textBox1);
        InputPanel.Controls.Add(CMC_Input_Panel);
        InputPanel.Controls.Add(CopiesInDeck);
        InputPanel.Controls.Add(label3);
        InputPanel.Controls.Add(CalculateButton);
        InputPanel.Dock = System.Windows.Forms.DockStyle.Left;
        InputPanel.Location = new System.Drawing.Point(0, 0);
        InputPanel.Name = "InputPanel";
        InputPanel.Size = new System.Drawing.Size(321, 553);
        InputPanel.TabIndex = 11;
        // 
        // CMC_Input_Panel
        // 
        CMC_Input_Panel.Controls.Add(panel1);
        CMC_Input_Panel.Controls.Add(label11);
        CMC_Input_Panel.Controls.Add(label10);
        CMC_Input_Panel.Controls.Add(label9);
        CMC_Input_Panel.Controls.Add(label8);
        CMC_Input_Panel.Controls.Add(label7);
        CMC_Input_Panel.Controls.Add(label6);
        CMC_Input_Panel.Controls.Add(label5);
        CMC_Input_Panel.Controls.Add(label4);
        CMC_Input_Panel.Controls.Add(label1);
        CMC_Input_Panel.Controls.Add(SevenMana);
        CMC_Input_Panel.Controls.Add(SixMana);
        CMC_Input_Panel.Controls.Add(FiveMana);
        CMC_Input_Panel.Controls.Add(FourMana);
        CMC_Input_Panel.Controls.Add(ThreeMana);
        CMC_Input_Panel.Controls.Add(TwoMana);
        CMC_Input_Panel.Controls.Add(OneMana);
        CMC_Input_Panel.Controls.Add(ZeroMana);
        CMC_Input_Panel.Location = new System.Drawing.Point(0, 71);
        CMC_Input_Panel.Name = "CMC_Input_Panel";
        CMC_Input_Panel.Size = new System.Drawing.Size(321, 100);
        CMC_Input_Panel.TabIndex = 10;
        // 
        // label11
        // 
        label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label11.ForeColor = System.Drawing.Color.White;
        label11.Location = new System.Drawing.Point(3, 0);
        label11.Name = "label11";
        label11.Size = new System.Drawing.Size(100, 23);
        label11.TabIndex = 12;
        label11.Text = "Mana Curve:";
        // 
        // label10
        // 
        label10.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label10.ForeColor = System.Drawing.Color.White;
        label10.Location = new System.Drawing.Point(268, 49);
        label10.Name = "label10";
        label10.Size = new System.Drawing.Size(43, 23);
        label10.TabIndex = 11;
        label10.Text = "7+";
        label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label9
        // 
        label9.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label9.ForeColor = System.Drawing.Color.White;
        label9.Location = new System.Drawing.Point(235, 49);
        label9.Name = "label9";
        label9.Size = new System.Drawing.Size(31, 23);
        label9.TabIndex = 11;
        label9.Text = "6";
        label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label8
        // 
        label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label8.ForeColor = System.Drawing.Color.White;
        label8.Location = new System.Drawing.Point(198, 49);
        label8.Name = "label8";
        label8.Size = new System.Drawing.Size(31, 23);
        label8.TabIndex = 11;
        label8.Text = "5";
        label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label7
        // 
        label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label7.ForeColor = System.Drawing.Color.White;
        label7.Location = new System.Drawing.Point(161, 49);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(31, 23);
        label7.TabIndex = 11;
        label7.Text = "4";
        label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label6
        // 
        label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label6.ForeColor = System.Drawing.Color.White;
        label6.Location = new System.Drawing.Point(124, 49);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(31, 23);
        label6.TabIndex = 11;
        label6.Text = "3";
        label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label5
        // 
        label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label5.ForeColor = System.Drawing.Color.White;
        label5.Location = new System.Drawing.Point(87, 49);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(31, 23);
        label5.TabIndex = 11;
        label5.Text = "2";
        label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label4
        // 
        label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label4.ForeColor = System.Drawing.Color.White;
        label4.Location = new System.Drawing.Point(50, 49);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(31, 23);
        label4.TabIndex = 9;
        label4.Text = "1";
        label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.White;
        label1.Location = new System.Drawing.Point(13, 49);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(31, 23);
        label1.TabIndex = 8;
        label1.Text = "0";
        label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // SevenMana
        // 
        SevenMana.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        SevenMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
        SevenMana.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        SevenMana.Location = new System.Drawing.Point(272, 26);
        SevenMana.Name = "SevenMana";
        SevenMana.Size = new System.Drawing.Size(31, 20);
        SevenMana.TabIndex = 7;
        SevenMana.Text = "0";
        // 
        // SixMana
        // 
        SixMana.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        SixMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
        SixMana.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        SixMana.Location = new System.Drawing.Point(235, 26);
        SixMana.Name = "SixMana";
        SixMana.Size = new System.Drawing.Size(31, 20);
        SixMana.TabIndex = 6;
        SixMana.Text = "0";
        // 
        // FiveMana
        // 
        FiveMana.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        FiveMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
        FiveMana.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        FiveMana.Location = new System.Drawing.Point(198, 26);
        FiveMana.Name = "FiveMana";
        FiveMana.Size = new System.Drawing.Size(31, 20);
        FiveMana.TabIndex = 5;
        FiveMana.Text = "0";
        // 
        // FourMana
        // 
        FourMana.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        FourMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
        FourMana.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        FourMana.Location = new System.Drawing.Point(161, 26);
        FourMana.Name = "FourMana";
        FourMana.Size = new System.Drawing.Size(31, 20);
        FourMana.TabIndex = 4;
        FourMana.Text = "0";
        // 
        // ThreeMana
        // 
        ThreeMana.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        ThreeMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
        ThreeMana.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        ThreeMana.Location = new System.Drawing.Point(124, 26);
        ThreeMana.Name = "ThreeMana";
        ThreeMana.Size = new System.Drawing.Size(31, 20);
        ThreeMana.TabIndex = 3;
        ThreeMana.Text = "0";
        // 
        // TwoMana
        // 
        TwoMana.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        TwoMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
        TwoMana.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        TwoMana.Location = new System.Drawing.Point(87, 26);
        TwoMana.Name = "TwoMana";
        TwoMana.Size = new System.Drawing.Size(31, 20);
        TwoMana.TabIndex = 2;
        TwoMana.Text = "0";
        // 
        // OneMana
        // 
        OneMana.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        OneMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
        OneMana.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        OneMana.Location = new System.Drawing.Point(50, 26);
        OneMana.Name = "OneMana";
        OneMana.Size = new System.Drawing.Size(31, 20);
        OneMana.TabIndex = 1;
        OneMana.Text = "0";
        // 
        // ZeroMana
        // 
        ZeroMana.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        ZeroMana.BorderStyle = System.Windows.Forms.BorderStyle.None;
        ZeroMana.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        ZeroMana.Location = new System.Drawing.Point(13, 26);
        ZeroMana.Name = "ZeroMana";
        ZeroMana.Size = new System.Drawing.Size(31, 20);
        ZeroMana.TabIndex = 0;
        ZeroMana.Text = "0";
        // 
        // panel1
        // 
        panel1.Location = new System.Drawing.Point(3, 106);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(318, 100);
        panel1.TabIndex = 11;
        // 
        // textBox1
        // 
        textBox1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        textBox1.Location = new System.Drawing.Point(13, 194);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(31, 20);
        textBox1.TabIndex = 11;
        // 
        // textBox2
        // 
        textBox2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
        textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        textBox2.Location = new System.Drawing.Point(50, 194);
        textBox2.Name = "textBox2";
        textBox2.Size = new System.Drawing.Size(31, 20);
        textBox2.TabIndex = 12;
        // 
        // textBox3
        // 
        textBox3.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
        textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        textBox3.Location = new System.Drawing.Point(87, 194);
        textBox3.Name = "textBox3";
        textBox3.Size = new System.Drawing.Size(31, 20);
        textBox3.TabIndex = 13;
        // 
        // textBox4
        // 
        textBox4.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
        textBox4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        textBox4.Location = new System.Drawing.Point(124, 194);
        textBox4.Name = "textBox4";
        textBox4.Size = new System.Drawing.Size(31, 20);
        textBox4.TabIndex = 14;
        // 
        // textBox5
        // 
        textBox5.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
        textBox5.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        textBox5.Location = new System.Drawing.Point(161, 194);
        textBox5.Name = "textBox5";
        textBox5.Size = new System.Drawing.Size(31, 20);
        textBox5.TabIndex = 15;
        // 
        // label12
        // 
        label12.ForeColor = System.Drawing.Color.White;
        label12.Location = new System.Drawing.Point(129, 259);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(100, 23);
        label12.TabIndex = 16;
        label12.Text = "Spell Pips:";
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
        CMC_Input_Panel.ResumeLayout(false);
        CMC_Input_Panel.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.TextBox textBox4;
    private System.Windows.Forms.TextBox textBox5;
    private System.Windows.Forms.Label label12;

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox textBox1;

    private System.Windows.Forms.Label label11;

    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label10;

    private System.Windows.Forms.TextBox OneMana;
    private System.Windows.Forms.TextBox TwoMana;
    private System.Windows.Forms.TextBox ThreeMana;
    private System.Windows.Forms.TextBox FourMana;
    private System.Windows.Forms.TextBox FiveMana;
    private System.Windows.Forms.TextBox SixMana;
    private System.Windows.Forms.TextBox SevenMana;
    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox ZeroMana;

    private System.Windows.Forms.Panel CMC_Input_Panel;


    private System.Windows.Forms.RichTextBox IssuesBox;

    private System.Windows.Forms.Panel InputPanel;

    private System.Windows.Forms.Panel OutputPanel;

    private System.Windows.Forms.Button CalculateButton;

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox CopiesInDeck;

    private System.Windows.Forms.Label label2;

    #endregion
}