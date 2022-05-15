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
using System.Net;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Serializers;

namespace GeraToken
{
    public partial class Home : Form
    {
        Thread t2;
        Thread t1;
        Thread t3;
        DataTable dt = new DataTable();
        DataTable dr = new DataTable();
        public Home()
        {
            InitializeComponent();

            if (Global.loged == true)
            {
                lblNivel.Text = Global.acesso.ToString();
                lblUserName.Text = Global.username;

                string sql = "SELECT * FROM TB_TOKEN";
                dt = DataBase.request(sql);

                if (!dt.HasErrors && dt.Rows.Count > 0)
                {
                    lblToken.Text = dt.Rows[0].ItemArray[0].ToString();

                    lblData.Text = dt.Rows[0].ItemArray[1].ToString();

                    btnRefresh.Visible = true;

                    btnIntegracao.Visible = false;
                }
                else
                {
                    btnRefresh.Visible = false;
                }
            }
        }

        private void logOfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(openLogin);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        public void openLogin()
        {
            Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // faz o metodo de refresh aqui

            string strData = string.Empty;
            string strPOST = string.Empty;
            string[] strRetorno;

            try
            {

                string strRefreshToken = dt.Rows[0].ItemArray[2].ToString();

                strData = "grant_type=refresh_token&client_id=";
                strData += dt.Rows[0].ItemArray[3].ToString();
                strData += "&client_secret=";
                strData += dt.Rows[0].ItemArray[4].ToString();
                strData += "&refresh_token=";
                strData += strRefreshToken;

                strPOST = "https://api.mercadolibre.com/oauth/token?" + strData;

                var client = new RestClient(strPOST);

                var request = new RestRequest(Method.POST);
                request.AddHeader("accept", "application/json");
                request.AddHeader("content-type", "application/x-www-form-urlencoded");
                IRestResponse response = client.Execute(request);
                strRetorno = response.Content.ToString();

                if (response.ErrorMessage.Contains("error validating grant"))
                {
                    MessageBox.Show("Erro ao renovar Token, tente novamente");
                }
                else
                {
                    MessageBox.Show("Token renovado com sucesso");

                    string sql = "UPDATE TB_TOKEN SET REFRESH_TOKEN ='"  + "'" + ", ACCESS_TOKEN='" + strRetorno.Replace("","") + "'" + "EXPIRA_EM ='" + "'";
                    dt = DataBase.request(sql);


                    this.Close();
                    t3 = new Thread(openHome);
                    t3.SetApartmentState(ApartmentState.STA);
                    t3.Start();

                }

            }
            catch (Exception ex)
            {

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
            t2 = new Thread(openLogin);
            t2.SetApartmentState(ApartmentState.STA);
            t2.Start();
        }

        private void btnIntegracao_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openIntegra);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        public void openIntegra()
        {
            Application.Run(new frmIntegra());
        }

        public void openHome()
        {
            Application.Run(new Home());
        }
    }
}
