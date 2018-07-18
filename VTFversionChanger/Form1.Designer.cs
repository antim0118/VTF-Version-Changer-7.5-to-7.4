namespace VTFversionChanger
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_folder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_change = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.button_start_single = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.button_minimize = new System.Windows.Forms.Button();
            this.button_exit = new System.Windows.Forms.Button();
            this.label_header = new System.Windows.Forms.Label();
            this.progressBar = new VTFversionChanger.NewgrassBar();
            this.SuspendLayout();
            // 
            // textBox_folder
            // 
            this.textBox_folder.Enabled = false;
            this.textBox_folder.Location = new System.Drawing.Point(143, 31);
            this.textBox_folder.Name = "textBox_folder";
            this.textBox_folder.Size = new System.Drawing.Size(278, 20);
            this.textBox_folder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder with VTFs:";
            // 
            // button_change
            // 
            this.button_change.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_change.Location = new System.Drawing.Point(424, 30);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(63, 22);
            this.button_change.TabIndex = 2;
            this.button_change.Text = "Change";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_start
            // 
            this.button_start.Enabled = false;
            this.button_start.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(424, 55);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(63, 22);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_start_single
            // 
            this.button_start_single.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start_single.Location = new System.Drawing.Point(304, 55);
            this.button_start_single.Name = "button_start_single";
            this.button_start_single.Size = new System.Drawing.Size(118, 22);
            this.button_start_single.TabIndex = 5;
            this.button_start_single.Text = "Process single file";
            this.button_start_single.UseVisualStyleBackColor = true;
            this.button_start_single.Click += new System.EventHandler(this.button_start_single_Click);
            // 
            // button_about
            // 
            this.button_about.FlatAppearance.BorderSize = 0;
            this.button_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_about.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_about.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.button_about.Location = new System.Drawing.Point(418, 1);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(25, 25);
            this.button_about.TabIndex = 6;
            this.button_about.Text = "i";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // button_minimize
            // 
            this.button_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_minimize.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_minimize.FlatAppearance.BorderSize = 0;
            this.button_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_minimize.Image = global::VTFversionChanger.Properties.Resources.minimize;
            this.button_minimize.Location = new System.Drawing.Point(446, 1);
            this.button_minimize.Name = "button_minimize";
            this.button_minimize.Size = new System.Drawing.Size(25, 25);
            this.button_minimize.TabIndex = 8;
            this.button_minimize.UseVisualStyleBackColor = true;
            this.button_minimize.Click += new System.EventHandler(this.button_minimize_Click);
            // 
            // button_exit
            // 
            this.button_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_exit.Cursor = System.Windows.Forms.Cursors.Default;
            this.button_exit.FlatAppearance.BorderSize = 0;
            this.button_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_exit.Image = global::VTFversionChanger.Properties.Resources.cross;
            this.button_exit.Location = new System.Drawing.Point(474, 1);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(25, 25);
            this.button_exit.TabIndex = 7;
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label_header
            // 
            this.label_header.AutoSize = true;
            this.label_header.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.label_header.Location = new System.Drawing.Point(5, 5);
            this.label_header.Name = "label_header";
            this.label_header.Size = new System.Drawing.Size(246, 16);
            this.label_header.TabIndex = 9;
            this.label_header.Text = "VTF Version Changer (7.5 to 7.4)";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 81);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(475, 22);
            this.progressBar.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(500, 118);
            this.Controls.Add(this.label_header);
            this.Controls.Add(this.button_minimize);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_start_single);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_folder);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "VTF Version Changer (7.5 to 7.4)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_start_single;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.Button button_minimize;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Label label_header;
        private NewgrassBar progressBar;
    }
}

