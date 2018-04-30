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
        public List<int> clientNumList = new List<int>(); // instances of objects accessiable through program
        public List<int> transactionIDList = new List<int>();

        public Main_Form()
        {
            InitializeComponent();
        }

        private void Main_form_Load(object sender, EventArgs e) // loads main page
        {
            try // tries to open connection to database
            {
                sqlConnection1.Open();
            }

            catch (Exception ex) // throws exception if can not connect
            {
                MessageBox.Show(ex.Message);
            }

            End_Date.Value = DateTime.Now; // gets the the value of the date and time 

            if (open_Radiobutton.Checked == true) // if open the fields are editable 
            {
                Start_Date.Enabled = false;
                End_Date.Enabled = false;
                Averages_Panel.Visible = false;
            }
            else if (closed_Radiobutton.Checked == true) // if close the fileds are closed and not editable
            {
                Start_Date.Enabled = true;
                End_Date.Enabled = true;
                CalculateAverages();
                Averages_Panel.Visible = true;
                AveragePL_Textbox.Text = totalPL.ToString(); // the average text box is populated with totalPL
            }

            SqlCommand cmdGetUsers = sqlConnection1.CreateCommand(); // a SQL command called cmdGetUsers is stored 
            cmdGetUsers.CommandText = "SELECT fname, lname, client_no FROM CLIENT"; // gets information from database
            SqlDataReader reader = cmdGetUsers.ExecuteReader(); // a reader to read the info from the database

            while (reader.Read()) // reads the reader until EOF is hit
            {
                comboBox2.Items.Add(reader[0].ToString() + " " + reader[1].ToString()); // adds fname and lname to User
                clientNumList.Add(Convert.ToInt32(reader[2])); // gets the strings, converts to a 32 bit signed int and adds to client num list
            }
            reader.Close(); // closes the reader 
            comboBox2.Text = comboBox2.Items[0].ToString(); // text in User is assigned to the first fname in User

            clientnum = clientNumList[comboBox2.SelectedIndex]; // clientnum is assigned to selected item in User

            transnum = Convert.ToInt32(Transaction_DataGridView.CurrentRow.Cells[0].Value); // transnum is assigned to a converted 32 bit int from the fname

            UpdateTechniqueSymbol(); // updates the views for the user to see information
            UpdateTransactionView();
            UpdateTransactionLegView();
        }

        private void UpdateTransactionView() // updates transaction view 
        {
            SqlCommand cmdGetTransactions = sqlConnection1.CreateCommand(); // creates a SQL command called cmdget transaction
            cmdGetTransactions.CommandText = "SELECT * FROM TRANSACTION_RECORD WHERE Client_no = @Client_no"; // selects * SQL command is created
            cmdGetTransactions.Parameters.AddWithValue("@Client_no", clientnum); // adds only value to clientnum

            if (open_Radiobutton.Checked == true) // if open adds below statement to the cmdGetTransaction
                cmdGetTransactions.CommandText += " AND open_Date IS NOT NULL AND close_Date IS NULL";

            else if (closed_Radiobutton.Checked == true) // if closed adds below statements to the cmdGetTransaction
            {
                cmdGetTransactions.CommandText += " AND close_Date BETWEEN @startDate AND @endDate";
                cmdGetTransactions.Parameters.AddWithValue("@startDate", Start_Date.Value.ToString("yyyy-MM-dd"));
                cmdGetTransactions.Parameters.AddWithValue("@endDate", End_Date.Value.ToString("yyyy-MM-dd"));
            }

            else if (pending_Radiobutton.Checked == true) // if pending adds below statement to the cmdGetTransaction
                cmdGetTransactions.CommandText += " AND open_Date IS NULL";

            if (Technique_Combobox.Text != "-- All Techniques --") // if the box does not have -- All Techniques -- the below statements are added
            {
                cmdGetTransactions.CommandText += " AND technique = @technique";
                cmdGetTransactions.Parameters.AddWithValue("@technique", Technique_Combobox.Text);
            }

            if (Symbol_Combobox.Text != "-- All Symbols --") // if the box does not have -- All Symbols -- the below statements are added
            {
                cmdGetTransactions.CommandText += " AND Symbol = @symbol";
                cmdGetTransactions.Parameters.AddWithValue("@symbol", Symbol_Combobox.Text);
            }

            SqlDataReader reader4 = cmdGetTransactions.ExecuteReader(); // a new reader reads the and execute the cmdGetTransaction

            DataTable tmpTable = new DataTable(); // a new instance of the database is created
            tmpTable.Load(reader4); // the new table is populated with the reader from reader4

            Transaction_DataGridView.DataSource = tmpTable; // the data view is given the values of tmptable 
            reader4.Close(); // the reader closes

            //SqlDataReader reader5 = cmdGetTransactions.ExecuteReader();

            //transactionIDList.Clear();

            //while (reader5.Read())
            //    transactionIDList.Add(Convert.ToInt32(reader5[0]));

            //reader5.Close();

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

        private void UpdateTransactionLegView() // updates transactionLegView
        {
            if (Transaction_DataGridView.Rows.Count == 0) // if the row count is 0 the view is set to null
                TransactionLeg_DataGridView.DataSource = null;
            else 
            {
                SqlCommand cmdGetLegs = sqlConnection1.CreateCommand(); // a SQL command is created and the below commands are added
                cmdGetLegs.CommandText = "SELECT * FROM TRANSACTION_LEG WHERE Trans_no = @Trans_no "; 
                cmdGetLegs.Parameters.AddWithValue("@Trans_no", Convert.ToInt32(Transaction_DataGridView.CurrentRow.Cells[0].Value));

                SqlDataReader reader6 = cmdGetLegs.ExecuteReader(); // the reader executes and reads the cmdGetLegs command

                DataTable tmpTable = new DataTable(); // a new instance of the object datatable is created
                tmpTable.Load(reader6); // the information is loaded into the tmptable 

                TransactionLeg_DataGridView.DataSource = tmpTable; // the view is updated to the tmptable
                reader6.Close(); // the reader closes

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

        private void UpdateTechniqueSymbol() // updates the TechniqueSymbol
        {
            SqlCommand cmdGetTechniques = sqlConnection1.CreateCommand(); // a SQL command is created with the below statements
            cmdGetTechniques.CommandText = "SELECT Acronym FROM TECHNIQUE WHERE client_no = @client_no";
            cmdGetTechniques.Parameters.AddWithValue("@client_no", clientNumList[comboBox2.SelectedIndex]);

            SqlDataReader reader2 = cmdGetTechniques.ExecuteReader(); // a reader is created and reads the exucuted cmdGetTechniques SQL Command
            Technique_Combobox.Items.Clear(); // clears the items in Techique box
            Symbol_Combobox.Items.Clear(); // clears the items in Symbol box

            while (reader2.Read()) // while reader has not hit the EOF
                Technique_Combobox.Items.Add(reader2[0].ToString()); // reader2 adds its items to Techique box

            reader2.Close(); // reader2 cloeses

            if (Technique_Combobox.Items.Count == 0) // if the item count is 0 the box is given the -- no symbols-- and is not editable
            {
                Technique_Combobox.Items.Insert(0, "-- No Symbols --");
                Technique_Combobox.Text = Technique_Combobox.Items[0].ToString();
                Technique_Combobox.Enabled = false;
            }
            else if (Technique_Combobox.Items.Count == 1) // the box is made editable
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

            SqlCommand cmdGetSymbols = sqlConnection1.CreateCommand(); // a new SQL command is created and the below command is added
            cmdGetSymbols.CommandText = "SELECT DISTINCT Symbol FROM TRANSACTION_RECORD WHERE client_no = @client_no";
            cmdGetSymbols.Parameters.AddWithValue("@client_no", clientNumList[comboBox2.SelectedIndex]);
            SqlDataReader reader3 = cmdGetSymbols.ExecuteReader(); // the reader is created and the cmdGetSymbol command is exeucted

            while (reader3.Read()) // while the the EOF is not present
                Symbol_Combobox.Items.Add(reader3[0].ToString()); // the items from reader3 is added to symbol box

            reader3.Close(); //reader3 closes

            if (Symbol_Combobox.Items.Count == 0) // if no items are in the box then -- No Symbols -- is added and made uneditable
            {
                Symbol_Combobox.Items.Insert(0, "-- No Symbols --");
                Symbol_Combobox.Text = Symbol_Combobox.Items[0].ToString();
                Symbol_Combobox.Enabled = false;
            }
            else if (Symbol_Combobox.Items.Count == 1) // the box is made editable and first item is put in the text box
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

        private void Manage_Tech_Click(object sender, EventArgs e) // manage tech click button class
        {
            Manage_Technique frm = new Manage_Technique(); // a new instance of the object managetechnique is created
            frm.sqlDBConnection = sqlConnection1; // a SQL connection is created
            frm.User_TextBox.Text = comboBox2.Text; // values are assigned 
            frm.Manage_clientnum = clientnum;
            frm.ShowDialog(); // dialogbox is shown 
            UpdateTechniqueSymbol(); // update function is called
        }

        private void Remove_Tran_Click(object sender, EventArgs e) // remove trans button class
        {
            var result = MessageBox.Show("Are you sure you want to remove this transaction?", "Confirm transaction removal", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            { // if yes a command is created and executed to delete transaction Leg and record and updated
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

        private void Add_Leg_Click(object sender, EventArgs e) // add leg button class
        {
            Add_Leg frm = new Add_Leg();
            frm.sqlDBConnection = sqlConnection1;
            frm.transnum = transnum;
            frm.legnum = (TransactionLeg_DataGridView.RowCount) + 1;
            //frm.currentPosSize = Convert.ToInt32(TransactionLeg_DataGridView.Rows[legnum - 2].Cells[5].Value);
            frm.ShowDialog();
            UpdateTransactionLegView();
        }

        private void Update_Leg_Click(object sender, EventArgs e) // update leg button class
        {
            Add_Leg frm = new Add_Leg();
            frm.sqlDBConnection = sqlConnection1;
            frm.transnum = transnum;
            frm.legnum = legnum;
            frm.currentInstType = TransactionLeg_DataGridView.Rows[legnum - 1].Cells[2].Value.ToString();
            frm.currentOrderType = TransactionLeg_DataGridView.Rows[legnum - 1].Cells[3].Value.ToString();
            frm.currentQty = Convert.ToInt32(TransactionLeg_DataGridView.Rows[legnum - 1].Cells[4].Value);
            frm.currentPosSize = Convert.ToInt32(TransactionLeg_DataGridView.Rows[legnum - 1].Cells[5].Value);
            frm.currentPrice = Convert.ToDecimal(TransactionLeg_DataGridView.Rows[legnum - 1].Cells[6].Value);
            frm.currentStop = Convert.ToDecimal(TransactionLeg_DataGridView.Rows[legnum - 1].Cells[7].Value);
            frm.currentEntryDate = TransactionLeg_DataGridView.Rows[legnum - 1].Cells[8].Value.ToString();
            frm.currentFilledyDate = TransactionLeg_DataGridView.Rows[legnum - 1].Cells[9].Value.ToString();
            frm.currentFees = Convert.ToDecimal(TransactionLeg_DataGridView.Rows[legnum - 1].Cells[10].Value);
            frm.currentTransAmt = Convert.ToDecimal(TransactionLeg_DataGridView.Rows[legnum - 1].Cells[11].Value);
            frm.currentExpInfo = TransactionLeg_DataGridView.Rows[legnum - 1].Cells[12].Value.ToString();
            frm.currentStrikeInfo = TransactionLeg_DataGridView.Rows[legnum - 1].Cells[13].Value.ToString();
            frm.Show();

            UpdateTransactionLegView();
        }

        private void Remove_Leg_Click(object sender, EventArgs e) // remove leg button class
        {
            var result = MessageBox.Show("Are you sure you want to remove this leg?", "Confirm leg removal", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if(result == DialogResult.Yes) // asks to remove leg
            {
                SqlCommand cmdDeleteleg = sqlConnection1.CreateCommand(); // creates a connection with the below statements
                cmdDeleteleg.CommandText = "DELETE FROM TRANSACTION_LEG WHERE Trans_no = @Trans_no AND Leg_No = @Leg_No";
                cmdDeleteleg.Parameters.AddWithValue("@Trans_no", transnum);
                cmdDeleteleg.Parameters.AddWithValue("@Leg_no", legnum);
                cmdDeleteleg.ExecuteNonQuery();
                MessageBox.Show("Leg has been removed from database", "Leg removed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            UpdateTransactionLegView();
        }

        private void Update_Tran_Click(object sender, EventArgs e) //  update tran button class
        {
            Edit_Transaction form = new Edit_Transaction();
            form.ShowDialog();
            UpdateTransactionView();
            UpdateTransactionLegView();
        }

        private void Add_Tran_Click(object sender, EventArgs e) // add tran button class
        {
            Add_Transaction frm = new Add_Transaction();
            frm.sqlDBConnection = sqlConnection1;
            frm.clientnum = clientnum;
            frm.ShowDialog();
            UpdateTransactionView();
            UpdateTransactionLegView();
        }

        private void Reset_Filter_Click(object sender, EventArgs e) // reset filter button class
        {
            open_Radiobutton.Checked = true;
            End_Date.Value = DateTime.Now;
            Start_Date.Value = DateTime.Now.AddMonths(-1);
            Technique_Combobox.Text = "-- All Techniques --";
            Symbol_Combobox.Text = "-- All Symbols --";
            UpdateTransactionView();
        }

        private void Symbol_Combobox_SelectedIndexChanged(object sender, EventArgs e) // updates or calculates 
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
            transnum = Convert.ToInt32(Transaction_DataGridView.CurrentRow.Cells[0].Value); //Convert.ToInt32(Transaction_DataGridView.Rows[e.RowIndex].Cells[0].Value);
            UpdateTransactionLegView();
        }

        private void Technique_Combobox_SelectedIndexChanged(object sender, EventArgs e) 
        {
            UpdateTransactionView();
            CalculateAverages();
        }

        private void open_Radiobutton_CheckedChanged(object sender, EventArgs e) // open radio button class
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

        private void closed_Radiobutton_CheckedChanged(object sender, EventArgs e) // closed radio button class
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

        private void ManageUsers_Click(object sender, EventArgs e) // manage user button class
        {
            Add_Edit_Client frm = new Add_Edit_Client();
            frm.sqlDBConnection = sqlConnection1;
            frm.ShowDialog();
            UpdateTechniqueSymbol();
        }

        private void CalculateAverages() // calculates the average class
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

        private void pending_Radiobutton_CheckedChanged(object sender, EventArgs e) // pending radio button class 
        {
            UpdateTransactionView();
            UpdateTransactionLegView();
        }
    }
}