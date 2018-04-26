namespace Files_DatabaseFP
{
    partial class Manage_Technique
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
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Acronym_Label = new System.Windows.Forms.Label();
            this.ManageTechnique_Cancel = new System.Windows.Forms.Button();
            this.ManageTechnique_Add = new System.Windows.Forms.Button();
            this.ManageTechnique_Remove = new System.Windows.Forms.Button();
            this.Acronym_ComboBox = new System.Windows.Forms.ComboBox();
            this.ManageTechnique_Edit = new System.Windows.Forms.Button();
            this.User_Label = new System.Windows.Forms.Label();
            this.User_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Location = new System.Drawing.Point(131, 65);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.ReadOnly = true;
            this.Name_Textbox.Size = new System.Drawing.Size(199, 20);
            this.Name_Textbox.TabIndex = 61;
            this.Name_Textbox.TabStop = false;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Label.Location = new System.Drawing.Point(9, 66);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(120, 17);
            this.Name_Label.TabIndex = 60;
            this.Name_Label.Text = "Technique Name:";
            // 
            // Acronym_Label
            // 
            this.Acronym_Label.AutoSize = true;
            this.Acronym_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acronym_Label.Location = new System.Drawing.Point(62, 39);
            this.Acronym_Label.Name = "Acronym_Label";
            this.Acronym_Label.Size = new System.Drawing.Size(67, 17);
            this.Acronym_Label.TabIndex = 59;
            this.Acronym_Label.Text = "Acronym:";
            // 
            // ManageTechnique_Cancel
            // 
            this.ManageTechnique_Cancel.Location = new System.Drawing.Point(255, 91);
            this.ManageTechnique_Cancel.Name = "ManageTechnique_Cancel";
            this.ManageTechnique_Cancel.Size = new System.Drawing.Size(75, 23);
            this.ManageTechnique_Cancel.TabIndex = 63;
            this.ManageTechnique_Cancel.Text = "Cancel";
            this.ManageTechnique_Cancel.UseVisualStyleBackColor = true;
            this.ManageTechnique_Cancel.Click += new System.EventHandler(this.ManageTechnique_Cancel_Click);
            // 
            // ManageTechnique_Add
            // 
            this.ManageTechnique_Add.Location = new System.Drawing.Point(12, 91);
            this.ManageTechnique_Add.Name = "ManageTechnique_Add";
            this.ManageTechnique_Add.Size = new System.Drawing.Size(75, 23);
            this.ManageTechnique_Add.TabIndex = 62;
            this.ManageTechnique_Add.Text = "Add";
            this.ManageTechnique_Add.UseVisualStyleBackColor = true;
            this.ManageTechnique_Add.Click += new System.EventHandler(this.ManageTechnique_Add_Click);
            // 
            // ManageTechnique_Remove
            // 
            this.ManageTechnique_Remove.Location = new System.Drawing.Point(174, 91);
            this.ManageTechnique_Remove.Name = "ManageTechnique_Remove";
            this.ManageTechnique_Remove.Size = new System.Drawing.Size(75, 23);
            this.ManageTechnique_Remove.TabIndex = 64;
            this.ManageTechnique_Remove.Text = "Remove";
            this.ManageTechnique_Remove.UseVisualStyleBackColor = true;
            this.ManageTechnique_Remove.Click += new System.EventHandler(this.ManageTechnique_Remove_Click);
            // 
            // Acronym_ComboBox
            // 
            this.Acronym_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Acronym_ComboBox.FormattingEnabled = true;
            this.Acronym_ComboBox.Location = new System.Drawing.Point(131, 38);
            this.Acronym_ComboBox.Name = "Acronym_ComboBox";
            this.Acronym_ComboBox.Size = new System.Drawing.Size(118, 21);
            this.Acronym_ComboBox.TabIndex = 58;
            this.Acronym_ComboBox.TabStop = false;
            this.Acronym_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Acronym_ComboBox_SelectedIndexChanged);
            // 
            // ManageTechnique_Edit
            // 
            this.ManageTechnique_Edit.Location = new System.Drawing.Point(93, 91);
            this.ManageTechnique_Edit.Name = "ManageTechnique_Edit";
            this.ManageTechnique_Edit.Size = new System.Drawing.Size(75, 23);
            this.ManageTechnique_Edit.TabIndex = 65;
            this.ManageTechnique_Edit.Text = "Edit";
            this.ManageTechnique_Edit.UseVisualStyleBackColor = true;
            this.ManageTechnique_Edit.Click += new System.EventHandler(this.ManageTechnique_Edit_Click);
            // 
            // User_Label
            // 
            this.User_Label.AutoSize = true;
            this.User_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_Label.Location = new System.Drawing.Point(87, 13);
            this.User_Label.Name = "User_Label";
            this.User_Label.Size = new System.Drawing.Size(42, 17);
            this.User_Label.TabIndex = 66;
            this.User_Label.Text = "User:";
            // 
            // User_TextBox
            // 
            this.User_TextBox.Location = new System.Drawing.Point(131, 12);
            this.User_TextBox.Name = "User_TextBox";
            this.User_TextBox.ReadOnly = true;
            this.User_TextBox.Size = new System.Drawing.Size(118, 20);
            this.User_TextBox.TabIndex = 61;
            this.User_TextBox.TabStop = false;
            // 
            // Manage_Technique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 124);
            this.Controls.Add(this.User_Label);
            this.Controls.Add(this.ManageTechnique_Edit);
            this.Controls.Add(this.ManageTechnique_Remove);
            this.Controls.Add(this.ManageTechnique_Cancel);
            this.Controls.Add(this.ManageTechnique_Add);
            this.Controls.Add(this.User_TextBox);
            this.Controls.Add(this.Name_Textbox);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.Acronym_Label);
            this.Controls.Add(this.Acronym_ComboBox);
            this.Name = "Manage_Technique";
            this.Text = "Manage Techniques";
            this.Load += new System.EventHandler(this.Manage_Technique_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label Acronym_Label;
        private System.Windows.Forms.Button ManageTechnique_Cancel;
        private System.Windows.Forms.Button ManageTechnique_Add;
        private System.Windows.Forms.Button ManageTechnique_Remove;
        public System.Windows.Forms.ComboBox Acronym_ComboBox;
        private System.Windows.Forms.Button ManageTechnique_Edit;
        private System.Windows.Forms.Label User_Label;
        public System.Windows.Forms.TextBox User_TextBox;
    }
}