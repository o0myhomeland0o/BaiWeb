using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        TextBox[] txtNums; // 5 ô nhập
        Button btnCalc;
        Label lblKQ;

        public Form1()
        {
            // Cấu hình form
            this.Text = "Tính Trung Bình Cộng 5 số";
            this.Width = 400;
            this.Height = 300;
            this.StartPosition = FormStartPosition.CenterScreen;

            // Khởi tạo 5 label + textbox
            txtNums = new TextBox[5];
            for (int i = 0; i < 5; i++)
            {
                Label lbl = new Label();
                lbl.Text = $"Số {i + 1}:";
                lbl.Left = 20;
                lbl.Top = 20 + i * 30 + 3;
                lbl.Width = 50;
                this.Controls.Add(lbl);

                txtNums[i] = new TextBox();
                txtNums[i].Left = 80;
                txtNums[i].Top = 20 + i * 30;
                txtNums[i].Width = 100;
                this.Controls.Add(txtNums[i]);
            }

            // Nút tính
            btnCalc = new Button();
            btnCalc.Text = "Tính Trung Bình Cộng";
            btnCalc.Left = 200;
            btnCalc.Top = 40;
            btnCalc.Width = 150;
            btnCalc.Click += new EventHandler(btnCalc_Click);
            this.Controls.Add(btnCalc);

            // Label kết quả
            lblKQ = new Label();
            lblKQ.Left = 20;
            lblKQ.Top = 200;
            lblKQ.Width = 350;
            lblKQ.Text = "Kết quả:";
            this.Controls.Add(lblKQ);
        }

        void btnCalc_Click(object sender, EventArgs e)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < 5; i++)
            {
                if (!int.TryParse(txtNums[i].Text, out numbers[i]))
                {
                    MessageBox.Show($"Số thứ {i + 1} không hợp lệ!");
                    return;
                }
            }

            MayTinh calc = new MayTinh();
            try
            {
                double kq = calc.TinhTrungBinh(numbers);
                lblKQ.Text = "Kết quả: " + kq;
            }
            catch (Exception ex)
            {
                lblKQ.Text = "Lỗi: " + ex.Message;
            }
        }
    }
}
