using System.ComponentModel;

namespace Deck_Randomiser_3;

partial class RandomCard
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
        SearchCriteria = new System.Windows.Forms.RichTextBox();
        GetCard = new System.Windows.Forms.Button();
        GetCommander = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // SearchCriteria
        // 
        SearchCriteria.Location = new System.Drawing.Point(449, 157);
        SearchCriteria.Name = "SearchCriteria";
        SearchCriteria.Size = new System.Drawing.Size(161, 243);
        SearchCriteria.TabIndex = 0;
        SearchCriteria.Text = "name:\"Elusive Otter\"";
        // 
        // GetCard
        // 
        GetCard.Location = new System.Drawing.Point(449, 406);
        GetCard.Name = "GetCard";
        GetCard.Size = new System.Drawing.Size(161, 59);
        GetCard.TabIndex = 1;
        GetCard.Text = "GET A CARD";
        GetCard.UseVisualStyleBackColor = true;
        GetCard.Click += GetCard_Click;
        // 
        // GetCommander
        // 
        GetCommander.Location = new System.Drawing.Point(449, 471);
        GetCommander.Name = "GetCommander";
        GetCommander.Size = new System.Drawing.Size(161, 60);
        GetCommander.TabIndex = 2;
        GetCommander.Text = "GET A COMMANDER";
        GetCommander.UseVisualStyleBackColor = true;
        GetCommander.Click += GetCommander_Click;
        // 
        // RandomCard
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.LightSlateGray;
        Controls.Add(GetCommander);
        Controls.Add(GetCard);
        Controls.Add(SearchCriteria);
        Size = new System.Drawing.Size(637, 553);
        ResumeLayout(false);
    }

    private System.Windows.Forms.RichTextBox SearchCriteria;
    private System.Windows.Forms.Button GetCard;
    private System.Windows.Forms.Button GetCommander;

    #endregion
}