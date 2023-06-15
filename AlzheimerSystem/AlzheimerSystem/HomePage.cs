using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using InTheHand.Net;
using InTheHand.Net.Sockets;
using InTheHand.Net.Bluetooth;
using System.Data.SqlClient;
using System.IO;
using System.IO.Ports;
using myTools;
using CCWin;

namespace AlzheimerSystem
{
    public partial class HomePage : Skin_Mac
    {
        //WebLine.ADweb adweb;
        LWeb.ADwebSoapClient adweb;
        BluetoothAddress addr;//用於識別藍芽裝置的地址
        BluetoothEndPoint ep;//一個設備上的藍言服務端點
        BluetoothClient clnt;//藍芽用戶端
        BluetoothAddress[] MACs;
        Stream btStream;
        Thread RxBT;//thread為執行序
        StringBuilder res;

        BluetoothAddress addr2;//用於識別藍芽裝置的地址
        BluetoothEndPoint ep2;//一個設備上的藍言服務端點
        BluetoothClient clnt2;//藍芽用戶端
        Stream btStream2;
        Thread RxBT2;//thread為執行序
        StringBuilder res2;

        BluetoothAddress addr3;//用於識別藍芽裝置的地址
        BluetoothEndPoint ep3;//一個設備上的藍言服務端點
        BluetoothClient clnt3;//藍芽用戶端
        Stream btStream3;
        Thread RxBT3;//thread為執行序
        StringBuilder res3;

        BluetoothAddress addr4;//用於識別藍芽裝置的地址
        BluetoothEndPoint ep4;//一個設備上的藍言服務端點
        BluetoothClient clnt4;//藍芽用戶端
        Stream btStream4;
        Thread RxBT4;//thread為執行序
        StringBuilder res4;

        BluetoothAddress addr5;//用於識別藍芽裝置的地址
        BluetoothEndPoint ep5;//一個設備上的藍言服務端點
        BluetoothClient clnt5;//藍芽用戶端
        Stream btStream5;
        Thread RxBT5;//thread為執行序
        StringBuilder res5;

        bool bBT, bCOM;
        Stopwatch sw;
        int len, iStart, iEnd, ii, iStart1,iStart2, iStart3, iStart4;
        byte[] buffer, RxBuf, RxBuf2, RxBuf3, RxBuf4, RxBuf5;
        List<byte> raw;
        List<byte> raw2;
        List<byte> raw3;
        List<byte> raw4;
        List<byte> raw5;
        int i, LenRead, LenRead2, LenRead3, LenRead4, LenRead5;
        public static string plnm;
        public static bool clickOrnot = true;

        private void HomePage_Load(object sender, EventArgs e)
        {
            adweb = new LWeb.ADwebSoapClient();
            user = Login.CurrentUser.userName;
            raw = new List<byte>();
            res = new StringBuilder();

            raw2 = new List<byte>();
            res2 = new StringBuilder();

            raw3 = new List<byte>();
            res3 = new StringBuilder();

            raw4 = new List<byte>();
            res4 = new StringBuilder();

            raw5 = new List<byte>();
            res5 = new StringBuilder();
            clickOrnot = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (cmboBxBT.Text != "")
            {
                lbltime.Text = raw[iStart++].ToString();
                int a = int.Parse(lbltime.Text);
                if (a == 1)
                {
                    InsertData(a, user, cmbPlace.SelectedItem.ToString());
                }
            }

            if (cmboBxBT2.Text != "")
            {
                lbltime2.Text = raw2[iStart1++].ToString();
                int b = int.Parse(lbltime2.Text);
                if (b == 1)
                {
                    InsertData(b, user, cmbPlace2.SelectedItem.ToString());
                }
            }

            if (cmboBxBT3.Text != "")
            {
                lbltime3.Text = raw3[iStart2++].ToString();
                int c = int.Parse(lbltime3.Text);
                if (c == 1)
                {
                    InsertData(c, user, cmbPlace3.SelectedItem.ToString());
                }
            }

            if (skinCmbobxBT4.Text != "")
            {
                lbltime4.Text = raw4[iStart3++].ToString();
                int c = int.Parse(lbltime4.Text);
                if (c == 1)
                {
                    InsertData(c, user, skinCmbobxPlace4.SelectedItem.ToString());
                }
            }

            if (skinCmbobxBT5.Text != "")
            {
                lbltime5.Text = raw5[iStart4++].ToString();
                int c = int.Parse(lbltime5.Text);
                if (c == 1)
                {
                    InsertData(c, user, skinCmbobxPlace5.SelectedItem.ToString());
                }
            }
            Application.DoEvents();
        }

        
        private void btnScan_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            BluetoothRadio.PrimaryRadio.Mode = RadioMode.Connectable;
            BluetoothClient client = new BluetoothClient();
            BluetoothDeviceInfo[] devices = client.DiscoverDevices();
            MACs = new BluetoothAddress[devices.Length];
            i = 0;
            cmboBxBT.Items.Clear();
            cmboBxBT2.Items.Clear();
            cmboBxBT3.Items.Clear();
            skinCmbobxBT4.Items.Clear();
            skinCmbobxBT5.Items.Clear();
            foreach (BluetoothDeviceInfo device in devices)
            {
                cmboBxBT.Items.Add(string.Format("{0}:{1}", device.DeviceName, device.DeviceAddress));
                cmboBxBT2.Items.Add(string.Format("{0}:{1}", device.DeviceName, device.DeviceAddress));
                cmboBxBT3.Items.Add(string.Format("{0}:{1}", device.DeviceName, device.DeviceAddress));
                skinCmbobxBT4.Items.Add(string.Format("{0}:{1}", device.DeviceName, device.DeviceAddress));
                skinCmbobxBT5.Items.Add(string.Format("{0}:{1}", device.DeviceName, device.DeviceAddress));
                MACs[i++] = device.DeviceAddress;
            }
            clickOrnot ^= true;
       
            if (cmboBxBT.Items.Count >= 1)
            {
                lblDone.Text = "已成功搜尋所有藍芽模組";
                lblwrong.Text = "";
            }
            
        }

        private void btnBT_Click(object sender, EventArgs e)
        {
            //藍芽連接
            if (serialPortR.IsOpen)
                serialPortR.Close();
            if (clickOrnot == true)//沒有按btnScan
            {
                lblwrong.Text = "請先點按選取感測器的按鈕";
                return;
            }
            if(cmboBxBT.Text=="")//點按選取感測器按鈕後卻沒有選藍芽模組名稱
            {
                lblwrong.Text = "請先下拉選取藍芽模組名稱";
                return;
            }
            if (lbltime.Text != "" || lbltime2.Text != "" || lbltime3.Text != "")//按下兩次btnBT
            {
                lblwrong.Text = "藍芽感測器已啟動";
                return;
            }
            if(lblRepeat2.Text !="" || lblRepeat3.Text != "")
            {
                return;
            }
            bBT = true;
            bCOM = false;
            ConnectBtMedicalDevice();

            if (cmboBxBT.Text != "")
            {
                SelectBTPairing(user, cmboBxBT.SelectedItem);
                if (plnm == null)
                {
                    InsertBTPairing(user, cmbPlace.SelectedItem.ToString(), cmboBxBT.SelectedItem);
                }
                else
                {
                    UpdateBTPairing(user, cmboBxBT.SelectedItem, cmbPlace.SelectedItem.ToString());
                }
            }
            
            if (cmboBxBT2.Text != "")
            {
                SelectBTPairing(user, cmboBxBT2.SelectedItem);
                if (plnm == null)
                {
                    InsertBTPairing(user, cmbPlace2.SelectedItem.ToString(), cmboBxBT2.SelectedItem);
                }
                else
                {
                    UpdateBTPairing(user, cmboBxBT2.SelectedItem, cmbPlace2.SelectedItem.ToString());
                }
            }

            if (cmboBxBT3.Text != "")
            {
                SelectBTPairing(user, cmboBxBT3.SelectedItem);
                if (plnm == null)
                {
                    InsertBTPairing(user, cmbPlace3.SelectedItem.ToString(), cmboBxBT3.SelectedItem);
                }
                else
                {
                    UpdateBTPairing(user, cmboBxBT3.SelectedItem, cmbPlace3.SelectedItem.ToString());
                }
            }

            if (skinCmbobxBT4.Text != "")
            {
                SelectBTPairing(user, skinCmbobxBT4.SelectedItem);
                if (plnm == null)
                {
                    InsertBTPairing(user, skinCmbobxPlace4.SelectedItem.ToString(), skinCmbobxBT4.SelectedItem);
                }
                else
                {
                    UpdateBTPairing(user, skinCmbobxBT4.SelectedItem, skinCmbobxPlace4.SelectedItem.ToString());
                }
            }

            if (skinCmbobxBT5.Text != "")
            {
                SelectBTPairing(user, skinCmbobxBT5.SelectedItem);
                if (plnm == null)
                {
                    InsertBTPairing(user, skinCmbobxPlace5.SelectedItem.ToString(), skinCmbobxBT5.SelectedItem);
                }
                else
                {
                    UpdateBTPairing(user, skinCmbobxBT5.SelectedItem, skinCmbobxPlace5.SelectedItem.ToString());
                }
            }
            timer1.Start();
        }

        private void cmboBxBT_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectBTPairing(user, cmboBxBT.SelectedItem);
            cmbPlace.Text = plnm;
            lblDone.Text = "";
            lblwrong.Text = "";
        }

        private void cmboBxBT2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectBTPairing(user, cmboBxBT2.SelectedItem);
            cmbPlace2.Text = plnm;
            if (cmbPlace2.Text == cmbPlace.Text)//不能選和上面的地點一樣
            {
                lblRepeat2.Text = "請重新選擇感測器2的藍芽模組名稱";
            }
            else
            {
                lblDone.Text = "";
                lblwrong.Text = "";
                lblRepeat2.Text = "";
            }
        }

        private void cmboBxBT3_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectBTPairing(user, cmboBxBT3.SelectedItem);
            cmbPlace3.Text = plnm;
            if (cmbPlace3.Text == cmbPlace.Text || cmbPlace3.Text==cmbPlace2.Text)//不能選和上面的地點一樣
            {
                lblRepeat3.Text = "請重新選擇感測器3的藍芽模組名稱";
            }
            else
            {
                lblDone.Text = "";
                lblwrong.Text = "";
                lblRepeat3.Text = "";
            }
        }

        private void InsertData(int times, string username, string place)
        {
            int dateY = DateTime.Now.Year;
            int dateM = DateTime.Now.Month;
            int dateD = DateTime.Now.Day;
            int dateH = DateTime.Now.Hour;
            int datem = DateTime.Now.Minute;
            int dateS = DateTime.Now.Second;
            datetime = string.Format("{0:d4}/{1:D2}/{2:D2} {3:d2}:{4:d2}:{5:d2}", dateY, dateM, dateD, dateH, datem, dateS);
            long maxID = getMaxNum("Sn", "IndoorActivity");
            int sign = 0;
            if (place == "廚房")
            {
                place = "1";

            }
            else if (place == "房間")
            {
                place = "2";
            }
            else if (place == "浴室")
            {
                place = "3";
            }
            else if (place == "書房")
            {
                place = "4";
            }
            else
                place = "5";
            int place_id = int.Parse(place);
            try
            {
                string sql = @"INSERT INTO IndoorActivity(Sn,DateTime,Times,Place_id,Member_Account) VALUES ('{0}','{1}','{2}','{3}','{4}')";
                string sqlcmd = string.Format(sql, maxID + 1, datetime, times, place_id, username);
                SqlConnection con = new SqlConnection(Constr);
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlcmd, con);
                sign = cmd.ExecuteNonQuery();
                con.Close();
                if (sign == 1)
                {//判斷是否需要通知
                    string alertSql = @"Select A.Place_id, B.Place_Name, max(DATEPART(HOUR, DateTime)) as 時間段,Count(Times) as 次數,C.Member_Account,C.Object FROM dbo.IndoorActivity as A , Place as B ,Floorplans as C WHERE CONVERT (date, DateTime)='{0}' and DATEPART(HOUR, DateTime)='{1}' and A.Place_id='{2}'and A.Place_id=B.Place_id and C.Member_Account='{3}' Group by DATEPART(HOUR, DateTime),B.Place_Name,A.Place_id,C.Member_Account,C.Object Having Count(Times)>3";
                    string alertSqlcmd = string.Format(alertSql, DateTime.Now.ToShortDateString(), DateTime.Now.Hour.ToString(), place_id, username);
                    SqlConnection alertcon = new SqlConnection(Constr);
                    alertcon.Open();
                    SqlCommand alertcmd = new SqlCommand(alertSqlcmd, alertcon);
                    IDataReader reader = alertcmd.ExecuteReader();
                    if (reader.Read())
                    {
                        adweb.CallLineToken(username);
                    }
                    else
                        return;
                    alertcon.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong");
            }

        }

        public static long getMaxNum(string col, string table)
        {//抓取資料表中id最大值
            long imax = -1;
            using (SqlConnection conn = new SqlConnection(Constr))
            {
                string sqlCmd = string.Format("SELECT Max({0}) From {1};", col, table);
                using (SqlCommand cmd = new SqlCommand(sqlCmd))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlCmd, conn))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        if (!long.TryParse(dt.Rows[0][0].ToString(), out imax))
                            imax = 0;
                    }
                }
            }
            return imax;
        }

        private void InsertBTPairing(string username, string place, object cmBT)
        {
            long maxID = getMaxNum("Sn", "BlueToothPairing");
            int sign = 0;
            try
            {
                string sql = @"INSERT INTO BlueToothPairing(Sn,Place_Name,BTDevice_Name,Member_Account) VALUES ('{0}','{1}','{2}','{3}')";
                string sqlcmd = string.Format(sql, maxID + 1, place, cmBT, username);
                SqlConnection con = new SqlConnection(Constr);
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlcmd, con);
                sign = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("wrong");
            }

        }

        public void UpdateBTPairing(string username, object comboboxBT,object cmbPlace)
        {
            SqlConnection con = new SqlConnection(Constr); //建立資料庫連線
            con.Open(); //資料庫開啟
                        //建立指令try
            string sql = @"UPDATE dbo.BlueToothPairing SET Place_Name='{0}' WHERE BTDevice_Name='{1}' and Member_Account='{2}'";
            string sqlcmd = string.Format(sql, cmbPlace, comboboxBT, username);
            SqlCommand cmd = new SqlCommand(sqlcmd, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        public void SelectBTPairing(string username, object comboboxBT)
        {
            plnm = null;
            SqlConnection con = new SqlConnection(Constr); //建立資料庫連線
            con.Open(); //資料庫開啟
                        //建立指令try
            try
            {
                string sql = @"SELECT BTDevice_Name,Place_Name FROM BlueToothPairing WHERE BTDevice_Name='{0}' AND Member_Account='{1}'";
                string sqlcmd = string.Format(sql, comboboxBT, username);
                SqlCommand cmd = new SqlCommand(sqlcmd, con);
                IDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    plnm = reader["Place_Name"].ToString();
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
            }

        }

        void DisconnectBt()
        {
            if (clnt != null)
            {
                clnt.Close();
                clnt.Dispose();
                clnt = null;
            }
            if (clnt2 != null)
            {
                clnt2.Close();
                clnt2.Dispose();
                clnt2 = null;
            }
            if (clnt3 != null)
            {
                clnt3.Close();
                clnt3.Dispose();
                clnt3 = null;
            }
            if (clnt4 != null)
            {
                clnt4.Close();
                clnt4.Dispose();
                clnt4 = null;
            }
            if (clnt5 != null)
            {
                clnt5.Close();
                clnt5.Dispose();
                clnt5 = null;
            }
            if (RxBT != null)
                RxBT.Join();
            if (RxBT2 != null)
                RxBT2.Join();
            if (RxBT3 != null)
                RxBT3.Join();
            if (RxBT4 != null)
                RxBT4.Join();
            if (RxBT5 != null)
                RxBT5.Join();
        }


        void ConnectBtMedicalDevice()
        {
            try
            {
                if (cmboBxBT.Text != "")
                {
                    serviceClass = BluetoothService.SerialPort;
                    addr = MACs[cmboBxBT.SelectedIndex];
                    if (ep != null)
                        ep = null;
                    ep = new BluetoothEndPoint(addr, serviceClass);
                    if (clnt != null)
                    {
                        clnt.Close();
                        clnt.Dispose();
                        clnt = null;
                    }
                    clnt = new BluetoothClient();
                    clnt.Connect(ep);
                    btStream = clnt.GetStream();
                    RxBuf = new byte[bufLen];
                    RxBT = new Thread(ReceivingPacket);
                    RxBT.Start();
                }

                if (cmboBxBT2.Text != "")
                {
                    serviceClass2 = BluetoothService.SerialPort;
                    addr2 = MACs[cmboBxBT2.SelectedIndex];
                    if (ep2 != null)
                        ep2 = null;
                    ep2 = new BluetoothEndPoint(addr2, serviceClass2);
                    if (clnt2 != null)
                    {
                        clnt2.Close();
                        clnt2.Dispose();
                        clnt2 = null;
                    }
                    clnt2 = new BluetoothClient();
                    clnt2.Connect(ep2);
                    btStream2 = clnt2.GetStream();
                    RxBuf2 = new byte[bufLen2];
                    RxBT2 = new Thread(ReceivingPacket2);
                    RxBT2.Start();
                }

                if (cmboBxBT3.Text != "")
                {
                    serviceClass3 = BluetoothService.SerialPort;
                    addr3 = MACs[cmboBxBT3.SelectedIndex];
                    if (ep3 != null)
                        ep3 = null;
                    ep3 = new BluetoothEndPoint(addr3, serviceClass3);
                    if (clnt3 != null)
                    {
                        clnt3.Close();
                        clnt3.Dispose();
                        clnt3 = null;
                    }
                    clnt3 = new BluetoothClient();
                    clnt3.Connect(ep3);
                    btStream3 = clnt3.GetStream();
                    RxBuf3 = new byte[bufLen];
                    RxBT3 = new Thread(ReceivingPacket3);
                    RxBT3.Start();
                }

                if (skinCmbobxBT4.Text != "")
                {
                    serviceClass4 = BluetoothService.SerialPort;
                    addr4 = MACs[skinCmbobxBT4.SelectedIndex];
                    if (ep4 != null)
                        ep4 = null;
                    ep4 = new BluetoothEndPoint(addr4, serviceClass4);
                    if (clnt4 != null)
                    {
                        clnt4.Close();
                        clnt4.Dispose();
                        clnt4 = null;
                    }
                    clnt4 = new BluetoothClient();
                    clnt4.Connect(ep4);
                    btStream4 = clnt4.GetStream();
                    RxBuf4 = new byte[bufLen];
                    RxBT4 = new Thread(ReceivingPacket4);
                    RxBT4.Start();
                }

                if (skinCmbobxBT5.Text != "")
                {
                    serviceClass5 = BluetoothService.SerialPort;
                    addr5 = MACs[skinCmbobxBT5.SelectedIndex];
                    if (ep5 != null)
                        ep5 = null;
                    ep5 = new BluetoothEndPoint(addr5, serviceClass5);
                    if (clnt5 != null)
                    {
                        clnt5.Close();
                        clnt5.Dispose();
                        clnt5 = null;
                    }
                    clnt5 = new BluetoothClient();
                    clnt5.Connect(ep5);
                    btStream5 = clnt5.GetStream();
                    RxBuf5 = new byte[bufLen];
                    RxBT5 = new Thread(ReceivingPacket5);
                    RxBT5.Start();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error: Connecting BlueTooth");
            }
        }
        private void ReceivingPacket()
        {
            while (bBT)
            {
                LenRead = 0;
                try
                {
                    if (!btStream.CanRead)
                        break;
                    else
                    {
                        LenRead = btStream.Read(RxBuf, 0, bufLen);
                        for (int i0 = 0; i0 < LenRead; i0++)
                        {
                            raw.Add(RxBuf[i0]);
                        }
                    }
                }
                catch(Exception e)
                {

                }
                

            }
        }

        private void ReceivingPacket2()
        {
            while (bBT)
            {
                LenRead2 = 0;
                try
                {
                    if (!btStream2.CanRead)
                        break;
                    else
                    {
                        LenRead2 = btStream2.Read(RxBuf2, 0, bufLen2);
                        for (int i0 = 0; i0 < LenRead2; i0++)
                        {
                            raw2.Add(RxBuf2[i0]);
                        }
                    }
                }
                catch (Exception e)
                {

                }
            }
        }

        private void ReceivingPacket4()
        {
            while (bBT)
            {
                LenRead4 = 0;
                try
                {
                    if (!btStream4.CanRead)
                        break;
                    else
                    {
                        LenRead4 = btStream4.Read(RxBuf4, 0, bufLen4);
                        for (int i0 = 0; i0 < LenRead4; i0++)
                        {
                            raw4.Add(RxBuf4[i0]);
                        }
                    }
                }
                catch (Exception e)
                {

                }
            }
        }

        private void ReceivingPacket5()
        {
            while (bBT)
            {
                LenRead5 = 0;
                try
                {
                    if (!btStream5.CanRead)
                        break;
                    else
                    {
                        LenRead5 = btStream5.Read(RxBuf5, 0, bufLen5);
                        for (int i0 = 0; i0 < LenRead5; i0++)
                        {
                            raw5.Add(RxBuf5[i0]);
                        }
                    }
                }
                catch (Exception e)
                {

                }
            }
        }

        private void btnModifyPairing_Click(object sender, EventArgs e)
        {
            BTPairing d1 = new BTPairing();
            if (lbltime.Text!=null || lbltime2.Text!=null || lbltime3.Text != null)
            {
                DialogResult dialogResult = MessageBox.Show("如果要離開，室內移動軌跡將不會繼續計算，請問是否要離開此頁面?", "確認訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    d1.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
            this.Hide();
            d1.Show();
            //中斷藍芽連接
            bBT = false;
            DisconnectBt();
            sw.Stop();
            Application.DoEvents();
            timer1.Stop();
        }
        int cnt = 0;
        private void 新增感測器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cnt += 1;
            if (cnt == 1)
            {
                groupBox4.Visible = true;
                lbltime4.Visible = true;
                label4.Visible = true;
            }
            if (cnt == 2)
            {
                groupBox5.Visible = true;
                lbltime5.Visible = true;
                label5.Visible = true;
            }
            if (cnt == 3)
            {
                groupBox6.Visible = true;
                lbltime6.Visible = true;
                label6.Visible = true;
            }
            if (cnt == 4)
            {
                groupBox7.Visible = true;
                lbltime7.Visible = true;
                label7.Visible = true;
            }
            if (cnt == 5)
            {
                groupBox8.Visible = true;
                lbltime8.Visible = true;
                label8.Visible = true;
            }
            if (cnt == 6)
            {
                groupBox9.Visible = true;
                lbltime9.Visible = true;
                label9.Visible = true;
            }
            if (cnt == 7)
            {
                groupBox10.Visible = true;
                lbltime10.Visible = true;
                label10.Visible = true;
            }
            if (cnt >= 7)
            {
                新增感測器ToolStripMenuItem.Text = "無法新增，系統目前最大容量為10台感測器";
            }
        }

        private void lbltime_TextChanged(object sender, EventArgs e)
        {
            lblwrong.Text = "";
        }

        private void lbltime2_TextChanged(object sender, EventArgs e)
        {
            lblwrong.Text = "";
        }

        private void skinCmbobxBT5_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectBTPairing(user, skinCmbobxBT5.SelectedItem);
            skinCmbobxPlace5.Text = plnm;
            if (skinCmbobxPlace5.Text == skinCmbobxPlace4.Text)//不能選和上面的地點一樣
            {
                lblRepeat5.Text = "請重新選擇感測器5的藍芽模組名稱";
            }
            else
            {
                lblDone.Text = "";
                lblwrong.Text = "";
                lblRepeat5.Text = "";
            }
        }

        private void skinCmbobxBT4_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectBTPairing(user, skinCmbobxBT4.SelectedItem);
            skinCmbobxPlace4.Text = plnm;
            if (skinCmbobxPlace4.Text == cmboBxBT3.Text)//不能選和上面的地點一樣
            {
                lblRepeat4.Text = "請重新選擇感測器4的藍芽模組名稱";
            }
            else
            {
                lblDone.Text = "";
                lblwrong.Text = "";
                lblRepeat4.Text = "";
            }
        }

        private void lbltime3_TextChanged(object sender, EventArgs e)
        {
            lblwrong.Text = "";
        }

        private void lbltime4_TextChanged(object sender, EventArgs e)
        {
            lblwrong.Text = "";
        }

        private void skinCmbobxBT4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dialogResult = MessageBox.Show("是否清除此下拉選單的選取值?", "確認訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    skinCmbobxBT4.SelectedIndex = -1;
                    skinCmbobxPlace4.SelectedIndex = -1;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void skinCmbobxBT5_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dialogResult = MessageBox.Show("是否清除此下拉選單的選取值?", "確認訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    skinCmbobxBT5.SelectedIndex = -1;
                    skinCmbobxPlace5.SelectedIndex = -1;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void lbltime5_TextChanged(object sender, EventArgs e)
        {
            lblwrong.Text = "";
        }



        private void cmboBxBT_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dialogResult = MessageBox.Show("是否清除此下拉選單的選取值?", "確認訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    cmboBxBT.SelectedIndex = -1;
                    cmbPlace.SelectedIndex = -1;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void cmboBxBT2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dialogResult = MessageBox.Show("是否清除此下拉選單的選取值?", "確認訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    cmboBxBT2.SelectedIndex = -1;
                    cmbPlace2.SelectedIndex = -1;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void cmboBxBT3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult dialogResult = MessageBox.Show("是否清除此下拉選單的選取值?", "確認訊息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    cmboBxBT3.SelectedIndex = -1;
                    cmbPlace3.SelectedIndex = -1;
                }
                else if (dialogResult == DialogResult.No)
                {
                    return;
                }
            }
        }

        private void ReceivingPacket3()
        {
            while (bBT)
            {
                try
                {
                    LenRead3 = 0;
                    if (!btStream3.CanRead)
                        break;
                    else
                    {
                        LenRead3 = btStream3.Read(RxBuf3, 0, bufLen3);
                        for (int i0 = 0; i0 < LenRead3; i0++)
                        {
                            raw3.Add(RxBuf3[i0]);
                        }
                    }
                }
                catch (Exception e)
                {

                }
            }
        }

        //List<byte> raw;
        Guid serviceClass;
        Guid serviceClass2;
        Guid serviceClass3;
        Guid serviceClass4;
        Guid serviceClass5;
        const int bufLen = 7, bufLen2 = 7, bufLen3 = 7, bufLen4 = 7, bufLen5 = 7;
        int count = 0;
        string user, datetime;
        public static int valueOrnot = 0;
        public static int valueOrnot2 = 0;
        public static int valueOrnot3 = 0;
        public static string Constr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataBase;Integrated Security=True";

        public HomePage()
        {
            InitializeComponent();
            sw = new Stopwatch();
            
        }

    }
}
