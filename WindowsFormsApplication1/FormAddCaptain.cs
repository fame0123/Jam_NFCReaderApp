using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormAddCaptain : Form
    {
        public FormAddCaptain()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void link_add_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Size = new Size(319, 330);
        }

        private void FormAddCaptain_Load(object sender, EventArgs e)
        {
            this.Size = new Size(319, 133);
            
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
