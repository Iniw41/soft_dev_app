namespace Register_and_LogIn
{
    partial class Forget_Password
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
            panel1 = new Panel();
            Minimize_btn = new Button();
            Maximize_btn = new Button();
            close_btn = new Button();
            label_name_project = new Label();
            Change_pass_btn = new Button();
            label4 = new Label();
            new_pass_conf_textbox = new TextBox();
            label3 = new Label();
            new_pass_textbox = new TextBox();
            label1 = new Label();
            current_password_textbox = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(933, 42);
            panel1.TabIndex = 2;
            // 
            // Minimize_btn
            // 
            Minimize_btn.Dock = DockStyle.Right;
            Minimize_btn.FlatAppearance.BorderSize = 0;
            Minimize_btn.FlatStyle = FlatStyle.Flat;
            Minimize_btn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Minimize_btn.ForeColor = Color.Gray;
            Minimize_btn.Location = new Point(819, 0);
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
            Maximize_btn.Location = new Point(857, 0);
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
            close_btn.Location = new Point(895, 0);
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
            label_name_project.Size = new Size(193, 13);
            label_name_project.TabIndex = 0;
            label_name_project.Text = "Biniw  Chat       Forgot Password";
            // 
            // Change_pass_btn
            // 
            Change_pass_btn.BackColor = Color.FromArgb(41, 43, 47);
            Change_pass_btn.FlatAppearance.BorderColor = Color.FromArgb(62, 65, 71);
            Change_pass_btn.FlatStyle = FlatStyle.Flat;
            Change_pass_btn.ForeColor = Color.Silver;
            Change_pass_btn.Location = new Point(396, 380);
            Change_pass_btn.Margin = new Padding(4, 3, 4, 3);
            Change_pass_btn.Name = "Change_pass_btn";
            Change_pass_btn.Size = new Size(133, 45);
            Change_pass_btn.TabIndex = 30;
            Change_pass_btn.Text = "Change";
            Change_pass_btn.UseVisualStyleBackColor = false;
            Change_pass_btn.Click += Change_pass_btn_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Noto Sans JP", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(112, 236);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(253, 30);
            label4.TabIndex = 25;
            label4.Text = "Password Confirmation";
            // 
            // new_pass_conf_textbox
            // 
            new_pass_conf_textbox.BackColor = Color.FromArgb(62, 65, 71);
            new_pass_conf_textbox.BorderStyle = BorderStyle.FixedSingle;
            new_pass_conf_textbox.Font = new Font("Noto Sans JP", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_pass_conf_textbox.ForeColor = Color.Gray;
            new_pass_conf_textbox.Location = new Point(396, 239);
            new_pass_conf_textbox.Margin = new Padding(4, 3, 4, 3);
            new_pass_conf_textbox.Name = "new_pass_conf_textbox";
            new_pass_conf_textbox.Size = new Size(227, 31);
            new_pass_conf_textbox.TabIndex = 24;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Noto Sans JP", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(203, 173);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(162, 30);
            label3.TabIndex = 23;
            label3.Text = "New Password";
            // 
            // new_pass_textbox
            // 
            new_pass_textbox.BackColor = Color.FromArgb(62, 65, 71);
            new_pass_textbox.BorderStyle = BorderStyle.FixedSingle;
            new_pass_textbox.Font = new Font("Noto Sans JP", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            new_pass_textbox.ForeColor = Color.Gray;
            new_pass_textbox.Location = new Point(396, 172);
            new_pass_textbox.Margin = new Padding(4, 3, 4, 3);
            new_pass_textbox.Name = "new_pass_textbox";
            new_pass_textbox.Size = new Size(227, 31);
            new_pass_textbox.TabIndex = 21;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Noto Sans JP", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(356, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 42);
            label1.TabIndex = 19;
            label1.Text = "Change Password";
            // 
            // current_password_textbox
            // 
            current_password_textbox.BackColor = Color.FromArgb(62, 65, 71);
            current_password_textbox.BorderStyle = BorderStyle.FixedSingle;
            current_password_textbox.Font = new Font("Noto Sans JP", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            current_password_textbox.ForeColor = Color.Gray;
            current_password_textbox.Location = new Point(399, 113);
            current_password_textbox.Margin = new Padding(4, 3, 4, 3);
            current_password_textbox.Name = "current_password_textbox";
            current_password_textbox.Size = new Size(227, 31);
            current_password_textbox.TabIndex = 31;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Noto Sans JP", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(169, 114);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(196, 30);
            label2.TabIndex = 32;
            label2.Text = "Current Password";
            // 
            // Forget_Password
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 49, 54);
            ClientSize = new Size(933, 519);
            Controls.Add(current_password_textbox);
            Controls.Add(label2);
            Controls.Add(Change_pass_btn);
            Controls.Add(panel1);
            Controls.Add(new_pass_conf_textbox);
            Controls.Add(label1);
            Controls.Add(new_pass_textbox);
            Controls.Add(label4);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Forget_Password";
            Text = "Forgot_password";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.Button Maximize_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label label_name_project;
        private System.Windows.Forms.Button Change_pass_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox new_pass_conf_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox new_pass_textbox;
        private System.Windows.Forms.Label label1;
        private TextBox current_password_textbox;
        private Label label2;
    }
}