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
using GeraToken;

namespace GeraToken
{
    public partial class Login : Form
    {
        Thread t1;
        DataTable dt = new DataTable();
        public Login()
        {
            InitializeComponent();

        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Close();               
            t1 = new Thread(openCadastro);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btbLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string passWord = txtPassword.Text;

            if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Digite um usuário e senha!");
                txtUserName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Digite seu usuário!");
                txtUserName.Focus();
                return;
            }
            else if (!string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Digite sua senha!");
                txtPassword.Focus();
                return;
            }

            string sql = "SELECT * FROM TB_USER WHERE USER_LOGIN='" + userName + "'AND USER_PASSWORD='" + passWord + "'";
            dt = DataBase.request(sql);

            if (dt.Rows.Count == 1)
            {                
                Global.acesso = int.Parse(dt.Rows[0].Field<Int64>("USER_NIVEL").ToString());
                Global.username = dt.Rows[0].Field<string>("USER_LOGIN");
                Global.nivel = int.Parse(dt.Rows[0].Field<Int64>("USER_NIVEL").ToString());
                Global.loged = true;
                Global.ID = int.Parse(dt.Rows[0].Field<Int64>("ID_USER").ToString());

                this.Close();
                t1 = new Thread(openHome);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();

            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
            }            
        }
        private void openHome(object obj)
        {
            Application.Run(new Home());
        }

        private void openCadastro(object obj)
        {
            Application.Run(new frmCadastro());
        }

        private void openChangePass(object obj)
        {
            Application.Run(new ChangePassWord());
        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openChangePass);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
    }
}
