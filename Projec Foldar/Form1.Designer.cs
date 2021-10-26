
namespace Finite_Automata
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTopic = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.panelDrag = new System.Windows.Forms.Panel();
            this.pctMinimize = new System.Windows.Forms.PictureBox();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.panelDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTopic.Location = new System.Drawing.Point(38, 38);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(225, 37);
            this.lblTopic.TabIndex = 0;
            this.lblTopic.Text = "LOGIN PAGE";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pctLogo);
            this.panel1.Controls.Add(this.panelDrag);
            this.panel1.Controls.Add(this.lblTopic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 90);
            this.panel1.TabIndex = 4;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = ((System.Drawing.Image)(resources.GetObject("pctLogo.Image")));
            this.pctLogo.Location = new System.Drawing.Point(257, 32);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(51, 50);
            this.pctLogo.TabIndex = 11;
            this.pctLogo.TabStop = false;
            // 
            // panelDrag
            // 
            this.panelDrag.Controls.Add(this.pctMinimize);
            this.panelDrag.Controls.Add(this.pctExit);
            this.panelDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrag.Location = new System.Drawing.Point(0, 0);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(422, 26);
            this.panelDrag.TabIndex = 10;
            this.panelDrag.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDrag_MouseDown);
            // 
            // pctMinimize
            // 
            this.pctMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pctMinimize.Image")));
            this.pctMinimize.Location = new System.Drawing.Point(377, 3);
            this.pctMinimize.Name = "pctMinimize";
            this.pctMinimize.Size = new System.Drawing.Size(20, 21);
            this.pctMinimize.TabIndex = 18;
            this.pctMinimize.TabStop = false;
            this.pctMinimize.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pctExit
            // 
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(399, 3);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(20, 21);
            this.pctExit.TabIndex = 17;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(37, 149);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(98, 18);
            this.lblUsername.TabIndex = 5;
            this.lblUsername.Text = "Username:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(42, 178);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(93, 18);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.ForeColor = System.Drawing.Color.Lime;
            this.txtUsername.Location = new System.Drawing.Point(141, 146);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(182, 26);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.ForeColor = System.Drawing.Color.Lime;
            this.txtPassword.Location = new System.Drawing.Point(141, 178);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(182, 26);
            this.txtPassword.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(218, 210);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 31);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "  Login";
            this.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(0)))));
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegister.Location = new System.Drawing.Point(195, 247);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(128, 31);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "  Register";
            this.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 3000;
            // 
            // notify
            // 
            this.notify.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notify.Text = "notify";
            this.notify.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(422, 313);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Page";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.panelDrag.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.Panel panelDrag;
        private System.Windows.Forms.PictureBox pctMinimize;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.PictureBox pctLogo;
    }
}

