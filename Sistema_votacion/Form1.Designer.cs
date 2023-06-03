
namespace Sistema_votacion
{
    partial class Form1
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
            this.lblc1 = new System.Windows.Forms.Label();
            this.TxtCandidato_uno = new System.Windows.Forms.TextBox();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.BtnVotar = new System.Windows.Forms.Button();
            this.TxtCandidato_dos = new System.Windows.Forms.TextBox();
            this.lblc2 = new System.Windows.Forms.Label();
            this.lblconteoc1 = new System.Windows.Forms.Label();
            this.lblconteoc2 = new System.Windows.Forms.Label();
            this.Btnc1 = new System.Windows.Forms.Button();
            this.Btnc2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblc1
            // 
            this.lblc1.AutoSize = true;
            this.lblc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblc1.Location = new System.Drawing.Point(94, 85);
            this.lblc1.Name = "lblc1";
            this.lblc1.Size = new System.Drawing.Size(121, 18);
            this.lblc1.TabIndex = 0;
            this.lblc1.Text = "Candidato_uno";
            this.lblc1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TxtCandidato_uno
            // 
            this.TxtCandidato_uno.Location = new System.Drawing.Point(269, 82);
            this.TxtCandidato_uno.Name = "TxtCandidato_uno";
            this.TxtCandidato_uno.Size = new System.Drawing.Size(100, 20);
            this.TxtCandidato_uno.TabIndex = 1;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(444, 79);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(75, 23);
            this.BtnNuevo.TabIndex = 2;
            this.BtnNuevo.Text = "Nuevo";
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // BtnVotar
            // 
            this.BtnVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVotar.Location = new System.Drawing.Point(406, 130);
            this.BtnVotar.Name = "BtnVotar";
            this.BtnVotar.Size = new System.Drawing.Size(139, 23);
            this.BtnVotar.TabIndex = 5;
            this.BtnVotar.Text = "Iniciar_Votación";
            this.BtnVotar.UseVisualStyleBackColor = true;
            this.BtnVotar.Click += new System.EventHandler(this.BtnVotar_Click);
            // 
            // TxtCandidato_dos
            // 
            this.TxtCandidato_dos.Location = new System.Drawing.Point(269, 127);
            this.TxtCandidato_dos.Name = "TxtCandidato_dos";
            this.TxtCandidato_dos.Size = new System.Drawing.Size(100, 20);
            this.TxtCandidato_dos.TabIndex = 4;
            // 
            // lblc2
            // 
            this.lblc2.AutoSize = true;
            this.lblc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblc2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblc2.Location = new System.Drawing.Point(78, 132);
            this.lblc2.Name = "lblc2";
            this.lblc2.Size = new System.Drawing.Size(121, 18);
            this.lblc2.TabIndex = 3;
            this.lblc2.Text = "Candidato_dos";
            // 
            // lblconteoc1
            // 
            this.lblconteoc1.AutoSize = true;
            this.lblconteoc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconteoc1.Location = new System.Drawing.Point(575, 82);
            this.lblconteoc1.Name = "lblconteoc1";
            this.lblconteoc1.Size = new System.Drawing.Size(83, 16);
            this.lblconteoc1.TabIndex = 6;
            this.lblconteoc1.Text = "Conteo_C1";
            // 
            // lblconteoc2
            // 
            this.lblconteoc2.AutoSize = true;
            this.lblconteoc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconteoc2.Location = new System.Drawing.Point(573, 127);
            this.lblconteoc2.Name = "lblconteoc2";
            this.lblconteoc2.Size = new System.Drawing.Size(83, 16);
            this.lblconteoc2.TabIndex = 7;
            this.lblconteoc2.Text = "Conteo_C2";
            this.lblconteoc2.Click += new System.EventHandler(this.lblconteo2_Click);
            // 
            // Btnc1
            // 
            this.Btnc1.Location = new System.Drawing.Point(168, 265);
            this.Btnc1.Name = "Btnc1";
            this.Btnc1.Size = new System.Drawing.Size(95, 34);
            this.Btnc1.TabIndex = 9;
            this.Btnc1.Text = "Candidato_uno";
            this.Btnc1.UseVisualStyleBackColor = true;
            this.Btnc1.Click += new System.EventHandler(this.Btnc1_Click);
            // 
            // Btnc2
            // 
            this.Btnc2.Location = new System.Drawing.Point(328, 265);
            this.Btnc2.Name = "Btnc2";
            this.Btnc2.Size = new System.Drawing.Size(93, 36);
            this.Btnc2.TabIndex = 8;
            this.Btnc2.Text = "Candidato_dos";
            this.Btnc2.UseVisualStyleBackColor = true;
            this.Btnc2.Click += new System.EventHandler(this.Btnc2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(230, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sistema_de_votacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Heading", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(499, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total_Votantes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(649, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "900";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Btnc1);
            this.Controls.Add(this.Btnc2);
            this.Controls.Add(this.lblconteoc2);
            this.Controls.Add(this.lblconteoc1);
            this.Controls.Add(this.BtnVotar);
            this.Controls.Add(this.TxtCandidato_dos);
            this.Controls.Add(this.lblc2);
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.TxtCandidato_uno);
            this.Controls.Add(this.lblc1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblc1;
        private System.Windows.Forms.TextBox TxtCandidato_uno;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Button BtnVotar;
        private System.Windows.Forms.TextBox TxtCandidato_dos;
        private System.Windows.Forms.Label lblc2;
        private System.Windows.Forms.Label lblconteoc1;
        private System.Windows.Forms.Label lblconteoc2;
        private System.Windows.Forms.Button Btnc1;
        private System.Windows.Forms.Button Btnc2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

