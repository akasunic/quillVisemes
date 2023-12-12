namespace VisemesWinFormsApp
{
  partial class characterToLayerMatch
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

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
            this.step3_innerPanel = new System.Windows.Forms.Panel();
            this.step3_charName = new System.Windows.Forms.Label();
            this.step3_mouthDropdown = new System.Windows.Forms.ComboBox();
            this.step3_innerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // step3_innerPanel
            // 
            this.step3_innerPanel.Controls.Add(this.step3_charName);
            this.step3_innerPanel.Controls.Add(this.step3_mouthDropdown);
            this.step3_innerPanel.Location = new System.Drawing.Point(42, 3);
            this.step3_innerPanel.Name = "step3_innerPanel";
            this.step3_innerPanel.Size = new System.Drawing.Size(705, 35);
            this.step3_innerPanel.TabIndex = 16;
            // 
            // step3_charName
            // 
            this.step3_charName.AutoSize = true;
            this.step3_charName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.step3_charName.Location = new System.Drawing.Point(0, 11);
            this.step3_charName.Name = "step3_charName";
            this.step3_charName.Size = new System.Drawing.Size(195, 16);
            this.step3_charName.TabIndex = 23;
            this.step3_charName.Text = "Sample Character (autopopulate)";
            // 
            // step3_mouthDropdown
            // 
            this.step3_mouthDropdown.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.step3_mouthDropdown.FormattingEnabled = true;
            this.step3_mouthDropdown.Location = new System.Drawing.Point(373, 8);
            this.step3_mouthDropdown.Name = "step3_mouthDropdown";
            this.step3_mouthDropdown.Size = new System.Drawing.Size(329, 24);
            this.step3_mouthDropdown.TabIndex = 14;
            this.step3_mouthDropdown.SelectedIndexChanged += new System.EventHandler(this.step3_mouthDropdown_SelectedIndexChanged);
            // 
            // characterToLayerMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.step3_innerPanel);
            this.Name = "characterToLayerMatch";
            this.Size = new System.Drawing.Size(764, 38);
            this.step3_innerPanel.ResumeLayout(false);
            this.step3_innerPanel.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private Panel step3_innerPanel;
    private Label step3_charName;
    private ComboBox step3_mouthDropdown;
  }
}
