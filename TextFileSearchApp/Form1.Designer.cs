namespace TextFileSearchApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnFilePath = new DevExpress.XtraEditors.SimpleButton();
            this.lblAlarm = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textEdit1.Enabled = false;
            this.textEdit1.Location = new System.Drawing.Point(140, 138);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.textEdit1.Size = new System.Drawing.Size(511, 34);
            this.textEdit1.TabIndex = 2;
            this.textEdit1.TextChanged += new System.EventHandler(this.textEdit1_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.75042F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.23283F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.01675F));
            this.tableLayoutPanel1.Controls.Add(this.textEdit1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.545455F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.90909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 374);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.04013F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.95987F));
            this.tableLayoutPanel2.Controls.Add(this.btnFilePath, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblAlarm, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(140, 223);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.50847F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 69.49153F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(511, 149);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFilePath.Appearance.Options.UseFont = true;
            this.btnFilePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFilePath.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnFilePath.ImageOptions.Image")));
            this.btnFilePath.Location = new System.Drawing.Point(320, 2);
            this.btnFilePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.True;
            this.btnFilePath.Size = new System.Drawing.Size(188, 41);
            this.btnFilePath.TabIndex = 3;
            this.btnFilePath.Text = "Dosya Yolu";
            this.btnFilePath.Click += new System.EventHandler(this.btnFilePath_Click);
            this.btnFilePath.MouseLeave += new System.EventHandler(this.simpleButton1_MouseLeave);
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAlarm.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAlarm.ForeColor = System.Drawing.Color.Maroon;
            this.lblAlarm.Location = new System.Drawing.Point(3, 0);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(311, 45);
            this.lblAlarm.TabIndex = 4;
            this.lblAlarm.Text = "-";
            this.lblAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAlarm.Visible = false;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(140, 36);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(511, 81);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::TextFileSearchApp.Properties.Resources.alpNEXT_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(79, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Appearance.BorderColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 374);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("Form1.IconOptions.Icon")));
            this.LookAndFeel.SkinName = "McSkin";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton btnFilePath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblAlarm;
    }
}

