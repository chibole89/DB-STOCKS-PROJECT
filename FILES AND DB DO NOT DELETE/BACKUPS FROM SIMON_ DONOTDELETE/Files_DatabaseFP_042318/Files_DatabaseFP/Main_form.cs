using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Files_DatabaseFP
{
    public partial class Main_Form : Form
    {
        public decimal totalPL;
        public int clientnum, legnum, transnum;
        public List<int> clientNumList = new List<int>();
        public List<int> transactionIDList = new List<int>();

        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_form_Load(object sender, EventArgs e)
        {

            try
            {
                sqlConnection1.Open();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            End_Date.Value = DateTime.Now;

            if (open_Radiobutton.Checked == true)
            {
                Start_Date.Enabled = false;
                End_Date.Enabled = false;
                Averages_Panel.Visible = false;
            }
            else if (closed_Radiobutton.Checked == true)
            {
                Start_Date.Enabled = true;
                End_Date.Enabled = true;
                CalculateAverages();
                Averages_Panel.Visible = true;
                AveragePL_Textbox.Text = totalPL.ToString();
            }

            SqlCommand cmdGetUsers = sqlConnection1.CreateCommand();
            cmdGetUsers.CommandText = "SELECT fname, lname, client_no FROM CLIENT";
            SqlDataReader reader = cmdGetUsers.ExecuteReader();

            while (reader.Read())
            {
                comboBox2.Items.Add(reader[0].ToString() + " " + reader[1].ToString());
                clientNumList.Add(Convert.ToInt32(reader[2]));
            }
            reader.Close();
            comboBox2.Text = comboBox2.Items[0].ToString();

            clientnum = clientNumList[comboBox2.SelectedIndex];

            NewMethod();

            UpdateTechniqueSymbol();
            UpdateTransactionView();
            UpdateTransactionLegView();
        }

        

        private void NewMethod()
        {
            transnum = Convert.ToInt32(Transaction_DataGridView.CurrentRow.Cells[0].Value);
        }

        private void UpdateTransactionView()
        {

            SqlCommand cmdGetTransactions = sqlConnection1.CreateCommand();
            cmdGetTransactions.CommandText = "SELECT * FROM TRANSACTION_RECORD WHERE Client_no = @Client_no";
            cmdGetTransactions.Parameters.AddWithValue("@Client_no", clientnum);

            if (open_Radiobutton.Checked == true)
                cmdGetTransactions.CommandText += " AND open_Date IS NOT NULL AND close_Date IS NULL";

            else if (closed_Radiobutton.Checked == true)
            {
                cmdGetTransactions.CommandText += " AND close_Date BETWEEN @startDate AND @endDate";
                cmdGetTransactions.Parameters.AddWithValue("@startDate", Start_Date.Value.ToString("yyyy-MM-dd"));
                cmdGetTransactions.Parameters.AddWithValue("@endDate", End_Date.Value.ToString("yyyy-MM-dd"));
            }

            else if (pending_Radiobutton.Checked == true)
                cmdGetTransactions.CommandText += " AND open_Date IS NULL";

            if (Technique_Combobox.Text != "-- All Techniques --")
            {
                cmdGetTransactions.CommandText += " AND technique = @technique";
                cmdGetTransactions.Parameters.AddWithValue("@technique", Technique_Combobox.Text);
            }

            if (Symbol_Combobox.Text != "-- All Symbols --")
            {
                cmdGetTransactions.CommandText += " AND Symbol = @symbol";
                cmdGetTransactions.Parameters.AddWithValue("@symbol", Symbol_Combobox.Text);
            }

            SqlDataReader reader4 = cmdGetTransactions.ExecuteReader();

            DataTable tmpTable = new DataTable();
            tmpTable.Load(reader4);

            Transaction_DataGridView.DataSource = tmpTable;
            reader4.Close();

            Transaction_DataGridView.Columns[0].Width = 60;         // Transaction Number
            Transaction_DataGridView.Columns[1].Visible = false;    // Client Number
            Transaction_DataGridView.Columns[2].Width = 50;         // Symbol
            Transaction_DataGridView.Columns[3].Width = 70;         // Open Date
            Transaction_DataGridView.Columns[4].Width = 70;         // Close Date
            Transaction_DataGridView.Columns[5].Width = 55;         // Technique
            Transaction_DataGridView.Columns[6].Width = 70;         // Entry Amount
            Transaction_DataGridView.Columns[7].Width = 70;         // Risk
            Transaction_DataGridView.Columns[8].Width = 70;         // Exit Amount
            Transaction_DataGridView.Columns[9].Width = 60;         // Fees
            Transaction_DataGridView.Columns[10].Width = 80;        // PL
            Transaction_DataGridView.Columns[11].Width = 70;        // Return Rate
            Transaction_DataGridView.Columns[12].Width = 50;        // Days In Trade
            Transaction_DataGridView.Columns[13].Width = 65;        // Annualized Rate
            Transaction_DataGridView.Columns[14].Width = 60;        // Paper Trade
        }

        private void UpdateTransactionLegView()
        {
            if (Transaction_DataGridView.Rows.Count == 0)
                TransactionLeg_DataGridView.DataSource = null;
            else
            {
                SqlCommand cmdGetLegs = sqlConnection1.CreateCommand();
                cmdGetLegs.CommandText = "SELECT * FROM TRANSACTION_LEG WHERE Trans_no = @Trans_no ";
                cmdGetLegs.Parameters.AddWithValue("@Trans_no", Convert.ToInt32(Transaction_DataGridView.CurrentRow.Cells[0].Value));

                SqlDataReader reader6 = cmdGetLegs.ExecuteReader();

                DataTable tmpTable = new DataTable();
                tmpTable.Load(reader6);

                TransactionLeg_DataGridView.DataSource = tmpTable;
                reader6.Close();

                TransactionLeg_DataGridView.Columns[0].Width = 60;         // Transaction Number
                TransactionLeg_DataGridView.Columns[1].Width = 50;         // Leg Number
                TransactionLeg_DataGridView.Columns[2].Width = 60;         // Instrument Type
                TransactionLeg_DataGridView.Columns[3].Width = 50;         // Order Type
                TransactionLeg_DataGridView.Columns[4].Width = 50;         // Quantity
                TransactionLeg_DataGridView.Columns[5].Width = 55;         // Position Size
                TransactionLeg_DataGridView.Columns[6].Width = 70;         // Share Price
                TransactionLeg_DataGridView.Columns[7].Width = 70;         // Stop Loss
                TransactionLeg_DataGridView.Columns[8].Width = 70;         // Entry Date
                TransactionLeg_DataGridView.Columns[9].Width = 70;         // Filled Date
                TransactionLeg_DataGridView.Columns[10].Width = 60;        // Fees
                TransactionLeg_DataGridView.Columns[11].Width = 70;        // Transaction Amount 
                TransactionLeg_DataGridView.Columns[12].Width = 70;        // Expiry Info
                TransactionLeg_DataGridView.Columns[13].Width = 95;        // Strike Info
            }
        }

        private void UpdateTechniqueSymbol()
        {
            SqlCommand cmdGetTechniques = sqlConnection1.CreateCommand();
            cmdGetTechniques.CommandText = "SELECT Acronym FROM TECHNIQUE WHERE client_no = @client_no";
            cmdGetTechniques.Parameters.AddWithValue("@client_no", clientNumList[comboBox2.SelectedIndex]);

            SqlDataReader reader2 = cmdGetTechniques.ExecuteReader();
            Technique_Combobox.Items.Clear();
            Symbol_Combobox.Items.Clear();

            while (reader2.Read())
                Technique_Combobox.Items.Add(reader2[0].ToString());

            reader2.Close();

            if (Technique_Combobox.Items.Count == 0)
            {
                Technique_Combobox.Items.Insert(0, "-- No Symbols --");
                Technique_Combobox.Text = Technique_Combobox.Items[0].ToString();
                Technique_Combobox.Enabled = false;
            }
            else if (Technique_Combobox.Items.Count == 1)
            {
                Technique_Combobox.Text = Technique_Combobox.Items[0].ToString();
                Technique_Combobox.Enabled = true;
            }
            else                       //if (Technique_Combobox.Items.Count > 1)
            {
                Technique_Combobox.Items.Insert(0, "-- All Techniques --");
                Technique_Combobox.Text = Technique_Combobox.Items[0].ToString();
                Technique_Combobox.Enabled = true;
            }

            SqlCommand cmdGetSymbols = sqlConnection1.CreateCommand();
            cmdGetSymbols.CommandText = "SELECT DISTINCT Symbol FROM TRANSACTION_RECORD WHERE client_no = @client_no";
            cmdGetSymbols.Parameters.AddWithValue("@client_no", clientNumList[comboBox2.SelectedIndex]);
            SqlDataReader reader3 = cmdGetSymbols.ExecuteReader();

            while (reader3.Read())
                Symbol_Combobox.Items.Add(reader3[0].ToString());

            reader3.Close();

            if (Symbol_Combobox.Items.Count == 0)
            {
                Symbol_Combobox.Items.Insert(0, "-- No Symbols --");
                Symbol_Combobox.Text = Symbol_Combobox.Items[0].ToString();
                Symbol_Combobox.Enabled = false;
            }
            else if (Symbol_Combobox.Items.Count == 1)
            {
                Symbol_Combobox.Text = Symbol_Combobox.Items[0].ToString();
                Symbol_Combobox.Enabled = true;
            }
            else                   // if (Symbol_Combobox.Items.Count > 1)
            {
                Symbol_Combobox.Items.Insert(0, "-- All Symbols --");
                Symbol_Combobox.Text = Symbol_Combobox.Items[0].ToString();
                Symbol_Combobox.Enabled = true;
            }
        }

        private void Manage_Tech_Click(object sender, EventArgs e)
        {
            Manage_Technique frm = new Manage_Technique();
            frm.sqlDBConnection = sqlConnection1;
            frm.User_TextBox.Text = comboBox2.Text;
            frm.Manage_clientnum = clientnum;
            frm.ShowDialog();
            UpdateTechniqueSymbol();
        }

        private void Remove_Tran_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to remove this transaction?", "Confirm transaction removal", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmdDeleteTrans = sqlConnection1.CreateCommand();
                cmdDeleteTrans.CommandText = "DELETE FROM TRANSACTION_LEG WHERE Trans_no = @Trans_no ";
                cmdDeleteTrans.Parameters.AddWithValue("@Trans_no", transnum);
                cmdDeleteTrans.ExecuteNonQuery();

                cmdDeleteTrans.CommandText = "DELETE FROM TRANSACTION_RECORD WHERE Trans_no = @Trans_num ";
                cmdDeleteTrans.Parameters.AddWithValue("@Trans_num", transnum);
                cmdDeleteTrans.ExecuteNonQuery();
                MessageBox.Show("Transaction has been removed from database", "Transaction removed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                UpdateTechniqueSymbol();
                UpdateTransactionView();
                UpdateTransactionLegView();
            }
        }

        private void Add_Leg_Click(object sender, EventArgs e)
        {
            Add_Leg frm = new Add_Leg();
            frm.ShowDialog();
        }

        private void Update_Leg_Click(object sender, EventArgs e)
        {
            Add_Leg frm = new Add_Leg();
            frm.ShowDialog();
        }

        private void Remove_Leg_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to remove this leg?", "Confirm leg removal", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if(result == DialogResult.Yes)
            {
                SqlCommand cmdDeleteleg = sqlConnection1.CreateCommand();
                cmdDeleteleg.CommandText = "DELETE FROM TRANSACTION_LEG WHERE Trans_no = @Trans_no AND Leg_No = @Leg_No";
                cmdDeleteleg.Parameters.AddWithValue("@Trans_no", transnum);
                cmdDeleteleg.Parameters.AddWithValue("@Leg_no", legnum);
                cmdDeleteleg.ExecuteNonQuery();
            }
            MessageBox.Show("Leg has been removed from database", "Leg removed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            UpdateTransactionLegView();
        }

        private void Update_Tran_Click(object sender, EventArgs e)
        {
            Add_Edit_Transaction form = new Add_Edit_Transaction();
            form.Text = "Update Transaction";
            form.ShowDialog();
        }

        private void Add_Tran_Click(object sender, EventArgs e)
        {
            Add_Edit_Transaction form = new Add_Edit_Transaction();
            form.ShowDialog();
        }

        private void Reset_Filter_Click(object sender, EventArgs e)
        {
            open_Radiobutton.Checked = true;
            End_Date.Value = DateTime.Now;
            Start_Date.Value = DateTime.Now.AddMonths(-1);
            Technique_Combobox.Text = "-- All Techniques --";
            Symbol_Combobox.Text = "-- All Symbols --";
            UpdateTransactionView();
        }

        private void Symbol_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTransactionView();
            if (closed_Radiobutton.Checked == true)
                CalculateAverages();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            clientnum = clientNumList[comboBox2.SelectedIndex];
            UpdateTechniqueSymbol();
            UpdateTransactionView();
            UpdateTransactionLegView();
            CalculateAverages();
        }

        private void Start_Date_ValueChanged(object sender, EventArgs e)
        {
            UpdateTransactionView();
            UpdateTransactionLegView();
            CalculateAverages();
        }

        private void End_Date_ValueChanged(object sender, EventArgs e)
        {
            UpdateTransactionView();
            CalculateAverages();
        }

        private void TransactionLeg_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            legnum = Convert.ToInt32(TransactionLeg_DataGridView.Rows[e.RowIndex].Cells[1].Value);
        }

        private void Transaction_DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            transnum = Convert.ToInt32(Transaction_DataGridView.CurrentRow.Cells[0].Value);//Convert.ToInt32(Transaction_DataGridView.Rows[e.RowIndex].Cells[0].Value);
            UpdateTransactionLegView();
        }

        private void Technique_Combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTransactionView();
            CalculateAverages();
        }

        private void open_Radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTransactionView();
            UpdateTransactionLegView();
            if (open_Radiobutton.Checked == true)
            {
                Start_Date.Enabled = false;
                End_Date.Enabled = false;
            }
            else
            {
                Start_Date.Enabled = true;
                End_Date.Enabled = true;
            }
        }

        private void closed_Radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTransactionView();
            UpdateTransactionLegView();
            if (closed_Radiobutton.Checked == true)
            {
                CalculateAverages();
                Averages_Panel.Visible = true;
            }
            else
            {
                Averages_Panel.Visible = false;
            }
        }

        private void ManageUsers_Click(object sender, EventArgs e)
        {
            Add_Edit_Client frm = new Add_Edit_Client();
            frm.sqlDBConnection = sqlConnection1;
            frm.ShowDialog();
            UpdateTechniqueSymbol();
        }

        private void sqlConnection1_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {

        }

        private void Transaction_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CalculateAverages()
        {
            totalPL = 0;
            for (int i = 0; i < Transaction_DataGridView.Rows.Count; ++i)
                if (Transaction_DataGridView.Rows[i].Cells[10].Value == DBNull.Value)
                    continue;
                else
                    totalPL += Convert.ToDecimal(Transaction_DataGridView.Rows[i].Cells[10].Value);
            if (Transaction_DataGridView.Rows.Count != 0)
                totalPL /= (Transaction_DataGridView.Rows.Count);
            AveragePL_Textbox.Text = totalPL.ToString();
        }

        private void pending_Radiobutton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTransactionView();
            UpdateTransactionLegView();
        }
    }
}
