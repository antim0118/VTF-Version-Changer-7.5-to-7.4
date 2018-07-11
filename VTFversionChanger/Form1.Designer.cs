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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.button_start_single = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_folder
            // 
            this.textBox_folder.Enabled = false;
            this.textBox_folder.Location = new System.Drawing.Point(107, 12);
            this.textBox_folder.Name = "textBox_folder";
            this.textBox_folder.Size = new System.Drawing.Size(246, 20);
            this.textBox_folder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Folder with VTFs:";
            // 
            // button_change
            // 
            this.button_change.Location = new System.Drawing.Point(359, 10);
            this.button_change.Name = "button_change";
            this.button_change.Size = new System.Drawing.Size(63, 23);
            this.button_change.TabIndex = 2;
            this.button_change.Text = "Change";
            this.button_change.UseVisualStyleBackColor = true;
            this.button_change.Click += new System.EventHandler(this.button_change_Click);
            // 
            // button_start
            // 
            this.button_start.Enabled = false;
            this.button_start.Location = new System.Drawing.Point(359, 39);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(63, 23);
            this.button_start.TabIndex = 3;
            this.button_start.Text = "Start";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 68);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(410, 23);
            this.progressBar.TabIndex = 4;
            // 
            // button_start_single
            // 
            this.button_start_single.Location = new System.Drawing.Point(252, 39);
            this.button_start_single.Name = "button_start_single";
            this.button_start_single.Size = new System.Drawing.Size(101, 23);
            this.button_start_single.TabIndex = 5;
            this.button_start_single.Text = "Process single file";
            this.button_start_single.UseVisualStyleBackColor = true;
            this.button_start_single.Click += new System.EventHandler(this.button_start_single_Click);
            // 
            // button_about
            // 
            this.button_about.Location = new System.Drawing.Point(12, 39);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(49, 23);
            this.button_about.TabIndex = 6;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 102);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_start_single);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_change);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_folder);
            this.Name = "Form1";
            this.Text = "VTF Version Changer (7.5 to 7.4)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_folder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_change;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button button_start_single;
        private System.Windows.Forms.Button button_about;
    }
}

