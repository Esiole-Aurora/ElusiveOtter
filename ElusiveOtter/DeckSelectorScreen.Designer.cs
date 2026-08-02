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
        NoOfDecks.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        NoOfDecks.ForeColor = System.Drawing.Color.White;
        NoOfDecks.Location = new System.Drawing.Point(27, 29);
        NoOfDecks.Name = "NoOfDecks";
        NoOfDecks.Size = new System.Drawing.Size(160, 23);
        NoOfDecks.TabIndex = 0;
        NoOfDecks.Text = "Number of Decks:";
        // 
        // NoSelectBox
        // 
        NoSelectBox.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        NoSelectBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
        NoSelectBox.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        NoSelectBox.Location = new System.Drawing.Point(167, 29);
        NoSelectBox.Name = "NoSelectBox";
        NoSelectBox.Size = new System.Drawing.Size(100, 20);
        NoSelectBox.TabIndex = 1;
        // 
        // SelectButton
        // 
        SelectButton.BackColor = System.Drawing.Color.FromArgb(((int)((byte)91)), ((int)((byte)106)), ((int)((byte)240)));
        SelectButton.Cursor = System.Windows.Forms.Cursors.Hand;
        SelectButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)91)), ((int)((byte)106)), ((int)((byte)240)));
        SelectButton.FlatAppearance.BorderSize = 0;
        SelectButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)70)), ((int)((byte)88)), ((int)((byte)210)));
        SelectButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)120)), ((int)((byte)248)));
        SelectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        SelectButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        SelectButton.ForeColor = System.Drawing.Color.White;
        SelectButton.Location = new System.Drawing.Point(273, 22);
        SelectButton.Name = "SelectButton";
        SelectButton.Size = new System.Drawing.Size(79, 31);
        SelectButton.TabIndex = 2;
        SelectButton.Text = "SELECT";
        SelectButton.UseVisualStyleBackColor = false;
        SelectButton.Click += SelectButton_Click;
        // 
        // RerollButton
        // 
        RerollButton.BackColor = System.Drawing.Color.FromArgb(((int)((byte)91)), ((int)((byte)106)), ((int)((byte)240)));
        RerollButton.Cursor = System.Windows.Forms.Cursors.Hand;
        RerollButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)91)), ((int)((byte)106)), ((int)((byte)240)));
        RerollButton.FlatAppearance.BorderSize = 0;
        RerollButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)70)), ((int)((byte)88)), ((int)((byte)210)));
        RerollButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)120)), ((int)((byte)248)));
        RerollButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        RerollButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        RerollButton.ForeColor = System.Drawing.Color.White;
        RerollButton.Location = new System.Drawing.Point(358, 22);
        RerollButton.Name = "RerollButton";
        RerollButton.Size = new System.Drawing.Size(79, 31);
        RerollButton.TabIndex = 3;
        RerollButton.Text = "REROLL";
        RerollButton.UseVisualStyleBackColor = false;
        RerollButton.Click += RerollButton_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.ForeColor = System.Drawing.Color.White;
        label1.Location = new System.Drawing.Point(431, 464);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(100, 23);
        label1.TabIndex = 4;
        label1.Text = "Min Bracket: ";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.ForeColor = System.Drawing.Color.White;
        label2.Location = new System.Drawing.Point(431, 502);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 5;
        label2.Text = "Max Bracket: ";
        // 
        // MaxBracket
        // 
        MaxBracket.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        MaxBracket.BorderStyle = System.Windows.Forms.BorderStyle.None;
        MaxBracket.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        MaxBracket.Location = new System.Drawing.Point(537, 502);
        MaxBracket.Name = "MaxBracket";
        MaxBracket.Size = new System.Drawing.Size(70, 20);
        MaxBracket.TabIndex = 7;
        MaxBracket.Text = "5";
        MaxBracket.TextChanged += MaxBracket_TextChanged;
        // 
        // MinBracket
        // 
        MinBracket.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        MinBracket.BorderStyle = System.Windows.Forms.BorderStyle.None;
        MinBracket.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        MinBracket.Location = new System.Drawing.Point(537, 464);
        MinBracket.Name = "MinBracket";
        MinBracket.Size = new System.Drawing.Size(70, 20);
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