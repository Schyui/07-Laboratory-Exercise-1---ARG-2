namespace CashierApplication1
{
    partial class frmLoginAccount
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
            label1 = new Label();
            label2 = new Label();
            uNameTxtBx = new TextBox();
            passwordTxtBx = new TextBox();
            loginBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // uNameTxtBx
            // 
            uNameTxtBx.Location = new Point(12, 29);
            uNameTxtBx.Name = "uNameTxtBx";
            uNameTxtBx.Size = new Size(206, 23);
            uNameTxtBx.TabIndex = 2;
            // 
            // passwordTxtBx
            // 
            passwordTxtBx.Location = new Point(12, 73);
            passwordTxtBx.Name = "passwordTxtBx";
            passwordTxtBx.Size = new Size(206, 23);
            passwordTxtBx.TabIndex = 3;
            passwordTxtBx.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = SystemColors.ActiveCaption;
            loginBtn.Location = new Point(12, 102);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(206, 36);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // frmLoginAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(230, 158);
            Controls.Add(loginBtn);
            Controls.Add(passwordTxtBx);
            Controls.Add(uNameTxtBx);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLoginAccount";
            Text = "User Login";
            Load += frmLoginAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox uNameTxtBx;
        private TextBox passwordTxtBx;
        private Button loginBtn;
    }
}