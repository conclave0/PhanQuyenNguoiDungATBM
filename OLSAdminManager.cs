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
    public partial class OLSAdminManager : Form
    {
        ConnectDB dbs;
        string username, password;
        public OLSAdminManager(string US, string PW)
        {
            InitializeComponent();
            dbs = new ConnectDB(US, PW);
            Level_Cbb.Items.Insert(0, "BT:TT:CB");
            Level_Cbb.Items.Insert(1, "QT:TT:CB");
            Level_Cbb.Items.Insert(2, "BT:BM:CB");
            Level_Cbb.Items.Insert(3, "QT:BM:CB");
            Level_Cbb.Items.Insert(4, "BT:K:CB");
            Level_Cbb.Items.Insert(5, "QT:K:CB");
            Level_Cbb.Items.Insert(6, "BT:TT:GV");
            Level_Cbb.Items.Insert(7, "QT:TT:GV");
            Level_Cbb.Items.Insert(8, "BT:BM:GV");
            Level_Cbb.Items.Insert(9, "QT:BM:GV");
            Level_Cbb.Items.Insert(10, "BT:K:GV");
            Level_Cbb.Items.Insert(11, "QT:K:GV");
            Level_Cbb.Items.Insert(12, "BT:TT:SV");
            Level_Cbb.Items.Insert(13, "QT:TT:SV");
            Level_Cbb.Items.Insert(14, "BT:BM:SV");
            Level_Cbb.Items.Insert(15, "QT:BM:SV");
            Level_Cbb.Items.Insert(16, "BT:K:SV");
            Level_Cbb.Items.Insert(17, "QT:K:SV");
            Level_Cbb.SelectedIndex = 0;
            username = US;
            password = PW;
        }

        private void OLSAdminManager_Load(object sender, EventArgs e)
        {
            DataTable dt = dbs.viewThongBao();
            dataGridView1.DataSource = dt;
            ID_Cbb.ValueMember = "ID";
            ID_Cbb.DisplayMember = "ID";
            ID_Cbb.DataSource = dt;
            //ID_Cbb.SelectedIndex = 0;
            label2.Text = username;
        }

        private void Execute_Btn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(ID_Cbb.SelectedValue.ToString().Trim());
            string policy = Level_Cbb.SelectedItem.ToString().Trim();
            bool status = dbs.executeStoreSetThongBaoPolicy(id, policy);
            if (status)
            {
                MessageBox.Show("Changed Successfuly!");
            }
            DataTable dt = dbs.viewThongBao();
            dataGridView1.DataSource = dt;
            ID_Cbb.ValueMember = "ID";
            ID_Cbb.DisplayMember = "ID";
            ID_Cbb.DataSource = dt;
            ID_Cbb.SelectedIndex = 0;
        }
    }
}
