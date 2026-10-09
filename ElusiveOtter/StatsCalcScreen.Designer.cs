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
        RampInDeck = new System.Windows.Forms.TextBox();
        label24 = new System.Windows.Forms.Label();
        label23 = new System.Windows.Forms.Label();
        label18 = new System.Windows.Forms.Label();
        label19 = new System.Windows.Forms.Label();
        label20 = new System.Windows.Forms.Label();
        label21 = new System.Windows.Forms.Label();
        label22 = new System.Windows.Forms.Label();
        G_Land_Pips = new System.Windows.Forms.TextBox();
        R_Land_Pips = new System.Windows.Forms.TextBox();
        B_Land_Pips = new System.Windows.Forms.TextBox();
        U_Land_Pips = new System.Windows.Forms.TextBox();
        W_Land_Pips = new System.Windows.Forms.TextBox();
        label17 = new System.Windows.Forms.Label();
        label16 = new System.Windows.Forms.Label();
        label15 = new System.Windows.Forms.Label();
        label14 = new System.Windows.Forms.Label();
        label13 = new System.Windows.Forms.Label();
        label12 = new System.Windows.Forms.Label();
        G_Spell_Pips = new System.Windows.Forms.TextBox();
        R_Spell_Pips = new System.Windows.Forms.TextBox();
        B_Spell_Pips = new System.Windows.Forms.TextBox();
        U_Spell_Pips = new System.Windows.Forms.TextBox();
        W_Spell_Pips = new System.Windows.Forms.TextBox();
        CMC_Input_Panel = new System.Windows.Forms.Panel();
        panel1 = new System.Windows.Forms.Panel();
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
        label25 = new System.Windows.Forms.Label();
        CommanderCost = new System.Windows.Forms.TextBox();
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
        label3.Location = new System.Drawing.Point(6, 12);
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
        CopiesInDeck.Location = new System.Drawing.Point(124, 12);
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
        InputPanel.Controls.Add(CommanderCost);
        InputPanel.Controls.Add(label25);
        InputPanel.Controls.Add(RampInDeck);
        InputPanel.Controls.Add(label24);
        InputPanel.Controls.Add(label23);
        InputPanel.Controls.Add(label18);
        InputPanel.Controls.Add(label19);
        InputPanel.Controls.Add(label20);
        InputPanel.Controls.Add(label21);
        InputPanel.Controls.Add(label22);
        InputPanel.Controls.Add(G_Land_Pips);
        InputPanel.Controls.Add(R_Land_Pips);
        InputPanel.Controls.Add(B_Land_Pips);
        InputPanel.Controls.Add(U_Land_Pips);
        InputPanel.Controls.Add(W_Land_Pips);
        InputPanel.Controls.Add(label17);
        InputPanel.Controls.Add(label16);
        InputPanel.Controls.Add(label15);
        InputPanel.Controls.Add(label14);
        InputPanel.Controls.Add(label13);
        InputPanel.Controls.Add(label12);
        InputPanel.Controls.Add(G_Spell_Pips);
        InputPanel.Controls.Add(R_Spell_Pips);
        InputPanel.Controls.Add(B_Spell_Pips);
        InputPanel.Controls.Add(U_Spell_Pips);
        InputPanel.Controls.Add(W_Spell_Pips);
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
        // RampInDeck
        // 
        RampInDeck.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        RampInDeck.BorderStyle = System.Windows.Forms.BorderStyle.None;
        RampInDeck.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        RampInDeck.Location = new System.Drawing.Point(124, 35);
        RampInDeck.Name = "RampInDeck";
        RampInDeck.Size = new System.Drawing.Size(100, 20);
        RampInDeck.TabIndex = 34;
        RampInDeck.Text = "10";
        // 
        // label24
        // 
        label24.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label24.ForeColor = System.Drawing.Color.White;
        label24.Location = new System.Drawing.Point(6, 35);
        label24.Name = "label24";
        label24.Size = new System.Drawing.Size(117, 23);
        label24.TabIndex = 33;
        label24.Text = "Ramp in Deck: ";
        // 
        // label23
        // 
        label23.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label23.ForeColor = System.Drawing.Color.White;
        label23.Location = new System.Drawing.Point(6, 246);
        label23.Name = "label23";
        label23.Size = new System.Drawing.Size(100, 23);
        label23.TabIndex = 32;
        label23.Text = "Land Pips:";
        // 
        // label18
        // 
        label18.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label18.ForeColor = System.Drawing.Color.White;
        label18.Location = new System.Drawing.Point(161, 295);
        label18.Name = "label18";
        label18.Size = new System.Drawing.Size(31, 23);
        label18.TabIndex = 31;
        label18.Text = "G";
        label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label19
        // 
        label19.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label19.ForeColor = System.Drawing.Color.White;
        label19.Location = new System.Drawing.Point(124, 295);
        label19.Name = "label19";
        label19.Size = new System.Drawing.Size(31, 23);
        label19.TabIndex = 30;
        label19.Text = "R";
        label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label20
        // 
        label20.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label20.ForeColor = System.Drawing.Color.White;
        label20.Location = new System.Drawing.Point(87, 295);
        label20.Name = "label20";
        label20.Size = new System.Drawing.Size(31, 23);
        label20.TabIndex = 29;
        label20.Text = "B";
        label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label21
        // 
        label21.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label21.ForeColor = System.Drawing.Color.White;
        label21.Location = new System.Drawing.Point(50, 295);
        label21.Name = "label21";
        label21.Size = new System.Drawing.Size(31, 23);
        label21.TabIndex = 28;
        label21.Text = "U";
        label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label22
        // 
        label22.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label22.ForeColor = System.Drawing.Color.White;
        label22.Location = new System.Drawing.Point(13, 295);
        label22.Name = "label22";
        label22.Size = new System.Drawing.Size(31, 23);
        label22.TabIndex = 27;
        label22.Text = "W";
        label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // G_Land_Pips
        // 
        G_Land_Pips.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        G_Land_Pips.BorderStyle = System.Windows.Forms.BorderStyle.None;
        G_Land_Pips.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        G_Land_Pips.Location = new System.Drawing.Point(161, 272);
        G_Land_Pips.Name = "G_Land_Pips";
        G_Land_Pips.Size = new System.Drawing.Size(31, 20);
        G_Land_Pips.TabIndex = 26;
        G_Land_Pips.Text = "0";
        G_Land_Pips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // R_Land_Pips
        // 
        R_Land_Pips.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        R_Land_Pips.BorderStyle = System.Windows.Forms.BorderStyle.None;
        R_Land_Pips.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        R_Land_Pips.Location = new System.Drawing.Point(124, 272);
        R_Land_Pips.Name = "R_Land_Pips";
        R_Land_Pips.Size = new System.Drawing.Size(31, 20);
        R_Land_Pips.TabIndex = 25;
        R_Land_Pips.Text = "0";
        R_Land_Pips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // B_Land_Pips
        // 
        B_Land_Pips.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        B_Land_Pips.BorderStyle = System.Windows.Forms.BorderStyle.None;
        B_Land_Pips.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        B_Land_Pips.Location = new System.Drawing.Point(87, 272);
        B_Land_Pips.Name = "B_Land_Pips";
        B_Land_Pips.Size = new System.Drawing.Size(31, 20);
        B_Land_Pips.TabIndex = 24;
        B_Land_Pips.Text = "0";
        B_Land_Pips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // U_Land_Pips
        // 
        U_Land_Pips.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        U_Land_Pips.BorderStyle = System.Windows.Forms.BorderStyle.None;
        U_Land_Pips.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        U_Land_Pips.Location = new System.Drawing.Point(50, 272);
        U_Land_Pips.Name = "U_Land_Pips";
        U_Land_Pips.Size = new System.Drawing.Size(31, 20);
        U_Land_Pips.TabIndex = 23;
        U_Land_Pips.Text = "0";
        U_Land_Pips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // W_Land_Pips
        // 
        W_Land_Pips.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        W_Land_Pips.BorderStyle = System.Windows.Forms.BorderStyle.None;
        W_Land_Pips.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        W_Land_Pips.Location = new System.Drawing.Point(13, 272);
        W_Land_Pips.Name = "W_Land_Pips";
        W_Land_Pips.Size = new System.Drawing.Size(31, 20);
        W_Land_Pips.TabIndex = 22;
        W_Land_Pips.Text = "0";
        W_Land_Pips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // label17
        // 
        label17.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label17.ForeColor = System.Drawing.Color.White;
        label17.Location = new System.Drawing.Point(161, 217);
        label17.Name = "label17";
        label17.Size = new System.Drawing.Size(31, 23);
        label17.TabIndex = 21;
        label17.Text = "G";
        label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label16
        // 
        label16.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label16.ForeColor = System.Drawing.Color.White;
        label16.Location = new System.Drawing.Point(124, 217);
        label16.Name = "label16";
        label16.Size = new System.Drawing.Size(31, 23);
        label16.TabIndex = 20;
        label16.Text = "R";
        label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label15
        // 
        label15.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label15.ForeColor = System.Drawing.Color.White;
        label15.Location = new System.Drawing.Point(87, 217);
        label15.Name = "label15";
        label15.Size = new System.Drawing.Size(31, 23);
        label15.TabIndex = 19;
        label15.Text = "B";
        label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label14
        // 
        label14.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label14.ForeColor = System.Drawing.Color.White;
        label14.Location = new System.Drawing.Point(50, 217);
        label14.Name = "label14";
        label14.Size = new System.Drawing.Size(31, 23);
        label14.TabIndex = 18;
        label14.Text = "U";
        label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label13
        // 
        label13.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label13.ForeColor = System.Drawing.Color.White;
        label13.Location = new System.Drawing.Point(13, 217);
        label13.Name = "label13";
        label13.Size = new System.Drawing.Size(31, 23);
        label13.TabIndex = 17;
        label13.Text = "W";
        label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // label12
        // 
        label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label12.ForeColor = System.Drawing.Color.White;
        label12.Location = new System.Drawing.Point(6, 168);
        label12.Name = "label12";
        label12.Size = new System.Drawing.Size(100, 23);
        label12.TabIndex = 16;
        label12.Text = "Spell Pips:";
        // 
        // G_Spell_Pips
        // 
        G_Spell_Pips.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        G_Spell_Pips.BorderStyle = System.Windows.Forms.BorderStyle.None;
        G_Spell_Pips.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        G_Spell_Pips.Location = new System.Drawing.Point(161, 194);
        G_Spell_Pips.Name = "G_Spell_Pips";
        G_Spell_Pips.Size = new System.Drawing.Size(31, 20);
        G_Spell_Pips.TabIndex = 15;
        G_Spell_Pips.Text = "0";
        G_Spell_Pips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // R_Spell_Pips
        // 
        R_Spell_Pips.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        R_Spell_Pips.BorderStyle = System.Windows.Forms.BorderStyle.None;
        R_Spell_Pips.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        R_Spell_Pips.Location = new System.Drawing.Point(124, 194);
        R_Spell_Pips.Name = "R_Spell_Pips";
        R_Spell_Pips.Size = new System.Drawing.Size(31, 20);
        R_Spell_Pips.TabIndex = 14;
        R_Spell_Pips.Text = "0";
        R_Spell_Pips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // B_Spell_Pips
        // 
        B_Spell_Pips.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        B_Spell_Pips.BorderStyle = System.Windows.Forms.BorderStyle.None;
        B_Spell_Pips.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        B_Spell_Pips.Location = new System.Drawing.Point(87, 194);
        B_Spell_Pips.Name = "B_Spell_Pips";
        B_Spell_Pips.Size = new System.Drawing.Size(31, 20);
        B_Spell_Pips.TabIndex = 13;
        B_Spell_Pips.Text = "0";
        B_Spell_Pips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // U_Spell_Pips
        // 
        U_Spell_Pips.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        U_Spell_Pips.BorderStyle = System.Windows.Forms.BorderStyle.None;
        U_Spell_Pips.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        U_Spell_Pips.Location = new System.Drawing.Point(50, 194);
        U_Spell_Pips.Name = "U_Spell_Pips";
        U_Spell_Pips.Size = new System.Drawing.Size(31, 20);
        U_Spell_Pips.TabIndex = 12;
        U_Spell_Pips.Text = "0";
        U_Spell_Pips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // W_Spell_Pips
        // 
        W_Spell_Pips.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        W_Spell_Pips.BorderStyle = System.Windows.Forms.BorderStyle.None;
        W_Spell_Pips.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        W_Spell_Pips.Location = new System.Drawing.Point(13, 194);
        W_Spell_Pips.Name = "W_Spell_Pips";
        W_Spell_Pips.Size = new System.Drawing.Size(31, 20);
        W_Spell_Pips.TabIndex = 11;
        W_Spell_Pips.Text = "0";
        W_Spell_Pips.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
        // panel1
        // 
        panel1.Location = new System.Drawing.Point(3, 106);
        panel1.Name = "panel1";
        panel1.Size = new System.Drawing.Size(318, 100);
        panel1.TabIndex = 11;
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
        SevenMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
        SixMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
        FiveMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
        FourMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
        ThreeMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
        TwoMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
        OneMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
        ZeroMana.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        // 
        // label25
        // 
        label25.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label25.ForeColor = System.Drawing.Color.White;
        label25.Location = new System.Drawing.Point(13, 333);
        label25.Name = "label25";
        label25.Size = new System.Drawing.Size(147, 23);
        label25.TabIndex = 35;
        label25.Text = "Commander Cost:";
        // 
        // CommanderCost
        // 
        CommanderCost.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        CommanderCost.BorderStyle = System.Windows.Forms.BorderStyle.None;
        CommanderCost.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        CommanderCost.Location = new System.Drawing.Point(152, 333);
        CommanderCost.Name = "CommanderCost";
        CommanderCost.Size = new System.Drawing.Size(72, 20);
        CommanderCost.TabIndex = 36;
        CommanderCost.Text = "0";
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

    private System.Windows.Forms.TextBox CommanderCost;

    private System.Windows.Forms.Label label25;

    private System.Windows.Forms.TextBox RampInDeck;
    private System.Windows.Forms.Label label24;

    private System.Windows.Forms.TextBox G_Land_Pips;
    private System.Windows.Forms.TextBox R_Land_Pips;
    private System.Windows.Forms.TextBox B_Land_Pips;
    private System.Windows.Forms.TextBox U_Land_Pips;
    private System.Windows.Forms.TextBox W_Land_Pips;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label label19;
    private System.Windows.Forms.Label label20;
    private System.Windows.Forms.Label label21;
    private System.Windows.Forms.Label label22;
    private System.Windows.Forms.Label label23;

    private System.Windows.Forms.Label label14;
    private System.Windows.Forms.Label label15;
    private System.Windows.Forms.Label label16;
    private System.Windows.Forms.Label label17;

    private System.Windows.Forms.Label label13;

    private System.Windows.Forms.TextBox U_Spell_Pips;
    private System.Windows.Forms.TextBox B_Spell_Pips;
    private System.Windows.Forms.TextBox R_Spell_Pips;
    private System.Windows.Forms.TextBox G_Spell_Pips;
    private System.Windows.Forms.Label label12;

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox W_Spell_Pips;

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