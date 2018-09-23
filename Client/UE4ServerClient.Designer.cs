namespace DSManager
{
    partial class DSManager
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DSManager));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.T_Return = new System.Windows.Forms.TextBox();
            this.Server_Clear_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Client_Close_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ServerDataList = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // T_Return
            // 
            this.T_Return.BackColor = System.Drawing.Color.LightSlateGray;
            this.T_Return.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.T_Return.Location = new System.Drawing.Point(98, 40);
            this.T_Return.Multiline = true;
            this.T_Return.Name = "T_Return";
            this.T_Return.Size = new System.Drawing.Size(170, 27);
            this.T_Return.TabIndex = 0;
            // 
            // Server_Clear_btn
            // 
            this.Server_Clear_btn.BackColor = System.Drawing.Color.Transparent;
            this.Server_Clear_btn.BackgroundImage = global::DSManager.Properties.Resources.Server_Clear_btn;
            this.Server_Clear_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Server_Clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Server_Clear_btn.Location = new System.Drawing.Point(902, 40);
            this.Server_Clear_btn.Name = "Server_Clear_btn";
            this.Server_Clear_btn.Size = new System.Drawing.Size(132, 36);
            this.Server_Clear_btn.TabIndex = 2;
            this.Server_Clear_btn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Client_Close_btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 87);
            this.panel1.TabIndex = 3;
            // 
            // Client_Close_btn
            // 
            this.Client_Close_btn.BackgroundImage = global::DSManager.Properties.Resources.Client_Close_btn;
            this.Client_Close_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Client_Close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Client_Close_btn.Location = new System.Drawing.Point(1256, 3);
            this.Client_Close_btn.Name = "Client_Close_btn";
            this.Client_Close_btn.Size = new System.Drawing.Size(21, 17);
            this.Client_Close_btn.TabIndex = 4;
            this.Client_Close_btn.UseVisualStyleBackColor = true;
            this.Client_Close_btn.Click += new System.EventHandler(this.Client_Close_btn_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DSManager.Properties.Resources.Client_Content_Bg;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(0, 99);
            this.panel2.Margin = new System.Windows.Forms.Padding(300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(210, 622);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::DSManager.Properties.Resources.Client_Content_Bg;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(221, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1059, 622);
            this.panel3.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::DSManager.Properties.Resources.Client_Content_Header_Bg;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Controls.Add(this.ServerDataList);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1057, 320);
            this.panel5.TabIndex = 4;
            // 
            // ServerDataList
            // 
            this.ServerDataList.BackColor = System.Drawing.Color.Black;
            this.ServerDataList.BackgroundImage = global::DSManager.Properties.Resources.Client_Content_Bg;
            this.ServerDataList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServerDataList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ServerDataList.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ServerDataList.Location = new System.Drawing.Point(16, 13);
            this.ServerDataList.Name = "ServerDataList";
            this.ServerDataList.Size = new System.Drawing.Size(1030, 290);
            this.ServerDataList.TabIndex = 2;
            this.ServerDataList.UseCompatibleStateImageBehavior = false;
            this.ServerDataList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::DSManager.Properties.Resources.Client_Content_Bttm_Bg;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Controls.Add(this.button1);
            this.panel4.Controls.Add(this.T_Return);
            this.panel4.Controls.Add(this.Server_Clear_btn);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 508);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1057, 112);
            this.panel4.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::DSManager.Properties.Resources.Server_Refresh;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(766, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 36);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DSManager
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::DSManager.Properties.Resources.Client_bg;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DSManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DSManager_FormClosed);
            this.Load += new System.EventHandler(this.DSManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox T_Return;
        private System.Windows.Forms.Button Server_Clear_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ListView ServerDataList;
        private System.Windows.Forms.Button Client_Close_btn;
    }
}

