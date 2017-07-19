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
    public partial class Form1 : Form
    {
        private OracleConnection _connection;
        //OleDbConnection _connection = null;
        String _connectionString = "";
        string USN = null;
        string PW = null;
        ConnectDB dbs;
        public Form1()
        {
            InitializeComponent();
            //_connection = new OleDbConnection(_connectionString);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
                USN = textBox1.Text.ToString().Trim();
                PW = textBox2.Text.ToString().Trim();
            dbs = new ConnectDB(USN, PW);
            if (dbs.GetConnected())
            {
                MessageBox.Show("Đăng nhập thành công!");
                if (dbs.isAdmin(USN))
                {
                    Form form2 = new Form2(USN, PW);
                    form2.Show();
                }
                else
                {
                    if (USN.Equals("ATBMN28OLS"))
                    {

                        Form frm4 = new OLSAdminManager(USN, PW);
                        frm4.Show();
                    }
                    else {
                        Form form3 = new Form3(USN, PW);
                        form3.Show();
                    }
                }

            }
            else {
                USN = null;
                PW = null;
                MessageBox.Show("Đăng nhập thất bại");
            }
            
                //_connectionString = "Provider=MSDAORA;Data Source=JSTComDevice:1521/ORCLPDB;User ID=" + textBox1.Text+";Password="+textBox2.Text;

                // _connection = new OleDbConnection(_connectionString);
                /*if (dbs.GetConnected())
                {
                    
                    Form2 form2 = new Form2(USN, PW);
                    form2.Show();
                    Form3 form3 = new Form3(USN, PW);
                    form3.Show();
                    /*Form frm4 = new OLSAdminManager(USN, PW);
                    frm4.Show();
                }
                else {
                    
                }*/
                
            

        }

  


    }
}
