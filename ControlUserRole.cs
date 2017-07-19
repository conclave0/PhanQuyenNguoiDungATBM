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
    public partial class ControlUserRole : Form
    {

        ConnectDB dbs;
        public ControlUserRole(string username, string password)
        {
            InitializeComponent();
            Syntax_Cbb.Items.Add("GRANT");
            Syntax_Cbb.Items.Add("REVOKE");
            dbs = new ConnectDB(username, password);
            Syntax_Cbb.SelectedIndex = 0;

        }

        private void ControlUserRole_Load(object sender, EventArgs e)
        {
            DataTable dt = dbs.viewAllUserRole();
            dataGridView1.DataSource = dt;
            DataTable role = dbs.viewAllRole();
            Role_Cbb.ValueMember = "GRANTED_ROLE";
            Role_Cbb.DisplayMember = "GRANTED_ROLE";
            Role_Cbb.DataSource = role;
            DataTable user = dbs.viewAllUser();
            User_Cbb.ValueMember = "USERNAME";
            User_Cbb.DisplayMember = "USERNAME";
            User_Cbb.DataSource = user;
        }

        private void Execute_Btn_Click(object sender, EventArgs e)
        {
            string cmd;
            string syntax = Syntax_Cbb.SelectedItem.ToString().Trim();
            string user = User_Cbb.Text.ToString().Trim();
            string role = Role_Cbb.SelectedValue.ToString().Trim();
            int temp;
            bool isNumeric = int.TryParse(user, out temp);
            if (syntax.Equals("GRANT"))
            {
                    if (isNumeric)
                    {
                        cmd = syntax + " " + role +  " to \"" + user + "\"";
                    }
                    else
                    {
                        cmd = syntax + " " + role + " to " + user + " ";
                    }
            }
            else
            {
                if (isNumeric)
                {
                    cmd = syntax + " " + role + " from \"" + user + "\"";
                }
                else
                {
                    cmd = syntax + " " + role + " from " + user + " ";
                }
            }
            try
            {
                dbs.executeGrantRevokePrivilege(cmd);
                MessageBox.Show("Successful!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataTable dt = dbs.viewAllUserRole();
            dataGridView1.DataSource = dt;

        }
    }
}
