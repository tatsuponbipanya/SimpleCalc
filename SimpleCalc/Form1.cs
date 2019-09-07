using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int left = InputCheck(textBox1.Text, out left);
            int right = InputCheck(textBox2.Text, out right);

            int answer = left + right;

            textBox3.Text = answer.ToString();

        }

        //以下サブルーチン。
        private int InputCheck(string textValue, out int value)

        {
            if(int.TryParse(textValue, out value) == true)　　//もしintに変換出来たらそのまま値を返す。
            {
                value = int.Parse(textValue);
    }
            else　　                                         //intに変換出来ない場合は0として扱う。
            {
                value = 0;
            }
            return value; 

        }


    }
}
