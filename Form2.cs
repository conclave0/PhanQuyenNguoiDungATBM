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
    public partial class Form2 : Form
    {
        //OleDbConnection _connection = null;
        OracleConnection _connection = null;
        String _connectionString = "";
        ConnectDB dbs;
        string US;
        string PW;
        public Form2(string Username,string Password)
        {
            InitializeComponent();
            this.US = Username;
            this.PW = Password;
            //_connectionString = "Provider=MSDAORA;Data Source=localhost/orcl;User ID=" + Username + ";Password=" + Password;
            _connectionString = "DATA SOURCE=JSTComDevice:1521/ORCLPDB;USER ID=" + US + "; Password =" + PW;

            //_connection = new OleDbConnection(_connectionString);
            _connection = new OracleConnection(_connectionString);
            dbs = new ConnectDB(US,PW);
            comboBox1.SelectedIndex = 0;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //user role table views   
            
            string cmstring="";
            if (comboBox1.SelectedIndex == 0)
                cmstring = "select * from all_users";
            if (comboBox1.SelectedIndex == 1)
                cmstring = "SELECT * FROM DBA_ROLES";
            if (comboBox1.SelectedIndex == 2)
                cmstring = "SELECT * FROM all_tables";
            if (comboBox1.SelectedIndex == 3)
                cmstring = "select view_name from all_views";
            _connection.Open();
            OracleCommand cm = new OracleCommand(cmstring, _connection);
            OracleDataReader reader;
            reader= cm.ExecuteReader();
            DataTable table =new DataTable();
            table.Load(reader);
            dataGridView1.DataSource=table;
            _connection.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //user role table views   
            _connection.Open();
            try
            {
                string cmstring = "";
                if (comboBox1.SelectedIndex == 0)
                    cmstring = "CREATE USER " + textBox1.Text + " IDENTIFIED BY " + textBox2.Text;
                if (comboBox1.SelectedIndex == 1)
                    cmstring = "create role " + textBox1.Text;
                if (comboBox1.SelectedIndex == 2)
                    cmstring = "create table " + textBox1.Text;
                if (comboBox1.SelectedIndex == 3)
                    cmstring = "create view " + textBox1.Text;

                //OleDbCommand cm = new OleDbCommand(cmstring, _connection);
                OracleCommand cm = new OracleCommand(cmstring, _connection);
                cm.ExecuteNonQuery();
                MessageBox.Show("Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            _connection.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label3.Text = US;
        }

        private void controlUserPrivacyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ControlUserPrivacy(US, PW);
            frm.Show();

        }

        private void viewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ControlUserRole(US, PW);
            frm.Show();
        }

        private void auditViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new AuditViewer(US, PW);
            frm.Show();
        }
    }
}
