using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;

namespace Scale12
{
    public partial class Scale12 : Form
    {
        readonly int[] scale12int = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        readonly string[] scale12eng = { "C", "C#(D♭)", "D", "D#(E♭)", "E", "F", "F#(G♭)", "G", "G#(A♭)", "A", "A#(B♭)", "B" };
        readonly string[] scale12jp = { "ハ", "嬰ハ(変ニ)", "ニ", "嬰ニ(変ホ)", "ホ", "ヘ", "嬰ヘ(変ト)", "ト", "嬰ト(変イ)", "イ", "嬰イ(変ロ)", "ロ", };
        readonly string[] scale12dig = { "完全1度", "短2度", "長2度", "短3度", "長3度", "完全4度", "増4度(減5度)", "完全5度", "短6度", "長6度", "短7度", "長7度" };
        readonly string[] scale12sona = { "協和", "不協和", "不協和", "不完全協和", "不完全協和", "協和", "不協和", "協和", "不完全協和", "不完全協和", "不協和", "不協和" };

        public Scale12()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select_str = comboBox1.SelectedItem.ToString();
            int select_int = int.Parse(select_str) - 1;
            lbl1.Text = "英表記  " + scale12eng[select_int] +
                        "\n日本表記  " + scale12jp[select_int];
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select_str = comboBox2.SelectedItem.ToString();
            int select_int = ToMath(select_str);
            lbl2.Text = "数表記  " + scale12int[select_int] +
                        "\n日本表記  " + scale12jp[select_int];
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select_str = comboBox3.SelectedItem.ToString();
            int select_int = ToMath(select_str);
            lbl3.Text = "数表記  " + scale12int[select_int] +
                        "\n英表記  " + scale12eng[select_int];
        }
        
        public int ToMath(string s) 
        {
            int toMath = 0;
            int magic = 0;
            for (var i = 0; i < scale12int.Length; i++)
            {
                if (scale12eng[i] == s)
                {
                    toMath = i;
                }
                else if (scale12jp[i] == s)
                {
                    toMath = i;
                }
                else if (int.TryParse(s, out magic)) 
                {
                    magic = int.Parse(s);
                    if (magic == scale12int[i])
                    {
                        toMath = i;
                    }
                }
            }
            return toMath;
        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string select4_str = comboBox4.SelectedItem.ToString();
            int select4_int = ToMath(select4_str);
            string select5_str = comboBox5.SelectedItem.ToString();
            int select5_int = ToMath(select5_str);
            int absTone = select4_int <= select5_int ? select5_int - select4_int : select4_int - select5_int;
            lbl6.Text = "半音数  " + absTone +
                        "\n度数  " + scale12dig[absTone] +
                        "\n協和性  " + scale12sona[absTone];

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select4_str = comboBox4.SelectedItem.ToString();
            int select4_int = ToMath(select4_str);
            string select5_str = comboBox5.SelectedItem.ToString();
            int select5_int = ToMath(select5_str);
            int absTone = select4_int <= select5_int ? select5_int - select4_int : select4_int - select5_int;
            lbl6.Text = "半音数  " + absTone +
                        "\n度数  " + scale12dig[absTone] +
                        "\n協和性  " + scale12sona[absTone];
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            string select4_str = comboBox4.SelectedItem.ToString();
            int select4_int = ToMath(select4_str);
            string select5_str = comboBox5.SelectedItem.ToString();
            int select5_int = ToMath(select5_str);
            int absTone = select4_int <= select5_int ? select5_int - select4_int : select4_int - select5_int;
            lbl6.Text = "半音数  " + absTone +
                        "\n度数  " + scale12dig[absTone] +
                        "\n協和性  " + scale12sona[absTone];
        }
    }
}
