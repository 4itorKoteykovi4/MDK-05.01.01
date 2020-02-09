namespace MDK_05._01._01
{
    partial class AuhtorizationFrm
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
            this.LoginTxt = new System.Windows.Forms.TextBox();
            this.PasswordTxt = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.RegBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PasLab = new System.Windows.Forms.Label();
            this.PassShow = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // LoginTxt
            // 
            this.LoginTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTxt.Location = new System.Drawing.Point(120, 12);
            this.LoginTxt.Name = "LoginTxt";
            this.LoginTxt.Size = new System.Drawing.Size(172, 33);
            this.LoginTxt.TabIndex = 0;
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTxt.Location = new System.Drawing.Point(120, 52);
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.Size = new System.Drawing.Size(172, 33);
            this.PasswordTxt.TabIndex = 1;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBtn.Location = new System.Drawing.Point(212, 131);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(80, 26);
            this.LoginBtn.TabIndex = 2;
            this.LoginBtn.Text = "Логин";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // RegBtn
            // 
            this.RegBtn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegBtn.Location = new System.Drawing.Point(30, 131);
            this.RegBtn.Name = "RegBtn";
            this.RegBtn.Size = new System.Drawing.Size(111, 26);
            this.RegBtn.TabIndex = 3;
            this.RegBtn.Text = "Регистрация";
            this.RegBtn.UseVisualStyleBackColor = true;
            this.RegBtn.Click += new System.EventHandler(this.RegBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // PasLab
            // 
            this.PasLab.AutoSize = true;
            this.PasLab.BackColor = System.Drawing.Color.Transparent;
            this.PasLab.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasLab.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PasLab.Location = new System.Drawing.Point(13, 59);
            this.PasLab.Name = "PasLab";
            this.PasLab.Size = new System.Drawing.Size(78, 26);
            this.PasLab.TabIndex = 5;
            this.PasLab.Text = "Пароль";
            // 
            // PassShow
            // 
            this.PassShow.AutoSize = true;
            this.PassShow.BackColor = System.Drawing.Color.Transparent;
            this.PassShow.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassShow.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.PassShow.Location = new System.Drawing.Point(159, 91);
            this.PassShow.Name = "PassShow";
            this.PassShow.Size = new System.Drawing.Size(133, 22);
            this.PassShow.TabIndex = 6;
            this.PassShow.Text = "Показать пароль";
            this.PassShow.UseVisualStyleBackColor = false;
            this.PassShow.CheckedChanged += new System.EventHandler(this.PassShow_CheckedChanged);
            // 
            // AuhtorizationFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MDK_05._01._01.Properties.Resources.fone;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(335, 191);
            this.Controls.Add(this.PassShow);
            this.Controls.Add(this.PasLab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegBtn);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.PasswordTxt);
            this.Controls.Add(this.LoginTxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AuhtorizationFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AuhtorizationFrm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginTxt;
        private System.Windows.Forms.TextBox PasswordTxt;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Button RegBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PasLab;
        private System.Windows.Forms.CheckBox PassShow;
    }
}

