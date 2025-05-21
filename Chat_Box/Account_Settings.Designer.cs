namespace Chat_Box
{
    partial class Account_Settings
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
            Go_forget_password = new Button();
            panel1 = new Panel();
            Minimize_btn = new Button();
            Maximize_btn = new Button();
            close_btn = new Button();
            label_name_project = new Label();
            label6 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            Go_back_click = new Label();
            Username_info_text = new Label();
            label5 = new Label();
            label7 = new Label();
            Email_info_text = new Label();
            Age_info_text = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Go_forget_password
            // 
            Go_forget_password.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Go_forget_password.BackColor = Color.FromArgb(41, 43, 47);
            Go_forget_password.FlatAppearance.BorderColor = Color.FromArgb(62, 65, 71);
            Go_forget_password.FlatStyle = FlatStyle.Flat;
            Go_forget_password.ForeColor = Color.Silver;
            Go_forget_password.Location = new Point(436, 381);
            Go_forget_password.Margin = new Padding(4, 3, 4, 3);
            Go_forget_password.Name = "Go_forget_password";
            Go_forget_password.Size = new Size(113, 42);
            Go_forget_password.TabIndex = 43;
            Go_forget_password.Text = "Send";
            Go_forget_password.UseVisualStyleBackColor = false;
            Go_forget_password.Click += Go_forget_password_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 37, 37);
            panel1.Controls.Add(Minimize_btn);
            panel1.Controls.Add(Maximize_btn);
            panel1.Controls.Add(close_btn);
            panel1.Controls.Add(label_name_project);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(939, 42);
            panel1.TabIndex = 32;
            // 
            // Minimize_btn
            // 
            Minimize_btn.Dock = DockStyle.Right;
            Minimize_btn.FlatAppearance.BorderSize = 0;
            Minimize_btn.FlatStyle = FlatStyle.Flat;
            Minimize_btn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Minimize_btn.ForeColor = Color.Gray;
            Minimize_btn.Location = new Point(825, 0);
            Minimize_btn.Margin = new Padding(4, 3, 4, 3);
            Minimize_btn.Name = "Minimize_btn";
            Minimize_btn.Size = new Size(38, 42);
            Minimize_btn.TabIndex = 3;
            Minimize_btn.Text = "_";
            Minimize_btn.UseVisualStyleBackColor = true;
            Minimize_btn.Click += Minimize_btn_Click;
            // 
            // Maximize_btn
            // 
            Maximize_btn.Dock = DockStyle.Right;
            Maximize_btn.FlatAppearance.BorderSize = 0;
            Maximize_btn.FlatStyle = FlatStyle.Flat;
            Maximize_btn.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Maximize_btn.ForeColor = Color.Gray;
            Maximize_btn.Location = new Point(863, 0);
            Maximize_btn.Margin = new Padding(4, 3, 4, 3);
            Maximize_btn.Name = "Maximize_btn";
            Maximize_btn.Size = new Size(38, 42);
            Maximize_btn.TabIndex = 2;
            Maximize_btn.Text = "▢";
            Maximize_btn.UseVisualStyleBackColor = true;
            Maximize_btn.Click += Maximize_btn_Click;
            // 
            // close_btn
            // 
            close_btn.Dock = DockStyle.Right;
            close_btn.FlatAppearance.BorderSize = 0;
            close_btn.FlatStyle = FlatStyle.Flat;
            close_btn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close_btn.ForeColor = Color.Red;
            close_btn.Location = new Point(901, 0);
            close_btn.Margin = new Padding(4, 3, 4, 3);
            close_btn.Name = "close_btn";
            close_btn.Size = new Size(38, 42);
            close_btn.TabIndex = 1;
            close_btn.Text = "✕";
            close_btn.UseVisualStyleBackColor = true;
            close_btn.Click += close_btn_Click;
            // 
            // label_name_project
            // 
            label_name_project.AutoSize = true;
            label_name_project.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_name_project.ForeColor = Color.Gray;
            label_name_project.Location = new Point(13, 10);
            label_name_project.Margin = new Padding(2, 0, 4, 0);
            label_name_project.Name = "label_name_project";
            label_name_project.Size = new Size(196, 13);
            label_name_project.TabIndex = 0;
            label_name_project.Text = "Biniw  Chat       Account Settings";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Noto Sans JP", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(214, 381);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(176, 30);
            label6.TabIndex = 41;
            label6.Text = "Passord Change";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox3.BackColor = Color.FromArgb(62, 65, 71);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Noto Sans JP", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.Gray;
            textBox3.Location = new Point(436, 190);
            textBox3.Margin = new Padding(4, 3, 4, 3);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(227, 31);
            textBox3.TabIndex = 36;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans JP", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(436, 56);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 42);
            label1.TabIndex = 33;
            label1.Text = "Info";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans JP", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(191, 191);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(199, 30);
            label4.TabIndex = 37;
            label4.Text = "Username Change";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans JP", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(273, 124);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(117, 30);
            label3.TabIndex = 35;
            label3.Text = "Username";
            // 
            // Go_back_click
            // 
            Go_back_click.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Go_back_click.AutoSize = true;
            Go_back_click.Font = new Font("Noto Sans JP Medium", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Go_back_click.ForeColor = Color.Gray;
            Go_back_click.Location = new Point(816, 474);
            Go_back_click.Margin = new Padding(4, 0, 4, 0);
            Go_back_click.Name = "Go_back_click";
            Go_back_click.Size = new Size(85, 24);
            Go_back_click.TabIndex = 44;
            Go_back_click.Text = "Go Back <";
            Go_back_click.Click += Go_back_click_Click;
            // 
            // Username_info_text
            // 
            Username_info_text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Username_info_text.AutoSize = true;
            Username_info_text.Font = new Font("Noto Sans JP", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username_info_text.ForeColor = Color.Gray;
            Username_info_text.Location = new Point(436, 124);
            Username_info_text.Margin = new Padding(4, 0, 4, 0);
            Username_info_text.Name = "Username_info_text";
            Username_info_text.Size = new Size(145, 30);
            Username_info_text.TabIndex = 45;
            Username_info_text.Text = "Place Holder";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Noto Sans JP", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(319, 257);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(71, 30);
            label5.TabIndex = 46;
            label5.Text = "Email";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Noto Sans JP", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(339, 314);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 30);
            label7.TabIndex = 47;
            label7.Text = "Age";
            // 
            // Email_info_text
            // 
            Email_info_text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Email_info_text.AutoSize = true;
            Email_info_text.Font = new Font("Noto Sans JP", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Email_info_text.ForeColor = Color.Gray;
            Email_info_text.Location = new Point(436, 257);
            Email_info_text.Margin = new Padding(4, 0, 4, 0);
            Email_info_text.Name = "Email_info_text";
            Email_info_text.Size = new Size(208, 30);
            Email_info_text.TabIndex = 48;
            Email_info_text.Text = "Place Holder Email";
            // 
            // Age_info_text
            // 
            Age_info_text.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Age_info_text.AutoSize = true;
            Age_info_text.Font = new Font("Noto Sans JP", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Age_info_text.ForeColor = Color.Gray;
            Age_info_text.Location = new Point(436, 314);
            Age_info_text.Margin = new Padding(4, 0, 4, 0);
            Age_info_text.Name = "Age_info_text";
            Age_info_text.Size = new Size(195, 30);
            Age_info_text.TabIndex = 49;
            Age_info_text.Text = "Age Place_Holder";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(41, 43, 47);
            button1.FlatAppearance.BorderColor = Color.FromArgb(62, 65, 71);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Silver;
            button1.Location = new Point(682, 191);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(113, 30);
            button1.TabIndex = 50;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = false;
            // 
            // Account_Settings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 49, 54);
            ClientSize = new Size(939, 528);
            Controls.Add(button1);
            Controls.Add(Age_info_text);
            Controls.Add(Email_info_text);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(Username_info_text);
            Controls.Add(Go_back_click);
            Controls.Add(Go_forget_password);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(textBox3);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Account_Settings";
            Text = "Account_Settings";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button Go_forget_password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.Button Maximize_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label label_name_project;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Go_back_click;
        private System.Windows.Forms.Label Username_info_text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Email_info_text;
        private System.Windows.Forms.Label Age_info_text;
        private Button button1;
    }
}