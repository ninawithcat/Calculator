using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformCalculator
{
    public partial class Form1 : Form
    {
        public double count1 = 0;     //计数器1（用于两数计算）
        public double count2 = 0;     //计数器2（用于两数计算）
        public double result = 0;     //结果
        public double ts = 0;         //暂存
        public string sign = "";      //符号
        public bool negate = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNumber_Click(object sender, EventArgs e)        //取值
        {
            if (sign == "")
            {
                if (sign == "" && count1 != 0 && result == 0)
                {
                    count1 = 0;
                }
                count1 = count1 * 10 + double.Parse(((Button)sender).Text);
                txtShowCount.Text = "";
                txtShow.Text = count1.ToString();
                ts = count1;
            }      
            else if(sign != "")
            {
                count2 = count2 * 10 + double.Parse(((Button)sender).Text);
                txtShow.Text = count2.ToString();
            }
        }
        private void btnOperator_Click(object sender, EventArgs e)           //取符号   
        {
            if (ts != '\0')
            {
                count1 = ts;
                ts = '\0';
            }
            txtShowCount.Text = count1.ToString();
            txtShowCount.Text = txtShowCount.Text + ((Button)sender).Text;     //符号赋给计算区
            sign = ((Button)sender).Text;                                      //符号赋值
        }
        private void btnNegate_Click(object sender, EventArgs e)               //取反
        {
            if (count1 != 0 && count2 == 0 && sign =="")
            {
                count1 = -count1;
                txtShow.Text = count1.ToString();
            }
            if (count1 !=0 && sign !="" && count2 !=0)
            {
                count2 = -count2;
                txtShow.Text = count2.ToString();
            }
            if (count1 !=0 && sign =="" && count2 !=0)
            {
                count2 = -count1;
                txtShow.Text = count2.ToString();
            }

        }
        private void btnReciprocal_Click(object sender, EventArgs e)         //倒数
        {

        }
        private void btnEqual_Click(object sender, EventArgs e)              //运算 
        {
                switch (sign)
                {
                    case "+":
                        result = count1 + count2;
                        break;

                    case "-":
                        result = count1 - count2;
                        break;

                    case "×":
                        result = count1 * count2;
                        break;

                    case "÷":
                        result = count1 / count2;
                        break;
                }

            if (sign != "" )
            {
                txtShowCount.Text = count1.ToString() + sign + count2.ToString() + "=";
                txtShow.Text = Convert.ToString(result);
            }
            ts = result;
            result = 0;
            count1 = 0;
            count2 = 0;
            sign = "";
            
        }
        private void btnClear_Click(object sender, EventArgs e)         //清除全部(C)
        {
            count1 = 0;
            count2 = 0;
            txtShow.Text = "";
            txtShowCount.Text = "";
        }

        private void btnClearEntry_Click(object sender, EventArgs e)    //清除结果(CE)
        {
            txtShow.Text = "";
        }

    }
}
