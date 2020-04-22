using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //사실 이 사진 1번을 어디 갔는지 모르겠음... 성진아 안녕... 찾았음.
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("그러나 좀만 있음 다시 고슴도치다.", "빡빡탈출^!^");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("그래^^안녕=="
                , "안녕하세요~!"
                , MessageBoxButtons.OK
                ,MessageBoxIcon.Error);
        }
    }
}
