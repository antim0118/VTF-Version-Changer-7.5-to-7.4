namespace VTFversionChanger
{
    partial class About
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
            this.label_soft = new System.Windows.Forms.Label();
            this.label_createdby = new System.Windows.Forms.Label();
            this.button_close = new System.Windows.Forms.Button();
            this.linkLabel_antim = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_soft
            // 
            this.label_soft.AutoSize = true;
            this.label_soft.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_soft.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.label_soft.Location = new System.Drawing.Point(12, 16);
            this.label_soft.Name = "label_soft";
            this.label_soft.Size = new System.Drawing.Size(54, 16);
            this.label_soft.TabIndex = 0;
            this.label_soft.Text = "*soft*";
            // 
            // label_createdby
            // 
            this.label_createdby.AutoSize = true;
            this.label_createdby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label_createdby.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_createdby.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.label_createdby.Location = new System.Drawing.Point(12, 43);
            this.label_createdby.Name = "label_createdby";
            this.label_createdby.Size = new System.Drawing.Size(81, 16);
            this.label_createdby.TabIndex = 1;
            this.label_createdby.Text = "Created by";
            // 
            // button_close
            // 
            this.button_close.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_close.Location = new System.Drawing.Point(15, 70);
            this.button_close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(238, 28);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "OK";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // linkLabel_antim
            // 
            this.linkLabel_antim.AutoSize = true;
            this.linkLabel_antim.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel_antim.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(79)))), ((int)(((byte)(254)))));
            this.linkLabel_antim.Location = new System.Drawing.Point(89, 43);
            this.linkLabel_antim.Name = "linkLabel_antim";
            this.linkLabel_antim.Size = new System.Drawing.Size(56, 16);
            this.linkLabel_antim.TabIndex = 3;
            this.linkLabel_antim.TabStop = true;
            this.linkLabel_antim.Text = "/antim/";
            this.linkLabel_antim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_antim_LinkClicked);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.label1.Location = new System.Drawing.Point(212, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "2018";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(265, 112);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel_antim);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_createdby);
            this.Controls.Add(this.label_soft);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "About";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "About";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.About_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.About_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_soft;
        private System.Windows.Forms.Label label_createdby;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.LinkLabel linkLabel_antim;
        private System.Windows.Forms.Label label1;
    }
}