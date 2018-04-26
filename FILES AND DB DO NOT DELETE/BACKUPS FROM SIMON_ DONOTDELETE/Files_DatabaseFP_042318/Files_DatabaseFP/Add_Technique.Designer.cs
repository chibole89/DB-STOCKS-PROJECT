using System.Windows.Forms;

namespace Files_DatabaseFP
{
    partial class Add_Technique
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
            this.AddTechnique_Cancel = new System.Windows.Forms.Button();
            this.AddTechnique_Add = new System.Windows.Forms.Button();
            this.Name_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Acronym_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddTechnique_Cancel
            // 
            this.AddTechnique_Cancel.Location = new System.Drawing.Point(247, 64);
            this.AddTechnique_Cancel.Name = "AddTechnique_Cancel";
            this.AddTechnique_Cancel.Size = new System.Drawing.Size(77, 23);
            this.AddTechnique_Cancel.TabIndex = 71;
            this.AddTechnique_Cancel.Text = "Cancel";
            this.AddTechnique_Cancel.UseVisualStyleBackColor = true;
            this.AddTechnique_Cancel.Click += new System.EventHandler(this.ManageTechnique_Cancel_Click);
            // 
            // AddTechnique_Add
            // 
            this.AddTechnique_Add.Location = new System.Drawing.Point(166, 64);
            this.AddTechnique_Add.Name = "AddTechnique_Add";
            this.AddTechnique_Add.Size = new System.Drawing.Size(77, 23);
            this.AddTechnique_Add.TabIndex = 70;
            this.AddTechnique_Add.Text = "Accept";
            this.AddTechnique_Add.UseVisualStyleBackColor = true;
            this.AddTechnique_Add.Click += new System.EventHandler(this.ManageTechnique_Add_Click);
            // 
            // Name_TextBox
            // 
            this.Name_TextBox.Location = new System.Drawing.Point(131, 38);
            this.Name_TextBox.Name = "Name_TextBox";
            this.Name_TextBox.Size = new System.Drawing.Size(193, 20);
            this.Name_TextBox.TabIndex = 69;
            this.Name_TextBox.TextChanged += new System.EventHandler(this.Name_TextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Technique Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Acronym:";
            // 
            // Acronym_TextBox
            // 
            this.Acronym_TextBox.Location = new System.Drawing.Point(131, 12);
            this.Acronym_TextBox.Name = "Acronym_TextBox";
            this.Acronym_TextBox.Size = new System.Drawing.Size(112, 20);
            this.Acronym_TextBox.TabIndex = 72;
            this.Acronym_TextBox.TextChanged += new System.EventHandler(this.Acronym_TextBox_TextChanged);
            // 
            // Add_Technique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 98);
            this.Controls.Add(this.Acronym_TextBox);
            this.Controls.Add(this.AddTechnique_Cancel);
            this.Controls.Add(this.AddTechnique_Add);
            this.Controls.Add(this.Name_TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Name = "Add_Technique";
            this.Text = "Add Technique";
            this.Load += new System.EventHandler(this.Add_Technique_Load);
            this.FormClosed += new FormClosedEventHandler(this.Add_Technique_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddTechnique_Cancel;
        private System.Windows.Forms.Button AddTechnique_Add;
        public System.Windows.Forms.TextBox Name_TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox Acronym_TextBox;
    }
}