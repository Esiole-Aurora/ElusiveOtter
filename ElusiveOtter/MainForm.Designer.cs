namespace Deck_Randomiser_3;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        NavPanel = new System.Windows.Forms.Panel();
        RulingsButton = new System.Windows.Forms.Button();
        ModifyDecksButton = new System.Windows.Forms.Button();
        RandomCardButton = new System.Windows.Forms.Button();
        StatsButton = new System.Windows.Forms.Button();
        DeckSelectorButton = new System.Windows.Forms.Button();
        ContentPanel = new System.Windows.Forms.Panel();
        NavPanel.SuspendLayout();
        SuspendLayout();
        // 
        // NavPanel
        // 
        NavPanel.BackColor = System.Drawing.Color.DarkSlateGray;
        NavPanel.Controls.Add(RulingsButton);
        NavPanel.Controls.Add(ModifyDecksButton);
        NavPanel.Controls.Add(RandomCardButton);
        NavPanel.Controls.Add(StatsButton);
        NavPanel.Controls.Add(DeckSelectorButton);
        NavPanel.Dock = System.Windows.Forms.DockStyle.Left;
        NavPanel.Location = new System.Drawing.Point(0, 0);
        NavPanel.Name = "NavPanel";
        NavPanel.Size = new System.Drawing.Size(145, 553);
        NavPanel.TabIndex = 0;
        // 
        // RulingsButton
        // 
        RulingsButton.Dock = System.Windows.Forms.DockStyle.Top;
        RulingsButton.FlatAppearance.BorderSize = 0;
        RulingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        RulingsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        RulingsButton.ForeColor = System.Drawing.Color.White;
        RulingsButton.Location = new System.Drawing.Point(0, 300);
        RulingsButton.Name = "RulingsButton";
        RulingsButton.Size = new System.Drawing.Size(145, 75);
        RulingsButton.TabIndex = 4;
        RulingsButton.Text = "Rulings";
        RulingsButton.UseVisualStyleBackColor = true;
        // 
        // ModifyDecksButton
        // 
        ModifyDecksButton.Dock = System.Windows.Forms.DockStyle.Top;
        ModifyDecksButton.FlatAppearance.BorderSize = 0;
        ModifyDecksButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        ModifyDecksButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        ModifyDecksButton.ForeColor = System.Drawing.Color.White;
        ModifyDecksButton.Location = new System.Drawing.Point(0, 225);
        ModifyDecksButton.Name = "ModifyDecksButton";
        ModifyDecksButton.Size = new System.Drawing.Size(145, 75);
        ModifyDecksButton.TabIndex = 3;
        ModifyDecksButton.Text = "Modify Decks List";
        ModifyDecksButton.UseVisualStyleBackColor = true;
        // 
        // RandomCardButton
        // 
        RandomCardButton.Dock = System.Windows.Forms.DockStyle.Top;
        RandomCardButton.FlatAppearance.BorderSize = 0;
        RandomCardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        RandomCardButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        RandomCardButton.ForeColor = System.Drawing.Color.White;
        RandomCardButton.Location = new System.Drawing.Point(0, 150);
        RandomCardButton.Name = "RandomCardButton";
        RandomCardButton.Size = new System.Drawing.Size(145, 75);
        RandomCardButton.TabIndex = 2;
        RandomCardButton.Text = "Random Card";
        RandomCardButton.UseVisualStyleBackColor = true;
        // 
        // StatsButton
        // 
        StatsButton.Dock = System.Windows.Forms.DockStyle.Top;
        StatsButton.FlatAppearance.BorderSize = 0;
        StatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        StatsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        StatsButton.ForeColor = System.Drawing.Color.White;
        StatsButton.Location = new System.Drawing.Point(0, 75);
        StatsButton.Name = "StatsButton";
        StatsButton.Size = new System.Drawing.Size(145, 75);
        StatsButton.TabIndex = 1;
        StatsButton.Text = "Statistics";
        StatsButton.UseVisualStyleBackColor = true;
        // 
        // DeckSelectorButton
        // 
        DeckSelectorButton.Dock = System.Windows.Forms.DockStyle.Top;
        DeckSelectorButton.FlatAppearance.BorderSize = 0;
        DeckSelectorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        DeckSelectorButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        DeckSelectorButton.ForeColor = System.Drawing.Color.White;
        DeckSelectorButton.Location = new System.Drawing.Point(0, 0);
        DeckSelectorButton.Name = "DeckSelectorButton";
        DeckSelectorButton.Size = new System.Drawing.Size(145, 75);
        DeckSelectorButton.TabIndex = 0;
        DeckSelectorButton.Text = "Deck Selector";
        DeckSelectorButton.UseVisualStyleBackColor = true;
        // 
        // ContentPanel
        // 
        ContentPanel.BackColor = System.Drawing.Color.LightSlateGray;
        ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
        ContentPanel.Location = new System.Drawing.Point(145, 0);
        ContentPanel.Name = "ContentPanel";
        ContentPanel.Size = new System.Drawing.Size(637, 553);
        ContentPanel.TabIndex = 1;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(782, 553);
        Controls.Add(ContentPanel);
        Controls.Add(NavPanel);
        Text = "ElusiveOtter";
        NavPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button RandomCardButton;
    private System.Windows.Forms.Button ModifyDecksButton;
    private System.Windows.Forms.Button RulingsButton;

    private System.Windows.Forms.Button DeckSelectorButton;
    private System.Windows.Forms.Button StatsButton;

    private System.Windows.Forms.Panel ContentPanel;

    private System.Windows.Forms.Panel NavPanel;

    #endregion
}