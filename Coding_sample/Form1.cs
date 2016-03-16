using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;
using OrangeCryptHelper;

namespace Coding_sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var _Crypt = new OrangeCryptMethods();
                // サンプルのQRコード文字列
                string _SourceQRString = textBox1.Text;
                // サンプルのローテート値
                int _Rot = int.Parse(comboBox1.Text);

                if (radioButton1.Checked)
                {
                    // 暗号化
                    string _EncryptedString = _Crypt.Encrypt(_SourceQRString, _Rot);
                    // 暗号化文字列の表示
                    textBox2.Text = _EncryptedString;
                }
                if (radioButton2.Checked)
                {
                    // 復号化
                    string _DectyptedString = _Crypt.Decrypt(textBox1.Text, _Rot);
                    // 復号化文字列の表示
                    textBox2.Text = _DectyptedString;
                    // 復号化正常性チェック
                    //System.Diagnostics.Debug.Assert(
                    //_Crypt.Decrypt(textBox1.Text, _Rot) == _SourceQRString, "Decrypt Error"
                    //);
                }

            }
            catch { }

        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            label3.Text = "暗号化された文字列";
        }

        private void radioButton2_Click(object sender, EventArgs e)
        {
            label3.Text = "復号化された文字列";
        }
    }
}
