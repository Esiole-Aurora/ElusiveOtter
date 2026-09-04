using System.ComponentModel;

namespace Deck_Randomiser_3;

partial class ManaBaseScreen
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
        InputPanel = new System.Windows.Forms.Panel();
        OutputPanel = new System.Windows.Forms.Panel();
        OutputBox = new System.Windows.Forms.RichTextBox();
        OutputPanel.SuspendLayout();
        SuspendLayout();
        // 
        // InputPanel
        // 
        InputPanel.Dock = System.Windows.Forms.DockStyle.Left;
        InputPanel.Location = new System.Drawing.Point(0, 0);
        InputPanel.Name = "InputPanel";
        InputPanel.Size = new System.Drawing.Size(381, 553);
        InputPanel.TabIndex = 0;
        // 
        // OutputPanel
        // 
        OutputPanel.Controls.Add(OutputBox);
        OutputPanel.Dock = System.Windows.Forms.DockStyle.Right;
        OutputPanel.Location = new System.Drawing.Point(380, 0);
        OutputPanel.Name = "OutputPanel";
        OutputPanel.Size = new System.Drawing.Size(257, 553);
        OutputPanel.TabIndex = 1;
        // 
        // OutputBox
        // 
        OutputBox.Dock = System.Windows.Forms.DockStyle.Bottom;
        OutputBox.Location = new System.Drawing.Point(0, 378);
        OutputBox.Name = "OutputBox";
        OutputBox.ReadOnly = true;
        OutputBox.Size = new System.Drawing.Size(257, 175);
        OutputBox.TabIndex = 0;
        OutputBox.Text = "";
        // 
        // ManaBaseScreen
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.LightSlateGray;
        Controls.Add(OutputPanel);
        Controls.Add(InputPanel);
        Size = new System.Drawing.Size(637, 553);
        OutputPanel.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.RichTextBox OutputBox;

    private System.Windows.Forms.Panel OutputPanel;

    private System.Windows.Forms.Panel InputPanel;

    #endregion
}