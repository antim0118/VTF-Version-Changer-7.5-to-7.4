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
            this.SuspendLayout();
            // 
            // label_soft
            // 
            this.label_soft.AutoSize = true;
            this.label_soft.Location = new System.Drawing.Point(12, 15);
            this.label_soft.Name = "label_soft";
            this.label_soft.Size = new System.Drawing.Size(32, 13);
            this.label_soft.TabIndex = 0;
            this.label_soft.Text = "*soft*";
            // 
            // label_createdby
            // 
            this.label_createdby.AutoSize = true;
            this.label_createdby.Location = new System.Drawing.Point(12, 40);
            this.label_createdby.Name = "label_createdby";
            this.label_createdby.Size = new System.Drawing.Size(58, 13);
            this.label_createdby.TabIndex = 1;
            this.label_createdby.Text = "Created by";
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(130, 35);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(42, 23);
            this.button_close.TabIndex = 2;
            this.button_close.Text = "OK";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // linkLabel_antim
            // 
            this.linkLabel_antim.AutoSize = true;
            this.linkLabel_antim.Location = new System.Drawing.Point(66, 40);
            this.linkLabel_antim.Name = "linkLabel_antim";
            this.linkLabel_antim.Size = new System.Drawing.Size(42, 13);
            this.linkLabel_antim.TabIndex = 3;
            this.linkLabel_antim.TabStop = true;
            this.linkLabel_antim.Text = "/antim/";
            this.linkLabel_antim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_antim_LinkClicked);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 70);
            this.Controls.Add(this.linkLabel_antim);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.label_createdby);
            this.Controls.Add(this.label_soft);
            this.Name = "About";
            this.ShowIcon = false;
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_soft;
        private System.Windows.Forms.Label label_createdby;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.LinkLabel linkLabel_antim;
    }
}