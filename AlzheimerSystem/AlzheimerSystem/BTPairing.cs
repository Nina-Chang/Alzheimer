using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections;
using CCWin;

namespace AlzheimerSystem
{
    public partial class BTPairing : Skin_Mac
    {
        public BTPairing()
        {
            InitializeComponent();
        }
        public static string Constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataBase;Integrated Security=True";
        public void DeleteBTPairing()
        {
            SqlConnection con = new SqlConnection(Constr); //建立資料庫連線
            con.Open(); //資料庫開啟
                        //建立指令try
            string sql = @"DELETE dbo.BlueToothPairing WHERE BTDevice_Name='{0}' and Member_Account='{1}'";
            string sqlcmd = string.Format(sql, txtbxBTnameModify.Text, user);
            SqlCommand cmd = new SqlCommand(sqlcmd, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void SelectBTAllPairing()
        {
            SqlConnection con = new SqlConnection(Constr); //建立資料庫連線
            con.Open(); //資料庫開啟
                        //建立指令try
            string sql = @"SELECT Place_Name as 地點,BTDevice_Name as 藍芽名稱 FROM BlueToothPairing WHERE Member_Account='{0}'";
            string sqlcmd = string.Format(sql, user);
            SqlCommand cmd = new SqlCommand(sqlcmd, con);
            IDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            DataGridView.DataSource = dt;
            for (int i = 0; i < DataGridView.Rows.Count; i++)
            {
                DataGridViewRow row = DataGridView.Rows[i];
            }

            reader.Close();
            con.Close();
        }

        string user;
        private void BTPairing_Load(object sender, EventArgs e)
        {
            user = Login.CurrentUser.userName;
            SelectBTAllPairing();
        }

        public void UpdateBTPairing()
        {
            SqlConnection con = new SqlConnection(Constr); //建立資料庫連線
            con.Open(); //資料庫開啟
                        //建立指令try
            string sql = @"UPDATE dbo.BlueToothPairing SET Place_Name=N'{0}' WHERE BTDevice_Name='{1}' and Member_Account='{2}'";
            string sqlcmd = string.Format(sql, cmboboxLoc.Text, txtbxBTnameModify.Text, user);
            SqlCommand cmd = new SqlCommand(sqlcmd, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                cmboboxLoc.Items.Clear();
                GroupBox1.Visible = true;
                cmboboxLoc.Text = DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                //ComboBoxPlace();
                SqlConnection con = new SqlConnection(Constr); //建立資料庫連線
                con.Open(); //資料庫開啟
                            //建立指令try
                string sql = @"Select Place_Name From Place";
                string sqlcmd = string.Format(sql);
                SqlCommand cmd = new SqlCommand(sqlcmd, con);
                IDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    cmboboxLoc.Items.Add(reader["Place_Name"].ToString().Trim());
                }
                reader.Close();
                con.Close();
                txtbxBTnameModify.Text = DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch(Exception ex)
            {

            }
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            UpdateBTPairing();
            SelectBTAllPairing();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteBTPairing();
            SqlConnection con = new SqlConnection(Constr); //建立資料庫連線
            con.Open(); //資料庫開啟
                        //建立指令try
            string sql = @"DECLARE @item INT SET @item = 0 UPDATE BlueToothPairing SET @item = @item + 1,[Sn] = @item";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
            SelectBTAllPairing();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HomePage h1 = new HomePage();
            this.Hide();
            h1.Show();
        }

    }
}
