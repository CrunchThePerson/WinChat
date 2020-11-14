namespace WinChat
{
    partial class SignIn
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
            this.Option = new System.Windows.Forms.TabControl();
            this.Login = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Signup = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.EnterUser = new System.Windows.Forms.TextBox();
            this.EnterPass = new System.Windows.Forms.TextBox();
            this.Register = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LogButton = new System.Windows.Forms.Button();
            this.Option.SuspendLayout();
            this.Login.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Signup.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Option
            // 
            this.Option.Controls.Add(this.Login);
            this.Option.Controls.Add(this.Signup);
            this.Option.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Option.Location = new System.Drawing.Point(0, 0);
            this.Option.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Option.Name = "Option";
            this.Option.SelectedIndex = 0;
            this.Option.Size = new System.Drawing.Size(1067, 554);
            this.Option.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.Controls.Add(this.tableLayoutPanel1);
            this.Login.Location = new System.Drawing.Point(4, 25);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Login.Size = new System.Drawing.Size(1059, 525);
            this.Login.TabIndex = 0;
            this.Login.Text = "Sign In";
            this.Login.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Username, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Password, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LogButton, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1051, 517);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Username
            // 
            this.Username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Username.Location = new System.Drawing.Point(266, 272);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Username.MaxLength = 16;
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(517, 22);
            this.Username.TabIndex = 0;
            // 
            // Password
            // 
            this.Password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Password.Location = new System.Drawing.Point(266, 348);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password.MaxLength = 16;
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(517, 22);
            this.Password.TabIndex = 1;
            // 
            // Signup
            // 
            this.Signup.Controls.Add(this.tableLayoutPanel2);
            this.Signup.Location = new System.Drawing.Point(4, 25);
            this.Signup.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Signup.Name = "Signup";
            this.Signup.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Signup.Size = new System.Drawing.Size(1059, 525);
            this.Signup.TabIndex = 1;
            this.Signup.Text = "Sign Up";
            this.Signup.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.EnterUser, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.EnterPass, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.Register, 1, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1051, 517);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // EnterUser
            // 
            this.EnterUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterUser.Location = new System.Drawing.Point(266, 272);
            this.EnterUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnterUser.MaxLength = 16;
            this.EnterUser.Name = "EnterUser";
            this.EnterUser.Size = new System.Drawing.Size(517, 22);
            this.EnterUser.TabIndex = 0;
            // 
            // EnterPass
            // 
            this.EnterPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EnterPass.Location = new System.Drawing.Point(266, 348);
            this.EnterPass.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EnterPass.MaxLength = 16;
            this.EnterPass.Name = "EnterPass";
            this.EnterPass.PasswordChar = '*';
            this.EnterPass.Size = new System.Drawing.Size(517, 22);
            this.EnterPass.TabIndex = 1;
            // 
            // Register
            // 
            this.Register.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Register.Location = new System.Drawing.Point(474, 389);
            this.Register.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(100, 28);
            this.Register.TabIndex = 2;
            this.Register.Text = "Sign Up";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(265, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(519, 252);
            this.textBox1.TabIndex = 3;
            // 
            // LogButton
            // 
            this.LogButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogButton.Location = new System.Drawing.Point(474, 389);
            this.LogButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(100, 28);
            this.LogButton.TabIndex = 4;
            this.LogButton.Text = "Sign In";
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Option);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SignIn";
            this.Text = "Sign In";
            this.Option.ResumeLayout(false);
            this.Login.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.Signup.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Option;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TabPage Signup;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox EnterUser;
        private System.Windows.Forms.TextBox EnterPass;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button LogButton;
    }
}