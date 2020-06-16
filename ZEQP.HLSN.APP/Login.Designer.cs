using Camera.Hikvision.Properties;

namespace PreviewDemo
{
    partial class Login
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

            for (int i = 0; i < 9; i++)
            {
                if (m_lRealHandle[i] >= 0)
                {
                    CHCNetSDK.NET_DVR_StopRealPlay(m_lRealHandle[i]);
                }
                if (m_lUserID[i] >= 0)
                {
                    CHCNetSDK.NET_DVR_Logout(m_lUserID[i]);
                }
            } 
           
            if (m_bInitSDK == true)
            {
                CHCNetSDK.NET_DVR_Cleanup();
            }
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.labels1 = new System.Windows.Forms.Label();
            this.labels2 = new System.Windows.Forms.Label();
            this.labels3 = new System.Windows.Forms.Label();
            this.labels4 = new System.Windows.Forms.Label();
            this.labels5 = new System.Windows.Forms.Label();
            this.labels6 = new System.Windows.Forms.Label();
            this.labels7 = new System.Windows.Forms.Label();
            this.labels8 = new System.Windows.Forms.Label();
            this.labels9 = new System.Windows.Forms.Label();
            this.btnJPEG = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBoxport = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPreview2 = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogin.Location = new System.Drawing.Point(325, 237);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(108, 31);
            this.btnLogin.TabIndex = 12;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPreview.Location = new System.Drawing.Point(457, 237);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(108, 31);
            this.btnPreview.TabIndex = 13;
            this.btnPreview.Text = "打开画面";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 22;
            this.label6.Text = "设备端口";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(78, 291);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(110, 21);
            this.textBox9.TabIndex = 20;
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "设备号";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 12);
            this.label9.TabIndex = 27;
            this.label9.Text = "设备1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 29;
            this.label10.Text = "设备2";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 21);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 31;
            this.label11.Text = "设备3";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(78, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 21);
            this.textBox2.TabIndex = 30;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 33;
            this.label12.Text = "设备4";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(78, 129);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(110, 21);
            this.textBox3.TabIndex = 32;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 155);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 35;
            this.label13.Text = "设备5";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(78, 156);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(110, 21);
            this.textBox4.TabIndex = 34;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 182);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 12);
            this.label14.TabIndex = 37;
            this.label14.Text = "设备6";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(78, 183);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(110, 21);
            this.textBox5.TabIndex = 36;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 209);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 12);
            this.label15.TabIndex = 39;
            this.label15.Text = "设备7";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(78, 210);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(110, 21);
            this.textBox6.TabIndex = 38;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 236);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 12);
            this.label16.TabIndex = 41;
            this.label16.Text = "设备8";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(78, 237);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(110, 21);
            this.textBox7.TabIndex = 40;
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 263);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 12);
            this.label17.TabIndex = 43;
            this.label17.Text = "设备9";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(78, 264);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(110, 21);
            this.textBox8.TabIndex = 42;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(188, 11);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 44;
            this.label18.Text = "设备状态";
            // 
            // labels1
            // 
            this.labels1.AutoSize = true;
            this.labels1.Location = new System.Drawing.Point(188, 46);
            this.labels1.Name = "labels1";
            this.labels1.Size = new System.Drawing.Size(71, 12);
            this.labels1.TabIndex = 45;
            this.labels1.Text = "Unconnected";
            // 
            // labels2
            // 
            this.labels2.AutoSize = true;
            this.labels2.Location = new System.Drawing.Point(188, 74);
            this.labels2.Name = "labels2";
            this.labels2.Size = new System.Drawing.Size(71, 12);
            this.labels2.TabIndex = 46;
            this.labels2.Text = "Unconnected";
            // 
            // labels3
            // 
            this.labels3.AutoSize = true;
            this.labels3.Location = new System.Drawing.Point(188, 101);
            this.labels3.Name = "labels3";
            this.labels3.Size = new System.Drawing.Size(71, 12);
            this.labels3.TabIndex = 47;
            this.labels3.Text = "Unconnected";
            // 
            // labels4
            // 
            this.labels4.AutoSize = true;
            this.labels4.Location = new System.Drawing.Point(188, 128);
            this.labels4.Name = "labels4";
            this.labels4.Size = new System.Drawing.Size(71, 12);
            this.labels4.TabIndex = 48;
            this.labels4.Text = "Unconnected";
            // 
            // labels5
            // 
            this.labels5.AutoSize = true;
            this.labels5.Location = new System.Drawing.Point(188, 155);
            this.labels5.Name = "labels5";
            this.labels5.Size = new System.Drawing.Size(71, 12);
            this.labels5.TabIndex = 49;
            this.labels5.Text = "Unconnected";
            // 
            // labels6
            // 
            this.labels6.AutoSize = true;
            this.labels6.Location = new System.Drawing.Point(188, 182);
            this.labels6.Name = "labels6";
            this.labels6.Size = new System.Drawing.Size(71, 12);
            this.labels6.TabIndex = 50;
            this.labels6.Text = "Unconnected";
            // 
            // labels7
            // 
            this.labels7.AutoSize = true;
            this.labels7.Location = new System.Drawing.Point(188, 209);
            this.labels7.Name = "labels7";
            this.labels7.Size = new System.Drawing.Size(71, 12);
            this.labels7.TabIndex = 51;
            this.labels7.Text = "Unconnected";
            // 
            // labels8
            // 
            this.labels8.AutoSize = true;
            this.labels8.Location = new System.Drawing.Point(188, 236);
            this.labels8.Name = "labels8";
            this.labels8.Size = new System.Drawing.Size(71, 12);
            this.labels8.TabIndex = 52;
            this.labels8.Text = "Unconnected";
            // 
            // labels9
            // 
            this.labels9.AutoSize = true;
            this.labels9.Location = new System.Drawing.Point(188, 263);
            this.labels9.Name = "labels9";
            this.labels9.Size = new System.Drawing.Size(71, 12);
            this.labels9.TabIndex = 53;
            this.labels9.Text = "Unconnected";
            // 
            // btnJPEG
            // 
            this.btnJPEG.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnJPEG.Location = new System.Drawing.Point(390, 327);
            this.btnJPEG.Name = "btnJPEG";
            this.btnJPEG.Size = new System.Drawing.Size(108, 37);
            this.btnJPEG.TabIndex = 54;
            this.btnJPEG.Text = "抓图";
            this.btnJPEG.UseVisualStyleBackColor = false;
            this.btnJPEG.Click += new System.EventHandler(this.btnJPEG_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.labels9);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.labels8);
            this.panel1.Controls.Add(this.labels5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.labels7);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.labels6);
            this.panel1.Controls.Add(this.labels1);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.labels2);
            this.panel1.Controls.Add(this.labels4);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.labels3);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(23, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 295);
            this.panel1.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 16;
            this.label5.Text = "设备IP";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Location = new System.Drawing.Point(87, 91);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(115, 21);
            this.textBoxPassword.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 12);
            this.label8.TabIndex = 23;
            this.label8.Text = "密码";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "User Name";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(87, 28);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(114, 21);
            this.textBoxUserName.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 26;
            this.label7.Text = "用户名";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.textBoxUserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxPassword);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.textBoxport);
            this.panel2.Location = new System.Drawing.Point(325, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 180);
            this.panel2.TabIndex = 56;
            // 
            // textBoxport
            // 
            this.textBoxport.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBoxport.Location = new System.Drawing.Point(86, 149);
            this.textBoxport.Name = "textBoxport";
            this.textBoxport.Size = new System.Drawing.Size(49, 21);
            this.textBoxport.TabIndex = 17;
            this.textBoxport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox10
            // 
            this.textBox10.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox10.Location = new System.Drawing.Point(147, 336);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(108, 21);
            this.textBox10.TabIndex = 27;
            this.textBox10.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 27;
            this.label2.Text = "抓图设备号";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(325, 281);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(108, 31);
            this.btnLogout.TabIndex = 57;
            this.btnLogout.Text = "注销全部";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPreview2
            // 
            this.btnPreview2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPreview2.Location = new System.Drawing.Point(457, 281);
            this.btnPreview2.Name = "btnPreview2";
            this.btnPreview2.Size = new System.Drawing.Size(108, 31);
            this.btnPreview2.TabIndex = 58;
            this.btnPreview2.Text = "关闭画面";
            this.btnPreview2.UseVisualStyleBackColor = false;
            this.btnPreview2.Click += new System.EventHandler(this.btnPreview2_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(23, 11);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(59, 12);
            this.labelLogin.TabIndex = 59;
            this.labelLogin.Text = "登录状态:";
            this.labelLogin.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(580, 376);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.btnPreview2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.btnJPEG);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "监控终端";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label labels1;
        private System.Windows.Forms.Label labels2;
        private System.Windows.Forms.Label labels3;
        private System.Windows.Forms.Label labels4;
        private System.Windows.Forms.Label labels5;
        private System.Windows.Forms.Label labels6;
        private System.Windows.Forms.Label labels7;
        private System.Windows.Forms.Label labels8;
        private System.Windows.Forms.Label labels9;
        private System.Windows.Forms.Button btnJPEG;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBoxport;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPreview2;
        private System.Windows.Forms.Label labelLogin;
    }
}