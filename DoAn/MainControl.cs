using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using DoAn.MenuTab;
using System.Data.SqlClient;
using System.IO;
using DoAn_2.MenuTab;

namespace DoAn
{
    public partial class MainControl : Form
    {
        SqlConnection connect = ClassKetnoi.connect;
        // SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-SSEL2VD\QUOCMANH;Initial Catalog=doan;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader rdr;
        DataSet ds;
        SqlDataAdapter da;

        private IconButton currentbtn;
        private Panel lefborderbtn;
        private Form currentchildform;

        public static string tennv = "";

        public MainControl()
        {
            InitializeComponent();
            lefborderbtn = new Panel();
            lefborderbtn.Size = new Size(7, 50);
            PanelMenu.Controls.Add(lefborderbtn);
            timer1.Start();//dong ho
           

        }

        

        

        private void disablebtn()
        {
            if(currentbtn != null)
            {
                //button

                currentbtn.BackColor = Color.FromArgb(34, 36, 49);
                currentbtn.ForeColor = Color.Gainsboro;
                currentbtn.TextAlign = ContentAlignment.MiddleLeft;
                currentbtn.IconColor = Color.Gainsboro;
                currentbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentbtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void motrangcon(Form trangcon)
        {
            if (currentchildform != null)
            {
                currentchildform.Close();

            }
            currentchildform = trangcon;
            trangcon.TopLevel = false;
            trangcon.FormBorderStyle = FormBorderStyle.None;
            trangcon.Dock = DockStyle.Fill;
            paneltrangcon.Controls.Add(trangcon);
            paneltrangcon.Tag = trangcon;
            trangcon.BringToFront();
            trangcon.Show();
            labelcon.Text = trangcon.Text;
        }
        private void btnhome_Click(object sender, EventArgs e)
        {
            
            motrangcon(new BanHang());
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            motrangcon(new donhang());
        }

        private void btnsanpham_Click(object sender, EventArgs e)
        {
           

        }

        private void btnnhanvien_Click(object sender, EventArgs e)
        {
           
            motrangcon(new sanpham());
        }

        private void btnluong_Click(object sender, EventArgs e)
        {
           
            motrangcon(new tonkho());
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
           
            Application.Restart();
            
        }



        private void Reset()
        {
            disablebtn();
            lefborderbtn.Visible = false;
            iconmenusmall.IconChar = IconChar.Home;
            iconmenusmall.IconColor = Color.Gainsboro;
            labelcon.Text = "Home";
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam );

        private void panelTitlebar_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        

        private void iconExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void iconZoom_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }

        }

        private void MainControl_Load(object sender, EventArgs e)
        {
            PanelDropDownSP.Height = 50;
            try
            {
                connect.Open();
                cmd.CommandText = "select usernv,tennv from nhanvien where usernv='"+Form1.usernv+"'";
                cmd.Connection = connect;
                rdr = cmd.ExecuteReader();
                bool temp = false;
                while (rdr.Read())
                {
                    LabelUser.Text = rdr.GetString(1);
                    tennv = rdr.GetString(1);
                    temp = true;
                }
                if (temp == false)
                    MessageBox.Show("not found");
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void paneltrangcon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButtonSP_Click(object sender, EventArgs e)
        {
            //activebtn(sender, RGBColors.color3);
            if(PanelDropDownSP.Height == 200)
            {
                PanelDropDownSP.Height = 50;
            }
            else
            {
                PanelDropDownSP.Height = 200;
            }
        }

        private void iconButtonSPLoai_Click(object sender, EventArgs e)
        {
            motrangcon(new LoaiSP());
        }

        private void iconButtonSPDonvi_Click(object sender, EventArgs e)
        {
            motrangcon(new DonViSP());
        }

        private void btnsetting_Click(object sender, EventArgs e)
        {
            motrangcon(new Setting());
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbDateTime.Text = datetime.ToString("dd/MM/yyyy HH:mm:ss");
            this.labelGioBig.Text = datetime.ToString("HH:mm:ss");
            this.lbNgayThangBig.Text = datetime.ToString("dd/MM/yyyy");
            this.lbDateBig.Text = datetime.ToString("dddd");
        }

        private void labelcon_Click(object sender, EventArgs e)
        {

        }

        private void iconmenusmall_Click(object sender, EventArgs e)
        {

        }

        private void panelTitlebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnkh_Click(object sender, EventArgs e)
        {
            motrangcon(new KhachHang());
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            motrangcon(new Dashboard());
        }
    }
}
