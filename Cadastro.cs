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
    public partial class frmCadastro : Form
    {
        DataTable dt = new DataTable();
        Thread t1;
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openLogin);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnCadasrtro_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string lastName = txtLastName.Text;
            string email = txtEmail.Text;
            string userLogin = txtUser.Text;
            string passWord = txtPassWord.Text;

            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Digite um usuário e senha!");
                txtUser.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(lastName))
            {
                MessageBox.Show("Digite um usuário e senha!");
                txtLastName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Digite um usuário e senha!");
                txtEmail.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(userLogin))
            {
                MessageBox.Show("Digite um usuário e senha!");
                txtUserName.Focus();
                return;
            }
            else if (string.IsNullOrEmpty(passWord))
            {
                MessageBox.Show("Digite um usuário e senha!");
                txtPassWord.Focus();
                return;
            }

            string sql = "INSERT INTO TB_USER (USER_NAME, LAST_NAME, USER_EMAIL, USER_LOGIN, USER_PASSWORD, USER_STATUS, USER_NIVEL) VALUES(" + "'" + userName + "'," + "'" + lastName + "'," + "'" + email + "'," + "'" + userLogin + "'," + "'" + passWord + "',1,1" + ")";
            dt = DataBase.insert(sql);

            if (!dt.HasErrors)
            {
                MessageBox.Show("Usuário Cadastrado com sucesso!");
                this.Close();
                t1 = new Thread(openLogin);
            }
        }
        private void openLogin(object obj)
        {
            Application.Run(new Login());
        }
    }
}
