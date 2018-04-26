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
    public partial class Add_Technique : Form
    {
        public SqlConnection sqlDBConnection;
        public string init_acronym;
        public string init_name;
        public int AddTech_client_num;

        public Add_Technique()
        {
            InitializeComponent();
        }

        private void Add_Technique_Load(object sender, EventArgs e)
        {
            if (Text == "Edit Technique")
            {
                Acronym_TextBox.Text = init_acronym;
                Name_TextBox.Text = init_name;
            }
        }

        private void ManageTechnique_Add_Click(object sender, EventArgs e)
        {
            if (Text == "Edit Technique")
            {
                SqlCommand cmdEditTechnique = sqlDBConnection.CreateCommand();
                cmdEditTechnique.CommandText = "UPDATE TECHNIQUE SET Acronym = @newacronym, Name = @newname WHERE (Acronym = @oldacronym AND Name = @oldname AND client_no = @client_num)";
                cmdEditTechnique.Parameters.AddWithValue("@newacronym", Acronym_TextBox.Text);
                cmdEditTechnique.Parameters.AddWithValue("@newname", Name_TextBox.Text);
                cmdEditTechnique.Parameters.AddWithValue("@oldacronym", init_acronym);
                cmdEditTechnique.Parameters.AddWithValue("@oldname", init_name);
                cmdEditTechnique.Parameters.AddWithValue("@client_num", AddTech_client_num);
                cmdEditTechnique.ExecuteNonQuery();
                MessageBox.Show("Technique information has been edited", "Technique Edited", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
            else if (Text == "Add Technique")
            {
                SqlCommand cmdEditTechnique = sqlDBConnection.CreateCommand();
                cmdEditTechnique.CommandText = "INSERT INTO TECHNIQUE VALUES (@client_num, @newacronym, @newname)";
                cmdEditTechnique.Parameters.AddWithValue("@newacronym", Acronym_TextBox.Text);
                cmdEditTechnique.Parameters.AddWithValue("@newname", Name_TextBox.Text);
                cmdEditTechnique.Parameters.AddWithValue("@client_num", AddTech_client_num);
                cmdEditTechnique.ExecuteNonQuery();
                MessageBox.Show("Technique has been added to database", "Technique Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.Close();
            }
        }

        private void ManageTechnique_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
