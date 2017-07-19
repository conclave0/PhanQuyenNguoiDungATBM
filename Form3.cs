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
    public partial class Form3 : Form
    {
        private string username, password;
        //OleDbConnection _connection = null;
        OracleConnection _connection = null;
        String _connectionString = "";
        public Form3(string Username,string Password)
        {
            InitializeComponent();
            username = Username; password = Password;
            //_connectionString = "Provider=MSDAORA;Data Source=localhost/orcl;User ID=" + Username + ";Password=" + Password;
            // _connection = new OleDbConnection(_connectionString);
            _connectionString = "DATA SOURCE=JSTComDevice:1521/ORCLPDB;USER ID=" + username + "; Password =" + password;
            _connection = new OracleConnection(_connectionString);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _connection.Open();
            try
            {
                string cmstring="select * from ATBMN28.GIAOVIEN where GiaoVien.MaGV='" + textBox1.Text.ToUpper() + "'";
                //OleDbCommand cm = new OleDbCommand(cmstring, _connection);
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

        private void button2_Click(object sender, EventArgs e)
        {
            _connection.Open();
            try
            {
                string cmstring="select MaGV,THOIGIAN,NAM from atbmn28.monhoc_mo where monhoc_mo.MaGV='" + textBox1.Text.ToUpper() + "'";
                /*OleDbCommand cm = new OleDbCommand(cmstring, _connection);
                OleDbDataReader reader;*/
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

        private void button3_Click(object sender, EventArgs e)
        {
            _connection.Open();
            try
            {
                string cmstring = "update ATBMN28.GIAOVIEN set " + textBox2.Text + " where GIAOVIEN.MAGV='" + textBox1.Text.ToUpper() + "'";
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

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(username, password);
            form4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            _connection.Open();
            try
            {
                string cmstring = "select MAGV, ATBMN28.decrypt_Luong(LUONG,'" + textBox3.Text + "')from ATBMN28.Luong";
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

        private void button6_Click(object sender, EventArgs e)
        {
            _connection.Open();
            try
            {
                string cmstring = "update ATBMN28.GIAOVIEN set " + textBox2.Text + " where GIAOVIEN.MAGV='" + textBox1.Text.ToUpper() + "'";
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MSSV_TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void XemDiem_Btn_Click(object sender, EventArgs e)
        {
            ConnectDB dbs = new ConnectDB(username, password);
            DataTable dt = dbs.getDiemSV(MSSV_TextBox.Text.Trim());
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewThongBao_Click(object sender, EventArgs e)
        {
            ConnectDB dbs = new ConnectDB(username, password);
            DataTable dt = dbs.viewThongBao();
            dataGridView1.DataSource = dt;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label7.Text = username;
            comboBox1.SelectedIndex = 0;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void ThemThongBao_Click(object sender, EventArgs e)
        {
            ConnectDB dbs = new ConnectDB(username, password);
            dbs.executeStoreAddThongBao(int.Parse(textBox6.Text), textBox7.Text, comboBox1.SelectedItem.ToString().Trim());
            DataTable dt = dbs.viewThongBao();
            dataGridView1.DataSource = dt;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            _connection.Open();
            try
            {
                string cmstring = "update ATBMN28.Luong set Luong= ATBMN28.encrypt_Luong('" + textBox5.Text + "','" + textBox3.Text + "') where MaGv='" +textBox4.Text.ToUpper() +"'";
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

        
    }
}
