namespace ProjectSystem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            buttonEnter = new Button();
            buttonHideShow = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(618, 398);
            label1.Name = "label1";
            label1.Size = new Size(163, 20);
            label1.TabIndex = 0;
            label1.Text = "Don't have an account?";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(323, 128);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(184, 27);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(323, 232);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(184, 27);
            textBoxPassword.TabIndex = 2;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            button1.Location = new Point(645, 430);
            button1.Name = "button1";
            button1.Size = new Size(107, 36);
            button1.TabIndex = 3;
            button1.Text = "Create new";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(210, 129);
            label2.Name = "label2";
            label2.Size = new Size(52, 23);
            label2.TabIndex = 4;
            label2.Text = "Login";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(210, 233);
            label3.Name = "label3";
            label3.Size = new Size(82, 23);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(363, 303);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(94, 35);
            buttonEnter.TabIndex = 6;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // buttonHideShow
            // 
            buttonHideShow.Location = new Point(552, 232);
            buttonHideShow.Name = "buttonHideShow";
            buttonHideShow.Size = new Size(73, 29);
            buttonHideShow.TabIndex = 7;
            buttonHideShow.Text = "show";
            buttonHideShow.UseVisualStyleBackColor = true;
            buttonHideShow.Click += buttonHideShow_Click;
            // 
            // Form1
            // 
            AcceptButton = buttonEnter;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 531);
            Controls.Add(buttonHideShow);
            Controls.Add(buttonEnter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button buttonEnter;
        private Button buttonHideShow;
    }
}