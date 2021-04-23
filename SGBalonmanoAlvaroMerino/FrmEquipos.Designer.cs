
namespace SGBalonmanoAlvaroMerino
{
    partial class FrmEquipos
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
            this.components = new System.ComponentModel.Container();
            this.dsBd = new SGBalonmanoAlvaroMerino.dsBd();
            this.eQUIPOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eQUIPOSTableAdapter = new SGBalonmanoAlvaroMerino.dsBdTableAdapters.EQUIPOSTableAdapter();
            this.tableAdapterManager = new SGBalonmanoAlvaroMerino.dsBdTableAdapters.TableAdapterManager();
            this.eQUIPOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dsBd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPOSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dsBd
            // 
            this.dsBd.DataSetName = "dsBd";
            this.dsBd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eQUIPOSBindingSource
            // 
            this.eQUIPOSBindingSource.DataMember = "EQUIPOS";
            this.eQUIPOSBindingSource.DataSource = this.dsBd;
            // 
            // eQUIPOSTableAdapter
            // 
            this.eQUIPOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EQUIPOSTableAdapter = this.eQUIPOSTableAdapter;
            this.tableAdapterManager.GOLES_PARTIDOTableAdapter = null;
            this.tableAdapterManager.JUGADORESTableAdapter = null;
            this.tableAdapterManager.PARTIDOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SGBalonmanoAlvaroMerino.dsBdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eQUIPOSDataGridView
            // 
            this.eQUIPOSDataGridView.AutoGenerateColumns = false;
            this.eQUIPOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eQUIPOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3});
            this.eQUIPOSDataGridView.DataSource = this.eQUIPOSBindingSource;
            this.eQUIPOSDataGridView.Location = new System.Drawing.Point(12, 39);
            this.eQUIPOSDataGridView.MultiSelect = false;
            this.eQUIPOSDataGridView.Name = "eQUIPOSDataGridView";
            this.eQUIPOSDataGridView.Size = new System.Drawing.Size(776, 261);
            this.eQUIPOSDataGridView.TabIndex = 1;
            this.eQUIPOSDataGridView.DoubleClick += new System.EventHandler(this.eQUIPOSDataGridView_DoubleClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Categoria";
            this.dataGridViewTextBoxColumn4.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Pabellon";
            this.dataGridViewTextBoxColumn3.HeaderText = "Pabellon";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Location = new System.Drawing.Point(30, 350);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(119, 52);
            this.btnAñadir.TabIndex = 2;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(340, 350);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(117, 52);
            this.btnModificar.TabIndex = 3;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(677, 349);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 53);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FrmEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.eQUIPOSDataGridView);
            this.Name = "FrmEquipos";
            this.Text = "FrmEquipos";
            this.Load += new System.EventHandler(this.FrmEquipos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPOSDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private dsBd dsBd;
        private System.Windows.Forms.BindingSource eQUIPOSBindingSource;
        private dsBdTableAdapters.EQUIPOSTableAdapter eQUIPOSTableAdapter;
        private dsBdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView eQUIPOSDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}