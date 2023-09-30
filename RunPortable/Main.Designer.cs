namespace Programda_ne_programı_bilmiom_amq
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.main_pnl_functionpanel = new System.Windows.Forms.Panel();
            this.main_btn_open = new System.Windows.Forms.Button();
            this.main_btn_cancel = new System.Windows.Forms.Button();
            this.main_lbl_run = new System.Windows.Forms.Label();
            this.main_lbl_explain = new System.Windows.Forms.Label();
            this.main_lbl_explain2 = new System.Windows.Forms.Label();
            this.main_textb_commandbox = new System.Windows.Forms.TextBox();
            this.main_pbox_runportableicon = new System.Windows.Forms.PictureBox();
            this.main_pnl_functionpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_pbox_runportableicon)).BeginInit();
            this.SuspendLayout();
            // 
            // main_pnl_functionpanel
            // 
            this.main_pnl_functionpanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.main_pnl_functionpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.main_pnl_functionpanel.Controls.Add(this.main_btn_open);
            this.main_pnl_functionpanel.Controls.Add(this.main_btn_cancel);
            this.main_pnl_functionpanel.Location = new System.Drawing.Point(-3, 110);
            this.main_pnl_functionpanel.Name = "main_pnl_functionpanel";
            this.main_pnl_functionpanel.Size = new System.Drawing.Size(477, 100);
            this.main_pnl_functionpanel.TabIndex = 0;
            // 
            // main_btn_open
            // 
            this.main_btn_open.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.main_btn_open.Location = new System.Drawing.Point(282, 46);
            this.main_btn_open.Name = "main_btn_open";
            this.main_btn_open.Size = new System.Drawing.Size(75, 23);
            this.main_btn_open.TabIndex = 1;
            this.main_btn_open.Text = "Open";
            this.main_btn_open.UseVisualStyleBackColor = true;
            this.main_btn_open.Visible = false;
            this.main_btn_open.Click += new System.EventHandler(this.main_btn_open_Click);
            // 
            // main_btn_cancel
            // 
            this.main_btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.main_btn_cancel.Location = new System.Drawing.Point(363, 46);
            this.main_btn_cancel.Name = "main_btn_cancel";
            this.main_btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.main_btn_cancel.TabIndex = 0;
            this.main_btn_cancel.Text = "Cancel";
            this.main_btn_cancel.UseVisualStyleBackColor = true;
            this.main_btn_cancel.Click += new System.EventHandler(this.main_btn_cancel_Click);
            // 
            // main_lbl_run
            // 
            this.main_lbl_run.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.main_lbl_run.AutoSize = true;
            this.main_lbl_run.Location = new System.Drawing.Point(12, 82);
            this.main_lbl_run.Name = "main_lbl_run";
            this.main_lbl_run.Size = new System.Drawing.Size(30, 13);
            this.main_lbl_run.TabIndex = 0;
            this.main_lbl_run.Text = "Run:";
            // 
            // main_lbl_explain
            // 
            this.main_lbl_explain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.main_lbl_explain.AutoSize = true;
            this.main_lbl_explain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.main_lbl_explain.Location = new System.Drawing.Point(67, 30);
            this.main_lbl_explain.Name = "main_lbl_explain";
            this.main_lbl_explain.Size = new System.Drawing.Size(374, 15);
            this.main_lbl_explain.TabIndex = 2;
            this.main_lbl_explain.Text = "Type the name of a Program, folder, document or Internet Resource";
            // 
            // main_lbl_explain2
            // 
            this.main_lbl_explain2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.main_lbl_explain2.AutoSize = true;
            this.main_lbl_explain2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.main_lbl_explain2.Location = new System.Drawing.Point(67, 47);
            this.main_lbl_explain2.Name = "main_lbl_explain2";
            this.main_lbl_explain2.Size = new System.Drawing.Size(203, 15);
            this.main_lbl_explain2.TabIndex = 3;
            this.main_lbl_explain2.Text = "and RunPortable will open it for you.";
            // 
            // main_textb_commandbox
            // 
            this.main_textb_commandbox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.main_textb_commandbox.Location = new System.Drawing.Point(70, 79);
            this.main_textb_commandbox.Name = "main_textb_commandbox";
            this.main_textb_commandbox.Size = new System.Drawing.Size(365, 20);
            this.main_textb_commandbox.TabIndex = 4;
            this.main_textb_commandbox.TextChanged += new System.EventHandler(this.main_textb_commandbox_TextChanged);
            // 
            // main_pbox_runportableicon
            // 
            this.main_pbox_runportableicon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.main_pbox_runportableicon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("main_pbox_runportableicon.BackgroundImage")));
            this.main_pbox_runportableicon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.main_pbox_runportableicon.Location = new System.Drawing.Point(7, 12);
            this.main_pbox_runportableicon.Name = "main_pbox_runportableicon";
            this.main_pbox_runportableicon.Size = new System.Drawing.Size(58, 50);
            this.main_pbox_runportableicon.TabIndex = 5;
            this.main_pbox_runportableicon.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(447, 191);
            this.Controls.Add(this.main_pbox_runportableicon);
            this.Controls.Add(this.main_textb_commandbox);
            this.Controls.Add(this.main_lbl_explain2);
            this.Controls.Add(this.main_lbl_explain);
            this.Controls.Add(this.main_lbl_run);
            this.Controls.Add(this.main_pnl_functionpanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 765);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Run";
            this.main_pnl_functionpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.main_pbox_runportableicon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button main_btn_open;
        private System.Windows.Forms.Button main_btn_cancel;
        public System.Windows.Forms.Panel main_pnl_functionpanel;
        public System.Windows.Forms.Label main_lbl_run;
        public System.Windows.Forms.Label main_lbl_explain;
        public System.Windows.Forms.Label main_lbl_explain2;
        public System.Windows.Forms.TextBox main_textb_commandbox;
        private System.Windows.Forms.PictureBox main_pbox_runportableicon;
    }
}

