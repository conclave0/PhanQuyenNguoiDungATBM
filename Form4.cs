using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace ATBMN28_Login
{
    public partial class Form4 : Form
    {
        OracleConnection _connection = null;
        String _connectionString = "";
        string username, password;
        public Form4(string Username, string Password)
        {
            InitializeComponent();
            _connectionString = "DATA SOURCE=JSTComDevice:1521/ORCLPDB;USER ID=" + Username + "; Password =" + Password;
            _connection = new OracleConnection(_connectionString);
            username = Username;
            password = Password;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _connection.Open();
            try
            {
                string cmstring = "select * from ATBMN28.monhoc_mo where monhoc_mo.nam='" + textBox1.Text + "' and monhoc_mo.hocky='" + textBox2.Text + "'";
                OracleCommand cm = new OracleCommand(cmstring, _connection);
                OracleDataReader reader;
                reader = cm.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                dataGridView1.DataSource = table;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _connection.Close();

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label3.Text = username;
        }
    }
}
