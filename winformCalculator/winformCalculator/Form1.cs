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
        private void btn0_Click(object sender, EventArgs e)
        {

        }
        private void btnNumber_Click(object sender, EventArgs e)        //取值
        {
            /*if (result != 0 && count1 != 0 && count2 != 0)
            {
                ts = result;
                count1 = 0;
                count2 = 0;
                sign = "";      
            }*/
            if (sign == "")
            {
                if (sign == "" && count1 != 0 && ts == 0)
                {
                    count1 = 0;
                }
                count1 = count1 * 10 + double.Parse(((Button)sender).Text);
                txtShowCount.Text = "";
                txtShow.Text = count1.ToString();
                ts = count1;
                result = 0;
            }      
            else if(sign != "")
            {
                count2 = count2 * 10 + double.Parse(((Button)sender).Text);
                txtShow.Text = count2.ToString();
            }
        }
        private void btnOperator_Click(object sender, EventArgs e)           //取符号   
        {
            if (result != '\0')
            {
                count1 = ts;
                result = '\0';
            }
            txtShowCount.Text = count1.ToString();
            txtShowCount.Text = count1.ToString() + ((Button)sender).Text;     //符号赋给计算区
            sign = ((Button)sender).Text;                                      //符号赋值
        }
        /*public void btnElse(double count1,double count2,string sign)
        {
            if (count1 != 0 && count2 == 0 && sign == "")
            {
                count1 = -count1;
                txtShow.Text = count1.ToString();
            }
            if (count1 != 0 && sign != "" && count2 != 0)
            {
                count2 = -count2;
                txtShow.Text = count2.ToString();
            }
            if (count1 != 0 && sign != "" && count2 == 0)
            {
                count2 = -count1;
                txtShow.Text = count2.ToString();
            }
        }*/
        private void btnNegate_Click(object sender, EventArgs e)               //取反(+/-)
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
            if (count1 !=0 && sign !="" && count2 ==0)
            {
                count2 = -count1;
                txtShow.Text = count2.ToString();
            }
        }
        private void btnReciprocal_Click(object sender, EventArgs e)         //倒数(1/x)
        {
            if (count1 != 0 && count2 == 0 && sign == "")
            {
                count1 = 1/count1;
                txtShowCount.Text = count1.ToString();
            }
            if (count1 != 0 && sign != "" && count2 != 0)
            {
                count2 = 1/count2;
                txtShow.Text = count2.ToString();
            }
            if (count1 != 0 && sign != "" && count2 == 0)
            {
                count2 = 1/count1;
                txtShow.Text = count2.ToString();
            }
        }
        private void BtnSq_Click(object sender, EventArgs e)                 //平方(x²)
        {
            if (count1 != 0 && count2 == 0 && sign == "")
            {
                count1 = count1 * count1;
                txtShowCount.Text = count1.ToString();
            }
            if (count1 != 0 && sign != "" && count2 != 0)
            {
                count2 = count2 * count2;
                txtShow.Text = count2.ToString();
            }
            if (count1 != 0 && sign != "" && count2 == 0)
            {
                count2 = count1 * count1;
                txtShow.Text = count2.ToString();
            }
        }
        private void btnSqrt_Click(object sender, EventArgs e)               //开平方(²√x)
        {
            if (count1 != 0 && count2 == 0 && sign == "")
            {
                count1 = Math.Sqrt(count1);
                txtShowCount.Text = count1.ToString();
            }
            if (count1 != 0 && sign != "" && count2 != 0)
            {
                count2 = Math.Sqrt(count2);
                txtShow.Text = count2.ToString();
            }
            if (count1 != 0 && sign != "" && count2 == 0)
            {
                count2 = Math.Sqrt(count1);
                txtShow.Text = count2.ToString();
            }
        }
        private void btnPoint_Click(object sender, EventArgs e)              //小数点
        {

        }
        private void btnEqual_Click(object sender, EventArgs e)              //运算 
        {
            /*if(result != 0)
                count1 = result;*/
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
            count1 = 0;
            count2 = 0;
            sign = "";        
        }

        private void btnPercent_Click(object sender, EventArgs e)       //百分号(%)
        {
            if (count1 != 0 && count2 == 0 && sign == "")
            {
                count1 = 0;
                txtShow.Text = count1.ToString();
            }
            if (count1 != 0 && sign != "" && count2 != 0)
            {
                count2 = count1*count2/100;
                txtShow.Text = count2.ToString();
                txtShowCount.Text = count2.ToString() + sign + count2.ToString();
            }
        }
        private void btnClear_Click(object sender, EventArgs e)         //清除全部(C)
        {
            ts = 0;
            count1 = 0;
            count2 = 0;
            result = '\0';
            txtShowCount.Text = "";
            txtShow.Text = count1.ToString();
        }

        private void btnClearEntry_Click(object sender, EventArgs e)    //清除结果(CE)
        {
            if (count1 != 0 && count2 == 0 && sign == "")
            {
                count1 = 0;
                txtShowCount.Text = count1.ToString();
            }
            if (count1 != 0 && sign != "" && count2 != 0)
            {
                count2 = 0;
                txtShow.Text = count2.ToString();
            }
            if (count1 != 0 && sign != "" && count2 == 0)
            {
                count2 = 0;
                txtShow.Text = count2.ToString();
            }
            txtShow.Text = "0";
        }
        private void btnBack_Click(object sender, EventArgs e)          //Back
        {
            if (count1 != 0 && count2 == 0 && sign == "")
            {
                count1 = Math.Floor(count1 / 10);      //Math.Floor()取整数的较小数
                txtShow.Text = count1.ToString();
            }
            if (count1 != 0 && sign != "" && count2 != 0)
            {
                if (count2 >= 10)
                    count2 = Math.Floor(count2 / 10);
                else
                    count2 = 0;
                txtShow.Text = count2.ToString();
            }
            if (count1 != 0 && sign != "" && count2 == 0)
            {
                count2 = 0;
                txtShow.Text = count2.ToString();
            }
            if(result!= 0)
            {
                txtShowCount.Text = "";
            }
        }
        private void txtShow_TextChanged(object sender, EventArgs e)    //改变txtBox里数字的大小
        {
            while (txtShow.Text.Length > 10 && txtShow.Font.Size != 18)
            {
                txtShow.Font = new Font(txtShow.Font.FontFamily, 18, txtShow.Font.Style); 
            }
            while (txtShow.Text.Length < 10 && txtShow.Font.Size == 18)
            {
                txtShow.Font = new Font(txtShow.Font.FontFamily, 36, txtShow.Font.Style);
            }
        }

    }
}
