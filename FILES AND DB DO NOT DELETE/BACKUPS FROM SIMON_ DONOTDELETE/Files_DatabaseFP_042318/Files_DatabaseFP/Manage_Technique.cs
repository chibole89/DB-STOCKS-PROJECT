using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Files_DatabaseFP
{
    public partial class Manage_Technique : Form
    {
        public SqlConnection sqlDBConnection;
        public int Manage_clientnum;
        public List<string> techniqueNameList = new List<string>();

        public Manage_Technique()
        {
            InitializeComponent();
        }

        private void Manage_Technique_Load(object sender, EventArgs e)
        {
            Acronym_ComboBox.Items.Clear();
            techniqueNameList.Clear();

            SqlCommand cmdUpdateTechniqueAcronym = sqlDBConnection.CreateCommand();
            cmdUpdateTechniqueAcronym.CommandText = "SELECT Acronym, Name FROM TECHNIQUE WHERE client_no = @client_no";
            cmdUpdateTechniqueAcronym.Parameters.AddWithValue("@client_no", Manage_clientnum);
            SqlDataReader reader = cmdUpdateTechniqueAcronym.ExecuteReader();

            while (reader.Read())
            {
                Acronym_ComboBox.Items.Add(reader[0].ToString());
                techniqueNameList.Add(reader[1].ToString());
            }

            reader.Close();
            Acronym_ComboBox.Text = Acronym_ComboBox.Items[0].ToString();
        }

        private void ManageTechnique_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ManageTechnique_Add_Click(object sender, EventArgs e)
        {
            Add_Technique frm = new Add_Technique();
            frm.sqlDBConnection = this.sqlDBConnection;
            frm.AddTech_client_num = this.Manage_clientnum;
            frm.ShowDialog();
            Manage_Technique_Load(this, null);
            Acronym_ComboBox.Text = Acronym_ComboBox.Items[Acronym_ComboBox.Items.Count - 1].ToString();
        }

        private void ManageTechnique_Edit_Click(object sender, EventArgs e)
        {
            Add_Technique frm = new Add_Technique();
            frm.sqlDBConnection = this.sqlDBConnection;
            var editedIndex = Acronym_ComboBox.SelectedIndex;
            frm.init_acronym = this.Acronym_ComboBox.Text;
            frm.init_name = this.Name_Textbox.Text;
            frm.AddTech_client_num = this.Manage_clientnum;
            frm.Text = "Edit Technique";
            frm.ShowDialog();
            Manage_Technique_Load(this, null);
            Acronym_ComboBox.Text = Acronym_ComboBox.Items[editedIndex].ToString();
        }

        private void ManageTechnique_Remove_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to remove this technique?", "Confirm technique removal", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Yes)
            {
                SqlCommand cmdRemoveTechnique = sqlDBConnection.CreateCommand();
                cmdRemoveTechnique.CommandText = "DELETE FROM TECHNIQUE WHERE Acronym = @acronym AND Name = @name AND client_no = @client_no";
                cmdRemoveTechnique.Parameters.AddWithValue("@acronym", Acronym_ComboBox.Text);
                cmdRemoveTechnique.Parameters.AddWithValue("@name", Name_Textbox.Text);
                cmdRemoveTechnique.Parameters.AddWithValue("@client_no", Manage_clientnum);
                cmdRemoveTechnique.ExecuteNonQuery();
            }
            MessageBox.Show("Technique has been removed from database", "Technique removed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            Manage_Technique_Load(this, null);
            Acronym_ComboBox.Text = Acronym_ComboBox.Items[Acronym_ComboBox.Items.Count - 1].ToString();
        }

        private void Acronym_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Name_Textbox.Text = techniqueNameList[Acronym_ComboBox.SelectedIndex];
        }
    }
}