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
    public partial class Add_Leg : Form
    {
        public SqlConnection sqlDBConnection;
        public int transnum, legnum, currentPosSize, newPosSize, currentQty;
        public decimal transAmt, currentPrice, currentStop, currentFees, currentTransAmt;
        public int currentEntryAmt, currentExitAmt;

        private void Add_Leg_Load(object sender, EventArgs e) // loads page
        {

        }

        public string currentOpenDate, currentInstType, currentOrderType, currentEntryDate, currentFilledyDate, currentExpInfo, currentStrikeInfo;

        public Add_Leg() 
        {
            InitializeComponent();
        }

        private void cmbOrderType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((txtQty.Text != "") && (txtPrice.Text != ""))
            {
                if (cmbInstType.Text == "O")
                {
                    txtTransAmt.Text = (Convert.ToDecimal(txtQty.Text) * 100 * Convert.ToDecimal(txtPrice.Text)).ToString();
                }
                else
                {
                    txtTransAmt.Text = (Convert.ToDecimal(txtQty.Text) * Convert.ToDecimal(txtPrice.Text)).ToString();
                }
            }
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if ((cmbOrderType.Text != "") && (txtPrice.Text != ""))
            {
                if (cmbInstType.Text == "O")           //(cmbOrderType.Text == "BTO" || cmbOrderType.Text == "BTC")
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
                if (cmbInstType.Text == "O")
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

        private void AddLeg_Add_Leg_Click(object sender, EventArgs e)
        {

            // managetechnique add click
            // add techniques
            if (cmbInstType.Text != "" && cmbOrderType.Text != "" && txtQty.Text != "" && txtPrice.Text != "" && txtFees.Text != "" && dateEntryDate.Text != "")
            {
                SqlCommand cmdAddleg = sqlDBConnection.CreateCommand();
                cmdAddleg.CommandText = "INSERT INTO TRANSACTION_LEG VALUES (@trans_no,@leg_no,@Inst_type,@Order_type,@Qty,@Pos_size,@Share_price,@Stop_loss,@Entry_date,@Fill_date,@Fees,@Trans_amt,@Exp_info,@Strike_info)";
                cmdAddleg.Parameters.AddWithValue("@Trans_no", transnum);
                cmdAddleg.Parameters.AddWithValue("@Leg_no", legnum);
                cmdAddleg.Parameters.AddWithValue("@Inst_type", cmbInstType.Text);
                cmdAddleg.Parameters.AddWithValue("@Order_type", cmbOrderType.Text);
                cmdAddleg.Parameters.AddWithValue("@Qty", Convert.ToInt32(txtQty.Text));
                if (cmbOrderType.Text == "BTO" || cmbOrderType.Text == "BTC")
                {
                    newPosSize = currentPosSize + Convert.ToInt32(txtQty.Text);
                }
                else
                {
                    newPosSize = currentPosSize - Convert.ToInt32(txtQty.Text);
                }
                cmdAddleg.Parameters.AddWithValue("@Pos_size", newPosSize);
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
                if (chkFilled.Checked == true)
                {
                    cmdAddleg.Parameters.AddWithValue("@Fill_date", Convert.ToDateTime(dateFilledDate.Text));
                    // Update the transaction with data
                    updateTransaction();
                }
                else
                {
                    cmdAddleg.Parameters.AddWithValue("@Fill_date", DBNull.Value);
                }
                cmdAddleg.Parameters.AddWithValue("@Fees", Convert.ToDecimal(txtFees.Text));
                cmdAddleg.Parameters.AddWithValue("@Trans_amt", Convert.ToDecimal(txtTransAmt.Text));
                cmdAddleg.Parameters.AddWithValue("@Exp_info", txtExpireInfo.Text);
                cmdAddleg.Parameters.AddWithValue("@Strike_info", txtStrikeInfo.Text);
                cmdAddleg.ExecuteNonQuery();

                MessageBox.Show("Leg has been added to database", "Leg Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.Close();
            }
        }

        private void updateTransaction()
        {

            // updates transaction with values from the leg
            SqlCommand cmdUpdateTrans = sqlDBConnection.CreateCommand();
            cmdUpdateTrans.CommandText = "UPDATE TRANSACTION_RECORD SET (@Open_date,@Close_date,@Fees,@Entry_amount,@Exit_amount)";

            if (currentOpenDate == "")
            {
                cmdUpdateTrans.Parameters.AddWithValue("@Open_date", Convert.ToDateTime(dateFilledDate.Text));
            }
            else
            {
                cmdUpdateTrans.Parameters.AddWithValue("@Open_date", Convert.ToDateTime(currentOpenDate));
            }
            if (newPosSize == 0 && dateFilledDate.Text != "")
            {
                cmdUpdateTrans.Parameters.AddWithValue("@Close_date", Convert.ToDateTime(dateFilledDate.Text));
            }
            else
            {
                cmdUpdateTrans.Parameters.AddWithValue("@Open_date", DBNull.Value);
            }
            cmdUpdateTrans.Parameters.AddWithValue("@Fees", currentFees + Convert.ToInt32(txtFees.Text));
            if (cmbOrderType.Text == "BTO" || cmbOrderType.Text == "BTC")
            {
                cmdUpdateTrans.Parameters.AddWithValue("@Entry_amount", currentEntryAmt + transAmt);
                cmdUpdateTrans.Parameters.AddWithValue("@Exit_amount", currentExitAmt);
            }
            else
            {
                cmdUpdateTrans.Parameters.AddWithValue("@Entry_amount", currentEntryAmt);
                cmdUpdateTrans.Parameters.AddWithValue("@Exit_amount", currentExitAmt + transAmt);
            }

            cmdUpdateTrans.ExecuteNonQuery();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
