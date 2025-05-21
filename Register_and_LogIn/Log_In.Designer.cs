namespace Register_and_LogIn
{
    partial class Log_In
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
            components = new System.ComponentModel.Container();
            panel1 = new System.Windows.Forms.Panel();
            Minimize_btn = new System.Windows.Forms.Button();
            Maximize_btn = new System.Windows.Forms.Button();
            close_btn = new System.Windows.Forms.Button();
            label_name_project = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            username_textbox = new System.Windows.Forms.TextBox();
            contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(components);
            password_textbox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            LogIn_btn = new System.Windows.Forms.Button();
            Register_text_click = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(37, 37, 37);
            panel1.Controls.Add(Minimize_btn);
            panel1.Controls.Add(Maximize_btn);
            panel1.Controls.Add(close_btn);
            panel1.Controls.Add(label_name_project);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(933, 42);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseMove += panel1_MouseMove;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // Minimize_btn
            // 
            Minimize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            Minimize_btn.FlatAppearance.BorderSize = 0;
            Minimize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Minimize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Minimize_btn.ForeColor = System.Drawing.Color.Gray;
            Minimize_btn.Location = new System.Drawing.Point(819, 0);
            Minimize_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Minimize_btn.Name = "Minimize_btn";
            Minimize_btn.Size = new System.Drawing.Size(38, 42);
            Minimize_btn.TabIndex = 3;
            Minimize_btn.Text = "_";
            Minimize_btn.UseVisualStyleBackColor = true;
            Minimize_btn.Click += Minimize_btn_Click;
            // 
            // Maximize_btn
            // 
            Maximize_btn.Dock = System.Windows.Forms.DockStyle.Right;
            Maximize_btn.FlatAppearance.BorderSize = 0;
            Maximize_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Maximize_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Maximize_btn.ForeColor = System.Drawing.Color.Gray;
            Maximize_btn.Location = new System.Drawing.Point(857, 0);
            Maximize_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Maximize_btn.Name = "Maximize_btn";
            Maximize_btn.Size = new System.Drawing.Size(38, 42);
            Maximize_btn.TabIndex = 2;
            Maximize_btn.Text = "▢";
            Maximize_btn.UseVisualStyleBackColor = true;
            Maximize_btn.Click += Maximize_btn_Click;
            // 
            // close_btn
            // 
            close_btn.Dock = System.Windows.Forms.DockStyle.Right;
            close_btn.FlatAppearance.BorderSize = 0;
            close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            close_btn.ForeColor = System.Drawing.Color.Red;
            close_btn.Location = new System.Drawing.Point(895, 0);
            close_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            close_btn.Name = "close_btn";
            close_btn.Size = new System.Drawing.Size(38, 42);
            close_btn.TabIndex = 1;
            close_btn.Text = "✕";
            close_btn.UseVisualStyleBackColor = true;
            close_btn.Click += close_btn_Click;
            // 
            // label_name_project
            // 
            label_name_project.AutoSize = true;
            label_name_project.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label_name_project.ForeColor = System.Drawing.Color.Gray;
            label_name_project.Location = new System.Drawing.Point(13, 10);
            label_name_project.Margin = new System.Windows.Forms.Padding(2, 0, 4, 0);
            label_name_project.Name = "label_name_project";
            label_name_project.Size = new System.Drawing.Size(155, 13);
            label_name_project.TabIndex = 0;
            label_name_project.Text = "Biniw  Chat           Log In \r\n";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Noto Sans JP", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Gray;
            label1.Location = new System.Drawing.Point(386, 45);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 42);
            label1.TabIndex = 1;
            label1.Text = "Log  In";
            // 
            // username_textbox
            // 
            username_textbox.BackColor = System.Drawing.Color.FromArgb(62, 65, 71);
            username_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            username_textbox.Font = new System.Drawing.Font("Noto Sans JP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            username_textbox.ForeColor = System.Drawing.Color.Gray;
            username_textbox.Location = new System.Drawing.Point(394, 132);
            username_textbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new System.Drawing.Size(227, 31);
            username_textbox.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // password_textbox
            // 
            password_textbox.BackColor = System.Drawing.Color.FromArgb(62, 65, 71);
            password_textbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            password_textbox.Font = new System.Drawing.Font("Noto Sans JP", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            password_textbox.ForeColor = System.Drawing.Color.Gray;
            password_textbox.Location = new System.Drawing.Point(394, 210);
            password_textbox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new System.Drawing.Size(227, 31);
            password_textbox.TabIndex = 4;
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Noto Sans JP", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Gray;
            label2.Location = new System.Drawing.Point(251, 133);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 30);
            label2.TabIndex = 5;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Noto Sans JP", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Gray;
            label3.Location = new System.Drawing.Point(257, 211);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(112, 30);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // LogIn_btn
            // 
            LogIn_btn.BackColor = System.Drawing.Color.FromArgb(41, 43, 47);
            LogIn_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(62, 65, 71);
            LogIn_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LogIn_btn.ForeColor = System.Drawing.Color.Silver;
            LogIn_btn.Location = new System.Drawing.Point(394, 280);
            LogIn_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LogIn_btn.Name = "LogIn_btn";
            LogIn_btn.Size = new System.Drawing.Size(133, 45);
            LogIn_btn.TabIndex = 7;
            LogIn_btn.Text = "Log In";
            LogIn_btn.UseVisualStyleBackColor = false;
            LogIn_btn.Click += LogIn_btn_Click;
            // 
            // Register_text_click
            // 
            Register_text_click.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            Register_text_click.AutoSize = true;
            Register_text_click.Font = new System.Drawing.Font("Noto Sans JP Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Register_text_click.ForeColor = System.Drawing.Color.Gray;
            Register_text_click.Location = new System.Drawing.Point(485, 447);
            Register_text_click.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Register_text_click.Name = "Register_text_click";
            Register_text_click.Size = new System.Drawing.Size(74, 24);
            Register_text_click.TabIndex = 11;
            Register_text_click.Text = "Register";
            Register_text_click.Click += Register_text_click_Click;
            // 
            // label6
            // 
            label6.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Noto Sans JP Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.Gray;
            label6.Location = new System.Drawing.Point(258, 447);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(189, 24);
            label6.TabIndex = 10;
            label6.Text = "Don't have an account?";
            // 
            // Log_In
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(47, 49, 54);
            ClientSize = new System.Drawing.Size(933, 519);
            ControlBox = false;
            Controls.Add(Register_text_click);
            Controls.Add(label6);
            Controls.Add(LogIn_btn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(password_textbox);
            Controls.Add(username_textbox);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Log_In";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_name_project;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button Minimize_btn;
        private System.Windows.Forms.Button Maximize_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LogIn_btn;
        private System.Windows.Forms.Label Register_text_click;
        private System.Windows.Forms.Label label6;
    }
}

