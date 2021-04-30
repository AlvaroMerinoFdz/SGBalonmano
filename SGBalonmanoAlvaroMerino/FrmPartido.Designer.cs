
namespace SGBalonmanoAlvaroMerino
{
    partial class FrmPartido
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
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.cmbLocal = new System.Windows.Forms.ComboBox();
            this.cmbVisitante = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGolesLocal = new System.Windows.Forms.Label();
            this.lblGolesVisitante = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPabellon = new System.Windows.Forms.Label();
            this.dgvLocal = new System.Windows.Forms.DataGridView();
            this.dgvVisitante = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnQuitarLocal = new System.Windows.Forms.Button();
            this.btnAñadirLocal = new System.Windows.Forms.Button();
            this.pcbVisitante = new System.Windows.Forms.PictureBox();
            this.pcbLocal = new System.Windows.Forms.PictureBox();
            this.btnQuitarVisitante = new System.Windows.Forms.Button();
            this.btnAñadirVisitante = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVisitante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLocal)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Items.AddRange(new object[] {
            "Alevín",
            "Infantil",
            "Cadete",
            "Juvenil"});
            this.cmbCategoria.Location = new System.Drawing.Point(140, 32);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(143, 21);
            this.cmbCategoria.TabIndex = 0;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // cmbLocal
            // 
            this.cmbLocal.Enabled = false;
            this.cmbLocal.FormattingEnabled = true;
            this.cmbLocal.Location = new System.Drawing.Point(140, 81);
            this.cmbLocal.Name = "cmbLocal";
            this.cmbLocal.Size = new System.Drawing.Size(143, 21);
            this.cmbLocal.TabIndex = 1;
            // 
            // cmbVisitante
            // 
            this.cmbVisitante.Enabled = false;
            this.cmbVisitante.FormattingEnabled = true;
            this.cmbVisitante.Location = new System.Drawing.Point(535, 81);
            this.cmbVisitante.Name = "cmbVisitante";
            this.cmbVisitante.Size = new System.Drawing.Size(143, 21);
            this.cmbVisitante.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "CATEGORÍA:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "EQUIPO LOCAL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(377, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "EQUIPO VISITANTE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "FECHA:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(535, 17);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(143, 20);
            this.dtpFecha.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(99, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "GOLES LOCAL:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "GOLES VISITANTE:";
            // 
            // lblGolesLocal
            // 
            this.lblGolesLocal.AutoSize = true;
            this.lblGolesLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGolesLocal.ForeColor = System.Drawing.Color.Yellow;
            this.lblGolesLocal.Location = new System.Drawing.Point(218, 238);
            this.lblGolesLocal.Name = "lblGolesLocal";
            this.lblGolesLocal.Size = new System.Drawing.Size(16, 16);
            this.lblGolesLocal.TabIndex = 10;
            this.lblGolesLocal.Text = "0";
            // 
            // lblGolesVisitante
            // 
            this.lblGolesVisitante.AutoSize = true;
            this.lblGolesVisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGolesVisitante.ForeColor = System.Drawing.Color.Yellow;
            this.lblGolesVisitante.Location = new System.Drawing.Point(684, 238);
            this.lblGolesVisitante.Name = "lblGolesVisitante";
            this.lblGolesVisitante.Size = new System.Drawing.Size(16, 16);
            this.lblGolesVisitante.TabIndex = 11;
            this.lblGolesVisitante.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(343, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "PABELLÓN:";
            // 
            // lblPabellon
            // 
            this.lblPabellon.AutoSize = true;
            this.lblPabellon.Location = new System.Drawing.Point(343, 189);
            this.lblPabellon.Name = "lblPabellon";
            this.lblPabellon.Size = new System.Drawing.Size(104, 13);
            this.lblPabellon.TabIndex = 13;
            this.lblPabellon.Text = "Nombre del pabellón";
            // 
            // dgvLocal
            // 
            this.dgvLocal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocal.Location = new System.Drawing.Point(15, 263);
            this.dgvLocal.Name = "dgvLocal";
            this.dgvLocal.Size = new System.Drawing.Size(268, 150);
            this.dgvLocal.TabIndex = 16;
            // 
            // dgvVisitante
            // 
            this.dgvVisitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitante.Location = new System.Drawing.Point(503, 263);
            this.dgvVisitante.Name = "dgvVisitante";
            this.dgvVisitante.Size = new System.Drawing.Size(274, 150);
            this.dgvVisitante.TabIndex = 17;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(346, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(108, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnQuitarLocal
            // 
            this.btnQuitarLocal.BackgroundImage = global::SGBalonmanoAlvaroMerino.Properties.Resources.quitar;
            this.btnQuitarLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitarLocal.Location = new System.Drawing.Point(190, 419);
            this.btnQuitarLocal.Name = "btnQuitarLocal";
            this.btnQuitarLocal.Size = new System.Drawing.Size(44, 23);
            this.btnQuitarLocal.TabIndex = 21;
            this.btnQuitarLocal.UseVisualStyleBackColor = true;
            // 
            // btnAñadirLocal
            // 
            this.btnAñadirLocal.BackgroundImage = global::SGBalonmanoAlvaroMerino.Properties.Resources.anadir1;
            this.btnAñadirLocal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAñadirLocal.Location = new System.Drawing.Point(57, 419);
            this.btnAñadirLocal.Name = "btnAñadirLocal";
            this.btnAñadirLocal.Size = new System.Drawing.Size(44, 23);
            this.btnAñadirLocal.TabIndex = 18;
            this.btnAñadirLocal.UseVisualStyleBackColor = true;
            // 
            // pcbVisitante
            // 
            this.pcbVisitante.Location = new System.Drawing.Point(536, 128);
            this.pcbVisitante.Name = "pcbVisitante";
            this.pcbVisitante.Size = new System.Drawing.Size(132, 95);
            this.pcbVisitante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbVisitante.TabIndex = 15;
            this.pcbVisitante.TabStop = false;
            // 
            // pcbLocal
            // 
            this.pcbLocal.Location = new System.Drawing.Point(102, 128);
            this.pcbLocal.Name = "pcbLocal";
            this.pcbLocal.Size = new System.Drawing.Size(132, 95);
            this.pcbLocal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLocal.TabIndex = 14;
            this.pcbLocal.TabStop = false;
            // 
            // btnQuitarVisitante
            // 
            this.btnQuitarVisitante.BackgroundImage = global::SGBalonmanoAlvaroMerino.Properties.Resources.quitar;
            this.btnQuitarVisitante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitarVisitante.Location = new System.Drawing.Point(669, 419);
            this.btnQuitarVisitante.Name = "btnQuitarVisitante";
            this.btnQuitarVisitante.Size = new System.Drawing.Size(44, 23);
            this.btnQuitarVisitante.TabIndex = 23;
            this.btnQuitarVisitante.UseVisualStyleBackColor = true;
            // 
            // btnAñadirVisitante
            // 
            this.btnAñadirVisitante.BackgroundImage = global::SGBalonmanoAlvaroMerino.Properties.Resources.anadir1;
            this.btnAñadirVisitante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAñadirVisitante.Location = new System.Drawing.Point(536, 419);
            this.btnAñadirVisitante.Name = "btnAñadirVisitante";
            this.btnAñadirVisitante.Size = new System.Drawing.Size(44, 23);
            this.btnAñadirVisitante.TabIndex = 22;
            this.btnAñadirVisitante.UseVisualStyleBackColor = true;
            // 
            // FrmPartido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuitarVisitante);
            this.Controls.Add(this.btnAñadirVisitante);
            this.Controls.Add(this.btnQuitarLocal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnAñadirLocal);
            this.Controls.Add(this.dgvVisitante);
            this.Controls.Add(this.dgvLocal);
            this.Controls.Add(this.pcbVisitante);
            this.Controls.Add(this.pcbLocal);
            this.Controls.Add(this.lblPabellon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblGolesVisitante);
            this.Controls.Add(this.lblGolesLocal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbVisitante);
            this.Controls.Add(this.cmbLocal);
            this.Controls.Add(this.cmbCategoria);
            this.Name = "FrmPartido";
            this.Text = "FrmPartido";
            this.Load += new System.EventHandler(this.FrmPartido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbVisitante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLocal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.ComboBox cmbLocal;
        private System.Windows.Forms.ComboBox cmbVisitante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGolesLocal;
        private System.Windows.Forms.Label lblGolesVisitante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPabellon;
        private System.Windows.Forms.PictureBox pcbLocal;
        private System.Windows.Forms.PictureBox pcbVisitante;
        private System.Windows.Forms.DataGridView dgvLocal;
        private System.Windows.Forms.DataGridView dgvVisitante;
        private System.Windows.Forms.Button btnAñadirLocal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnQuitarLocal;
        private System.Windows.Forms.Button btnQuitarVisitante;
        private System.Windows.Forms.Button btnAñadirVisitante;
    }
}