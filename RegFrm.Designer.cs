namespace MDK_05._01._01
{
    partial class RegFrm
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
            this.PassShow = new System.Windows.Forms.CheckBox();
            this.PasLab = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.PassLab2 = new System.Windows.Forms.Label();
            this.PasswordTxt2 = new System.Windows.Forms.TextBox();
            this.RegBtn = new System.Windows.Forms.Button();
            this.CanBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PassShow
            // 
            this.PassShow.AutoSize = true;
            this.PassShow.BackColor = System.Drawing.Color.Transparent;
            this.PassShow.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassShow.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PassShow.Location = new System.Drawing.Point(202, 140);
            this.PassShow.Name = "PassShow";
            this.PassShow.Size = new System.Drawing.Size(133, 22);
            this.PassShow.TabIndex = 11;
            this.PassShow.Text = "Показать пароль";
            this.PassShow.UseVisualStyleBackColor = false;
            this.PassShow.CheckedChanged += new System.EventHandler(this.PassShow_CheckedChanged);
            // 
            // PasLab
            // 
            this.PasLab.AutoSize = true;
            this.PasLab.BackColor = System.Drawing.Color.Transparent;
            this.PasLab.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasLab.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PasLab.Location = new System.Drawing.Point(79, 69);
            this.PasLab.Name = "PasLab";
            this.PasLab.Size = new System.Drawing.Size(78, 26);
            this.PasLab.TabIndex = 10;
            this.PasLab.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(91, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Логин";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTxt.Location = new System.Drawing.Point(163, 62);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(172, 33);
            this.PasswordTxt.TabIndex = 8;
            // 
            // LoginTxt
            // 
            this.LoginTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTxt.Location = new System.Drawing.Point(163, 23);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(172, 33);
            this.LoginTxt.TabIndex = 7;
            // 
            // PassLab2
            // 
            this.PassLab2.AutoSize = true;
            this.PassLab2.BackColor = System.Drawing.Color.Transparent;
            this.PassLab2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassLab2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PassLab2.Location = new System.Drawing.Point(12, 108);
            this.PassLab2.Name = "PassLab2";
            this.PassLab2.Size = new System.Drawing.Size(145, 26);
            this.PassLab2.TabIndex = 13;
            this.PassLab2.Text = "Повтор пароля";
            // 
            // PasswordTxt2
            // 
            this.PasswordTxt2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTxt2.Location = new System.Drawing.Point(163, 101);
            this.PasswordTxt2.Name = "PasswordTxt2";
            this.PasswordTxt2.PasswordChar = '*';
            this.PasswordTxt2.Size = new System.Drawing.Size(172, 33);
            this.PasswordTxt2.TabIndex = 12;
            // 
            // RegBtn
            // 
            this.RegBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegBtn.Location = new System.Drawing.Point(224, 179);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(111, 26);
            this.RegBtn.TabIndex = 14;
            this.RegBtn.Text = "Регистрация";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // CanBtn
            // 
            this.CanBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CanBtn.Location = new System.Drawing.Point(46, 179);
            this.CanBtn.Name = "CanBtn";
            this.CanBtn.Size = new System.Drawing.Size(111, 26);
            this.CanBtn.TabIndex = 15;
            this.CanBtn.Text = "Назад";
            this.CanBtn.UseVisualStyleBackColor = true;
            this.CanBtn.Click += new System.EventHandler(this.CanBtn_Click);
            // 
            // RegFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MDK_05._01._01.Properties.Resources.fone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(366, 233);
            this.Controls.Add(this.CanBtn);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.PassLab2);
            this.Controls.Add(this.PasswordTxt2);
            this.Controls.Add(this.PassShow);
            this.Controls.Add(this.PasLab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.LoginTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RegFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegFrm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegFrm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox PassShow;
        private System.Windows.Forms.Label PasLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.TextBox LoginTxt;
        private System.Windows.Forms.Label PassLab2;
        private System.Windows.Forms.TextBox PasswordTxt2;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.Button CanBtn;
    }
}