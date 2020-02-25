using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeviceMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            bool flag = true;

            for (int i = 0; i < 15; i++)
            {
                DevController devController = new DevController();
                devController.MouseClick += new MouseEventHandler(btn_OnClick);
                flowLayoutPanel1.Controls.Add(devController);
            }

            for (int i = 0;i < 32; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = i.ToString() + "QWEWDJK";
                this.listView1.Items.Add(item);
            }
        }

        private void btn_OnClick(object sender, MouseEventArgs e)
        {
            UserControl uc = (UserControl)sender;
            flowLayoutPanel1.Controls[flowLayoutPanel1.Controls.IndexOf(uc)].BackColor = Color.MediumSeaGreen;
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }
    }
}
