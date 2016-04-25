namespace GUI
{
    partial class ventanaResultado
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
            this._buttonRetornar = new System.Windows.Forms.Button();
            this._labelMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _buttonRetornar
            // 
            this._buttonRetornar.Location = new System.Drawing.Point(520, 312);
            this._buttonRetornar.Name = "_buttonRetornar";
            this._buttonRetornar.Size = new System.Drawing.Size(75, 23);
            this._buttonRetornar.TabIndex = 0;
            this._buttonRetornar.Text = "Regresar";
            this._buttonRetornar.UseVisualStyleBackColor = true;
            this._buttonRetornar.Click += new System.EventHandler(this._buttonRetornar_Click);
            // 
            // _labelMensaje
            // 
            this._labelMensaje.AutoSize = true;
            this._labelMensaje.Font = new System.Drawing.Font("Cambria Math", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._labelMensaje.ForeColor = System.Drawing.SystemColors.HighlightText;
            this._labelMensaje.Location = new System.Drawing.Point(19, 26);
            this._labelMensaje.Name = "_labelMensaje";
            this._labelMensaje.Size = new System.Drawing.Size(120, 89);
            this._labelMensaje.TabIndex = 1;
            this._labelMensaje.Text = "No Cargado";
            // 
            // ventanaResultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(607, 347);
            this.Controls.Add(this._labelMensaje);
            this.Controls.Add(this._buttonRetornar);
            this.Name = "ventanaResultado";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ventanaResultado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _buttonRetornar;
        private System.Windows.Forms.Label _labelMensaje;
    }
}