
namespace SGBalonmanoAlvaroMerino
{
    partial class FrmJugadores
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
            System.Windows.Forms.Label dniLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label fotoLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label equipoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmJugadores));
            this.dsBd = new SGBalonmanoAlvaroMerino.dsBd();
            this.jUGADORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jUGADORESTableAdapter = new SGBalonmanoAlvaroMerino.dsBdTableAdapters.JUGADORESTableAdapter();
            this.tableAdapterManager = new SGBalonmanoAlvaroMerino.dsBdTableAdapters.TableAdapterManager();
            this.eQUIPOSTableAdapter = new SGBalonmanoAlvaroMerino.dsBdTableAdapters.EQUIPOSTableAdapter();
            this.jUGADORESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.jUGADORESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dniMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.telefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.equipoComboBox = new System.Windows.Forms.ComboBox();
            this.eQUIPOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnImagen = new System.Windows.Forms.Button();
            dniLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            fotoLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            equipoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dsBd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jUGADORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jUGADORESBindingNavigator)).BeginInit();
            this.jUGADORESBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dniLabel
            // 
            dniLabel.AutoSize = true;
            dniLabel.Location = new System.Drawing.Point(42, 58);
            dniLabel.Name = "dniLabel";
            dniLabel.Size = new System.Drawing.Size(26, 13);
            dniLabel.TabIndex = 1;
            dniLabel.Text = "Dni:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(42, 137);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(47, 13);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(42, 209);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(52, 13);
            apellidosLabel.TabIndex = 5;
            apellidosLabel.Text = "Apellidos:";
            // 
            // fotoLabel
            // 
            fotoLabel.AutoSize = true;
            fotoLabel.Location = new System.Drawing.Point(314, 58);
            fotoLabel.Name = "fotoLabel";
            fotoLabel.Size = new System.Drawing.Size(31, 13);
            fotoLabel.TabIndex = 7;
            fotoLabel.Text = "Foto:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(42, 285);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(52, 13);
            telefonoLabel.TabIndex = 9;
            telefonoLabel.Text = "Telefono:";
            // 
            // equipoLabel
            // 
            equipoLabel.AutoSize = true;
            equipoLabel.Location = new System.Drawing.Point(42, 339);
            equipoLabel.Name = "equipoLabel";
            equipoLabel.Size = new System.Drawing.Size(43, 13);
            equipoLabel.TabIndex = 11;
            equipoLabel.Text = "Equipo:";
            // 
            // dsBd
            // 
            this.dsBd.DataSetName = "dsBd";
            this.dsBd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jUGADORESBindingSource
            // 
            this.jUGADORESBindingSource.DataMember = "JUGADORES";
            this.jUGADORESBindingSource.DataSource = this.dsBd;
            // 
            // jUGADORESTableAdapter
            // 
            this.jUGADORESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.EQUIPOSTableAdapter = this.eQUIPOSTableAdapter;
            this.tableAdapterManager.GOLES_PARTIDOTableAdapter = null;
            this.tableAdapterManager.JUGADORESTableAdapter = this.jUGADORESTableAdapter;
            this.tableAdapterManager.PARTIDOSTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SGBalonmanoAlvaroMerino.dsBdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // eQUIPOSTableAdapter
            // 
            this.eQUIPOSTableAdapter.ClearBeforeFill = true;
            // 
            // jUGADORESBindingNavigator
            // 
            this.jUGADORESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jUGADORESBindingNavigator.BindingSource = this.jUGADORESBindingSource;
            this.jUGADORESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jUGADORESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.jUGADORESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.jUGADORESBindingNavigatorSaveItem});
            this.jUGADORESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jUGADORESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jUGADORESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jUGADORESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jUGADORESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jUGADORESBindingNavigator.Name = "jUGADORESBindingNavigator";
            this.jUGADORESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jUGADORESBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.jUGADORESBindingNavigator.TabIndex = 0;
            this.jUGADORESBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de elementos";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primero";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posición";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posición actual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover siguiente";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // jUGADORESBindingNavigatorSaveItem
            // 
            this.jUGADORESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jUGADORESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("jUGADORESBindingNavigatorSaveItem.Image")));
            this.jUGADORESBindingNavigatorSaveItem.Name = "jUGADORESBindingNavigatorSaveItem";
            this.jUGADORESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.jUGADORESBindingNavigatorSaveItem.Text = "Guardar datos";
            this.jUGADORESBindingNavigatorSaveItem.Click += new System.EventHandler(this.jUGADORESBindingNavigatorSaveItem_Click);
            // 
            // dniMaskedTextBox
            // 
            this.dniMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jUGADORESBindingSource, "Dni", true));
            this.dniMaskedTextBox.Location = new System.Drawing.Point(95, 55);
            this.dniMaskedTextBox.Mask = "99999999-A";
            this.dniMaskedTextBox.Name = "dniMaskedTextBox";
            this.dniMaskedTextBox.Size = new System.Drawing.Size(138, 20);
            this.dniMaskedTextBox.TabIndex = 2;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jUGADORESBindingSource, "Nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(95, 134);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(138, 20);
            this.nombreTextBox.TabIndex = 4;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jUGADORESBindingSource, "Apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(95, 206);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(138, 20);
            this.apellidosTextBox.TabIndex = 6;
            // 
            // fotoPictureBox
            // 
            this.fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.jUGADORESBindingSource, "Foto", true));
            this.fotoPictureBox.Location = new System.Drawing.Point(317, 93);
            this.fotoPictureBox.Name = "fotoPictureBox";
            this.fotoPictureBox.Size = new System.Drawing.Size(228, 129);
            this.fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fotoPictureBox.TabIndex = 8;
            this.fotoPictureBox.TabStop = false;
            // 
            // telefonoMaskedTextBox
            // 
            this.telefonoMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jUGADORESBindingSource, "Telefono", true));
            this.telefonoMaskedTextBox.Location = new System.Drawing.Point(95, 282);
            this.telefonoMaskedTextBox.Mask = "999999999";
            this.telefonoMaskedTextBox.Name = "telefonoMaskedTextBox";
            this.telefonoMaskedTextBox.Size = new System.Drawing.Size(138, 20);
            this.telefonoMaskedTextBox.TabIndex = 10;
            // 
            // equipoComboBox
            // 
            this.equipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jUGADORESBindingSource, "Equipo", true));
            this.equipoComboBox.DataSource = this.eQUIPOSBindingSource;
            this.equipoComboBox.DisplayMember = "Nombre";
            this.equipoComboBox.FormattingEnabled = true;
            this.equipoComboBox.Location = new System.Drawing.Point(95, 336);
            this.equipoComboBox.Name = "equipoComboBox";
            this.equipoComboBox.Size = new System.Drawing.Size(138, 21);
            this.equipoComboBox.TabIndex = 12;
            this.equipoComboBox.ValueMember = "Id_equipo";
            // 
            // eQUIPOSBindingSource
            // 
            this.eQUIPOSBindingSource.DataMember = "EQUIPOS";
            this.eQUIPOSBindingSource.DataSource = this.dsBd;
            // 
            // btnImagen
            // 
            this.btnImagen.Location = new System.Drawing.Point(322, 251);
            this.btnImagen.Name = "btnImagen";
            this.btnImagen.Size = new System.Drawing.Size(223, 23);
            this.btnImagen.TabIndex = 13;
            this.btnImagen.Text = "Elegir Imagen";
            this.btnImagen.UseVisualStyleBackColor = true;
            this.btnImagen.Click += new System.EventHandler(this.btnImagen_Click);
            // 
            // FrmJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnImagen);
            this.Controls.Add(equipoLabel);
            this.Controls.Add(this.equipoComboBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoMaskedTextBox);
            this.Controls.Add(fotoLabel);
            this.Controls.Add(this.fotoPictureBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(dniLabel);
            this.Controls.Add(this.dniMaskedTextBox);
            this.Controls.Add(this.jUGADORESBindingNavigator);
            this.Name = "FrmJugadores";
            this.Text = "FrmJugadores";
            this.Load += new System.EventHandler(this.FrmJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsBd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jUGADORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jUGADORESBindingNavigator)).EndInit();
            this.jUGADORESBindingNavigator.ResumeLayout(false);
            this.jUGADORESBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eQUIPOSBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dsBd dsBd;
        private System.Windows.Forms.BindingSource jUGADORESBindingSource;
        private dsBdTableAdapters.JUGADORESTableAdapter jUGADORESTableAdapter;
        private dsBdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jUGADORESBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton jUGADORESBindingNavigatorSaveItem;
        private System.Windows.Forms.MaskedTextBox dniMaskedTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.PictureBox fotoPictureBox;
        private System.Windows.Forms.MaskedTextBox telefonoMaskedTextBox;
        private dsBdTableAdapters.EQUIPOSTableAdapter eQUIPOSTableAdapter;
        private System.Windows.Forms.ComboBox equipoComboBox;
        private System.Windows.Forms.BindingSource eQUIPOSBindingSource;
        private System.Windows.Forms.Button btnImagen;
    }
}