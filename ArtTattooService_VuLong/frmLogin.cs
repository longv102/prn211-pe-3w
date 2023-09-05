using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtTattooService_VuLong
{
    public partial class frmLogin : Form
    {
        private static readonly int STAFF_ROLE = 2;
        IRepo _repo = new Repo();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string email = txtEmail.Text;
                string password = txtPassword.Text;
                AccountMember loginMember = _repo.CheckLogin(email, password);
                if (loginMember != null)
                {
                    if (STAFF_ROLE == loginMember.Role)
                    {
                        frmArtTattooStyle frmArtTattooStyle = new frmArtTattooStyle()
                        {
                            GetStaff = loginMember
                        };
                        frmArtTattooStyle.Show();
                        this.Hide();
                        frmArtTattooStyle.FormClosed += (s, args) => this.Close();
                    }
                    else
                    {
                        MessageBox.Show("You have no permission to access this function!");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect Email or Password!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
