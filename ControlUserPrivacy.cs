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
    public partial class ControlUserPrivacy : Form
    {
        ConnectDB dbs;
        public ControlUserPrivacy(string username, string password)
        {
            InitializeComponent();
            Syntax_Cbb.Items.Add("GRANT");
            Syntax_Cbb.Items.Add("REVOKE");
            Type_Cbb.Items.Add("ALL");
            Type_Cbb.Items.Add("INSERT");
            Type_Cbb.Items.Add("SELECT");
            Type_Cbb.Items.Add("UPDATE");
            Type_Cbb.Items.Add("DELETE");
            Type_Cbb.Items.Add("EXECUTE");
            Syntax_Cbb.SelectedIndex = 0;
            Type_Cbb.SelectedIndex = 0;
            dbs = new ConnectDB(username, password);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ControlUserPrivacy_Load(object sender, EventArgs e)
        {
            DataTable dt = dbs.viewAllUserPrivilege();
            dataGridView1.DataSource = dt;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_MouseClick(object sender, MouseEventArgs e)
        {
            User_Cbb.DataSource = null;
            DataTable dt = dbs.viewAllUser();
            User_Cbb.ValueMember = "USERNAME";
            User_Cbb.DisplayMember = "USERNAME";
            User_Cbb.DataSource = dt;
            User_Cbb.SelectedIndex = 0;
        }

        private void radioButton2_MouseClick(object sender, MouseEventArgs e)
        {
            User_Cbb.DataSource = null;
            DataTable dt = dbs.viewAllRole();
            User_Cbb.ValueMember = "GRANTED_ROLE";
            User_Cbb.DisplayMember = "GRANTED_ROLE";
            User_Cbb.DataSource = dt;
            User_Cbb.SelectedIndex = 0;
        }

        private void User_Cbb_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = dbs.viewRolePrivilege(User_Cbb.SelectedValue.ToString().Trim());
                if (dt.Rows.Count != 0)
                {
                    TS_Cbb.ValueMember = "TABLE_NAME";
                    TS_Cbb.DisplayMember = "TABLE_NAME";
                    TS_Cbb.DataSource = dt;
                    TS_Cbb.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                TS_Cbb.DataSource = null;
            }
        }

        private void Execute_Btn_Click(object sender, EventArgs e)
        {
            string cmd;
            string syntax = Syntax_Cbb.SelectedItem.ToString().Trim();
            string user = User_Cbb.Text.ToString().Trim();
            string type = Type_Cbb.SelectedItem.ToString().Trim();
            string table = TS_Cbb.Text.ToString().Trim();
            int temp;
            bool isNumeric = int.TryParse(user, out temp);
            if (syntax.Equals("GRANT"))
            {
                if (!type.Equals("EXECUTE"))
                {
                    if (isNumeric)
                    {
                        cmd = syntax + " " + type + " on ATBMN28." + table + " to \"" + user + "\"";
                    }
                    else
                    {
                        cmd = syntax + " " + type + " on ATBMN28." + table + " to " + user;
                    }
                }
                else
                {
                    if (isNumeric)
                    {
                        cmd = syntax + " " + type + " on " + table + " to \"" + user + "\"";
                    }
                    else
                    {
                        cmd = syntax + " " + type + " on " + table + " to " + user;
                    }
                }
            }
            else
            {
                if (!type.Equals("EXECUTE"))
                {
                    if (isNumeric)
                    {
                        cmd = syntax + " " + type + " on ATBMN28." + table + " from \"" + user + "\"";
                    }
                    else
                    {
                        cmd = syntax + " " + type + " on ATBMN28." + table + " from " + user;
                    }
                }
                else
                {
                    if (isNumeric)
                    {
                        cmd = syntax + " " + type + " on " + table + " from \"" + user + "\"";
                    }
                    else
                    {
                        cmd = syntax + " " + type + " on " + table + " from " + user;
                    }
                }
            }
            try
            {
                dbs.executeGrantRevokePrivilege(cmd);
                MessageBox.Show("Successful!");
                ControlUserPrivacy_Load(this, e);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataTable dt = dbs.viewAllUserPrivilege();
            dataGridView1.DataSource = dt;

        }
    }
}
