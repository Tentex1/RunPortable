using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programda_ne_programı_bilmiom_amq
{
    public partial class ErrorBox : Form
    {
        public ErrorBox()
        {
            InitializeComponent();
            ebox_lbl_error.Text = "- RunPortable Cannot Find This File. Make sure you spelled the name correctly and try again.";
        }

        private void ebox_lbl_error_Click(object sender, EventArgs e)
        {
            
        }

        private void ebox_btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
