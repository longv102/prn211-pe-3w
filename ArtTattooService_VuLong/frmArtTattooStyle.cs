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
    public partial class frmArtTattooStyle : Form
    {
        IRepo _repo = new Repo();
        public AccountMember GetStaff { get; set; }
        public frmArtTattooStyle()
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

        private void LoadStyles()
        {
            try
            {
                BindingSource source = new BindingSource();
                source.DataSource = _repo.GetArtTattooStyles();

                txtId.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtLocation.DataBindings.Clear();
                cboService.DataBindings.Clear();

                txtId.DataBindings.Add("Text", source, "TattooStyleId");
                txtName.DataBindings.Add("Text", source, "TattooStyleName");
                txtDescription.DataBindings.Add("Text", source, "StyleDescription");
                txtPrice.DataBindings.Add("Text", source, "StylePrice");
                txtLocation.DataBindings.Add("Text", source, "TattooLocation");
                cboService.DataBindings.Add("Text", source, "ServiceName");

                dgvResult.DataSource = source;
                dgvResult.Columns["ServiceId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load styles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadStyles(List<ArtTattooStyleDTO> list)
        {
            try
            {
                BindingSource source = new BindingSource();
                source.DataSource = list;

                txtId.DataBindings.Clear();
                txtName.DataBindings.Clear();
                txtDescription.DataBindings.Clear();
                txtPrice.DataBindings.Clear();
                txtLocation.DataBindings.Clear();
                cboService.DataBindings.Clear();

                txtId.DataBindings.Add("Text", source, "TattooStyleId");
                txtName.DataBindings.Add("Text", source, "TattooStyleName");
                txtDescription.DataBindings.Add("Text", source, "StyleDescription");
                txtPrice.DataBindings.Add("Text", source, "StylePrice");
                txtLocation.DataBindings.Add("Text", source, "TattooLocation");
                cboService.DataBindings.Add("Text", source, "ServiceName");

                dgvResult.DataSource = source;
                dgvResult.Columns["ServiceId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load styles", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmArtTattooStyle_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            LoadStyles();
            LoadServices();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchValue = txtSearch.Text.Trim();
                if (rdoLocation.Checked)
                {
                    List<ArtTattooStyleDTO> result = _repo.SearchStylesByLocation(searchValue);
                    if (result.Any())
                    {
                        LoadServices();
                        LoadStyles(result);

                    }
                    else
                    {
                        MessageBox.Show("No record is matched!");
                    }
                }
                else if (rdoDescription.Checked)
                {
                    List<ArtTattooStyleDTO> result = _repo.SearchStylesByDescription(searchValue);
                    if (result.Any())
                    {
                        LoadServices();
                        LoadStyles(result);
                    }
                    else
                    {
                        MessageBox.Show("No record is matched!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int styleId = int.Parse(txtId.Text);
                if (MessageBox.Show("Delete this style?", "Delete", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _repo.DeleteAStyle(styleId);
                    LoadStyles();
                    LoadServices();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            frmCreateUpdate frmCreateUpdate = new frmCreateUpdate()
            {
                IsUpdate = false
            };
            frmCreateUpdate.Show();
        }
    }
}
