namespace Files_DatabaseFP
{
    partial class Edit_Transaction
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
            this.txtRisk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.chkPaper = new System.Windows.Forms.CheckBox();
            this.cmbTechnique = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRisk
            // 
            this.txtRisk.Location = new System.Drawing.Point(1076, 10);
            this.txtRisk.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtRisk.Name = "txtRisk";
            this.txtRisk.Size = new System.Drawing.Size(196, 31);
            this.txtRisk.TabIndex = 65;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(980, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 64;
            this.label4.Text = "RISK";
            // 
            // txtSymbol
            // 
            this.txtSymbol.Location = new System.Drawing.Point(120, 12);
            this.txtSymbol.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(196, 31);
            this.txtSymbol.TabIndex = 63;
            // 
            // chkPaper
            // 
            this.chkPaper.AutoSize = true;
            this.chkPaper.Location = new System.Drawing.Point(788, 15);
            this.chkPaper.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.chkPaper.Name = "chkPaper";
            this.chkPaper.Size = new System.Drawing.Size(156, 29);
            this.chkPaper.TabIndex = 62;
            this.chkPaper.Text = "Paper trade";
            this.chkPaper.UseVisualStyleBackColor = true;
            // 
            // cmbTechnique
            // 
            this.cmbTechnique.FormattingEnabled = true;
            this.cmbTechnique.Location = new System.Drawing.Point(516, 10);
            this.cmbTechnique.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cmbTechnique.Name = "cmbTechnique";
            this.cmbTechnique.Size = new System.Drawing.Size(210, 33);
            this.cmbTechnique.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Technique";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Symbol";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1126, 60);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 44);
            this.button3.TabIndex = 67;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(946, 60);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(150, 44);
            this.btnAccept.TabIndex = 66;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // Edit_Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 121);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.txtRisk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSymbol);
            this.Controls.Add(this.chkPaper);
            this.Controls.Add(this.cmbTechnique);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Edit_Transaction";
            this.Text = "Edit Transaction";
            this.Load += new System.EventHandler(this.Edit_Transaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRisk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSymbol;
        private System.Windows.Forms.CheckBox chkPaper;
        private System.Windows.Forms.ComboBox cmbTechnique;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnAccept;
    }
}