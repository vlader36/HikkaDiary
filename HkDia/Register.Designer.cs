namespace HkDia
{
    partial class Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.lName = new System.Windows.Forms.Label();
            this.lPass = new System.Windows.Forms.Label();
            this.lPassRepeat = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.tPass = new System.Windows.Forms.TextBox();
            this.tPassRepeat = new System.Windows.Forms.TextBox();
            this.bExit = new System.Windows.Forms.Button();
            this.bCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lName.Location = new System.Drawing.Point(12, 77);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(116, 20);
            this.lName.TabIndex = 0;
            this.lName.Text = "Введи своё имя";
            // 
            // lPass
            // 
            this.lPass.AutoSize = true;
            this.lPass.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPass.Location = new System.Drawing.Point(12, 118);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(97, 20);
            this.lPass.TabIndex = 0;
            this.lPass.Text = "Свой пароль";
            // 
            // lPassRepeat
            // 
            this.lPassRepeat.AutoSize = true;
            this.lPassRepeat.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPassRepeat.Location = new System.Drawing.Point(12, 160);
            this.lPassRepeat.Name = "lPassRepeat";
            this.lPassRepeat.Size = new System.Drawing.Size(106, 20);
            this.lPassRepeat.TabIndex = 0;
            this.lPassRepeat.Text = "Снова пароль";
            // 
            // tName
            // 
            this.tName.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tName.Location = new System.Drawing.Point(134, 74);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(415, 28);
            this.tName.TabIndex = 1;
            // 
            // tPass
            // 
            this.tPass.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tPass.Location = new System.Drawing.Point(134, 115);
            this.tPass.Name = "tPass";
            this.tPass.Size = new System.Drawing.Size(415, 28);
            this.tPass.TabIndex = 2;
            // 
            // tPassRepeat
            // 
            this.tPassRepeat.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tPassRepeat.Location = new System.Drawing.Point(134, 157);
            this.tPassRepeat.Name = "tPassRepeat";
            this.tPassRepeat.Size = new System.Drawing.Size(415, 28);
            this.tPassRepeat.TabIndex = 3;
            // 
            // bExit
            // 
            this.bExit.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bExit.Location = new System.Drawing.Point(290, 191);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(258, 37);
            this.bExit.TabIndex = 5;
            this.bExit.Text = "Уйти";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // bCreate
            // 
            this.bCreate.Font = new System.Drawing.Font("Segoe Script", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreate.Location = new System.Drawing.Point(12, 191);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(272, 37);
            this.bCreate.TabIndex = 4;
            this.bCreate.Text = "Создать профиль";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.bCreate_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 240);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.tPassRepeat);
            this.Controls.Add(this.tPass);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.lPassRepeat);
            this.Controls.Add(this.lPass);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.label1);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lPass;
        private System.Windows.Forms.Label lPassRepeat;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tPass;
        private System.Windows.Forms.TextBox tPassRepeat;
        private System.Windows.Forms.Button bExit;
        private System.Windows.Forms.Button bCreate;
    }
}