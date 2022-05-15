
namespace GeraToken
{
    partial class ChangePassWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassWord));
            this.btnAlter = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblRepeatPass = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtRepeatPass = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlter
            // 
            this.btnAlter.Location = new System.Drawing.Point(233, 304);
            this.btnAlter.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlter.Name = "btnAlter";
            this.btnAlter.Size = new System.Drawing.Size(148, 33);
            this.btnAlter.TabIndex = 0;
            this.btnAlter.Text = "Alterar";
            this.btnAlter.UseVisualStyleBackColor = true;
            this.btnAlter.Click += new System.EventHandler(this.btnAlter_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUser.Location = new System.Drawing.Point(75, 68);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(80, 23);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Usuario";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.Location = new System.Drawing.Point(75, 148);
            this.lblNewPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(121, 23);
            this.lblNewPass.TabIndex = 2;
            this.lblNewPass.Text = "Nova Senha";
            // 
            // lblRepeatPass
            // 
            this.lblRepeatPass.AutoSize = true;
            this.lblRepeatPass.Location = new System.Drawing.Point(75, 233);
            this.lblRepeatPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRepeatPass.Name = "lblRepeatPass";
            this.lblRepeatPass.Size = new System.Drawing.Size(138, 23);
            this.lblRepeatPass.TabIndex = 3;
            this.lblRepeatPass.Text = "Repetir Senha";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(233, 68);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(148, 30);
            this.txtUser.TabIndex = 4;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(233, 148);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '#';
            this.txtNewPass.Size = new System.Drawing.Size(148, 30);
            this.txtNewPass.TabIndex = 5;
            // 
            // txtRepeatPass
            // 
            this.txtRepeatPass.Location = new System.Drawing.Point(233, 226);
            this.txtRepeatPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepeatPass.Name = "txtRepeatPass";
            this.txtRepeatPass.PasswordChar = '#';
            this.txtRepeatPass.Size = new System.Drawing.Size(148, 30);
            this.txtRepeatPass.TabIndex = 6;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(484, 332);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 35);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ChangePassWord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(621, 379);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtRepeatPass);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.lblRepeatPass);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.btnAlter);
            this.Font = new System.Drawing.Font("NanumGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePassWord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangePassWord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlter;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblNewPass;
        private System.Windows.Forms.Label lblRepeatPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtRepeatPass;
        private System.Windows.Forms.Button btnBack;
    }
}