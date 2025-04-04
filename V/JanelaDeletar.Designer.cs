namespace eu_só_queria_ser_feliz__isso_não_foi_uma_piada_.V
{
    partial class JanelaDeletar
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
            this.nudDeletar = new System.Windows.Forms.NumericUpDown();
            this.lbDeletar = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarAdd = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeletar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudDeletar
            // 
            this.nudDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDeletar.Location = new System.Drawing.Point(375, 33);
            this.nudDeletar.Name = "nudDeletar";
            this.nudDeletar.Size = new System.Drawing.Size(46, 32);
            this.nudDeletar.TabIndex = 0;
            // 
            // lbDeletar
            // 
            this.lbDeletar.AutoSize = true;
            this.lbDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeletar.Location = new System.Drawing.Point(3, 23);
            this.lbDeletar.Name = "lbDeletar";
            this.lbDeletar.Size = new System.Drawing.Size(261, 52);
            this.lbDeletar.TabIndex = 1;
            this.lbDeletar.Text = "Selecione o Id do Usuario\r\n que deseja deletar";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelarAdd);
            this.panel1.Controls.Add(this.btnDeletar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(548, 335);
            this.panel1.TabIndex = 2;
            // 
            // btnCancelarAdd
            // 
            this.btnCancelarAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarAdd.ForeColor = System.Drawing.Color.Red;
            this.btnCancelarAdd.Location = new System.Drawing.Point(63, 243);
            this.btnCancelarAdd.Name = "btnCancelarAdd";
            this.btnCancelarAdd.Size = new System.Drawing.Size(128, 46);
            this.btnCancelarAdd.TabIndex = 4;
            this.btnCancelarAdd.Text = "Cancelar";
            this.btnCancelarAdd.UseVisualStyleBackColor = true;
            this.btnCancelarAdd.Click += new System.EventHandler(this.btnCancelarAdd_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletar.BackColor = System.Drawing.Color.Red;
            this.btnDeletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(356, 243);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(128, 46);
            this.btnDeletar.TabIndex = 3;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbDeletar);
            this.panel2.Controls.Add(this.nudDeletar);
            this.panel2.Location = new System.Drawing.Point(63, 74);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 100);
            this.panel2.TabIndex = 2;
            // 
            // JanelaDeletar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 335);
            this.Controls.Add(this.panel1);
            this.Name = "JanelaDeletar";
            this.Text = "JanelaDeletar";
            ((System.ComponentModel.ISupportInitialize)(this.nudDeletar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudDeletar;
        private System.Windows.Forms.Label lbDeletar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnCancelarAdd;
    }
}