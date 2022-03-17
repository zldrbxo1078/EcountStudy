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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //함수
        //EventHandler 라는 delegator를 통해 자동 등록됨
        //click 사건 발생 시 해당 함수가 자동 호출된다.
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("이벤트 동작");
        }
    }
}
