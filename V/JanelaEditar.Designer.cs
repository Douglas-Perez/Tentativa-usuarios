namespace eu_só_queria_ser_feliz__isso_não_foi_uma_piada_.V
{
    partial class JanelaEditar
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
            this.nudEditar = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbNameEdit = new System.Windows.Forms.TextBox();
            this.txtEmailEdit = new System.Windows.Forms.TextBox();
            this.btnCancelarEdit = new System.Windows.Forms.Button();
            this.btnConfirmarEdit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudEditar
            // 
            this.nudEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudEditar.Location = new System.Drawing.Point(307, 52);
            this.nudEditar.Name = "nudEditar";
            this.nudEditar.Size = new System.Drawing.Size(46, 32);
            this.nudEditar.TabIndex = 1;
            this.nudEditar.ValueChanged += new System.EventHandler(this.NudEditar_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnConfirmarEdit);
            this.panel1.Controls.Add(this.btnCancelarEdit);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.nudEditar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(655, 366);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtEmailEdit);
            this.panel2.Controls.Add(this.txbNameEdit);
            this.panel2.Location = new System.Drawing.Point(12, 126);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(631, 136);
            this.panel2.TabIndex = 2;
            // 
            // txbNameEdit
            // 
            this.txbNameEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameEdit.Location = new System.Drawing.Point(3, 107);
            this.txbNameEdit.Name = "txbNameEdit";
            this.txbNameEdit.Size = new System.Drawing.Size(290, 26);
            this.txbNameEdit.TabIndex = 1;
            // 
            // txtEmailEdit
            // 
            this.txtEmailEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailEdit.Location = new System.Drawing.Point(338, 107);
            this.txtEmailEdit.Name = "txtEmailEdit";
            this.txtEmailEdit.Size = new System.Drawing.Size(290, 26);
            this.txtEmailEdit.TabIndex = 2;
            // 
            // btnCancelarEdit
            // 
            this.btnCancelarEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarEdit.ForeColor = System.Drawing.Color.Red;
            this.btnCancelarEdit.Location = new System.Drawing.Point(15, 291);
            this.btnCancelarEdit.Name = "btnCancelarEdit";
            this.btnCancelarEdit.Size = new System.Drawing.Size(128, 46);
            this.btnCancelarEdit.TabIndex = 3;
            this.btnCancelarEdit.Text = "Cancelar";
            this.btnCancelarEdit.UseVisualStyleBackColor = true;
            // 
            // btnConfirmarEdit
            // 
            this.btnConfirmarEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarEdit.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnConfirmarEdit.Location = new System.Drawing.Point(512, 291);
            this.btnConfirmarEdit.Name = "btnConfirmarEdit";
            this.btnConfirmarEdit.Size = new System.Drawing.Size(128, 46);
            this.btnConfirmarEdit.TabIndex = 4;
            this.btnConfirmarEdit.Text = "Editar";
            this.btnConfirmarEdit.UseVisualStyleBackColor = true;
            this.btnConfirmarEdit.Click += new System.EventHandler(this.BtnConfirmarEdit_Click);
            // 
            // JanelaEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 366);
            this.Controls.Add(this.panel1);
            this.Name = "JanelaEditar";
            this.Text = "JanelaEditar";
            ((System.ComponentModel.ISupportInitialize)(this.nudEditar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudEditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtEmailEdit;
        private System.Windows.Forms.TextBox txbNameEdit;
        private System.Windows.Forms.Button btnCancelarEdit;
        private System.Windows.Forms.Button btnConfirmarEdit;
    }
}