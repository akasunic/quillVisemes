namespace VisemesWinFormsApp
{
  partial class audioRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(audioRow));
            this.step5_innerPanel = new System.Windows.Forms.Panel();
            this.txtPathLabel = new System.Windows.Forms.Label();
            this.step4_attachButton = new System.Windows.Forms.Button();
            this.step4_audioCheckbox = new System.Windows.Forms.CheckBox();
            this.step4_audioFile = new System.Windows.Forms.Label();
            this.step5_innerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // step5_innerPanel
            // 
            this.step5_innerPanel.Controls.Add(this.txtPathLabel);
            this.step5_innerPanel.Controls.Add(this.step4_attachButton);
            this.step5_innerPanel.Controls.Add(this.step4_audioCheckbox);
            this.step5_innerPanel.Controls.Add(this.step4_audioFile);
            this.step5_innerPanel.Location = new System.Drawing.Point(0, 3);
            this.step5_innerPanel.Name = "step5_innerPanel";
            this.step5_innerPanel.Size = new System.Drawing.Size(741, 35);
            this.step5_innerPanel.TabIndex = 17;
            // 
            // txtPathLabel
            // 
            this.txtPathLabel.AutoSize = true;
            this.txtPathLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPathLabel.Location = new System.Drawing.Point(441, 12);
            this.txtPathLabel.Name = "txtPathLabel";
            this.txtPathLabel.Size = new System.Drawing.Size(100, 17);
            this.txtPathLabel.TabIndex = 8;
            this.txtPathLabel.Text = "None attached";
            // 
            // step4_attachButton
            // 
            this.step4_attachButton.BackColor = System.Drawing.Color.White;
            this.step4_attachButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("step4_attachButton.BackgroundImage")));
            this.step4_attachButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.step4_attachButton.FlatAppearance.BorderSize = 0;
            this.step4_attachButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.step4_attachButton.Font = new System.Drawing.Font("Yet R", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.step4_attachButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(94)))), ((int)(((byte)(255)))));
            this.step4_attachButton.Location = new System.Drawing.Point(403, 3);
            this.step4_attachButton.Name = "step4_attachButton";
            this.step4_attachButton.Size = new System.Drawing.Size(32, 29);
            this.step4_attachButton.TabIndex = 7;
            this.step4_attachButton.UseVisualStyleBackColor = false;
            // 
            // step4_audioCheckbox
            // 
            this.step4_audioCheckbox.AutoSize = true;
            this.step4_audioCheckbox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.step4_audioCheckbox.Location = new System.Drawing.Point(32, 10);
            this.step4_audioCheckbox.Name = "step4_audioCheckbox";
            this.step4_audioCheckbox.Size = new System.Drawing.Size(92, 21);
            this.step4_audioCheckbox.TabIndex = 4;
            this.step4_audioCheckbox.Text = "checkBox1";
            this.step4_audioCheckbox.UseVisualStyleBackColor = true;
            // 
            // step4_audioFile
            // 
            this.step4_audioFile.AutoSize = true;
            this.step4_audioFile.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.step4_audioFile.Location = new System.Drawing.Point(32, 11);
            this.step4_audioFile.Name = "step4_audioFile";
            this.step4_audioFile.Size = new System.Drawing.Size(0, 16);
            this.step4_audioFile.TabIndex = 2;
            // 
            // audioRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.step5_innerPanel);
            this.Name = "audioRow";
            this.Size = new System.Drawing.Size(741, 37);
            this.step5_innerPanel.ResumeLayout(false);
            this.step5_innerPanel.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private Panel step5_innerPanel;
    private Label step4_audioFile;
    private CheckBox step4_audioCheckbox;
    private Button step4_attachLabel;
    private Label txtPathLabel;
    private Button step4_attachButton;
  }
}
