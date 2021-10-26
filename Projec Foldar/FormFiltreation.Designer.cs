
namespace Finite_Automata
{
    partial class FormFiltreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiltreation));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pctTopic = new System.Windows.Forms.PictureBox();
            this.pctMinimize = new System.Windows.Forms.PictureBox();
            this.lblTopic = new System.Windows.Forms.Label();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.chkboxStatic = new System.Windows.Forms.CheckedListBox();
            this.chkboxDynamic = new System.Windows.Forms.CheckedListBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.prgsBarLoadingStatic = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.prgsBarGeneral = new System.Windows.Forms.ProgressBar();
            this.prgsBarLoadingDynamic = new System.Windows.Forms.ProgressBar();
            this.lstViewFinal = new System.Windows.Forms.ListView();
            this.btnNext = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNextDynamic = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTopic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pctTopic);
            this.panel1.Controls.Add(this.pctMinimize);
            this.panel1.Controls.Add(this.lblTopic);
            this.panel1.Controls.Add(this.pctExit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1097, 100);
            this.panel1.TabIndex = 0;
            // 
            // pctTopic
            // 
            this.pctTopic.Image = ((System.Drawing.Image)(resources.GetObject("pctTopic.Image")));
            this.pctTopic.Location = new System.Drawing.Point(385, 0);
            this.pctTopic.Name = "pctTopic";
            this.pctTopic.Size = new System.Drawing.Size(93, 94);
            this.pctTopic.TabIndex = 19;
            this.pctTopic.TabStop = false;
            // 
            // pctMinimize
            // 
            this.pctMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pctMinimize.Image")));
            this.pctMinimize.Location = new System.Drawing.Point(1052, 0);
            this.pctMinimize.Name = "pctMinimize";
            this.pctMinimize.Size = new System.Drawing.Size(20, 21);
            this.pctMinimize.TabIndex = 11;
            this.pctMinimize.TabStop = false;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTopic.ForeColor = System.Drawing.Color.Lime;
            this.lblTopic.Location = new System.Drawing.Point(12, 27);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(382, 42);
            this.lblTopic.TabIndex = 18;
            this.lblTopic.Text = "XSD HANDLE PART";
            // 
            // pctExit
            // 
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(1074, 0);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(20, 21);
            this.pctExit.TabIndex = 10;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // chkboxStatic
            // 
            this.chkboxStatic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.chkboxStatic.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxStatic.ForeColor = System.Drawing.Color.Lime;
            this.chkboxStatic.FormattingEnabled = true;
            this.chkboxStatic.Location = new System.Drawing.Point(12, 166);
            this.chkboxStatic.Name = "chkboxStatic";
            this.chkboxStatic.Size = new System.Drawing.Size(299, 256);
            this.chkboxStatic.TabIndex = 1;
            this.chkboxStatic.SelectedIndexChanged += new System.EventHandler(this.chkboxStatic_SelectedIndexChanged);
            // 
            // chkboxDynamic
            // 
            this.chkboxDynamic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.chkboxDynamic.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkboxDynamic.ForeColor = System.Drawing.Color.Lime;
            this.chkboxDynamic.FormattingEnabled = true;
            this.chkboxDynamic.Location = new System.Drawing.Point(326, 166);
            this.chkboxDynamic.Name = "chkboxDynamic";
            this.chkboxDynamic.Size = new System.Drawing.Size(299, 256);
            this.chkboxDynamic.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.Lime;
            this.lblInfo.Location = new System.Drawing.Point(631, 132);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(118, 25);
            this.lblInfo.TabIndex = 3;
            this.lblInfo.Text = "The User : ";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Lime;
            this.lblUser.Location = new System.Drawing.Point(743, 132);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 25);
            this.lblUser.TabIndex = 4;
            // 
            // prgsBarLoadingStatic
            // 
            this.prgsBarLoadingStatic.ForeColor = System.Drawing.Color.Lime;
            this.prgsBarLoadingStatic.Location = new System.Drawing.Point(12, 506);
            this.prgsBarLoadingStatic.Name = "prgsBarLoadingStatic";
            this.prgsBarLoadingStatic.Size = new System.Drawing.Size(299, 23);
            this.prgsBarLoadingStatic.Step = 5;
            this.prgsBarLoadingStatic.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // prgsBarGeneral
            // 
            this.prgsBarGeneral.Location = new System.Drawing.Point(12, 536);
            this.prgsBarGeneral.Name = "prgsBarGeneral";
            this.prgsBarGeneral.Size = new System.Drawing.Size(613, 29);
            this.prgsBarGeneral.TabIndex = 6;
            // 
            // prgsBarLoadingDynamic
            // 
            this.prgsBarLoadingDynamic.ForeColor = System.Drawing.Color.Lime;
            this.prgsBarLoadingDynamic.Location = new System.Drawing.Point(326, 506);
            this.prgsBarLoadingDynamic.Name = "prgsBarLoadingDynamic";
            this.prgsBarLoadingDynamic.Size = new System.Drawing.Size(299, 23);
            this.prgsBarLoadingDynamic.Step = 5;
            this.prgsBarLoadingDynamic.TabIndex = 7;
            // 
            // lstViewFinal
            // 
            this.lstViewFinal.HideSelection = false;
            this.lstViewFinal.Location = new System.Drawing.Point(631, 166);
            this.lstViewFinal.Name = "lstViewFinal";
            this.lstViewFinal.Size = new System.Drawing.Size(463, 256);
            this.lstViewFinal.TabIndex = 8;
            this.lstViewFinal.UseCompatibleStateImageBehavior = false;
            // 
            // btnNext
            // 
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Lime;
            this.btnNext.Location = new System.Drawing.Point(273, 449);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(121, 36);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next User";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(5, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 42);
            this.label1.TabIndex = 20;
            this.label1.Text = "STATIC PART";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(314, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 42);
            this.label2.TabIndex = 21;
            this.label2.Text = "DYNAMIC PART";
            // 
            // btnNextDynamic
            // 
            this.btnNextDynamic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNextDynamic.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextDynamic.ForeColor = System.Drawing.Color.Lime;
            this.btnNextDynamic.Location = new System.Drawing.Point(273, 449);
            this.btnNextDynamic.Name = "btnNextDynamic";
            this.btnNextDynamic.Size = new System.Drawing.Size(121, 36);
            this.btnNextDynamic.TabIndex = 22;
            this.btnNextDynamic.Text = "Next User";
            this.btnNextDynamic.UseVisualStyleBackColor = true;
            this.btnNextDynamic.Click += new System.EventHandler(this.btnNextDynamic_Click);
            // 
            // FormFiltreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1097, 577);
            this.Controls.Add(this.btnNextDynamic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lstViewFinal);
            this.Controls.Add(this.prgsBarLoadingDynamic);
            this.Controls.Add(this.prgsBarGeneral);
            this.Controls.Add(this.prgsBarLoadingStatic);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.chkboxDynamic);
            this.Controls.Add(this.chkboxStatic);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFiltreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFiltreation";
            this.Load += new System.EventHandler(this.FormFiltreation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctTopic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pctMinimize;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.CheckedListBox chkboxStatic;
        private System.Windows.Forms.CheckedListBox chkboxDynamic;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ProgressBar prgsBarLoadingStatic;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar prgsBarGeneral;
        private System.Windows.Forms.ProgressBar prgsBarLoadingDynamic;
        private System.Windows.Forms.ListView lstViewFinal;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pctTopic;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNextDynamic;
    }
}