namespace MascotContest
{
    partial class PetOwnerUI
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTopBarr = new System.Windows.Forms.Panel();
            this.BtnClosed = new System.Windows.Forms.Button();
            this.PnlContainer = new System.Windows.Forms.Panel();
            this.TxtAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEmail = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MskPhone = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSurName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNames = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MskIdNumber = new System.Windows.Forms.MaskedTextBox();
            this.LblCedula = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.Btndischarged = new System.Windows.Forms.Button();
            this.BtnList = new System.Windows.Forms.Button();
            this.DGView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTopBarr.SuspendLayout();
            this.PnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBarr
            // 
            this.pnlTopBarr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopBarr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTopBarr.Controls.Add(this.BtnClosed);
            this.pnlTopBarr.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBarr.Name = "pnlTopBarr";
            this.pnlTopBarr.Size = new System.Drawing.Size(1222, 50);
            this.pnlTopBarr.TabIndex = 0;
            // 
            // BtnClosed
            // 
            this.BtnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClosed.Location = new System.Drawing.Point(1170, 8);
            this.BtnClosed.Name = "BtnClosed";
            this.BtnClosed.Size = new System.Drawing.Size(38, 39);
            this.BtnClosed.TabIndex = 0;
            this.BtnClosed.Text = "X";
            this.BtnClosed.UseVisualStyleBackColor = true;
            this.BtnClosed.Click += new System.EventHandler(this.BtnClosed_Click);
            // 
            // PnlContainer
            // 
            this.PnlContainer.Controls.Add(this.TxtAddress);
            this.PnlContainer.Controls.Add(this.label6);
            this.PnlContainer.Controls.Add(this.TxtEmail);
            this.PnlContainer.Controls.Add(this.label5);
            this.PnlContainer.Controls.Add(this.MskPhone);
            this.PnlContainer.Controls.Add(this.label4);
            this.PnlContainer.Controls.Add(this.TxtSurName);
            this.PnlContainer.Controls.Add(this.label3);
            this.PnlContainer.Controls.Add(this.TxtNames);
            this.PnlContainer.Controls.Add(this.label2);
            this.PnlContainer.Controls.Add(this.MskIdNumber);
            this.PnlContainer.Controls.Add(this.LblCedula);
            this.PnlContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PnlContainer.Location = new System.Drawing.Point(49, 137);
            this.PnlContainer.Name = "PnlContainer";
            this.PnlContainer.Size = new System.Drawing.Size(450, 353);
            this.PnlContainer.TabIndex = 1;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtAddress.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(122, 297);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(300, 28);
            this.TxtAddress.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dirección";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtEmail.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(122, 242);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(300, 28);
            this.TxtEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Correo";
            // 
            // MskPhone
            // 
            this.MskPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MskPhone.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskPhone.Location = new System.Drawing.Point(122, 188);
            this.MskPhone.Mask = "####-####";
            this.MskPhone.Name = "MskPhone";
            this.MskPhone.Size = new System.Drawing.Size(300, 28);
            this.MskPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono";
            // 
            // TxtSurName
            // 
            this.TxtSurName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtSurName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurName.Location = new System.Drawing.Point(122, 135);
            this.TxtSurName.Name = "TxtSurName";
            this.TxtSurName.Size = new System.Drawing.Size(300, 28);
            this.TxtSurName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos";
            // 
            // TxtNames
            // 
            this.TxtNames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtNames.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNames.Location = new System.Drawing.Point(122, 82);
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.Size = new System.Drawing.Size(300, 28);
            this.TxtNames.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // MskIdNumber
            // 
            this.MskIdNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MskIdNumber.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskIdNumber.Location = new System.Drawing.Point(122, 31);
            this.MskIdNumber.Mask = "###-######-####A";
            this.MskIdNumber.Name = "MskIdNumber";
            this.MskIdNumber.Size = new System.Drawing.Size(300, 28);
            this.MskIdNumber.TabIndex = 1;
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Location = new System.Drawing.Point(28, 33);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(61, 20);
            this.LblCedula.TabIndex = 0;
            this.LblCedula.Text = "Cedula";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(148, 75);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(323, 29);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Información de Propietario";
            // 
            // BtnSave
            // 
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.Location = new System.Drawing.Point(532, 137);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(64, 64);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "Guardar";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.Location = new System.Drawing.Point(532, 207);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(64, 64);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // Btndischarged
            // 
            this.Btndischarged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btndischarged.Location = new System.Drawing.Point(532, 277);
            this.Btndischarged.Name = "Btndischarged";
            this.Btndischarged.Size = new System.Drawing.Size(64, 64);
            this.Btndischarged.TabIndex = 5;
            this.Btndischarged.Text = "Baja";
            this.Btndischarged.UseVisualStyleBackColor = true;
            this.Btndischarged.Click += new System.EventHandler(this.Btndischarged_Click);
            // 
            // BtnList
            // 
            this.BtnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnList.Location = new System.Drawing.Point(532, 347);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(64, 64);
            this.BtnList.TabIndex = 6;
            this.BtnList.Text = "Lista";
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // DGView
            // 
            this.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.DGView.Location = new System.Drawing.Point(627, 148);
            this.DGView.Name = "DGView";
            this.DGView.RowHeadersWidth = 51;
            this.DGView.RowTemplate.Height = 24;
            this.DGView.Size = new System.Drawing.Size(552, 218);
            this.DGView.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cedula";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellidos";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Estado";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // PetOwnerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1220, 538);
            this.Controls.Add(this.DGView);
            this.Controls.Add(this.BtnList);
            this.Controls.Add(this.Btndischarged);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.PnlContainer);
            this.Controls.Add(this.pnlTopBarr);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PetOwnerUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catálogo Propietario Mascota";
            this.pnlTopBarr.ResumeLayout(false);
            this.PnlContainer.ResumeLayout(false);
            this.PnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopBarr;
        private System.Windows.Forms.Panel PnlContainer;
        private System.Windows.Forms.Label LblCedula;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.TextBox TxtAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TxtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MskPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSurName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MskIdNumber;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button Btndischarged;
        private System.Windows.Forms.Button BtnList;
        private System.Windows.Forms.Button BtnClosed;
        private System.Windows.Forms.DataGridView DGView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

