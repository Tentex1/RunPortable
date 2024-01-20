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

        private void Main_Load(object sender, EventArgs e)
        {
            main_textb_commandbox.Focus();
            main_textb_commandbox.Select();
            Screen screen = Screen.FromControl(this);
            int left = screen.WorkingArea.Left;
            int bottom = screen.WorkingArea.Bottom - this.Height; 
            
            this.Location = new System.Drawing.Point(left, bottom);
        }

        private void main_btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_btn_open_Click(object sender, EventArgs e)
        {
            string command = main_textb_commandbox.Text;
            
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool containsLetter = main_textb_commandbox.Text.Any(char.IsLetter);
            
            main_btn_open.Enabled = containsLetter;
        }

        private void main_btn_browse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Dosya Seç";
                openFileDialog.Filter = "Tüm Dosyalar|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    main_textb_commandbox.Text = openFileDialog.FileName;
                }
            }
        }
    }
}
