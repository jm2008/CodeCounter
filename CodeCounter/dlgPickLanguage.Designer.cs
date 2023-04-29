namespace CodeCounter
{
    partial class dlgPickLanguage
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
            this.rbtnC = new System.Windows.Forms.RadioButton();
            this.rbtnCpp = new System.Windows.Forms.RadioButton();
            this.rbtnCSharp = new System.Windows.Forms.RadioButton();
            this.rbtnHeader = new System.Windows.Forms.RadioButton();
            this.bttnOK = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnHeader);
            this.groupBox1.Controls.Add(this.rbtnCSharp);
            this.groupBox1.Controls.Add(this.rbtnCpp);
            this.groupBox1.Controls.Add(this.rbtnC);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pick the language of the source file";
            // 
            // rbtnC
            // 
            this.rbtnC.AutoSize = true;
            this.rbtnC.Location = new System.Drawing.Point(6, 22);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(33, 19);
            this.rbtnC.TabIndex = 0;
            this.rbtnC.Text = "C";
            this.rbtnC.UseVisualStyleBackColor = true;
            // 
            // rbtnCpp
            // 
            this.rbtnCpp.AutoSize = true;
            this.rbtnCpp.Location = new System.Drawing.Point(6, 47);
            this.rbtnCpp.Name = "rbtnCpp";
            this.rbtnCpp.Size = new System.Drawing.Size(49, 19);
            this.rbtnCpp.TabIndex = 1;
            this.rbtnCpp.Text = "C++";
            this.rbtnCpp.UseVisualStyleBackColor = true;
            // 
            // rbtnCSharp
            // 
            this.rbtnCSharp.AutoSize = true;
            this.rbtnCSharp.Checked = true;
            this.rbtnCSharp.Location = new System.Drawing.Point(6, 72);
            this.rbtnCSharp.Name = "rbtnCSharp";
            this.rbtnCSharp.Size = new System.Drawing.Size(40, 19);
            this.rbtnCSharp.TabIndex = 2;
            this.rbtnCSharp.TabStop = true;
            this.rbtnCSharp.Text = "C#";
            this.rbtnCSharp.UseVisualStyleBackColor = true;
            // 
            // rbtnHeader
            // 
            this.rbtnHeader.AutoSize = true;
            this.rbtnHeader.Location = new System.Drawing.Point(6, 97);
            this.rbtnHeader.Name = "rbtnHeader";
            this.rbtnHeader.Size = new System.Drawing.Size(103, 19);
            this.rbtnHeader.TabIndex = 3;
            this.rbtnHeader.Text = "C/C++ Header";
            this.rbtnHeader.UseVisualStyleBackColor = true;
            // 
            // bttnOK
            // 
            this.bttnOK.Location = new System.Drawing.Point(166, 156);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(75, 23);
            this.bttnOK.TabIndex = 1;
            this.bttnOK.Text = "OK";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Location = new System.Drawing.Point(85, 156);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(75, 23);
            this.bttnCancel.TabIndex = 2;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dlgPickLanguage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 188);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnOK);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "dlgPickLanguage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pick Language";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnHeader;
        private System.Windows.Forms.RadioButton rbtnCSharp;
        private System.Windows.Forms.RadioButton rbtnCpp;
        private System.Windows.Forms.RadioButton rbtnC;
        private System.Windows.Forms.Button bttnOK;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}