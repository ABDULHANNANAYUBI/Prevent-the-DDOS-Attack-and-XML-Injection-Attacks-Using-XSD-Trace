
namespace Finite_Automata
{
    partial class FormInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInformation));
            this.pctMinimize = new System.Windows.Forms.PictureBox();
            this.pctExit = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTopic = new System.Windows.Forms.Label();
            this.flwLayotPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAverage1 = new System.Windows.Forms.Label();
            this.lblAverage2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctMinimize
            // 
            this.pctMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pctMinimize.Image")));
            this.pctMinimize.Location = new System.Drawing.Point(769, -1);
            this.pctMinimize.Name = "pctMinimize";
            this.pctMinimize.Size = new System.Drawing.Size(20, 21);
            this.pctMinimize.TabIndex = 20;
            this.pctMinimize.TabStop = false;
            // 
            // pctExit
            // 
            this.pctExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pctExit.Image = ((System.Drawing.Image)(resources.GetObject("pctExit.Image")));
            this.pctExit.Location = new System.Drawing.Point(791, -1);
            this.pctExit.Name = "pctExit";
            this.pctExit.Size = new System.Drawing.Size(20, 21);
            this.pctExit.TabIndex = 19;
            this.pctExit.TabStop = false;
            this.pctExit.Click += new System.EventHandler(this.pctExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblTopic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(813, 100);
            this.panel1.TabIndex = 22;
            // 
            // lblTopic
            // 
            this.lblTopic.AutoSize = true;
            this.lblTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lblTopic.ForeColor = System.Drawing.Color.Lime;
            this.lblTopic.Location = new System.Drawing.Point(3, 23);
            this.lblTopic.Name = "lblTopic";
            this.lblTopic.Size = new System.Drawing.Size(768, 42);
            this.lblTopic.TabIndex = 17;
            this.lblTopic.Text = "User Information Which Pass to Next Level";
            // 
            // flwLayotPnl
            // 
            this.flwLayotPnl.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flwLayotPnl.Location = new System.Drawing.Point(0, 106);
            this.flwLayotPnl.Name = "flwLayotPnl";
            this.flwLayotPnl.Size = new System.Drawing.Size(486, 304);
            this.flwLayotPnl.TabIndex = 23;
            // 
            // lblAverage1
            // 
            this.lblAverage1.AutoSize = true;
            this.lblAverage1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage1.ForeColor = System.Drawing.Color.Lime;
            this.lblAverage1.Location = new System.Drawing.Point(492, 106);
            this.lblAverage1.Name = "lblAverage1";
            this.lblAverage1.Size = new System.Drawing.Size(116, 18);
            this.lblAverage1.TabIndex = 0;
            this.lblAverage1.Text = "The Average:";
            // 
            // lblAverage2
            // 
            this.lblAverage2.AutoSize = true;
            this.lblAverage2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverage2.ForeColor = System.Drawing.Color.Lime;
            this.lblAverage2.Location = new System.Drawing.Point(602, 106);
            this.lblAverage2.Name = "lblAverage2";
            this.lblAverage2.Size = new System.Drawing.Size(0, 18);
            this.lblAverage2.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(492, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 33);
            this.button1.TabIndex = 18;
            this.button1.Text = "Filteration ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(813, 420);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAverage2);
            this.Controls.Add(this.lblAverage1);
            this.Controls.Add(this.flwLayotPnl);
            this.Controls.Add(this.pctMinimize);
            this.Controls.Add(this.pctExit);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInformation";
            this.Load += new System.EventHandler(this.FormInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctExit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctMinimize;
        private System.Windows.Forms.PictureBox pctExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flwLayotPnl;
        private System.Windows.Forms.Label lblAverage1;
        private System.Windows.Forms.Label lblAverage2;
        private System.Windows.Forms.Label lblTopic;
        private System.Windows.Forms.Button button1;
    }
}