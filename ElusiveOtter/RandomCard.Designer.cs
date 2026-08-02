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
        SearchCriteria.BackColor = System.Drawing.Color.FromArgb(((int)((byte)36)), ((int)((byte)40)), ((int)((byte)64)));
        SearchCriteria.BorderStyle = System.Windows.Forms.BorderStyle.None;
        SearchCriteria.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)212)), ((int)((byte)220)), ((int)((byte)220)));
        SearchCriteria.Location = new System.Drawing.Point(473, 0);
        SearchCriteria.Name = "SearchCriteria";
        SearchCriteria.Size = new System.Drawing.Size(164, 383);
        SearchCriteria.TabIndex = 0;
        SearchCriteria.Text = "name:\"Elusive Otter\"";
        // 
        // GetCard
        // 
        GetCard.BackColor = System.Drawing.Color.FromArgb(((int)((byte)91)), ((int)((byte)106)), ((int)((byte)240)));
        GetCard.Cursor = System.Windows.Forms.Cursors.Hand;
        GetCard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)91)), ((int)((byte)106)), ((int)((byte)240)));
        GetCard.FlatAppearance.BorderSize = 0;
        GetCard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)70)), ((int)((byte)88)), ((int)((byte)210)));
        GetCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)120)), ((int)((byte)248)));
        GetCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        GetCard.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        GetCard.ForeColor = System.Drawing.Color.White;
        GetCard.Location = new System.Drawing.Point(473, 383);
        GetCard.Name = "GetCard";
        GetCard.Size = new System.Drawing.Size(164, 82);
        GetCard.TabIndex = 1;
        GetCard.Text = "GET A CARD";
        GetCard.UseVisualStyleBackColor = false;
        GetCard.Click += GetCard_Click;
        // 
        // GetCommander
        // 
        GetCommander.BackColor = System.Drawing.Color.FromArgb(((int)((byte)91)), ((int)((byte)106)), ((int)((byte)240)));
        GetCommander.Cursor = System.Windows.Forms.Cursors.Hand;
        GetCommander.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)((byte)91)), ((int)((byte)106)), ((int)((byte)240)));
        GetCommander.FlatAppearance.BorderSize = 0;
        GetCommander.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)((byte)70)), ((int)((byte)88)), ((int)((byte)210)));
        GetCommander.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)((byte)107)), ((int)((byte)120)), ((int)((byte)248)));
        GetCommander.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        GetCommander.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        GetCommander.ForeColor = System.Drawing.Color.White;
        GetCommander.Location = new System.Drawing.Point(473, 471);
        GetCommander.Name = "GetCommander";
        GetCommander.Size = new System.Drawing.Size(164, 82);
        GetCommander.TabIndex = 2;
        GetCommander.Text = "GET A COMMANDER";
        GetCommander.UseVisualStyleBackColor = false;
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