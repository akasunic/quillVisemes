namespace VisemesWinFormsApp
{
  partial class audioMatch
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
            this.step5_charDropdown = new System.Windows.Forms.ComboBox();
            this.step5_audioFile = new System.Windows.Forms.Label();
            this.step5_innerPanel = new System.Windows.Forms.Panel();
            this.step5_innerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // step5_charDropdown
            // 
            this.step5_charDropdown.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.step5_charDropdown.FormattingEnabled = true;
            this.step5_charDropdown.Location = new System.Drawing.Point(371, 3);
            this.step5_charDropdown.Name = "step5_charDropdown";
            this.step5_charDropdown.Size = new System.Drawing.Size(331, 24);
            this.step5_charDropdown.TabIndex = 3;
            // 
            // step5_audioFile
            // 
            this.step5_audioFile.AutoSize = true;
            this.step5_audioFile.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.step5_audioFile.Location = new System.Drawing.Point(-1, 11);
            this.step5_audioFile.Name = "step5_audioFile";
            this.step5_audioFile.Size = new System.Drawing.Size(191, 16);
            this.step5_audioFile.TabIndex = 2;
            this.step5_audioFile.Text = "sample.wav (do last part of string)";
            // 
            // step5_innerPanel
            // 
            this.step5_innerPanel.Controls.Add(this.step5_charDropdown);
            this.step5_innerPanel.Controls.Add(this.step5_audioFile);
            this.step5_innerPanel.Location = new System.Drawing.Point(33, 3);
            this.step5_innerPanel.Name = "step5_innerPanel";
            this.step5_innerPanel.Size = new System.Drawing.Size(707, 35);
            this.step5_innerPanel.TabIndex = 17;
            // 
            // audioMatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.step5_innerPanel);
            this.Name = "audioMatch";
            this.Size = new System.Drawing.Size(754, 38);
            this.step5_innerPanel.ResumeLayout(false);
            this.step5_innerPanel.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private ComboBox step5_charDropdown;
    private Label step5_audioFile;
    private Panel step5_innerPanel;
  }
}
