namespace MascotContest
{
    partial class FrmPetOwner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPetOwner));
            this.pnlTopBarr = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.BtnList = new System.Windows.Forms.Button();
            this.Btndischarged = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnSave = new System.Windows.Forms.Button();
            this.pnlTopBarr.SuspendLayout();
            this.PnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBarr
            // 
            this.pnlTopBarr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopBarr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.pnlTopBarr.Controls.Add(this.label1);
            this.pnlTopBarr.Controls.Add(this.BtnClosed);
            this.pnlTopBarr.Location = new System.Drawing.Point(0, 0);
            this.pnlTopBarr.Name = "pnlTopBarr";
            this.pnlTopBarr.Size = new System.Drawing.Size(550, 50);
            this.pnlTopBarr.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de Propietario";
            // 
            // BtnClosed
            // 
            this.BtnClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClosed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClosed.Location = new System.Drawing.Point(501, 8);
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
            this.PnlContainer.Location = new System.Drawing.Point(48, 114);
            this.PnlContainer.Name = "PnlContainer";
            this.PnlContainer.Size = new System.Drawing.Size(450, 297);
            this.PnlContainer.TabIndex = 1;
            // 
            // TxtAddress
            // 
            this.TxtAddress.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtAddress.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAddress.Location = new System.Drawing.Point(122, 251);
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.Size = new System.Drawing.Size(300, 28);
            this.TxtAddress.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dirección";
            // 
            // TxtEmail
            // 
            this.TxtEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtEmail.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.Location = new System.Drawing.Point(122, 202);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(300, 28);
            this.TxtEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Correo";
            // 
            // MskPhone
            // 
            this.MskPhone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MskPhone.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskPhone.Location = new System.Drawing.Point(122, 155);
            this.MskPhone.Mask = "####-####";
            this.MskPhone.Name = "MskPhone";
            this.MskPhone.Size = new System.Drawing.Size(300, 28);
            this.MskPhone.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Teléfono";
            // 
            // TxtSurName
            // 
            this.TxtSurName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtSurName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSurName.Location = new System.Drawing.Point(122, 106);
            this.TxtSurName.Name = "TxtSurName";
            this.TxtSurName.Size = new System.Drawing.Size(300, 28);
            this.TxtSurName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos";
            // 
            // TxtNames
            // 
            this.TxtNames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TxtNames.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNames.Location = new System.Drawing.Point(122, 60);
            this.TxtNames.Name = "TxtNames";
            this.TxtNames.Size = new System.Drawing.Size(300, 28);
            this.TxtNames.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombres";
            // 
            // MskIdNumber
            // 
            this.MskIdNumber.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MskIdNumber.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MskIdNumber.Location = new System.Drawing.Point(122, 17);
            this.MskIdNumber.Mask = "###-######-####L";
            this.MskIdNumber.Name = "MskIdNumber";
            this.MskIdNumber.Size = new System.Drawing.Size(300, 28);
            this.MskIdNumber.TabIndex = 1;
            // 
            // LblCedula
            // 
            this.LblCedula.AutoSize = true;
            this.LblCedula.Location = new System.Drawing.Point(28, 25);
            this.LblCedula.Name = "LblCedula";
            this.LblCedula.Size = new System.Drawing.Size(61, 20);
            this.LblCedula.TabIndex = 0;
            this.LblCedula.Text = "Cedula";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(120, 72);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(323, 29);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Información de Propietario";
            // 
            // BtnList
            // 
            this.BtnList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnList.FlatAppearance.BorderSize = 0;
            this.BtnList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnList.Image = ((System.Drawing.Image)(resources.GetObject("BtnList.Image")));
            this.BtnList.Location = new System.Drawing.Point(372, 424);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(44, 44);
            this.BtnList.TabIndex = 6;
            this.BtnList.UseVisualStyleBackColor = true;
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // Btndischarged
            // 
            this.Btndischarged.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btndischarged.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btndischarged.FlatAppearance.BorderSize = 0;
            this.Btndischarged.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btndischarged.Image = ((System.Drawing.Image)(resources.GetObject("Btndischarged.Image")));
            this.Btndischarged.Location = new System.Drawing.Point(430, 424);
            this.Btndischarged.Name = "Btndischarged";
            this.Btndischarged.Size = new System.Drawing.Size(44, 44);
            this.Btndischarged.TabIndex = 5;
            this.Btndischarged.UseVisualStyleBackColor = true;
            this.Btndischarged.Click += new System.EventHandler(this.Btndischarged_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.FlatAppearance.BorderSize = 0;
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Image = global::MascotContest.Properties.Resources.btn_edit1;
            this.BtnEdit.Location = new System.Drawing.Point(315, 424);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(44, 44);
            this.BtnEdit.TabIndex = 4;
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatAppearance.BorderSize = 0;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Image = global::MascotContest.Properties.Resources.btn_save1;
            this.BtnSave.Location = new System.Drawing.Point(256, 424);
            this.BtnSave.Margin = new System.Windows.Forms.Padding(0);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(44, 44);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // PetOwnerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(548, 497);
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
            this.pnlTopBarr.PerformLayout();
            this.PnlContainer.ResumeLayout(false);
            this.PnlContainer.PerformLayout();
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
        private System.Windows.Forms.Label label1;
    }
}

