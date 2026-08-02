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
        DeckNamesBox.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        DeckNamesBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
        DeckNamesBox.Dock = System.Windows.Forms.DockStyle.Left;
        DeckNamesBox.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        DeckNamesBox.Location = new System.Drawing.Point(0, 0);
        DeckNamesBox.Name = "DeckNamesBox";
        DeckNamesBox.Size = new System.Drawing.Size(482, 553);
        DeckNamesBox.TabIndex = 0;
        DeckNamesBox.Text = "";
        // 
        // SaveButton
        // 
        SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)((byte)91)), ((int)((byte)106)), ((int)((byte)240)));
        SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
        SaveButton.Dock = System.Windows.Forms.DockStyle.Bottom;
        SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)91)), ((int)((byte)106)), ((int)((byte)240)));
        SaveButton.FlatAppearance.BorderSize = 0;
        SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)70)), ((int)((byte)88)), ((int)((byte)210)));
        SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)120)), ((int)((byte)248)));
        SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        SaveButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        SaveButton.ForeColor = System.Drawing.Color.White;
        SaveButton.Location = new System.Drawing.Point(482, 491);
        SaveButton.Name = "SaveButton";
        SaveButton.Size = new System.Drawing.Size(155, 62);
        SaveButton.TabIndex = 1;
        SaveButton.Text = "SAVE";
        SaveButton.UseVisualStyleBackColor = false;
        SaveButton.Click += SaveButton_Click;
        // 
        // ModifyDecksList
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.LightSlateGray;
        Controls.Add(SaveButton);
        Controls.Add(DeckNamesBox);
        Size = new System.Drawing.Size(637, 553);
        Load += ModifyDecksList_Load;
        ResumeLayout(false);
    }

    private System.Windows.Forms.RichTextBox DeckNamesBox;
    private System.Windows.Forms.Button SaveButton;

    #endregion
}