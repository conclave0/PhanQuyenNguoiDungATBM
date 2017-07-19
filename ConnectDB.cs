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
    class ConnectDB
    {
        private string connectString;
        private OracleConnection connection;

        public string StringCon
        {
            get { return connectString; }
            set { connectString = value; }
        }


        public ConnectDB(string us, string pw)
        {
            connectString = "DATA SOURCE=JSTComDevice:1521/ORCLPDB;USER ID=" + us + "; Password =" + pw;
            connection = new OracleConnection();
            connection.ConnectionString = connectString;
        }

        public ConnectDB()
        {
            connectString = "DATA SOURCE=JSTComDevice:1521/ORCLPDB;USER ID=ATBMN28; Password =ATBMN28";
            connection = new OracleConnection();
            connection.ConnectionString = connectString;
        }

        public bool GetConnected()
        {
            bool status;
            try
            {
                connection.Open();
                status = true;
                connection.Close();
            }
            catch (Exception e)
            {
                 status = false;
            }
            return status;
        }

        public bool isAdmin(string user)
        {
            bool value = false;
            try
            {
                DataTable dt = new DataTable();
                using (OracleCommand cmd = new OracleCommand("select * from all_objects where owner ='"+user+"'", this.connection))
                {
                    connection.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {

                        dt.Load(reader);
                        if (dt.Rows.Count != 0)
                            value = true;
                    }
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            return value;
        }
        public DataTable getDiemSV(string masv)
        {
            DataTable dt = new DataTable();
            if (masv == "")
            {
                try
                {
                    using (OracleCommand cmd = new OracleCommand("select * from ATBMN28.DANGKY", this.connection))
                    {
                        connection.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {

                            dt.Load(reader);
                        }
                        connection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    string SQLcommand = "select * from ATBMN28.DANGKY where MASV ='" + masv + "'";
                    using (OracleCommand cmd = new OracleCommand(SQLcommand, this.connection))
                    {
                        connection.Open();
                        using (OracleDataReader reader = cmd.ExecuteReader())
                        {

                            dt.Load(reader);
                        }
                        connection.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            return dt;
        }

        public DataTable viewThongBao()
        {
            DataTable dt = new DataTable();
            using (OracleCommand cmd = new OracleCommand("select * from ATBMN28.THONGBAO order by ID", this.connection))
            {
                connection.Open();
                using (OracleDataReader reader = cmd.ExecuteReader())
                {

                    dt.Load(reader);
                }
                connection.Close();
            }
            return dt;
        }

        public DataTable viewAllUserPrivilege()
        {
            DataTable dt = new DataTable();
            string commandString = "select distinct utp.GRANTEE,utp.TABLE_NAME, utp.PRIVILEGE, utp.TYPE from User_tab_privs utp, all_users au where utp.GRANTEE = au.USERNAME or (au.username like '1%' or au.username like '%GV%') order by utp.GRANTEE";
            using (OracleCommand cmd = new OracleCommand(commandString, this.connection))
            {
                connection.Open();
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                connection.Close();
            }
            return dt;

        }

        public DataTable viewAllUser()
        {
            DataTable dt = new DataTable();
            string commandString = "select distinct al.USERNAME from all_users al where al.USERNAME like 'GV%' or al.USERNAME like '1%'";
            using (OracleCommand cmd = new OracleCommand(commandString, this.connection))
            {
                connection.Open();
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                connection.Close();
            }
            return dt;
        }

        public DataTable viewAllRole()
        {
            DataTable dt = new DataTable();
            string commandString = "select distinct Granted_Role from Dba_role_privs where grantee like '1%' or grantee like'GV%' or grantee like 'ATBM%' ";
            using (OracleCommand cmd = new OracleCommand(commandString, this.connection))
            {
                connection.Open();
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                connection.Close();
            }
            return dt;
        }

        public DataTable viewRolePrivilege(string role)
        {
            DataTable dt = new DataTable();
            try
            {
                string commandString = "select distinct uts.TABLE_NAME, uts.Type from User_tab_privs uts where (uts.PRIVILEGE like 'INSERT' or uts.PRIVILEGE like 'UPDATE' or uts.PRIVILEGE like 'DELETE' or uts.PRIVILEGE like 'SELECT' or uts.PRIVILEGE like 'EXECUTE')"
 + " and uts.Grantee = '" + role + "' order by uts.TABLE_NAME ";
                using (OracleCommand cmd = new OracleCommand(commandString, this.connection))
                {
                    connection.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public bool executeGrantRevokePrivilege(string commandString)
        {
            bool status = false;
            try
            {
                
                using (OracleCommand cmd = new OracleCommand(commandString, this.connection))
                {
                    connection.Open();
                    cmd.ExecuteNonQuery();
                    status = true;
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            return status;
        }

        public DataTable viewAllUserRole()
        {
            DataTable dt = new DataTable();
            string commandString = "select distinct Granted_Role, GRANTEE from Dba_role_privs where grantee like '1%' or grantee like'GV%' or grantee like 'ATBM%' order by GRANTED_ROLE ";
            using (OracleCommand cmd = new OracleCommand(commandString, this.connection))
            {
                connection.Open();
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    dt.Load(reader);
                }
                connection.Close();
            }
            return dt;
        }

        public bool executeStoreSetThongBaoPolicy(int id, string policy)
        {
            bool status = false;
            string commandString = "ATBMN28.SetThongBaoPolicy";
            try
            {
                using (OracleCommand cmd = new OracleCommand(commandString, this.connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("ip_id", OracleDbType.Int32).Value = id;
                    cmd.Parameters.Add("ip_id", OracleDbType.Varchar2).Value = policy;
                    connection.Open();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                status = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return status;
        }
        public bool executeStoreAddThongBao(int id, string thongbao, string chucvu)
        {
            bool status = false;
            string commandString = "ATBMN28.ThemThongBao";
                using (OracleCommand cmd = new OracleCommand(commandString, this.connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("inp_ID", OracleDbType.Int32).Value = id;
                    cmd.Parameters.Add("inp_THONGBAO", OracleDbType.Varchar2).Value = thongbao;
                    cmd.Parameters.Add("inp_CHUCVU", OracleDbType.Varchar2).Value = chucvu;
                    connection.Open();
                    OracleDataAdapter da = new OracleDataAdapter(cmd);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    status = true;
            }
            MessageBox.Show("Thêm Thông Báo Thành Công");
            return status;
        }

        public DataTable auditThongBao()
        {
            DataTable dt = new DataTable();
            try
            {
                string commandString = "select * from ATBMN28.THONGBAO$AUDIT";
                using (OracleCommand cmd = new OracleCommand(commandString, this.connection))
                {
                    connection.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable auditLuong()
        {
            DataTable dt = new DataTable();
            try
            {
                string commandString = "select Log_Type, User_Name, Log_DATE,MAGV, ATBMN28.decrypt_Luong(OLD_VALUE,'antoanbaomat') OLD_LUONG from ATBMN28.log_luong";
                using (OracleCommand cmd = new OracleCommand(commandString, this.connection))
                {
                    connection.Open();
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

    }
}
