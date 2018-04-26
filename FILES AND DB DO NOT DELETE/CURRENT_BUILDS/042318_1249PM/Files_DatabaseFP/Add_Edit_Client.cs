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
    public partial class Add_Edit_Client : Form
    {
        public SqlConnection sqlDBConnection;

        public Add_Edit_Client()
        {
            InitializeComponent();
        }
    }
}
