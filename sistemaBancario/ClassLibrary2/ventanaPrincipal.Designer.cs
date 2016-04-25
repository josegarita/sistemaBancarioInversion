namespace GUI
{
    partial class ventanaPrincipal
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
            this._labelCuenta = new System.Windows.Forms.Label();
            this._radioButtonCC = new System.Windows.Forms.RadioButton();
            this._radioButtonDAV = new System.Windows.Forms.RadioButton();
            this._radioButtonCertificado = new System.Windows.Forms.RadioButton();
            this._labelNC = new System.Windows.Forms.Label();
            this._textBoxNomClien = new System.Windows.Forms.TextBox();
            this._textBoxMoneda = new System.Windows.Forms.TextBox();
            this._labelMoneda = new System.Windows.Forms.Label();
            this._textBoxDias = new System.Windows.Forms.TextBox();
            this._labelPlazo = new System.Windows.Forms.Label();
            this._buttonConfirmar = new System.Windows.Forms.Button();
            this._textBoxMonto = new System.Windows.Forms.TextBox();
            this._labelMonto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _labelCuenta
            // 
            this._labelCuenta.AutoSize = true;
            this._labelCuenta.Location = new System.Drawing.Point(12, 9);
            this._labelCuenta.Name = "_labelCuenta";
            this._labelCuenta.Size = new System.Drawing.Size(142, 13);
            this._labelCuenta.TabIndex = 0;
            this._labelCuenta.Text = "Seleccione el tipo de cuenta";
            // 
            // _radioButtonCC
            // 
            this._radioButtonCC.AutoSize = true;
            this._radioButtonCC.Location = new System.Drawing.Point(15, 36);
            this._radioButtonCC.Name = "_radioButtonCC";
            this._radioButtonCC.Size = new System.Drawing.Size(106, 17);
            this._radioButtonCC.TabIndex = 1;
            this._radioButtonCC.TabStop = true;
            this._radioButtonCC.Text = "Cuenta Corriemte";
            this._radioButtonCC.UseVisualStyleBackColor = true;
            // 
            // _radioButtonDAV
            // 
            this._radioButtonDAV.AutoSize = true;
            this._radioButtonDAV.Location = new System.Drawing.Point(15, 60);
            this._radioButtonDAV.Name = "_radioButtonDAV";
            this._radioButtonDAV.Size = new System.Drawing.Size(105, 17);
            this._radioButtonDAV.TabIndex = 2;
            this._radioButtonDAV.TabStop = true;
            this._radioButtonDAV.Text = "Deposito a Plazo";
            this._radioButtonDAV.UseVisualStyleBackColor = true;
            // 
            // _radioButtonCertificado
            // 
            this._radioButtonCertificado.AutoSize = true;
            this._radioButtonCertificado.Location = new System.Drawing.Point(13, 84);
            this._radioButtonCertificado.Name = "_radioButtonCertificado";
            this._radioButtonCertificado.Size = new System.Drawing.Size(75, 17);
            this._radioButtonCertificado.TabIndex = 3;
            this._radioButtonCertificado.TabStop = true;
            this._radioButtonCertificado.Text = "Certificado";
            this._radioButtonCertificado.UseVisualStyleBackColor = true;
            // 
            // _labelNC
            // 
            this._labelNC.AutoSize = true;
            this._labelNC.Location = new System.Drawing.Point(227, 9);
            this._labelNC.Name = "_labelNC";
            this._labelNC.Size = new System.Drawing.Size(98, 13);
            this._labelNC.TabIndex = 4;
            this._labelNC.Text = "Nombre del cliente:";
            // 
            // _textBoxNomClien
            // 
            this._textBoxNomClien.Location = new System.Drawing.Point(230, 36);
            this._textBoxNomClien.Name = "_textBoxNomClien";
            this._textBoxNomClien.Size = new System.Drawing.Size(144, 20);
            this._textBoxNomClien.TabIndex = 5;
            // 
            // _textBoxMoneda
            // 
            this._textBoxMoneda.Location = new System.Drawing.Point(13, 189);
            this._textBoxMoneda.Name = "_textBoxMoneda";
            this._textBoxMoneda.Size = new System.Drawing.Size(144, 20);
            this._textBoxMoneda.TabIndex = 7;
            // 
            // _labelMoneda
            // 
            this._labelMoneda.AutoSize = true;
            this._labelMoneda.Location = new System.Drawing.Point(10, 162);
            this._labelMoneda.Name = "_labelMoneda";
            this._labelMoneda.Size = new System.Drawing.Size(89, 13);
            this._labelMoneda.TabIndex = 6;
            this._labelMoneda.Text = "Digite la moneda:";
            // 
            // _textBoxDias
            // 
            this._textBoxDias.Location = new System.Drawing.Point(230, 189);
            this._textBoxDias.Name = "_textBoxDias";
            this._textBoxDias.Size = new System.Drawing.Size(144, 20);
            this._textBoxDias.TabIndex = 9;
            // 
            // _labelPlazo
            // 
            this._labelPlazo.AutoSize = true;
            this._labelPlazo.Location = new System.Drawing.Point(227, 162);
            this._labelPlazo.Name = "_labelPlazo";
            this._labelPlazo.Size = new System.Drawing.Size(75, 13);
            this._labelPlazo.TabIndex = 8;
            this._labelPlazo.Text = "Plazo en días:";
            // 
            // _buttonConfirmar
            // 
            this._buttonConfirmar.Location = new System.Drawing.Point(318, 245);
            this._buttonConfirmar.Name = "_buttonConfirmar";
            this._buttonConfirmar.Size = new System.Drawing.Size(75, 23);
            this._buttonConfirmar.TabIndex = 10;
            this._buttonConfirmar.Text = "Confirmar";
            this._buttonConfirmar.UseVisualStyleBackColor = true;
            this._buttonConfirmar.Click += new System.EventHandler(this._buttonConfirmar_Click);
            // 
            // _textBoxMonto
            // 
            this._textBoxMonto.Location = new System.Drawing.Point(230, 115);
            this._textBoxMonto.Name = "_textBoxMonto";
            this._textBoxMonto.Size = new System.Drawing.Size(144, 20);
            this._textBoxMonto.TabIndex = 12;
            // 
            // _labelMonto
            // 
            this._labelMonto.AutoSize = true;
            this._labelMonto.Location = new System.Drawing.Point(227, 88);
            this._labelMonto.Name = "_labelMonto";
            this._labelMonto.Size = new System.Drawing.Size(80, 13);
            this._labelMonto.TabIndex = 11;
            this._labelMonto.Text = "Digite el monto:";
            // 
            // ventanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(405, 280);
            this.Controls.Add(this._textBoxMonto);
            this.Controls.Add(this._labelMonto);
            this.Controls.Add(this._buttonConfirmar);
            this.Controls.Add(this._textBoxDias);
            this.Controls.Add(this._labelPlazo);
            this.Controls.Add(this._textBoxMoneda);
            this.Controls.Add(this._labelMoneda);
            this.Controls.Add(this._textBoxNomClien);
            this.Controls.Add(this._labelNC);
            this.Controls.Add(this._radioButtonCertificado);
            this.Controls.Add(this._radioButtonDAV);
            this.Controls.Add(this._radioButtonCC);
            this.Controls.Add(this._labelCuenta);
            this.Name = "ventanaPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ventanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _labelCuenta;
        private System.Windows.Forms.RadioButton _radioButtonCC;
        private System.Windows.Forms.RadioButton _radioButtonDAV;
        private System.Windows.Forms.RadioButton _radioButtonCertificado;
        private System.Windows.Forms.Label _labelNC;
        private System.Windows.Forms.TextBox _textBoxNomClien;
        private System.Windows.Forms.TextBox _textBoxMoneda;
        private System.Windows.Forms.Label _labelMoneda;
        private System.Windows.Forms.TextBox _textBoxDias;
        private System.Windows.Forms.Label _labelPlazo;
        private System.Windows.Forms.Button _buttonConfirmar;
        private System.Windows.Forms.TextBox _textBoxMonto;
        private System.Windows.Forms.Label _labelMonto;

    }
}