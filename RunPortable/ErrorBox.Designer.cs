namespace Programda_ne_programı_bilmiom_amq
{
    partial class ErrorBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ErrorBox));
            this.ebox_lbl_error = new System.Windows.Forms.Label();
            this.ebox_btn_ok = new System.Windows.Forms.Button();
            this.main_pnl_functionpanel = new System.Windows.Forms.Panel();
            this.ebox_pbox_erroricon = new System.Windows.Forms.PictureBox();
            this.main_pnl_functionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ebox_pbox_erroricon)).BeginInit();
            this.SuspendLayout();
            // 
            // ebox_lbl_error
            // 
            this.ebox_lbl_error.AutoSize = true;
            this.ebox_lbl_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.ebox_lbl_error.Location = new System.Drawing.Point(63, 21);
            this.ebox_lbl_error.Name = "ebox_lbl_error";
            this.ebox_lbl_error.Size = new System.Drawing.Size(0, 13);
            this.ebox_lbl_error.TabIndex = 0;
            this.ebox_lbl_error.Click += new System.EventHandler(this.ebox_lbl_error_Click);
            // 
            // ebox_btn_ok
            // 
            this.ebox_btn_ok.Location = new System.Drawing.Point(518, 13);
            this.ebox_btn_ok.Name = "ebox_btn_ok";
            this.ebox_btn_ok.Size = new System.Drawing.Size(75, 26);
            this.ebox_btn_ok.TabIndex = 1;
            this.ebox_btn_ok.Text = "Okay";
            this.ebox_btn_ok.UseVisualStyleBackColor = true;
            this.ebox_btn_ok.Click += new System.EventHandler(this.ebox_btn_ok_Click);
            // 
            // main_pnl_functionpanel
            // 
            this.main_pnl_functionpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.main_pnl_functionpanel.Controls.Add(this.ebox_btn_ok);
            this.main_pnl_functionpanel.Location = new System.Drawing.Point(-1, 56);
            this.main_pnl_functionpanel.Name = "main_pnl_functionpanel";
            this.main_pnl_functionpanel.Size = new System.Drawing.Size(622, 99);
            this.main_pnl_functionpanel.TabIndex = 2;
            // 
            // ebox_pbox_erroricon
            // 
            this.ebox_pbox_erroricon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ebox_pbox_erroricon.BackgroundImage")));
            this.ebox_pbox_erroricon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ebox_pbox_erroricon.Location = new System.Drawing.Point(12, 12);
            this.ebox_pbox_erroricon.Name = "ebox_pbox_erroricon";
            this.ebox_pbox_erroricon.Size = new System.Drawing.Size(45, 37);
            this.ebox_pbox_erroricon.TabIndex = 3;
            this.ebox_pbox_erroricon.TabStop = false;
            // 
            // ErrorBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 102);
            this.Controls.Add(this.ebox_pbox_erroricon);
            this.Controls.Add(this.ebox_lbl_error);
            this.Controls.Add(this.main_pnl_functionpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ErrorBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error: 37767";
            this.main_pnl_functionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ebox_pbox_erroricon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label ebox_lbl_error;
        private System.Windows.Forms.Button ebox_btn_ok;
        public System.Windows.Forms.Panel main_pnl_functionpanel;
        private System.Windows.Forms.PictureBox ebox_pbox_erroricon;
    }
}