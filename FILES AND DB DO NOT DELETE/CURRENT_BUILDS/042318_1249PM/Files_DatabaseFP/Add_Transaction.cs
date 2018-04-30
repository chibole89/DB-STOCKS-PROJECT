using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Files_DatabaseFP
{
    public partial class Add_Transaction : Form
    {
        public SqlConnection sqlDBConnection;
        public int clientnum, newTransNum;
        public decimal transAmt;

        public Add_Transaction()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmdGetTechniques = sqlDBConnection.CreateCommand(); // creates a SQL command  with the below statements
            cmdGetTechniques.CommandText = "SELECT Acronym FROM TECHNIQUE WHERE (client_no = " + clientnum + ")";
            SqlDataReader reader = cmdGetTechniques.ExecuteReader();

            while (reader.Read()) // adds items while reader is not EOF
            {
                cmbTechnique.Items.Add(reader[0].ToString());
            }
            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e) //button closes
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e) // button creates new instance from object and show dialog
        {
            Add_Leg frm = new Add_Leg();
            frm.Show();
        }

        private void btnAccept_Click(object sender, EventArgs e) // accept button class
        {
            if (txtSymbol.Text != "" && cmbTechnique.Text != "" && cmbInstType.Text != "" && cmbOrderType.Text != "" && txtQty.Text != "" && txtPrice.Text != "" && txtFees.Text != "")
            {
                SqlCommand cmdAddTrans = sqlDBConnection.CreateCommand();
                cmdAddTrans.CommandText = "INSERT INTO TRANSACTION_RECORD VALUES (@Client_no, @Symbol,@Open_date,@Close_date,@Technique,@Entry_Amount,@Risk,@Exit_Amount,@Fees,@P_L,@Return_Rate,@Days_in_trade,@Annualized_rate,@Paper_trade)";
                cmdAddTrans.Parameters.AddWithValue("@Client_no", clientnum);
                cmdAddTrans.Parameters.AddWithValue("@Symbol", txtSymbol.Text);
                cmdAddTrans.Parameters.AddWithValue("@Open_date", DBNull.Value);
                cmdAddTrans.Parameters.AddWithValue("@Close_date", DBNull.Value);
                cmdAddTrans.Parameters.AddWithValue("@Technique", cmbTechnique.Text);
                cmdAddTrans.Parameters.AddWithValue("@Entry_Amount", DBNull.Value);
                if (txtRisk.Text == "")
                {
                    cmdAddTrans.Parameters.AddWithValue("@Risk", DBNull.Value);
                }
                else
                {
                    cmdAddTrans.Parameters.AddWithValue("@Risk", Convert.ToDecimal(txtRisk.Text));
                }
                cmdAddTrans.Parameters.AddWithValue("@Exit_Amount", DBNull.Value);
                cmdAddTrans.Parameters.AddWithValue("@Fees", DBNull.Value);
                cmdAddTrans.Parameters.AddWithValue("@P_L", DBNull.Value);
                cmdAddTrans.Parameters.AddWithValue("@Return_rate", DBNull.Value);
                cmdAddTrans.Parameters.AddWithValue("@Days_in_trade", DBNull.Value);
                cmdAddTrans.Parameters.AddWithValue("@Annualized_rate", DBNull.Value);
                cmdAddTrans.Parameters.AddWithValue("@Paper_trade", chkPaper.Checked);
                cmdAddTrans.ExecuteNonQuery();

                SqlCommand cmdGetNewTransNo = sqlDBConnection.CreateCommand();

                cmdGetNewTransNo.CommandText = "SELECT MAX(Trans_no) FROM TRANSACTION_RECORD";
                newTransNum = Convert.ToInt32(cmdGetNewTransNo.ExecuteScalar());

                SqlCommand cmdAddleg = sqlDBConnection.CreateCommand();
                cmdAddleg.CommandText = "INSERT INTO TRANSACTION_LEG VALUES (@trans_no,@leg_no,@Inst_type,@Order_type,@Qty,@Pos_size,@Share_price,@Stop_loss,@Entry_date,@Fill_date,@Fees,@Trans_amt,@Exp_info,@Strike_info)";
                cmdAddleg.Parameters.AddWithValue("@Trans_no", newTransNum);
                cmdAddleg.Parameters.AddWithValue("@Leg_no", 1);
                cmdAddleg.Parameters.AddWithValue("@Inst_type", cmbInstType.Text);
                cmdAddleg.Parameters.AddWithValue("@Order_type", cmbOrderType.Text);
                cmdAddleg.Parameters.AddWithValue("@Qty", Convert.ToInt32(txtQty.Text));
                if (cmbOrderType.Text == "BTO" || cmbOrderType.Text == "BTC")
                {
                    cmdAddleg.Parameters.AddWithValue("@Pos_size", Convert.ToInt32(txtQty.Text));
                }
                else
                {
                    cmdAddleg.Parameters.AddWithValue("@Pos_size", Convert.ToInt32(txtQty.Text) * -1);
                }
                cmdAddleg.Parameters.AddWithValue("@Share_price", Convert.ToDecimal(txtPrice.Text));

                if (txtStopLoss.Text == "")
                {
                    cmdAddleg.Parameters.AddWithValue("@Stop_loss", DBNull.Value);
                }
                else
                {
                    cmdAddleg.Parameters.AddWithValue("@Stop_loss", Convert.ToDecimal(txtStopLoss.Text));
                }

                cmdAddleg.Parameters.AddWithValue("@Entry_date", Convert.ToDateTime(dateEntryDate.Text));
                cmdAddleg.Parameters.AddWithValue("@Fill_date", DBNull.Value);
                cmdAddleg.Parameters.AddWithValue("@Fees", Convert.ToDecimal(txtFees.Text));
                cmdAddleg.Parameters.AddWithValue("@Trans_amt", Convert.ToDecimal(txtTransAmt.Text));
                cmdAddleg.Parameters.AddWithValue("@Exp_info", txtExpireInfo.Text);
                cmdAddleg.Parameters.AddWithValue("@Strike_info", txtStrikeInfo.Text);
                cmdAddleg.ExecuteNonQuery();
                MessageBox.Show("Transaction has been added to database", "Transaction Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            this.Close();
        }

        private void cmbOrderType_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if ((txtQty.Text != "") && (txtPrice.Text != ""))
            {
                if (cmbOrderType.Text == "BTO" || cmbOrderType.Text == "BTC")
                {
                    transAmt = (Convert.ToDecimal(txtQty.Text) * Convert.ToDecimal(txtPrice.Text));
                    txtTransAmt.Text = (100 * transAmt).ToString();
                }
                else
                {
                    txtTransAmt.Text = (Convert.ToInt32(txtQty.Text) * Convert.ToInt32(txtPrice.Text)).ToString();
                }
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if ((txtPrice.Text != "") && (cmbOrderType.Text != ""))
            {
                if (cmbOrderType.Text == "BTO" || cmbOrderType.Text == "BTC")
                {
                    transAmt = (Convert.ToDecimal(txtQty.Text) * Convert.ToDecimal(txtPrice.Text));
                    txtTransAmt.Text = (100 * transAmt).ToString();
                }
                else
                {
                    txtTransAmt.Text = (Convert.ToInt32(txtQty.Text) * Convert.ToInt32(txtPrice.Text)).ToString();
                }
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if ((txtQty.Text != "") && (cmbOrderType.Text != ""))
            {
                if (cmbOrderType.Text == "BTO" || cmbOrderType.Text == "BTC")
                {
                    transAmt = (Convert.ToDecimal(txtQty.Text) * Convert.ToDecimal(txtPrice.Text));
                    txtTransAmt.Text = (100 * transAmt).ToString();
                }
                else
                {
                    txtTransAmt.Text = (Convert.ToInt32(txtQty) * Convert.ToInt32(txtPrice.Text)).ToString();
                }
            }
        }
    }
}
