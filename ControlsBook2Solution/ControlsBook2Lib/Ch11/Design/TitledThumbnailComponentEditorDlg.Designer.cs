namespace ControlsBook2Lib.Ch11.Design
{
  partial class TitledThumbnailComponentEditorDlg
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.textLongImageDesc = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.textPhotographerFullName = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.textLocation = new System.Windows.Forms.TextBox();
      this.dtpImageTaken = new System.Windows.Forms.DateTimePicker();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.textImageTitle = new System.Windows.Forms.TextBox();
      this.cboAlignment = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonOK = new System.Windows.Forms.Button();
      this.buttonCancel = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.textLongImageDesc);
      this.groupBox1.Controls.Add(this.label6);
      this.groupBox1.Controls.Add(this.label5);
      this.groupBox1.Controls.Add(this.textPhotographerFullName);
      this.groupBox1.Controls.Add(this.label4);
      this.groupBox1.Controls.Add(this.textLocation);
      this.groupBox1.Controls.Add(this.dtpImageTaken);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Location = new System.Drawing.Point(16, 80);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(448, 248);
      this.groupBox1.TabIndex = 13;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Image Info";
      // 
      // textLongImageDesc
      // 
      this.textLongImageDesc.Location = new System.Drawing.Point(8, 120);
      this.textLongImageDesc.Multiline = true;
      this.textLongImageDesc.Name = "textLongImageDesc";
      this.textLongImageDesc.Size = new System.Drawing.Size(424, 112);
      this.textLongImageDesc.TabIndex = 14;
      // 
      // label6
      // 
      this.label6.Location = new System.Drawing.Point(8, 96);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(136, 16);
      this.label6.TabIndex = 13;
      this.label6.Text = "Long Image Description:";
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(272, 32);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(152, 16);
      this.label5.TabIndex = 12;
      this.label5.Text = "Photographer Full Name:";
      // 
      // textPhotographerFullName
      // 
      this.textPhotographerFullName.Location = new System.Drawing.Point(272, 56);
      this.textPhotographerFullName.Name = "textPhotographerFullName";
      this.textPhotographerFullName.Size = new System.Drawing.Size(160, 20);
      this.textPhotographerFullName.TabIndex = 11;
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(136, 32);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(128, 16);
      this.label4.TabIndex = 10;
      this.label4.Text = "Location Image Taken:";
      // 
      // textLocation
      // 
      this.textLocation.Location = new System.Drawing.Point(136, 56);
      this.textLocation.Name = "textLocation";
      this.textLocation.Size = new System.Drawing.Size(112, 20);
      this.textLocation.TabIndex = 9;
      this.textLocation.Text = "0N,0W";
      // 
      // dtpImageTaken
      // 
      this.dtpImageTaken.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtpImageTaken.Location = new System.Drawing.Point(8, 56);
      this.dtpImageTaken.Name = "dtpImageTaken";
      this.dtpImageTaken.Size = new System.Drawing.Size(112, 20);
      this.dtpImageTaken.TabIndex = 8;
      this.dtpImageTaken.Value = new System.DateTime(2003, 4, 8, 0, 0, 0, 0);
      // 
      // label3
      // 
      this.label3.Location = new System.Drawing.Point(8, 32);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(100, 16);
      this.label3.TabIndex = 7;
      this.label3.Text = "Date Image Taken:";
      // 
      // label2
      // 
      this.label2.Location = new System.Drawing.Point(344, 16);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 16);
      this.label2.TabIndex = 12;
      this.label2.Text = "Alignment";
      // 
      // textImageTitle
      // 
      this.textImageTitle.Location = new System.Drawing.Point(16, 40);
      this.textImageTitle.Name = "textImageTitle";
      this.textImageTitle.Size = new System.Drawing.Size(304, 20);
      this.textImageTitle.TabIndex = 11;
      // 
      // cboAlignment
      // 
      this.cboAlignment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboAlignment.Location = new System.Drawing.Point(344, 40);
      this.cboAlignment.Name = "cboAlignment";
      this.cboAlignment.Size = new System.Drawing.Size(121, 21);
      this.cboAlignment.TabIndex = 10;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(16, 16);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 16);
      this.label1.TabIndex = 9;
      this.label1.Text = "Image Title:";
      // 
      // buttonOK
      // 
      this.buttonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.buttonOK.Location = new System.Drawing.Point(288, 344);
      this.buttonOK.Name = "buttonOK";
      this.buttonOK.Size = new System.Drawing.Size(75, 23);
      this.buttonOK.TabIndex = 7;
      this.buttonOK.Text = "&OK";
      this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
      // 
      // buttonCancel
      // 
      this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.buttonCancel.Location = new System.Drawing.Point(384, 344);
      this.buttonCancel.Name = "buttonCancel";
      this.buttonCancel.Size = new System.Drawing.Size(75, 23);
      this.buttonCancel.TabIndex = 8;
      this.buttonCancel.Text = "&Cancel";
      // 
      // TitledThumbnailComponentEditorDlg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(480, 382);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textImageTitle);
      this.Controls.Add(this.cboAlignment);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonOK);
      this.Controls.Add(this.buttonCancel);
      this.Name = "TitledThumbnailComponentEditorDlg";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
      this.Text = "TitledThumbnailComponentEditorDlg";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox textLongImageDesc;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox textPhotographerFullName;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox textLocation;
    private System.Windows.Forms.DateTimePicker dtpImageTaken;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox textImageTitle;
    private System.Windows.Forms.ComboBox cboAlignment;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button buttonOK;
    private System.Windows.Forms.Button buttonCancel;
  }
}