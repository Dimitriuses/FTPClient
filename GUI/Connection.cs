using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Connection : Form
    {
        public Client client { get; set; }
        public Connection()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string host = $"{numericUpDown1.Value.ToString()}.{numericUpDown2.Value.ToString()}.{numericUpDown3.Value.ToString()}.{numericUpDown4.Value.ToString()}:{numericUpDownPort.Value.ToString()}";
            client = new Client(host, textBoxLogin.Text, textBox1.Text);
        }
    }
}
