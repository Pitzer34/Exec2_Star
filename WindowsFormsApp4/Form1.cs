using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtStar.Text = string.Empty;
        }
        int rows = 0;
        
        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                rows = GetRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string LeftStar = MethodLeftStar(rows);

            DisplayStar(LeftStar);

        }

        private void btnMid_Click(object sender, EventArgs e)
        {
            try
            {
                rows = GetRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            string MidStar = MethodMidStar(rows);

            DisplayStar(MidStar);
        }
        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                rows = GetRows();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return ;
            }

            string RightStar = MethodRightStar(rows);

            DisplayStar(RightStar);
        }
        private string MethodLeftStar(int rows)
        {
            string result = string.Empty;

            for (int i = 1; i <= rows; i++)
            {
                result += new string('*', i) + "\r\n";
            }
            return result;
        }
        private string MethodMidStar(int rows)
        {
            string result = string.Empty;

            for (int i = 1; i <= rows; i++)
            {
                result += new string(' ', rows-i)+ new string('*', i) + "\r\n";
            }
            return result;
        }

        private string MethodRightStar(int rows)
        {
            string result = string.Empty;

            for (int i = 1; i <= rows; i++)
            {
                result += new string(' ', 2*rows - 2*i) + new string('*', i) + "\r\n";
            }
            return result;
        }

        private int GetRows()
        {
            string input = txtBox1.Text;
            bool isInt = int.TryParse(input, out int rows );

            if (isInt == false)
            {
                throw new Exception("列數參數錯誤");
            }
            if (rows <= 1 || rows > 10)
            {
                throw new Exception("列數需在0~10之間");
            }
            return rows;
        }
        private void DisplayStar(string print)
        {
            
            txtStar.Text = print;
            
        }
    }  
}
