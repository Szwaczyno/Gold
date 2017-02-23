namespace Gold
{
    partial class Main
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_password = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_changePassword = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.repeatNewPassword = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.inputNewPassword = new System.Windows.Forms.TextBox();
            this.inputNewPasswordRepeat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btChange = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.input_old_password = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tab_password.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tab_password);
            this.tabControl1.Location = new System.Drawing.Point(12, 82);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(889, 405);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_password
            // 
            this.tab_password.Controls.Add(this.groupBox1);
            this.tab_password.Location = new System.Drawing.Point(4, 4);
            this.tab_password.Name = "tab_password";
            this.tab_password.Padding = new System.Windows.Forms.Padding(3);
            this.tab_password.Size = new System.Drawing.Size(881, 379);
            this.tab_password.TabIndex = 0;
            this.tab_password.Text = "Change password";
            this.tab_password.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_changePassword);
            this.groupBox1.Controls.Add(this.bt_reset);
            this.groupBox1.Controls.Add(this.repeatNewPassword);
            this.groupBox1.Controls.Add(this.newPassword);
            this.groupBox1.Controls.Add(this.oldPassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(30, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 259);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change password";
            // 
            // bt_changePassword
            // 
            this.bt_changePassword.Enabled = false;
            this.bt_changePassword.Location = new System.Drawing.Point(10, 220);
            this.bt_changePassword.Name = "bt_changePassword";
            this.bt_changePassword.Size = new System.Drawing.Size(184, 26);
            this.bt_changePassword.TabIndex = 7;
            this.bt_changePassword.Text = "Change password";
            this.bt_changePassword.UseVisualStyleBackColor = true;
            this.bt_changePassword.Click += new System.EventHandler(this.btChange_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(10, 188);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(184, 26);
            this.bt_reset.TabIndex = 4;
            this.bt_reset.Text = "Reset";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // repeatNewPassword
            // 
            this.repeatNewPassword.Location = new System.Drawing.Point(10, 149);
            this.repeatNewPassword.Name = "repeatNewPassword";
            this.repeatNewPassword.PasswordChar = '*';
            this.repeatNewPassword.Size = new System.Drawing.Size(184, 20);
            this.repeatNewPassword.TabIndex = 6;
            this.repeatNewPassword.TextChanged += new System.EventHandler(this.check_draw);
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(10, 94);
            this.newPassword.Name = "newPassword";
            this.newPassword.PasswordChar = '*';
            this.newPassword.Size = new System.Drawing.Size(184, 20);
            this.newPassword.TabIndex = 5;
            this.newPassword.TextChanged += new System.EventHandler(this.check_draw);
            // 
            // oldPassword
            // 
            this.oldPassword.Location = new System.Drawing.Point(10, 44);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.PasswordChar = '*';
            this.oldPassword.Size = new System.Drawing.Size(184, 20);
            this.oldPassword.TabIndex = 4;
            this.oldPassword.TextChanged += new System.EventHandler(this.check_draw);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Old password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "New password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(6, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Repeat password";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(881, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(881, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(15, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 4;
            // 
            // inputNewPassword
            // 
            this.inputNewPassword.Location = new System.Drawing.Point(19, 101);
            this.inputNewPassword.Name = "inputNewPassword";
            this.inputNewPassword.PasswordChar = '*';
            this.inputNewPassword.Size = new System.Drawing.Size(175, 20);
            this.inputNewPassword.TabIndex = 3;
            // 
            // inputNewPasswordRepeat
            // 
            this.inputNewPasswordRepeat.Location = new System.Drawing.Point(19, 147);
            this.inputNewPasswordRepeat.Name = "inputNewPasswordRepeat";
            this.inputNewPasswordRepeat.PasswordChar = '*';
            this.inputNewPasswordRepeat.Size = new System.Drawing.Size(175, 20);
            this.inputNewPasswordRepeat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            // 
            // btChange
            // 
            this.btChange.Location = new System.Drawing.Point(19, 227);
            this.btChange.Name = "btChange";
            this.btChange.Size = new System.Drawing.Size(175, 31);
            this.btChange.TabIndex = 6;
            this.btChange.Text = "Change";
            this.btChange.UseVisualStyleBackColor = true;
            this.btChange.Click += new System.EventHandler(this.btChange_Click);
            // 
            // btReset
            // 
            this.btReset.Location = new System.Drawing.Point(19, 190);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(175, 31);
            this.btReset.TabIndex = 7;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // input_old_password
            // 
            this.input_old_password.Location = new System.Drawing.Point(19, 55);
            this.input_old_password.Name = "input_old_password";
            this.input_old_password.PasswordChar = '*';
            this.input_old_password.Size = new System.Drawing.Size(175, 20);
            this.input_old_password.TabIndex = 1;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(913, 499);
            this.Controls.Add(this.tabControl1);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_password.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tab_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputNewPassword;
        private System.Windows.Forms.TextBox inputNewPasswordRepeat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btChange;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.TextBox input_old_password;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_changePassword;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.TextBox repeatNewPassword;
        private System.Windows.Forms.TextBox newPassword;
        private System.Windows.Forms.TextBox oldPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

