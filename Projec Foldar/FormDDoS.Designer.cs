
namespace Finite_Automata
{
    partial class FormDDoS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDDoS));
            this.listInfos = new System.Windows.Forms.ListView();
            this.panelMain = new System.Windows.Forms.Panel();
            this.pctTopic = new System.Windows.Forms.PictureBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.pctMinimize = new System.Windows.Forms.PictureBox();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listLastLoginInfo = new System.Windows.Forms.ListView();
            this.rchInfo = new System.Windows.Forms.RichTextBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.SuspendLayout();
            // 
            // listInfos
            // 
            this.listInfos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listInfos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listInfos.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listInfos.ForeColor = System.Drawing.Color.Lime;
            this.listInfos.HideSelection = false;
            this.listInfos.Location = new System.Drawing.Point(0, 119);
            this.listInfos.Name = "listInfos";
            this.listInfos.Size = new System.Drawing.Size(483, 414);
            this.listInfos.TabIndex = 12;
            this.listInfos.UseCompatibleStateImageBehavior = false;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.pctTopic);
            this.panelMain.Controls.Add(this.lblTopic);
            this.panelMain.Controls.Add(this.pctMinimize);
            this.panelMain.Controls.Add(this.pctExit);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(948, 113);
            this.panelMain.TabIndex = 13;
            // 
            // pctTopic
            // 
            this.pctTopic.Image = ((System.Drawing.Image)(resources.GetObject("pctTopic.Image")));
            this.pctTopic.Location = new System.Drawing.Point(375, 12);
            this.pctTopic.Name = "pctTopic";
            this.pctTopic.Size = new System.Drawing.Size(100, 98);
            this.pctTopic.TabIndex = 17;
            this.pctTopic.TabStop = false;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTopic.ForeColor = System.Drawing.Color.Lime;
            this.lblTopic.Location = new System.Drawing.Point(12, 38);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(357, 42);
            this.lblTopic.TabIndex = 16;
            this.lblTopic.Text = "DDoS DETECTION";
            // 
            // pctMinimize
            // 
            this.pctMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pctMinimize.Image")));
            this.pctMinimize.Location = new System.Drawing.Point(903, 3);
            this.pctMinimize.Name = "pctMinimize";
            this.pctMinimize.Size = new System.Drawing.Size(20, 21);
            this.pctMinimize.TabIndex = 15;
            this.pctMinimize.TabStop = false;
            this.pctMinimize.Click += new System.EventHandler(this.pctMinimize_Click);
            // 
            // pctExit
            // 
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(925, 3);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(20, 21);
            this.pctExit.TabIndex = 14;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listLastLoginInfo
            // 
            this.listLastLoginInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.listLastLoginInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listLastLoginInfo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listLastLoginInfo.ForeColor = System.Drawing.Color.Lime;
            this.listLastLoginInfo.HideSelection = false;
            this.listLastLoginInfo.Location = new System.Drawing.Point(489, 119);
            this.listLastLoginInfo.Name = "listLastLoginInfo";
            this.listLastLoginInfo.Size = new System.Drawing.Size(456, 78);
            this.listLastLoginInfo.TabIndex = 14;
            this.listLastLoginInfo.UseCompatibleStateImageBehavior = false;
            // 
            // rchInfo
            // 
            this.rchInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.rchInfo.ForeColor = System.Drawing.Color.Lime;
            this.rchInfo.Location = new System.Drawing.Point(489, 315);
            this.rchInfo.Name = "rchInfo";
            this.rchInfo.ReadOnly = true;
            this.rchInfo.Size = new System.Drawing.Size(456, 96);
            this.rchInfo.TabIndex = 15;
            this.rchInfo.Text = "";
            // 
            // btnStop
            // 
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.ForeColor = System.Drawing.Color.Lime;
            this.btnStop.Location = new System.Drawing.Point(489, 498);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(180, 35);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop and Result";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // FormDDoS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(948, 545);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.rchInfo);
            this.Controls.Add(this.listLastLoginInfo);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.listInfos);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "FormDDoS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDDoS";
            this.Load += new System.EventHandler(this.FormDDoS_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listInfos;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox pctMinimize;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listLastLoginInfo;
        private System.Windows.Forms.RichTextBox rchInfo;
        private System.Windows.Forms.PictureBox pctTopic;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Button btnStop;
    }
}