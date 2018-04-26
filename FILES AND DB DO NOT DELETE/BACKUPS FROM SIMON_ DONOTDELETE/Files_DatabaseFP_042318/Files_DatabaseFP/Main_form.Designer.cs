using System;
using System.Data.SqlClient;

namespace Files_DatabaseFP
{
    partial class Main_Form
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
            this.TransactionLeg_DataGridView = new System.Windows.Forms.DataGridView();
            this.Transaction_DataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.StartDate_Label = new System.Windows.Forms.Label();
            this.Technique_Label = new System.Windows.Forms.Label();
            this.Symbol_Label = new System.Windows.Forms.Label();
            this.OrderStatus_Label = new System.Windows.Forms.Label();
            this.flowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.open_Radiobutton = new System.Windows.Forms.RadioButton();
            this.closed_Radiobutton = new System.Windows.Forms.RadioButton();
            this.pending_Radiobutton = new System.Windows.Forms.RadioButton();
            this.remove_Tran = new System.Windows.Forms.Button();
            this.remove_Leg = new System.Windows.Forms.Button();
            this.update_leg = new System.Windows.Forms.Button();
            this.MainForm_Add_Leg = new System.Windows.Forms.Button();
            this.Manage_Tech = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Update_Tran = new System.Windows.Forms.Button();
            this.Add_Tran = new System.Windows.Forms.Button();
            this.Technique_Combobox = new System.Windows.Forms.ComboBox();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Start_Date = new System.Windows.Forms.DateTimePicker();
            this.End_Date = new System.Windows.Forms.DateTimePicker();
            this.EndDate_Label = new System.Windows.Forms.Label();
            this.Reset_Filter = new System.Windows.Forms.Button();
            this.Symbol_Combobox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AveragePL_Textbox = new System.Windows.Forms.TextBox();
            this.Averages_Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Averages_Panel = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.ManageUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionLeg_DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transaction_DataGridView)).BeginInit();
            this.flowLayout.SuspendLayout();
            this.Averages_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TransactionLeg_DataGridView
            // 
            this.TransactionLeg_DataGridView.AllowUserToAddRows = false;
            this.TransactionLeg_DataGridView.AllowUserToDeleteRows = false;
            this.TransactionLeg_DataGridView.AllowUserToResizeColumns = false;
            this.TransactionLeg_DataGridView.AllowUserToResizeRows = false;
            this.TransactionLeg_DataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TransactionLeg_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TransactionLeg_DataGridView.ColumnHeadersVisible = false;
            this.TransactionLeg_DataGridView.Location = new System.Drawing.Point(18, 795);
            this.TransactionLeg_DataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TransactionLeg_DataGridView.MultiSelect = false;
            this.TransactionLeg_DataGridView.Name = "TransactionLeg_DataGridView";
            this.TransactionLeg_DataGridView.ReadOnly = true;
            this.TransactionLeg_DataGridView.RowHeadersVisible = false;
            this.TransactionLeg_DataGridView.Size = new System.Drawing.Size(1354, 308);
            this.TransactionLeg_DataGridView.TabIndex = 57;
            this.TransactionLeg_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TransactionLeg_DataGridView_CellClick);
            // 
            // Transaction_DataGridView
            // 
            this.Transaction_DataGridView.AllowUserToAddRows = false;
            this.Transaction_DataGridView.AllowUserToDeleteRows = false;
            this.Transaction_DataGridView.AllowUserToResizeColumns = false;
            this.Transaction_DataGridView.AllowUserToResizeRows = false;
            this.Transaction_DataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Transaction_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Transaction_DataGridView.ColumnHeadersVisible = false;
            this.Transaction_DataGridView.Location = new System.Drawing.Point(18, 302);
            this.Transaction_DataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Transaction_DataGridView.MultiSelect = false;
            this.Transaction_DataGridView.Name = "Transaction_DataGridView";
            this.Transaction_DataGridView.ReadOnly = true;
            this.Transaction_DataGridView.RowHeadersVisible = false;
            this.Transaction_DataGridView.Size = new System.Drawing.Size(1354, 308);
            this.Transaction_DataGridView.TabIndex = 59;
            this.Transaction_DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Transaction_DataGridView_CellClick);
            this.Transaction_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Transaction_DataGridView_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 67;
            this.label5.Text = "Filter By:";
            // 
            // StartDate_Label
            // 
            this.StartDate_Label.AutoSize = true;
            this.StartDate_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDate_Label.Location = new System.Drawing.Point(14, 95);
            this.StartDate_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StartDate_Label.Name = "StartDate_Label";
            this.StartDate_Label.Size = new System.Drawing.Size(99, 25);
            this.StartDate_Label.TabIndex = 69;
            this.StartDate_Label.Text = "Start Date";
            // 
            // Technique_Label
            // 
            this.Technique_Label.AutoSize = true;
            this.Technique_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Technique_Label.Location = new System.Drawing.Point(963, 95);
            this.Technique_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Technique_Label.Name = "Technique_Label";
            this.Technique_Label.Size = new System.Drawing.Size(105, 25);
            this.Technique_Label.TabIndex = 71;
            this.Technique_Label.Text = "Technique";
            // 
            // Symbol_Label
            // 
            this.Symbol_Label.AutoSize = true;
            this.Symbol_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Symbol_Label.Location = new System.Drawing.Point(1144, 95);
            this.Symbol_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Symbol_Label.Name = "Symbol_Label";
            this.Symbol_Label.Size = new System.Drawing.Size(78, 25);
            this.Symbol_Label.TabIndex = 72;
            this.Symbol_Label.Text = "Symbol";
            // 
            // OrderStatus_Label
            // 
            this.OrderStatus_Label.AutoSize = true;
            this.OrderStatus_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderStatus_Label.Location = new System.Drawing.Point(712, 95);
            this.OrderStatus_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OrderStatus_Label.Name = "OrderStatus_Label";
            this.OrderStatus_Label.Size = new System.Drawing.Size(123, 25);
            this.OrderStatus_Label.TabIndex = 79;
            this.OrderStatus_Label.Text = "Order Status";
            // 
            // flowLayout
            // 
            this.flowLayout.Controls.Add(this.open_Radiobutton);
            this.flowLayout.Controls.Add(this.closed_Radiobutton);
            this.flowLayout.Controls.Add(this.pending_Radiobutton);
            this.flowLayout.Location = new System.Drawing.Point(640, 128);
            this.flowLayout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayout.Name = "flowLayout";
            this.flowLayout.Size = new System.Drawing.Size(286, 34);
            this.flowLayout.TabIndex = 71;
            // 
            // open_Radiobutton
            // 
            this.open_Radiobutton.AutoSize = true;
            this.open_Radiobutton.Checked = true;
            this.open_Radiobutton.Location = new System.Drawing.Point(4, 5);
            this.open_Radiobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.open_Radiobutton.Name = "open_Radiobutton";
            this.open_Radiobutton.Size = new System.Drawing.Size(73, 24);
            this.open_Radiobutton.TabIndex = 0;
            this.open_Radiobutton.TabStop = true;
            this.open_Radiobutton.Text = "Open";
            this.open_Radiobutton.UseVisualStyleBackColor = true;
            this.open_Radiobutton.CheckedChanged += new System.EventHandler(this.open_Radiobutton_CheckedChanged);
            // 
            // closed_Radiobutton
            // 
            this.closed_Radiobutton.AutoSize = true;
            this.closed_Radiobutton.Location = new System.Drawing.Point(85, 5);
            this.closed_Radiobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.closed_Radiobutton.Name = "closed_Radiobutton";
            this.closed_Radiobutton.Size = new System.Drawing.Size(83, 24);
            this.closed_Radiobutton.TabIndex = 0;
            this.closed_Radiobutton.Text = "Closed";
            this.closed_Radiobutton.UseVisualStyleBackColor = true;
            this.closed_Radiobutton.CheckedChanged += new System.EventHandler(this.closed_Radiobutton_CheckedChanged);
            // 
            // pending_Radiobutton
            // 
            this.pending_Radiobutton.AutoSize = true;
            this.pending_Radiobutton.Location = new System.Drawing.Point(176, 5);
            this.pending_Radiobutton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pending_Radiobutton.Name = "pending_Radiobutton";
            this.pending_Radiobutton.Size = new System.Drawing.Size(92, 24);
            this.pending_Radiobutton.TabIndex = 0;
            this.pending_Radiobutton.Text = "Pending";
            this.pending_Radiobutton.UseVisualStyleBackColor = true;
            this.pending_Radiobutton.CheckedChanged += new System.EventHandler(this.pending_Radiobutton_CheckedChanged);
            // 
            // remove_Tran
            // 
            this.remove_Tran.BackColor = System.Drawing.SystemColors.Control;
            this.remove_Tran.Location = new System.Drawing.Point(1192, 217);
            this.remove_Tran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remove_Tran.Name = "remove_Tran";
            this.remove_Tran.Size = new System.Drawing.Size(180, 35);
            this.remove_Tran.TabIndex = 80;
            this.remove_Tran.Text = "Remove Transaction";
            this.remove_Tran.UseVisualStyleBackColor = true;
            this.remove_Tran.Click += new System.EventHandler(this.Remove_Tran_Click);
            // 
            // remove_Leg
            // 
            this.remove_Leg.BackColor = System.Drawing.SystemColors.Control;
            this.remove_Leg.Location = new System.Drawing.Point(1192, 711);
            this.remove_Leg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.remove_Leg.Name = "remove_Leg";
            this.remove_Leg.Size = new System.Drawing.Size(180, 35);
            this.remove_Leg.TabIndex = 83;
            this.remove_Leg.Text = "Remove Leg";
            this.remove_Leg.UseVisualStyleBackColor = true;
            this.remove_Leg.Click += new System.EventHandler(this.Remove_Leg_Click);
            // 
            // update_leg
            // 
            this.update_leg.BackColor = System.Drawing.SystemColors.Control;
            this.update_leg.Location = new System.Drawing.Point(1004, 711);
            this.update_leg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.update_leg.Name = "update_leg";
            this.update_leg.Size = new System.Drawing.Size(180, 35);
            this.update_leg.TabIndex = 82;
            this.update_leg.Text = "Update Leg";
            this.update_leg.UseVisualStyleBackColor = true;
            this.update_leg.Click += new System.EventHandler(this.Update_Leg_Click);
            // 
            // MainForm_Add_Leg
            // 
            this.MainForm_Add_Leg.BackColor = System.Drawing.SystemColors.Control;
            this.MainForm_Add_Leg.Location = new System.Drawing.Point(814, 711);
            this.MainForm_Add_Leg.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MainForm_Add_Leg.Name = "MainForm_Add_Leg";
            this.MainForm_Add_Leg.Size = new System.Drawing.Size(180, 35);
            this.MainForm_Add_Leg.TabIndex = 81;
            this.MainForm_Add_Leg.Text = "Add  Leg";
            this.MainForm_Add_Leg.UseVisualStyleBackColor = true;
            this.MainForm_Add_Leg.Click += new System.EventHandler(this.Add_Leg_Click);
            // 
            // Manage_Tech
            // 
            this.Manage_Tech.BackColor = System.Drawing.SystemColors.Control;
            this.Manage_Tech.Location = new System.Drawing.Point(1004, 172);
            this.Manage_Tech.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Manage_Tech.Name = "Manage_Tech";
            this.Manage_Tech.Size = new System.Drawing.Size(180, 35);
            this.Manage_Tech.TabIndex = 84;
            this.Manage_Tech.Text = "Manage Techniques";
            this.Manage_Tech.UseVisualStyleBackColor = true;
            this.Manage_Tech.Click += new System.EventHandler(this.Manage_Tech_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 206);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 36);
            this.label8.TabIndex = 85;
            this.label8.Text = "Transaction";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 698);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(229, 36);
            this.label9.TabIndex = 86;
            this.label9.Text = "Transaction Leg";
            // 
            // Update_Tran
            // 
            this.Update_Tran.Location = new System.Drawing.Point(1004, 217);
            this.Update_Tran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Update_Tran.Name = "Update_Tran";
            this.Update_Tran.Size = new System.Drawing.Size(180, 35);
            this.Update_Tran.TabIndex = 87;
            this.Update_Tran.Text = "Update Transaction";
            this.Update_Tran.UseVisualStyleBackColor = true;
            this.Update_Tran.Click += new System.EventHandler(this.Update_Tran_Click);
            // 
            // Add_Tran
            // 
            this.Add_Tran.Location = new System.Drawing.Point(814, 217);
            this.Add_Tran.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add_Tran.Name = "Add_Tran";
            this.Add_Tran.Size = new System.Drawing.Size(180, 35);
            this.Add_Tran.TabIndex = 88;
            this.Add_Tran.Text = "Add Transaction";
            this.Add_Tran.UseVisualStyleBackColor = true;
            this.Add_Tran.Click += new System.EventHandler(this.Add_Tran_Click);
            // 
            // Technique_Combobox
            // 
            this.Technique_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Technique_Combobox.FormattingEnabled = true;
            this.Technique_Combobox.Items.AddRange(new object[] {
            "-- All Techniques --"});
            this.Technique_Combobox.Location = new System.Drawing.Point(936, 126);
            this.Technique_Combobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Technique_Combobox.Name = "Technique_Combobox";
            this.Technique_Combobox.Size = new System.Drawing.Size(166, 28);
            this.Technique_Combobox.TabIndex = 89;
            this.Technique_Combobox.SelectedIndexChanged += new System.EventHandler(this.Technique_Combobox_SelectedIndexChanged);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Program Files\\Microsoft S" +
    "QL Server\\MSSQL11.MSSQLSERVER\\MSSQL\\DATA\\StockDatabase.mdf\";Integrated Security=" +
    "True;Connect Timeout=30";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection1.InfoMessage += new System.Data.SqlClient.SqlInfoMessageEventHandler(this.sqlConnection1_InfoMessage);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(110, 18);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(205, 28);
            this.comboBox2.TabIndex = 90;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 91;
            this.label1.Text = "User:";
            // 
            // Start_Date
            // 
            this.Start_Date.Location = new System.Drawing.Point(18, 132);
            this.Start_Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Start_Date.Name = "Start_Date";
            this.Start_Date.Size = new System.Drawing.Size(298, 26);
            this.Start_Date.TabIndex = 92;
            this.Start_Date.Value = new System.DateTime(2018, 2, 1, 0, 0, 0, 0);
            this.Start_Date.ValueChanged += new System.EventHandler(this.Start_Date_ValueChanged);
            // 
            // End_Date
            // 
            this.End_Date.Location = new System.Drawing.Point(332, 131);
            this.End_Date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.End_Date.Name = "End_Date";
            this.End_Date.Size = new System.Drawing.Size(298, 26);
            this.End_Date.TabIndex = 93;
            this.End_Date.Value = new System.DateTime(2018, 4, 21, 0, 0, 0, 0);
            this.End_Date.ValueChanged += new System.EventHandler(this.End_Date_ValueChanged);
            // 
            // EndDate_Label
            // 
            this.EndDate_Label.AutoSize = true;
            this.EndDate_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDate_Label.Location = new System.Drawing.Point(327, 95);
            this.EndDate_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EndDate_Label.Name = "EndDate_Label";
            this.EndDate_Label.Size = new System.Drawing.Size(93, 25);
            this.EndDate_Label.TabIndex = 69;
            this.EndDate_Label.Text = "End Date";
            // 
            // Reset_Filter
            // 
            this.Reset_Filter.Location = new System.Drawing.Point(1192, 172);
            this.Reset_Filter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Reset_Filter.Name = "Reset_Filter";
            this.Reset_Filter.Size = new System.Drawing.Size(180, 35);
            this.Reset_Filter.TabIndex = 94;
            this.Reset_Filter.Text = "Reset";
            this.Reset_Filter.UseVisualStyleBackColor = true;
            this.Reset_Filter.Click += new System.EventHandler(this.Reset_Filter_Click);
            // 
            // Symbol_Combobox
            // 
            this.Symbol_Combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Symbol_Combobox.FormattingEnabled = true;
            this.Symbol_Combobox.Items.AddRange(new object[] {
            "-- All Symbols --"});
            this.Symbol_Combobox.Location = new System.Drawing.Point(1113, 126);
            this.Symbol_Combobox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Symbol_Combobox.Name = "Symbol_Combobox";
            this.Symbol_Combobox.Size = new System.Drawing.Size(140, 28);
            this.Symbol_Combobox.TabIndex = 95;
            this.Symbol_Combobox.SelectedIndexChanged += new System.EventHandler(this.Symbol_Combobox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(699, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 26);
            this.textBox1.TabIndex = 96;
            // 
            // AveragePL_Textbox
            // 
            this.AveragePL_Textbox.Location = new System.Drawing.Point(855, 5);
            this.AveragePL_Textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AveragePL_Textbox.Name = "AveragePL_Textbox";
            this.AveragePL_Textbox.ReadOnly = true;
            this.AveragePL_Textbox.Size = new System.Drawing.Size(148, 26);
            this.AveragePL_Textbox.TabIndex = 97;
            // 
            // Averages_Label
            // 
            this.Averages_Label.AutoSize = true;
            this.Averages_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Averages_Label.Location = new System.Drawing.Point(3, 5);
            this.Averages_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Averages_Label.Name = "Averages_Label";
            this.Averages_Label.Size = new System.Drawing.Size(96, 25);
            this.Averages_Label.TabIndex = 91;
            this.Averages_Label.Text = "Averages";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 257);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 40);
            this.label2.TabIndex = 98;
            this.label2.Text = "Transaction\r\nNumber";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(117, 277);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 98;
            this.label4.Text = "Symbol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(194, 277);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 98;
            this.label6.Text = "Open Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(298, 277);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 98;
            this.label7.Text = "Close Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(393, 277);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 98;
            this.label10.Text = "Technique";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(584, 277);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 98;
            this.label11.Text = "Entry Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(507, 277);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 20);
            this.label12.TabIndex = 98;
            this.label12.Text = "Risk";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(693, 277);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 20);
            this.label13.TabIndex = 98;
            this.label13.Text = "Exit Amount";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(814, 277);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 20);
            this.label14.TabIndex = 98;
            this.label14.Text = "Fees";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(902, 277);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(91, 20);
            this.label15.TabIndex = 98;
            this.label15.Text = "Profit/Loss";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1006, 277);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(99, 20);
            this.label16.TabIndex = 98;
            this.label16.Text = "Return Rate";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(1112, 257);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 40);
            this.label17.TabIndex = 98;
            this.label17.Text = "Days\r\nIn Trade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1186, 257);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 40);
            this.label3.TabIndex = 98;
            this.label3.Text = "Annualized\r\nRate";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1290, 257);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 40);
            this.label18.TabIndex = 98;
            this.label18.Text = "Paper\r\nAccount";
            // 
            // Averages_Panel
            // 
            this.Averages_Panel.Controls.Add(this.Averages_Label);
            this.Averages_Panel.Controls.Add(this.textBox1);
            this.Averages_Panel.Controls.Add(this.AveragePL_Textbox);
            this.Averages_Panel.Location = new System.Drawing.Point(18, 618);
            this.Averages_Panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Averages_Panel.Name = "Averages_Panel";
            this.Averages_Panel.Size = new System.Drawing.Size(1354, 40);
            this.Averages_Panel.TabIndex = 99;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 751);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 40);
            this.label19.TabIndex = 98;
            this.label19.Text = "Transaction\r\nNumber";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(116, 751);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 40);
            this.label20.TabIndex = 98;
            this.label20.Text = "Leg\r\nNumber";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(188, 751);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(88, 40);
            this.label21.TabIndex = 98;
            this.label21.Text = "Instrument\r\nType";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(291, 751);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 40);
            this.label22.TabIndex = 98;
            this.label22.Text = "Order\r\nType";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(354, 771);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(71, 20);
            this.label23.TabIndex = 98;
            this.label23.Text = "Quantity";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(512, 771);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 20);
            this.label24.TabIndex = 98;
            this.label24.Text = "Share Price";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(434, 751);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(69, 40);
            this.label25.TabIndex = 98;
            this.label25.Text = "Position\r\nSize";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(626, 771);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(85, 20);
            this.label26.TabIndex = 98;
            this.label26.Text = "Stop Loss";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(1023, 751);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(97, 40);
            this.label27.TabIndex = 98;
            this.label27.Text = "Transaction\r\nAmount";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(951, 771);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(46, 20);
            this.label28.TabIndex = 98;
            this.label28.Text = "Fees";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(729, 771);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(89, 20);
            this.label29.TabIndex = 98;
            this.label29.Text = "Entry Date";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(834, 771);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(90, 20);
            this.label30.TabIndex = 98;
            this.label30.Text = "Filled Date";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(1263, 771);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(84, 20);
            this.label31.TabIndex = 98;
            this.label31.Text = "Strike Info";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(1136, 771);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(87, 20);
            this.label32.TabIndex = 98;
            this.label32.Text = "Expiry Info";
            // 
            // ManageUsers
            // 
            this.ManageUsers.Location = new System.Drawing.Point(1191, 18);
            this.ManageUsers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ManageUsers.Name = "ManageUsers";
            this.ManageUsers.Size = new System.Drawing.Size(180, 35);
            this.ManageUsers.TabIndex = 94;
            this.ManageUsers.TabStop = false;
            this.ManageUsers.Text = "Manage Users";
            this.ManageUsers.UseVisualStyleBackColor = true;
            this.ManageUsers.Click += new System.EventHandler(this.ManageUsers_Click);
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1394, 1122);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Symbol_Combobox);
            this.Controls.Add(this.ManageUsers);
            this.Controls.Add(this.Reset_Filter);
            this.Controls.Add(this.End_Date);
            this.Controls.Add(this.Start_Date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Technique_Combobox);
            this.Controls.Add(this.Add_Tran);
            this.Controls.Add(this.Update_Tran);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Manage_Tech);
            this.Controls.Add(this.remove_Leg);
            this.Controls.Add(this.update_leg);
            this.Controls.Add(this.MainForm_Add_Leg);
            this.Controls.Add(this.remove_Tran);
            this.Controls.Add(this.flowLayout);
            this.Controls.Add(this.OrderStatus_Label);
            this.Controls.Add(this.Symbol_Label);
            this.Controls.Add(this.Technique_Label);
            this.Controls.Add(this.EndDate_Label);
            this.Controls.Add(this.StartDate_Label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Transaction_DataGridView);
            this.Controls.Add(this.TransactionLeg_DataGridView);
            this.Controls.Add(this.Averages_Panel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock and Derivative Tracking Database";
            this.Load += new System.EventHandler(this.Main_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionLeg_DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Transaction_DataGridView)).EndInit();
            this.flowLayout.ResumeLayout(false);
            this.flowLayout.PerformLayout();
            this.Averages_Panel.ResumeLayout(false);
            this.Averages_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView TransactionLeg_DataGridView;
        private System.Windows.Forms.DataGridView Transaction_DataGridView;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label StartDate_Label;
        private System.Windows.Forms.Label Technique_Label;
        private System.Windows.Forms.Label Symbol_Label;
        private System.Windows.Forms.Label OrderStatus_Label;
        private System.Windows.Forms.FlowLayoutPanel flowLayout;
        private System.Windows.Forms.Button remove_Tran;
        private System.Windows.Forms.Button remove_Leg;
        private System.Windows.Forms.Button update_leg;
        private System.Windows.Forms.Button MainForm_Add_Leg;
        private System.Windows.Forms.Button Manage_Tech;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button Update_Tran;
        private System.Windows.Forms.Button Add_Tran;
        private System.Windows.Forms.ComboBox Technique_Combobox;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Start_Date;
        private System.Windows.Forms.DateTimePicker End_Date;
        private System.Windows.Forms.Label EndDate_Label;
        private System.Windows.Forms.Button Reset_Filter;
        private System.Windows.Forms.ComboBox Symbol_Combobox;
        private System.Windows.Forms.RadioButton open_Radiobutton;
        private System.Windows.Forms.RadioButton closed_Radiobutton;
        private System.Windows.Forms.RadioButton pending_Radiobutton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox AveragePL_Textbox;
        private System.Windows.Forms.Label Averages_Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private SqlConnection sqlConnection1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel Averages_Panel;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button ManageUsers;
    }
}