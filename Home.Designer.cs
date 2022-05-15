
namespace GeraToken
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlAcesso = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblAcesso = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lOGINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblVence = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblToken = new System.Windows.Forms.Label();
            this.btnIntegracao = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.pnlAcesso.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAcesso
            // 
            this.pnlAcesso.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.pnlAcesso.Controls.Add(this.lblUserName);
            this.pnlAcesso.Controls.Add(this.lblNivel);
            this.pnlAcesso.Controls.Add(this.pictureBox1);
            this.pnlAcesso.Controls.Add(this.lblUser);
            this.pnlAcesso.Controls.Add(this.lblAcesso);
            this.pnlAcesso.Location = new System.Drawing.Point(5, 376);
            this.pnlAcesso.Name = "pnlAcesso";
            this.pnlAcesso.Size = new System.Drawing.Size(773, 54);
            this.pnlAcesso.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(246, 22);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(31, 23);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.Text = "---";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(126, 22);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(22, 23);
            this.lblNivel.TabIndex = 2;
            this.lblNivel.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FinancesResource.Properties.Resources.ledverde;
            this.pictureBox1.Location = new System.Drawing.Point(11, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 22);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(154, 22);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(86, 23);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Usuario:";
            // 
            // lblAcesso
            // 
            this.lblAcesso.AutoSize = true;
            this.lblAcesso.Location = new System.Drawing.Point(40, 21);
            this.lblAcesso.Name = "lblAcesso";
            this.lblAcesso.Size = new System.Drawing.Size(80, 23);
            this.lblAcesso.TabIndex = 1;
            this.lblAcesso.Text = "Acesso:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lOGINToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(790, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lOGINToolStripMenuItem
            // 
            this.lOGINToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOfToolStripMenuItem});
            this.lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            this.lOGINToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.lOGINToolStripMenuItem.Text = "LOGIN";
            // 
            // logOfToolStripMenuItem
            // 
            this.logOfToolStripMenuItem.Name = "logOfToolStripMenuItem";
            this.logOfToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.logOfToolStripMenuItem.Text = "Logoff";
            this.logOfToolStripMenuItem.Click += new System.EventHandler(this.logOfToolStripMenuItem_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(26, 55);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(395, 28);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Seu Token atual é: ";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(255, 194);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(234, 56);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh Token";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblVence
            // 
            this.lblVence.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVence.Location = new System.Drawing.Point(26, 133);
            this.lblVence.Name = "lblVence";
            this.lblVence.Size = new System.Drawing.Size(238, 28);
            this.lblVence.TabIndex = 5;
            this.lblVence.Text = "Seu Token vencerá em: ";
            // 
            // lblData
            // 
            this.lblData.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(270, 133);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(238, 28);
            this.lblData.TabIndex = 6;
            // 
            // lblToken
            // 
            this.lblToken.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToken.Location = new System.Drawing.Point(217, 55);
            this.lblToken.Name = "lblToken";
            this.lblToken.Size = new System.Drawing.Size(561, 28);
            this.lblToken.TabIndex = 7;
            // 
            // btnIntegracao
            // 
            this.btnIntegracao.Location = new System.Drawing.Point(277, 314);
            this.btnIntegracao.Name = "btnIntegracao";
            this.btnIntegracao.Size = new System.Drawing.Size(234, 56);
            this.btnIntegracao.TabIndex = 8;
            this.btnIntegracao.Text = "Integrar Conta";
            this.btnIntegracao.UseVisualStyleBackColor = true;
            this.btnIntegracao.Click += new System.EventHandler(this.btnIntegracao_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(544, 314);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(234, 56);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(790, 442);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnIntegracao);
            this.Controls.Add(this.lblToken);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblVence);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pnlAcesso);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("NanumGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finances Resource - vs 1.0";
            this.pnlAcesso.ResumeLayout(false);
            this.pnlAcesso.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnlAcesso;
        public System.Windows.Forms.Label lblUserName;
        public System.Windows.Forms.Label lblUser;
        public System.Windows.Forms.Label lblNivel;
        public System.Windows.Forms.Label lblAcesso;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lOGINToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOfToolStripMenuItem;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblVence;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblToken;
        private System.Windows.Forms.Button btnIntegracao;
        private System.Windows.Forms.Button btnSair;
    }
}