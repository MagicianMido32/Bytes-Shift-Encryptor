namespace ByteROT
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtDir = new System.Windows.Forms.TextBox();
            this.txtHints = new System.Windows.Forms.TextBox();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(314, 39);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(314, 68);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 1;
            this.btnEncrypt.Text = "encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtDir
            // 
            this.txtDir.Location = new System.Drawing.Point(12, 39);
            this.txtDir.Name = "txtDir";
            this.txtDir.Size = new System.Drawing.Size(296, 20);
            this.txtDir.TabIndex = 2;
            // 
            // txtHints
            // 
            this.txtHints.Location = new System.Drawing.Point(12, 97);
            this.txtHints.Multiline = true;
            this.txtHints.Name = "txtHints";
            this.txtHints.Size = new System.Drawing.Size(505, 142);
            this.txtHints.TabIndex = 3;
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(208, 65);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(100, 20);
            this.txtOffset.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "offset int use small number";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(395, 68);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 277);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.txtHints);
            this.Controls.Add(this.txtDir);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnBrowse);
            this.Name = "Form1";
            this.Text = "ByteROT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtDir;
        private System.Windows.Forms.TextBox txtHints;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDecrypt;
    }
}

