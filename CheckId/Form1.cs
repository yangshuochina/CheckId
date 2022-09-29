using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckId
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String m_strOriginNum = "";
        String m_strValidatedNum = "";
    
        public readonly int[] m_weight = { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };    //十七位数字本体码权重
        public readonly char[] m_validate = { '1', '0', 'X', '9', '8', '7', '6', '5', '4', '3', '2' };    //mod11,对应校验码字符值    
        
        private char[] m_NumToValidate;
        private void btnCalcNum_Click(object sender, EventArgs e)
        {
            int i, j;
            String strTemp;
            m_strOriginNum = tbIdNum.Text;
            //MessageBox.Show(m_strOriginIdNum);
            m_NumToValidate = new char[18];

            if (CheckInputNum(m_strOriginNum) == false)
            {
                MessageBox.Show("号码长度必须为18位！(仅第11到14位可以忽略。)", "Error");
            }
            else
            {
                //输入数字符合要求，开始校验所有可能的号码

                tbResultNum.Text = ""; 
                for (i=1; i <= 12; i++)
                {
                    for (j=1; j<=31; j++)
                    {
                        if ((i == 4 || i == 6 || i == 9 || i == 11) && j == 31) break;
                        if ((i == 2) && (j >= 30)) break;

                        // 开始有效日期验证
                        m_NumToValidate[10] = (char)(i / 10 + (byte)'0');
                        m_NumToValidate[11] = (char)(i % 10 + (byte)'0');
                        m_NumToValidate[12] = (char)(j / 10 + (byte)'0');
                        m_NumToValidate[13] = (char)(j % 10 + (byte)'0');
                        if (true == CheckValidateCode(m_NumToValidate))
                        {
                            strTemp = new string(m_NumToValidate);
                            tbResultNum.Text += strTemp  + "\r\n";
                        }

                    }
                }
            }
        }
        private bool CheckValidateCode(char[] numChar)
        {
            byte[]  num = new byte[18];
            char ch;
            int i;
            int sum = 0;
            int mode = 0;
            for (i=0; i < 18; i++)
            {
                ch = numChar[i];
                if ((i <= 16) || (i == 17 && ch != 'X'))
                {
                    num[i] = (byte)(ch - '0');
                } 
                else
                {
                    num[i] = 10;
                }
            }
            // 计算加权和以及余数
            for (i=0; i < 17; i++)
            {
                sum += num[i] * m_weight[i];
            }
            mode = sum % 11;

            if (mode == num[17])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool CheckInputNum(String strNum)
        {
            char c;
            bool result = true;

            if (strNum.Length != 18)
            {
                result = false;
            }
            for (int i=0; i<18; i++)
            {
                c = strNum[i];
                if ((c >= '0' && c <= '9') ||
                    (i >= 10 && i <= 13) ||
                    (i==17 && c =='X'))
                {
                    m_NumToValidate[i] = c;
                    continue;
                }
                else
                {
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
