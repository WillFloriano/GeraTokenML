using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace GeraToken
{
    public partial class frmIntegra : Form
    {
        DataTable dt = new DataTable();
        Thread t1;
        Thread t2;
        public frmIntegra()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openHome);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnCadasrtro_Click(object sender, EventArgs e)
        {
            string client = txtClientId.Text;
            string key = txtSecretKey.Text;
            string token = txtToken.Text;
            string refresh = txtRefresh.Text;
            string vencimento = txtVence.Text;

            if (string.IsNullOrEmpty(client))
            {
                MessageBox.Show("Client Id é obrigatório!");
                txtRefresh.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("Secret Key é obrigatório!");
                txtSecretKey.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(token))
            {
                MessageBox.Show("Token atual é obrigatório!");
                txtToken.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(refresh))
            {
                MessageBox.Show("Refresh Token é obrigatório!");
                txtClientId.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(vencimento))
            {
                MessageBox.Show("Data vencimento token é obrigatório!");
                txtVence.Focus();
                return;
            }

            string sql = "INSERT INTO TB_TOKEN (CLIENT_ID, SECRET_KEY, ACCESS_TOKEN, REFRESH_TOKEN, EXPIRA_EM) VALUES(" + "'" + client + "'," + "'" + key + "'," + "'" + token + "'," + "'" + refresh + "'," + "'" + vencimento + "'" + ")";
            dt = DataBase.insert(sql);

            if (!dt.HasErrors)
            {
                MessageBox.Show("Integração Cadastrada com sucesso!");
                this.Close();
                t2 = new Thread(openHome);
                t2.SetApartmentState(ApartmentState.STA);
                t2.Start();
            }
        }
        private void openHome(object obj)
        {
            Application.Run(new Home());
        }

    }
}
