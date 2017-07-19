using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATBMN28_Login
{
    public partial class AuditViewer : Form
    {
        ConnectDB dbs;
        string username, password;
        public AuditViewer(string Username, string Password)
        {
            InitializeComponent();
            username = Username;
            password = Password;
            dbs = new ConnectDB(username, password);
            
        }


        private void LuongDGV_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void AuditViewer_Load(object sender, EventArgs e)
        {
            label1.Text = username;
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            dt1 = dbs.auditThongBao();
            dt2 = dbs.auditLuong();
            ThongBaoDGV.DataSource = dt1;
            LuongDGV.DataSource = dt2;
        }
    }
}
