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
    public partial class ChangePassWord : Form
    {
        DataTable dt = new DataTable();
        Thread t1;
        public ChangePassWord()
        {
            InitializeComponent();
        }

        private void btnAlter_Click(object sender, EventArgs e)
        {
            if(txtNewPass.Text != txtRepeatPass.Text)
            {
                MessageBox.Show("As senhas devem ser iguais!");
            }
            else
            {
                string user = txtUser.Text;
                string newpass = txtNewPass.Text;
                string repPass = txtRepeatPass.Text;

                string sql = "UPDATE TB_USER SET USER_PASSWORD='" + newpass + "' WHERE USER_LOGIN='" + user + "'";
                dt = DataBase.update(sql);

                if(!dt.HasErrors)
                {
                    MessageBox.Show("Senha alterada com sucesso.");

                    this.Close();
                    t1 = new Thread(openLogin);
                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();
                }               
            }
        }
        private void openLogin(object obj)
        {
            Application.Run(new Login());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(openLogin);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
    }
}
