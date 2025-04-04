namespace eu_só_queria_ser_feliz__isso_não_foi_uma_piada_.V
{
    partial class JanelaAdicionar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancelarAdd = new System.Windows.Forms.Button();
            this.btnConfirmarAdd = new System.Windows.Forms.Button();
            this.lbEmailAdd = new System.Windows.Forms.Label();
            this.txbEmailAdd = new System.Windows.Forms.TextBox();
            this.lbNameAdd = new System.Windows.Forms.Label();
            this.txbNameAdd = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbEmailAdd);
            this.panel1.Controls.Add(this.txbEmailAdd);
            this.panel1.Controls.Add(this.lbNameAdd);
            this.panel1.Controls.Add(this.txbNameAdd);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 331);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancelarAdd);
            this.panel2.Controls.Add(this.btnConfirmarAdd);
            this.panel2.Location = new System.Drawing.Point(90, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 82);
            this.panel2.TabIndex = 4;
            // 
            // btnCancelarAdd
            // 
            this.btnCancelarAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarAdd.ForeColor = System.Drawing.Color.Red;
            this.btnCancelarAdd.Location = new System.Drawing.Point(0, 19);
            this.btnCancelarAdd.Name = "btnCancelarAdd";
            this.btnCancelarAdd.Size = new System.Drawing.Size(128, 46);
            this.btnCancelarAdd.TabIndex = 1;
            this.btnCancelarAdd.Text = "Cancelar";
            this.btnCancelarAdd.UseVisualStyleBackColor = true;
            this.btnCancelarAdd.Click += new System.EventHandler(this.BtnCancelarAdd_Click);
            // 
            // btnConfirmarAdd
            // 
            this.btnConfirmarAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirmarAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmarAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnConfirmarAdd.Location = new System.Drawing.Point(268, 19);
            this.btnConfirmarAdd.Name = "btnConfirmarAdd";
            this.btnConfirmarAdd.Size = new System.Drawing.Size(128, 46);
            this.btnConfirmarAdd.TabIndex = 0;
            this.btnConfirmarAdd.Text = "Adicionar";
            this.btnConfirmarAdd.UseVisualStyleBackColor = true;
            this.btnConfirmarAdd.Click += new System.EventHandler(this.BtnConfirmarAdd_Click);
            // 
            // lbEmailAdd
            // 
            this.lbEmailAdd.AutoSize = true;
            this.lbEmailAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailAdd.Location = new System.Drawing.Point(138, 145);
            this.lbEmailAdd.Name = "lbEmailAdd";
            this.lbEmailAdd.Size = new System.Drawing.Size(74, 26);
            this.lbEmailAdd.TabIndex = 3;
            this.lbEmailAdd.Text = "Email:";
            // 
            // txbEmailAdd
            // 
            this.txbEmailAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEmailAdd.Location = new System.Drawing.Point(143, 193);
            this.txbEmailAdd.Name = "txbEmailAdd";
            this.txbEmailAdd.Size = new System.Drawing.Size(290, 26);
            this.txbEmailAdd.TabIndex = 2;
            // 
            // lbNameAdd
            // 
            this.lbNameAdd.AutoSize = true;
            this.lbNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameAdd.Location = new System.Drawing.Point(138, 52);
            this.lbNameAdd.Name = "lbNameAdd";
            this.lbNameAdd.Size = new System.Drawing.Size(77, 26);
            this.lbNameAdd.TabIndex = 1;
            this.lbNameAdd.Text = "Nome:";
            // 
            // txbNameAdd
            // 
            this.txbNameAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNameAdd.Location = new System.Drawing.Point(143, 100);
            this.txbNameAdd.Name = "txbNameAdd";
            this.txbNameAdd.Size = new System.Drawing.Size(290, 26);
            this.txbNameAdd.TabIndex = 0;
            // 
            // JanelaAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 331);
            this.Controls.Add(this.panel1);
            this.Name = "JanelaAdicionar";
            this.Text = "JanelaAdicionar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbNameAdd;
        private System.Windows.Forms.TextBox txbNameAdd;
        private System.Windows.Forms.Label lbEmailAdd;
        private System.Windows.Forms.TextBox txbEmailAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancelarAdd;
        private System.Windows.Forms.Button btnConfirmarAdd;
    }
}