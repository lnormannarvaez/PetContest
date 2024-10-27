namespace MascotContest.UI
{
    partial class FrmListPetOwner
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
            this.label2 = new System.Windows.Forms.Label();
            this.DGrView = new System.Windows.Forms.DataGridView();
            this.ColIdNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGrView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(256, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Propietarios de Mascotas";
            // 
            // DGrView
            // 
            this.DGrView.AllowUserToDeleteRows = false;
            this.DGrView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdNumber,
            this.ColNames,
            this.ColSurName,
            this.ColPhone,
            this.ColEmail,
            this.ColAddress});
            this.DGrView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DGrView.Location = new System.Drawing.Point(52, 106);
            this.DGrView.Name = "DGrView";
            this.DGrView.ReadOnly = true;
            this.DGrView.RowHeadersWidth = 50;
            this.DGrView.RowTemplate.Height = 28;
            this.DGrView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DGrView.Size = new System.Drawing.Size(1212, 465);
            this.DGrView.TabIndex = 2;
            // 
            // ColIdNumber
            // 
            this.ColIdNumber.FillWeight = 120F;
            this.ColIdNumber.HeaderText = "Cédula";
            this.ColIdNumber.MinimumWidth = 50;
            this.ColIdNumber.Name = "ColIdNumber";
            this.ColIdNumber.ReadOnly = true;
            this.ColIdNumber.Width = 110;
            // 
            // ColNames
            // 
            this.ColNames.HeaderText = "Nombres";
            this.ColNames.MinimumWidth = 100;
            this.ColNames.Name = "ColNames";
            this.ColNames.ReadOnly = true;
            this.ColNames.Width = 160;
            // 
            // ColSurName
            // 
            this.ColSurName.HeaderText = "Apellidos";
            this.ColSurName.MinimumWidth = 100;
            this.ColSurName.Name = "ColSurName";
            this.ColSurName.ReadOnly = true;
            this.ColSurName.Width = 160;
            // 
            // ColPhone
            // 
            this.ColPhone.HeaderText = "Teléfono";
            this.ColPhone.MinimumWidth = 80;
            this.ColPhone.Name = "ColPhone";
            this.ColPhone.ReadOnly = true;
            this.ColPhone.Width = 90;
            // 
            // ColEmail
            // 
            this.ColEmail.HeaderText = "Correo Electrónico";
            this.ColEmail.MinimumWidth = 100;
            this.ColEmail.Name = "ColEmail";
            this.ColEmail.ReadOnly = true;
            this.ColEmail.Width = 260;
            // 
            // ColAddress
            // 
            this.ColAddress.HeaderText = "Domicilio";
            this.ColAddress.MinimumWidth = 100;
            this.ColAddress.Name = "ColAddress";
            this.ColAddress.ReadOnly = true;
            this.ColAddress.Width = 260;
            // 
            // FrmListPetOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1310, 638);
            this.Controls.Add(this.DGrView);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmListPetOwner";
            this.ShowIcon = false;
            this.Text = "Listado de Propietarios";
            this.Load += new System.EventHandler(this.FrmListPetOwner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGrView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGrView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColAddress;
    }
}