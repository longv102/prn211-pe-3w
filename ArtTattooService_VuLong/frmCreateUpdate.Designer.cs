namespace ArtTattooService_VuLong
{
    partial class frmCreateUpdate
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
            cboService = new System.Windows.Forms.ComboBox();
            txtLocation = new System.Windows.Forms.TextBox();
            txtPrice = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            txtName = new System.Windows.Forms.TextBox();
            txtId = new System.Windows.Forms.TextBox();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btCreate = new System.Windows.Forms.Button();
            btUpdate = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // cboService
            // 
            cboService.FormattingEnabled = true;
            cboService.Location = new System.Drawing.Point(543, 141);
            cboService.Name = "cboService";
            cboService.Size = new System.Drawing.Size(134, 28);
            cboService.TabIndex = 23;
            // 
            // txtLocation
            // 
            txtLocation.Location = new System.Drawing.Point(543, 98);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new System.Drawing.Size(125, 27);
            txtLocation.TabIndex = 22;
            // 
            // txtPrice
            // 
            txtPrice.Location = new System.Drawing.Point(543, 57);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new System.Drawing.Size(125, 27);
            txtPrice.TabIndex = 21;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(174, 142);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new System.Drawing.Size(125, 27);
            txtDescription.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(174, 98);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(125, 27);
            txtName.TabIndex = 19;
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(174, 57);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(125, 27);
            txtId.TabIndex = 18;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(474, 145);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(56, 20);
            label6.TabIndex = 17;
            label6.Text = "Service";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(474, 101);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(66, 20);
            label5.TabIndex = 16;
            label5.Text = "Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(474, 60);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(41, 20);
            label4.TabIndex = 15;
            label4.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(83, 145);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(85, 20);
            label3.TabIndex = 14;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(109, 101);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(49, 20);
            label2.TabIndex = 13;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(109, 60);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 20);
            label1.TabIndex = 12;
            label1.Text = "ID";
            // 
            // btCreate
            // 
            btCreate.Location = new System.Drawing.Point(325, 205);
            btCreate.Name = "btCreate";
            btCreate.Size = new System.Drawing.Size(94, 29);
            btCreate.TabIndex = 24;
            btCreate.Text = "Create";
            btCreate.UseVisualStyleBackColor = true;
            btCreate.Click += btCreate_Click;
            // 
            // btUpdate
            // 
            btUpdate.Location = new System.Drawing.Point(325, 205);
            btUpdate.Name = "btUpdate";
            btUpdate.Size = new System.Drawing.Size(94, 29);
            btUpdate.TabIndex = 25;
            btUpdate.Text = "Update";
            btUpdate.UseVisualStyleBackColor = true;
            btUpdate.Click += btUpdate_Click;
            // 
            // frmCreateUpdate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 290);
            Controls.Add(btUpdate);
            Controls.Add(btCreate);
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
            Name = "frmCreateUpdate";
            Text = "Create & Update";
            Load += frmCreateUpdate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cboService;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCreate;
        private System.Windows.Forms.Button btUpdate;
    }
}