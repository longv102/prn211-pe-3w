namespace ArtTattooService_VuLong
{
    partial class frmArtTattooStyle
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            txtLocation = new System.Windows.Forms.TextBox();
            cboService = new System.Windows.Forms.ComboBox();
            dgvResult = new System.Windows.Forms.DataGridView();
            groupBox1 = new System.Windows.Forms.GroupBox();
            rdoLocation = new System.Windows.Forms.RadioButton();
            rdoDescription = new System.Windows.Forms.RadioButton();
            txtSearch = new System.Windows.Forms.TextBox();
            btSearch = new System.Windows.Forms.Button();
            btDelete = new System.Windows.Forms.Button();
            btAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvResult).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(94, 41);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 20);
            label1.TabIndex = 0;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(94, 82);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(68, 126);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(459, 41);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 20);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(459, 82);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(66, 20);
            label5.TabIndex = 4;
            label5.Text = "Location";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(459, 126);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(56, 20);
            label6.TabIndex = 5;
            label6.Text = "Service";
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(159, 38);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(125, 27);
            txtId.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(159, 79);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(125, 27);
            txtName.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(159, 123);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(125, 27);
            txtDescription.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(528, 38);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(125, 27);
            txtPrice.TabIndex = 9;
            // 
            // txtLocation
            // 
            txtLocation.Location = new System.Drawing.Point(528, 79);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new System.Drawing.Size(125, 27);
            txtLocation.TabIndex = 10;
            // 
            // cboService
            // 
            cboService.FormattingEnabled = true;
            cboService.Location = new System.Drawing.Point(528, 122);
            cboService.Name = "cboService";
            cboService.Size = new System.Drawing.Size(134, 28);
            cboService.TabIndex = 11;
            // 
            // dgvResult
            // 
            dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResult.Location = new System.Drawing.Point(12, 321);
            dgvResult.Name = "dgvResult";
            dgvResult.RowHeadersWidth = 51;
            dgvResult.RowTemplate.Height = 29;
            dgvResult.Size = new System.Drawing.Size(776, 131);
            dgvResult.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoLocation);
            groupBox1.Controls.Add(rdoDescription);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Controls.Add(btSearch);
            groupBox1.Location = new System.Drawing.Point(23, 193);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(314, 96);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Search Box";
            // 
            // rdoLocation
            // 
            rdoLocation.AutoSize = true;
            rdoLocation.Location = new System.Drawing.Point(194, 57);
            rdoLocation.Name = "rdoLocation";
            rdoLocation.Size = new System.Drawing.Size(87, 24);
            rdoLocation.TabIndex = 19;
            rdoLocation.TabStop = true;
            rdoLocation.Text = "Location";
            rdoLocation.UseVisualStyleBackColor = true;
            // 
            // rdoDescription
            // 
            rdoDescription.AutoSize = true;
            rdoDescription.Location = new System.Drawing.Point(194, 14);
            rdoDescription.Name = "rdoDescription";
            rdoDescription.Size = new System.Drawing.Size(106, 24);
            rdoDescription.TabIndex = 18;
            rdoDescription.TabStop = true;
            rdoDescription.Text = "Description";
            rdoDescription.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(6, 44);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(101, 27);
            txtSearch.TabIndex = 17;
            // 
            // btSearch
            // 
            btSearch.Location = new System.Drawing.Point(113, 42);
            btSearch.Name = "btSearch";
            btSearch.Size = new System.Drawing.Size(73, 29);
            btSearch.TabIndex = 16;
            btSearch.Text = "Search";
            btSearch.UseVisualStyleBackColor = true;
            btSearch.Click += btSearch_Click;
            // 
            // btDelete
            // 
            btDelete.DialogResult = System.Windows.Forms.DialogResult.Yes;
            btDelete.Location = new System.Drawing.Point(374, 226);
            btDelete.Name = "btDelete";
            btDelete.Size = new System.Drawing.Size(94, 29);
            btDelete.TabIndex = 14;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btAdd
            // 
            btAdd.Location = new System.Drawing.Point(568, 226);
            btAdd.Name = "btAdd";
            btAdd.Size = new System.Drawing.Size(94, 29);
            btAdd.TabIndex = 15;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // frmArtTattooStyle
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 464);
            Controls.Add(btAdd);
            Controls.Add(btDelete);
            Controls.Add(groupBox1);
            Controls.Add(dgvResult);
            Controls.Add(cboService);
            Controls.Add(txtLocation);
            Controls.Add(txtPrice);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmArtTattooStyle";
            Text = "Art Tattoo Style";
            Load += frmArtTattooStyle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvResult).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.RadioButton rdoLocation;
        private System.Windows.Forms.RadioButton rdoDescription;
    }
}