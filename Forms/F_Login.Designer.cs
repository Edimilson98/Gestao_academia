namespace estudocsharp
{
    partial class F_Login
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
            this.lb_userName = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.lb_senha = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.btn_logar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_userName
            // 
            this.lb_userName.AutoSize = true;
            this.lb_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_userName.Location = new System.Drawing.Point(15, 9);
            this.lb_userName.Name = "lb_userName";
            this.lb_userName.Size = new System.Drawing.Size(43, 16);
            this.lb_userName.TabIndex = 0;
            this.lb_userName.Text = "Login:";
            // 
            // tb_username
            // 
            this.tb_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(19, 30);
            this.tb_username.Multiline = true;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(237, 24);
            this.tb_username.TabIndex = 1;
            this.tb_username.Text = "edimilsonluiz";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.Location = new System.Drawing.Point(16, 65);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(49, 16);
            this.lb_senha.TabIndex = 2;
            this.lb_senha.Text = "Senha:";
            // 
            // tb_senha
            // 
            this.tb_senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_senha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha.Location = new System.Drawing.Point(19, 82);
            this.tb_senha.Multiline = true;
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(237, 24);
            this.tb_senha.TabIndex = 3;
            this.tb_senha.Text = "123";
            // 
            // btn_logar
            // 
            this.btn_logar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_logar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_logar.Location = new System.Drawing.Point(18, 124);
            this.btn_logar.Name = "btn_logar";
            this.btn_logar.Size = new System.Drawing.Size(240, 34);
            this.btn_logar.TabIndex = 4;
            this.btn_logar.Text = "Entrar";
            this.btn_logar.UseVisualStyleBackColor = false;
            this.btn_logar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cancelar.Location = new System.Drawing.Point(18, 164);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(240, 34);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria Math", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 161);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sistemas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MingLiU-ExtB", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGreen;
            this.label2.Location = new System.Drawing.Point(327, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "L";
            // 
            // F_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(447, 210);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_logar);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lb_userName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logar";
            this.Load += new System.EventHandler(this.F_Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_userName;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Button btn_logar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}