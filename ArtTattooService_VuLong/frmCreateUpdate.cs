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
    public partial class frmCreateUpdate : Form
    {
        public bool IsUpdate { get; set; }
        public ArtTattooStyleDTO GetCurrentSytle { get; set; }
        IRepo _repo = new Repo();
        public frmCreateUpdate()
        {
            InitializeComponent();
        }

        private void LoadServices()
        {
            try
            {
                BindingSource source = new BindingSource();
                source.DataSource = _repo.GetServices();
                cboService.DisplayMember = "ServiceName";
                cboService.ValueMember = "ServiceId";

                cboService.DataSource = source;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load services", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCreateUpdate_Load(object sender, EventArgs e)
        {
            LoadServices();
            btUpdate.Visible = false;
            btCreate.Visible = false;
            if (IsUpdate)
            {
                txtId.Enabled = false;
                btUpdate.Visible = IsUpdate;
            }
            else
            {
                btCreate.Visible = !IsUpdate;
            }
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ArtTattooStyle style = new ArtTattooStyle()
                {
                    TattooStyleId = int.Parse(txtId.Text),
                    TattooStyleName = txtName.Text,
                    StyleDescription = txtDescription.Text,
                    StylePrice = double.Parse(txtPrice.Text),
                    TattooLocation = txtLocation.Text,
                    ServiceId = (string)cboService.SelectedValue
                };
                _repo.AddAStyle(style);
                MessageBox.Show("Added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Create", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
