using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Programda_ne_programı_bilmiom_amq
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void main_btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_btn_open_Click(object sender, EventArgs e)
        {
            string command = main_textb_commandbox.Text;

            // Kontrol edilecek bir komut var mı?
            if (!string.IsNullOrWhiteSpace(command))
            {
                try
                {
                    Process.Start(command);
                    this.Close();
                }
                catch (Exception ex)
                {
                    ErrorBox error = new ErrorBox();
                    error.Show();
                }
            }
            else
            {
                ErrorBox error = new ErrorBox();
                error.Show();
            }
        }

        private void main_textb_commandbox_TextChanged(object sender, EventArgs e)
        {
            bool containsLetter = main_textb_commandbox.Text.Any(char.IsLetter);

            // Butonun görünürlüğünü ayarla
            main_btn_open.Visible = containsLetter;
        }
    }
}
