
namespace GeraToken
{
    partial class frmIntegra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIntegra));
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.btnCadasrtro = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.txtVence = new System.Windows.Forms.TextBox();
            this.lblUserPass = new System.Windows.Forms.Label();
            this.txtRefresh = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtToken = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(27, 61);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(100, 23);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Client ID";
            // 
            // lblLastName
            // 
            this.lblLastName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(27, 117);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(142, 23);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Secret Key";
            // 
            // btnCadasrtro
            // 
            this.btnCadasrtro.Font = new System.Drawing.Font("NanumGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadasrtro.Location = new System.Drawing.Point(331, 383);
            this.btnCadasrtro.Name = "btnCadasrtro";
            this.btnCadasrtro.Size = new System.Drawing.Size(138, 52);
            this.btnCadasrtro.TabIndex = 5;
            this.btnCadasrtro.Text = "Cadastrar";
            this.btnCadasrtro.UseVisualStyleBackColor = true;
            this.btnCadasrtro.Click += new System.EventHandler(this.btnCadasrtro_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("NanumGothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(513, 383);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 52);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtClientId
            // 
            this.txtClientId.Font = new System.Drawing.Font("NanumGothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClientId.Location = new System.Drawing.Point(331, 51);
            this.txtClientId.Multiline = true;
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(329, 33);
            this.txtClientId.TabIndex = 7;
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Font = new System.Drawing.Font("NanumGothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretKey.Location = new System.Drawing.Point(331, 107);
            this.txtSecretKey.Multiline = true;
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(329, 33);
            this.txtSecretKey.TabIndex = 8;
            // 
            // txtVence
            // 
            this.txtVence.Font = new System.Drawing.Font("NanumGothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVence.Location = new System.Drawing.Point(331, 278);
            this.txtVence.Multiline = true;
            this.txtVence.Name = "txtVence";
            this.txtVence.Size = new System.Drawing.Size(329, 33);
            this.txtVence.TabIndex = 10;
            this.txtVence.Text = "2022-05-02 22:10:33.000";
            // 
            // lblUserPass
            // 
            this.lblUserPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserPass.Location = new System.Drawing.Point(27, 281);
            this.lblUserPass.Name = "lblUserPass";
            this.lblUserPass.Size = new System.Drawing.Size(215, 23);
            this.lblUserPass.TabIndex = 4;
            this.lblUserPass.Text = "Data Expiracao Atual";
            // 
            // txtRefresh
            // 
            this.txtRefresh.Font = new System.Drawing.Font("NanumGothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefresh.Location = new System.Drawing.Point(331, 213);
            this.txtRefresh.Multiline = true;
            this.txtRefresh.Name = "txtRefresh";
            this.txtRefresh.Size = new System.Drawing.Size(392, 33);
            this.txtRefresh.TabIndex = 11;
            // 
            // lblUserName
            // 
            this.lblUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(27, 223);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(149, 23);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "Resfreh Token";
            // 
            // txtToken
            // 
            this.txtToken.Font = new System.Drawing.Font("NanumGothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToken.Location = new System.Drawing.Point(331, 160);
            this.txtToken.Multiline = true;
            this.txtToken.Name = "txtToken";
            this.txtToken.Size = new System.Drawing.Size(740, 33);
            this.txtToken.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(27, 170);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(100, 23);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Token";
            // 
            // frmIntegra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1084, 460);
            this.Controls.Add(this.txtRefresh);
            this.Controls.Add(this.txtVence);
            this.Controls.Add(this.txtToken);
            this.Controls.Add(this.txtSecretKey);
            this.Controls.Add(this.txtClientId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCadasrtro);
            this.Controls.Add(this.lblUserPass);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIntegra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Button btnCadasrtro;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.TextBox txtVence;
        private System.Windows.Forms.Label lblUserPass;
        private System.Windows.Forms.TextBox txtRefresh;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtToken;
        private System.Windows.Forms.Label lblEmail;
    }
}