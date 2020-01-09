using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 商场收银.Cash;

namespace 商场收银
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cboxDiscount.SelectedIndex = 0;
        }

        private static double TotalPrice = 0;

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                var Price = Convert.ToDouble(tboxPrice.Text.Trim());
                var Number = Convert.ToDouble(tboxNumber.Text.Trim());
                var Money = Price * Number;


                //简单工厂
                //Money = CashFactory.CreateCashAccecpt(cboxDiscount.SelectedItem.ToString()).AcceptCash(Money);

                //工厂+策略
                Money = new CashContext(cboxDiscount.SelectedItem.ToString()).GetResult(Money);

                TotalPrice += Money;
                listBoxMain.Items.Add($"单价：{Price} 数量：{Number} 合计：{Money}");
                laTotalPrice.Text = TotalPrice.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("输入正确数字");
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tboxPrice.Text = "";
            tboxNumber.Text = "";
            listBoxMain.Items.Clear();
            TotalPrice = 0;
            laTotalPrice.Text = TotalPrice.ToString();
        }
    }
}
