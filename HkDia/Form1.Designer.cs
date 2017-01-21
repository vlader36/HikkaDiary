namespace HkDia
{
    partial class Form1
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
            this.tName = new System.Windows.Forms.TextBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tPass = new System.Windows.Forms.TextBox();
            this.bClose = new System.Windows.Forms.Button();
            this.bLogin = new System.Windows.Forms.Button();
            this.bReg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tName
            // 
            this.tName.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tName.Location = new System.Drawing.Point(121, 91);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(631, 28);
            this.tName.TabIndex = 0;
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Segoe Script", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lStatus.Location = new System.Drawing.Point(235, 9);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(344, 58);
            this.lStatus.TabIndex = 1;
            this.lStatus.Text = "Ты снова тут...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Твоё имя?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Твой пароль?";
            // 
            // tPass
            // 
            this.tPass.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tPass.Location = new System.Drawing.Point(121, 131);
            this.tPass.Name = "tPass";
            this.tPass.Size = new System.Drawing.Size(631, 28);
            this.tPass.TabIndex = 0;
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClose.Location = new System.Drawing.Point(528, 165);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(224, 37);
            this.bClose.TabIndex = 3;
            this.bClose.Text = "Уйти";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // bLogin
            // 
            this.bLogin.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bLogin.Location = new System.Drawing.Point(257, 165);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(265, 37);
            this.bLogin.TabIndex = 3;
            this.bLogin.Text = "Войти";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bReg
            // 
            this.bReg.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bReg.Location = new System.Drawing.Point(13, 165);
            this.bReg.Name = "bReg";
            this.bReg.Size = new System.Drawing.Size(238, 37);
            this.bReg.TabIndex = 3;
            this.bReg.Text = "Ещё не с нами?";
            this.bReg.UseVisualStyleBackColor = true;
            this.bReg.Click += new System.EventHandler(this.bReg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 218);
            this.Controls.Add(this.bReg);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.tPass);
            this.Controls.Add(this.tName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tPass;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bLogin;
        private System.Windows.Forms.Button bReg;
    }
}

