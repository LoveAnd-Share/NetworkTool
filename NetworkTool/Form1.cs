using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkTool
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add(Reqenum.Get);
            comboBox1.Items.Add(Reqenum.Post);
            comboBox1.Items.Add(Reqenum.Put);
            comboBox1.Items.Add(Reqenum.Delete);
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string url = url_textBox.Text;
            string json = "11";
            url.RequestHelper(Reqenum.Get,json);
        }
    }
}
