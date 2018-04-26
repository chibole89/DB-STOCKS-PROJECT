﻿namespace Files_DatabaseFP
{
    partial class Add_Leg
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmbInstType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOrderType = new System.Windows.Forms.ComboBox();
            this.dateEntryDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTransAmt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFees = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStopLoss = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExpireInfo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStrikeInfo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.AddLeg_Add_Leg = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dateFilledDate = new System.Windows.Forms.DateTimePicker();
            this.chkFilled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Instrument Type:";
            // 
            // cmbInstType
            // 
            this.cmbInstType.FormattingEnabled = true;
            this.cmbInstType.Items.AddRange(new object[] {
            "S",
            "O",
            "X",
            "F"});
            this.cmbInstType.Location = new System.Drawing.Point(12, 31);
            this.cmbInstType.Name = "cmbInstType";
            this.cmbInstType.Size = new System.Drawing.Size(128, 21);
            this.cmbInstType.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Order Type:";
            // 
            // cmbOrderType
            // 
            this.cmbOrderType.FormattingEnabled = true;
            this.cmbOrderType.Items.AddRange(new object[] {
            "BTO",
            "BTC",
            "STO",
            "STC"});
            this.cmbOrderType.Location = new System.Drawing.Point(12, 85);
            this.cmbOrderType.Name = "cmbOrderType";
            this.cmbOrderType.Size = new System.Drawing.Size(128, 21);
            this.cmbOrderType.TabIndex = 37;
            this.cmbOrderType.SelectedIndexChanged += new System.EventHandler(this.cmbOrderType_SelectedIndexChanged);
            // 
            // dateEntryDate
            // 
            this.dateEntryDate.Location = new System.Drawing.Point(12, 133);
            this.dateEntryDate.Name = "dateEntryDate";
            this.dateEntryDate.Size = new System.Drawing.Size(200, 20);
            this.dateEntryDate.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "Entry Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(257, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Quantity:";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(260, 31);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(128, 20);
            this.txtQty.TabIndex = 55;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(260, 84);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(128, 20);
            this.txtPrice.TabIndex = 57;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(257, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Price per Share:";
            // 
            // txtTransAmt
            // 
            this.txtTransAmt.Location = new System.Drawing.Point(260, 133);
            this.txtTransAmt.Name = "txtTransAmt";
            this.txtTransAmt.ReadOnly = true;
            this.txtTransAmt.Size = new System.Drawing.Size(128, 20);
            this.txtTransAmt.TabIndex = 59;
            this.txtTransAmt.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(257, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 58;
            this.label6.Text = "Transaction Amount:";
            // 
            // txtFees
            // 
            this.txtFees.Location = new System.Drawing.Point(260, 186);
            this.txtFees.Name = "txtFees";
            this.txtFees.Size = new System.Drawing.Size(128, 20);
            this.txtFees.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(257, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 60;
            this.label7.Text = "Fees";
            // 
            // txtStopLoss
            // 
            this.txtStopLoss.Location = new System.Drawing.Point(440, 133);
            this.txtStopLoss.Name = "txtStopLoss";
            this.txtStopLoss.Size = new System.Drawing.Size(210, 20);
            this.txtStopLoss.TabIndex = 63;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(437, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 62;
            this.label8.Text = "Stop Loss:";
            // 
            // txtExpireInfo
            // 
            this.txtExpireInfo.Location = new System.Drawing.Point(440, 31);
            this.txtExpireInfo.Name = "txtExpireInfo";
            this.txtExpireInfo.Size = new System.Drawing.Size(210, 20);
            this.txtExpireInfo.TabIndex = 65;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(437, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 64;
            this.label9.Text = "Expiry Info:";
            // 
            // txtStrikeInfo
            // 
            this.txtStrikeInfo.Location = new System.Drawing.Point(440, 80);
            this.txtStrikeInfo.Name = "txtStrikeInfo";
            this.txtStrikeInfo.Size = new System.Drawing.Size(210, 20);
            this.txtStrikeInfo.TabIndex = 67;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(437, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 17);
            this.label10.TabIndex = 66;
            this.label10.Text = "Strike Info:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(530, 227);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 70;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddLeg_Add_Leg
            // 
            this.AddLeg_Add_Leg.Location = new System.Drawing.Point(440, 227);
            this.AddLeg_Add_Leg.Name = "AddLeg_Add_Leg";
            this.AddLeg_Add_Leg.Size = new System.Drawing.Size(75, 23);
            this.AddLeg_Add_Leg.TabIndex = 69;
            this.AddLeg_Add_Leg.Text = "Add Leg";
            this.AddLeg_Add_Leg.UseVisualStyleBackColor = true;
            this.AddLeg_Add_Leg.Click += new System.EventHandler(this.AddLeg_Add_Leg_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 233);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 72;
            this.label11.Text = "Filled Date:";

            // 
            // dateFilledDate
            // 
            this.dateFilledDate.Location = new System.Drawing.Point(12, 186);
            this.dateFilledDate.Name = "dateFilledDate";
            this.dateFilledDate.Size = new System.Drawing.Size(200, 20);
            this.dateFilledDate.TabIndex = 71;
            // 
            // chkFilled
            // 
            this.chkFilled.AutoSize = true;
            this.chkFilled.Location = new System.Drawing.Point(12, 167);
            this.chkFilled.Name = "chkFilled";
            this.chkFilled.Size = new System.Drawing.Size(67, 17);
            this.chkFilled.TabIndex = 73;
            this.chkFilled.Text = "Filled On";
            this.chkFilled.UseVisualStyleBackColor = true;
            // 
            // Add_Leg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 269);
            this.Controls.Add(this.chkFilled);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateFilledDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.AddLeg_Add_Leg);
            this.Controls.Add(this.txtStrikeInfo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtExpireInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStopLoss);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFees);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTransAmt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateEntryDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOrderType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbInstType);
            this.Name = "Add_Leg";
            this.Text = "Add Leg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbInstType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOrderType;
        private System.Windows.Forms.DateTimePicker dateEntryDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTransAmt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFees;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStopLoss;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExpireInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStrikeInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button AddLeg_Add_Leg;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateFilledDate;
        private System.Windows.Forms.CheckBox chkFilled;
    }
}