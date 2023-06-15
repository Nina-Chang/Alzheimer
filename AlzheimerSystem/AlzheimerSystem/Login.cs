using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using CCWin;

namespace AlzheimerSystem
{
    public partial class Login : Skin_Mac
    {
        public static string Constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataBase;Integrated Security=True";
        //public static string Constr = @"Data Source=120.125.78.204;Initial Catalog=DataServer;User ID=07400961;Password=Mcu110HIM";


        public Login()
        {
            InitializeComponent();
        }

        public static class CurrentUser
        {
            public static string userName { get; set; }
            public static DateTime LoginTime { get; set; }
        }

        string Acc, Pwd;
        //鎖住textBox輸入時不能輸入中文==>利用this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Disable;方式可以達成

        //用來判斷mail格式是否正確
        public static bool JudgeEmailAddress(string email)
        {
            try
            {
                //第三種方法判斷E-mail格式是否正確
                //return Regex.IsMatch(email, @"^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$");


                //第二種方法判斷E-mail格式是否正確
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                //MessageBox.Show("請輸入正確電子郵件", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }


            //第一種方法判斷E-mail格式是否正確，但是很多bug
            ////字串如果沒有@會顯示錯誤
            //if(email.IndexOf("@")==-1)
            //{
            //    MessageBox.Show("輸入的字串中沒有@");
            //    return false;
            //}
            ////字串如果輸入很多個@會顯示錯誤，因為只能輸入一個
            // if (email.IndexOf("@") != email.LastIndexOf("@"))
            //{
            //    MessageBox.Show("輸入的字串中有多個@");
            //    return false;
            //}

            ////字串如果沒有.會顯示錯誤
            //if (email.IndexOf(".")==-1)
            //{
            //    MessageBox.Show("輸入的字串中沒有.");
            //    return false;

            //}

            ////判斷@是否在第一個.前面
            //if (email.IndexOf("@") > email.LastIndexOf("."))
            //{
            //    MessageBox.Show("輸入的字串中@沒有在.前面");
            //    return false;
            //}

            ////判斷@不能是第一個
            //if(email.StartsWith("@"))
            //{
            //    MessageBox.Show("輸入的字串中@不能再第一個");
            //    return false;
            //}
            ////.不能在最後一個
            //if(email.EndsWith("."))
            //{
            //    MessageBox.Show("輸入的字串中.不能再最後一個");
            //    return false;
            //}
            ////判斷是否有出現@.的格式
            //if(email.IndexOf("@.") == -1)
            //{
            //    MessageBox.Show("輸入的字串中沒有@.的格式");
            //    return false;

            //}
            //if (email.IndexOf("..") == -1)
            //{
            //    MessageBox.Show("輸入的字串中沒有@.的格式");
            //        return false;

            //}
            //return true;
        }

        public static bool JudgePassword(string password)
        {
            try
            {
                Regex regex = new Regex(@"^(?=.*\d)(?=.*[a-zA-Z])(?=.*\W).{6,30}$");
                bool a = regex.IsMatch(password);
                return a;
            }
            catch
            {
                MessageBox.Show("請輸入正確密碼格式", "格式錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Acc = txtAcc.Text;
            Pwd = txtPss.Text;
            if (Acc.Length == 0)
            {
                lblAcc.Text = "請輸入帳號";
            }
            else
            {
                if (JudgeEmailAddress(Acc) == false)
                {
                    lblAcc.Text = "請輸入正確電子郵件";
                    return;
                }
                    
            }
            if (Pwd.Length == 0)
            {
                lblPWD.Text = "請輸入密碼";
                return;
            }
            else
            {

            }
            result = login(Acc, Pwd);
            if (result == true)
            {

                CurrentUser.userName = Acc;
                HomePage f1 = new HomePage();
                f1.Show();
                this.Hide();
            }
            else
            {
                lblLogin.Text = "帳號或密碼輸入錯誤";
                txtAcc.Focus();
            }
        }

        private void txtAcc_TextChanged(object sender, EventArgs e)
        {
            if (txtAcc.Text.Length != 0)
            {
                lblAcc.Text = "";
                lblLogin.Text = "";
            }
        }

        private void txtPss_TextChanged(object sender, EventArgs e)
        {
            if (txtPss.Text.Length != 0)
            {
                lblPWD.Text = "";
                lblLogin.Text = "";
            }
        }

        private bool login(string acc, string pwd)
        {
            bool res;
            SqlConnection con = new SqlConnection(Constr); //建立資料庫連線
            con.Open(); //資料庫開啟
                        //建立指令
            string sql = "select * from Member where Account='{0}' and Password='{1}'";
            string sqlcmd = string.Format(sql, acc, pwd);
            SqlCommand cmd = new SqlCommand(sqlcmd, con);
            //執行指令 => 查詢指令:ExecuteReader(),非查詢型指令:ExecuteNonQuery()
            IDataReader reader = cmd.ExecuteReader();
            //資料庫有資料且符合回傳True
            if (reader.Read())
            {
                res = true;
            }
            //登入失敗回傳False
            else
            {
                res = false;
            }
            reader.Close();
            con.Close();
            return res;
        }

        private void txtAcc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPss.Focus();
            }
        }

        private void txtPss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            btnShow.Visible = false;
            btnHide.Visible = true;
            txtPss.UseSystemPasswordChar = false;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnShow.Visible = true;
            btnHide.Visible = false;
            txtPss.UseSystemPasswordChar = true;
        }



        bool result;
    }
}
