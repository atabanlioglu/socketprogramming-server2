namespace Server_Computer
{
    partial class Server_Computer
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
        /// [ClassInterfaceAttribute(ClassInterfaceType.AutoDispatch)]
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.btn_Dinle = new System.Windows.Forms.Button();
            this.btn_Durdur = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_AlınanVeri = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(13, 94);
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(75, 20);
            this.txt_Port.TabIndex = 1;
            // 
            // btn_Dinle
            // 
            this.btn_Dinle.Location = new System.Drawing.Point(13, 120);
            this.btn_Dinle.Name = "btn_Dinle";
            this.btn_Dinle.Size = new System.Drawing.Size(75, 38);
            this.btn_Dinle.TabIndex = 2;
            this.btn_Dinle.Text = "Dinle";
            this.btn_Dinle.UseVisualStyleBackColor = true;
            this.btn_Dinle.Click += new System.EventHandler(this.btn_Dinle_Click);
            // 
            // btn_Durdur
            // 
            this.btn_Durdur.Location = new System.Drawing.Point(13, 164);
            this.btn_Durdur.Name = "btn_Durdur";
            this.btn_Durdur.Size = new System.Drawing.Size(75, 38);
            this.btn_Durdur.TabIndex = 3;
            this.btn_Durdur.Text = "Durdur";
            this.btn_Durdur.UseVisualStyleBackColor = true;
            this.btn_Durdur.Click += new System.EventHandler(this.btn_Durdur_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Port Numarası";
            // 
            // txt_AlınanVeri
            // 
            this.txt_AlınanVeri.FormattingEnabled = true;
            this.txt_AlınanVeri.HorizontalScrollbar = true;
            this.txt_AlınanVeri.IntegralHeight = false;
            this.txt_AlınanVeri.Location = new System.Drawing.Point(120, 7);
            this.txt_AlınanVeri.Name = "txt_AlınanVeri";
            this.txt_AlınanVeri.Size = new System.Drawing.Size(1133, 406);
            this.txt_AlınanVeri.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_Port);
            this.groupBox1.Controls.Add(this.btn_Dinle);
            this.groupBox1.Controls.Add(this.btn_Durdur);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(102, 209);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(10, 46);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "İp Adresi :";
            // 
            // Server_Computer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1265, 416);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_AlınanVeri);
            this.Name = "Server_Computer";
            this.Text = "Server";
            this.Load += new System.EventHandler(this.Server_Computer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Button btn_Dinle;
        private System.Windows.Forms.Button btn_Durdur;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox txt_AlınanVeri;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label2;
    }
}

