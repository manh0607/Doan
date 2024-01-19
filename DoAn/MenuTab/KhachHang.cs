using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn.MenuTab
{
    public partial class KhachHang : Form
    {
        SqlConnection connect = ClassKetnoi.connect;
        SqlDataAdapter adap;
        DataSet dskh;
        Label IDtt = new Label();
        public KhachHang()
        {
            InitializeComponent();
            gridviewKhachHang();
        }
        private void gridviewKhachHang()
        {
            try
            {
                connect.Open();
                adap = new SqlDataAdapter("select IDkh as 'ID', TenKH as 'Tên khách hàng', SDT as 'SĐT', DiaChi as 'Địa chỉ',Email as 'Email' from KhachHang", connect);
                dskh = new System.Data.DataSet();
                adap.Fill(dskh, "KhachHangTable");
                dataGridViewKH.DataSource = dskh.Tables[0];
            }
            catch (Exception ex)
            {
                connect.Close();
                MessageBox.Show(ex.Message);
            }

        }

        private void KhachHang_Load(object sender, EventArgs e)
        {

        }
        public void clearkh()
        {
            txtTenKH.Clear();
            txtsđtkh.Clear();
            txtdiachikh.Clear();
            txtemailkh.Clear();
        }
        private void BtnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Trống!");
                txtTenKH.Select();
            }

            if (string.IsNullOrWhiteSpace(txtsđtkh.Text))
            {
                txtsđtkh.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtdiachikh.Text))
            {
                txtdiachikh.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtemailkh.Text))
            {
                txtemailkh.Select();
            }
            else
            {
                using (var cmd = new SqlCommand("INSERT INTO KhachHang (TenKH,SDT,DiaChi,Email) VALUES (@TenKH,@SDT,@DiaChi,@Email)"))
                {
                    cmd.Connection = connect;
                    cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                    cmd.Parameters.AddWithValue("@SDT", txtsđtkh.Text);
                    cmd.Parameters.AddWithValue("@DiaChi", txtdiachikh.Text);
                    cmd.Parameters.AddWithValue("@Email", txtemailkh.Text);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Đã thêm");
                        connect.Close();
                        clearkh();
                        gridviewKhachHang();

                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công!");
                        connect.Close();
                    }
                    connect.Close();

                }

            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Thông tin trống!");
            }
            else
            {
                try
                {
                    using (var cmd = new SqlCommand("delete KhachHang where TenKH=@TenKH"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã xóa");
                            connect.Close();
                            clearkh();
                            gridviewKhachHang();
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công!");
                        }
                        connect.Close();
                    }
                }
                catch (Exception ex)
                {
                    connect.Close();
                    MessageBox.Show("Error during delete: " + ex.Message);
                }

            }
        }

        private void dataGridViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewKH.CurrentRow.Index != -1)
            {
                txtIdkh.Text = dataGridViewKH.CurrentRow.Cells[0].Value.ToString();
                txtTenKH.Text = dataGridViewKH.CurrentRow.Cells[1].Value.ToString();
                txtsđtkh.Text = dataGridViewKH.CurrentRow.Cells[2].Value.ToString();
                txtdiachikh.Text = dataGridViewKH.CurrentRow.Cells[3].Value.ToString();
                txtemailkh.Text = dataGridViewKH.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            clearkh();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKH.Text))
            {
                MessageBox.Show("Trống!");
                txtTenKH.Select();
            }

            if (string.IsNullOrWhiteSpace(txtsđtkh.Text))
            {
                txtsđtkh.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtdiachikh.Text))
            {
                txtdiachikh.Select();
            }
            else if (string.IsNullOrWhiteSpace(txtemailkh.Text))
            {
                txtemailkh.Select();
            }
            else
            {
                try
                {
                    using (var cmd = new SqlCommand("update KhachHang set TenKH=@TenKH,SDT=@SDT,DiaChi=@DiaChi,Email=@Email where IDkh=@IDkh"))
                    {
                        cmd.Connection = connect;
                        cmd.Parameters.AddWithValue("@IDkh", txtIdkh.Text);
                        cmd.Parameters.AddWithValue("@TenKH", txtTenKH.Text);
                        cmd.Parameters.AddWithValue("@SDT", txtsđtkh.Text);
                        cmd.Parameters.AddWithValue("@DiaChi", txtdiachikh.Text);
                        cmd.Parameters.AddWithValue("@Email", txtemailkh.Text);
                        connect.Open();
                        if (cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Đã lưu");
                            connect.Close();
                            clearkh();
                            gridviewKhachHang();
                        }
                        else
                        {
                            MessageBox.Show("Lưu không thành công!");
                        }
                        connect.Close();
                    }
                }
                catch (Exception ex)
                {
                    connect.Close();
                    MessageBox.Show("Error during update: " + ex.Message);
                }
            }
        }
    }
}

