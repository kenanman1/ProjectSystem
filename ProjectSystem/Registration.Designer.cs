namespace ProjectSystem
{
    partial class Registration
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
            button1 = new Button();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            textBoxMail = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(348, 405);
            button1.Name = "button1";
            button1.Size = new Size(144, 45);
            button1.TabIndex = 0;
            button1.Text = "Create Account";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(315, 152);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(177, 27);
            textBoxLogin.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(315, 237);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(177, 27);
            textBoxPassword.TabIndex = 2;
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(315, 315);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(177, 27);
            textBoxMail.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(156, 152);
            label1.Name = "label1";
            label1.Size = new Size(97, 23);
            label1.TabIndex = 5;
            label1.Text = "Enter Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(156, 236);
            label2.Name = "label2";
            label2.Size = new Size(127, 23);
            label2.TabIndex = 6;
            label2.Text = "Enter Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(156, 318);
            label3.Name = "label3";
            label3.Size = new Size(88, 23);
            label3.TabIndex = 7;
            label3.Text = "Enter Mail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(156, 74);
            label4.Name = "label4";
            label4.Size = new Size(101, 23);
            label4.TabIndex = 11;
            label4.Text = "Enter Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(315, 71);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(177, 27);
            textBoxName.TabIndex = 12;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 523);
            Controls.Add(textBoxName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxMail);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Registration";
            Text = "Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private TextBox textBoxMail;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxName;
    }
}