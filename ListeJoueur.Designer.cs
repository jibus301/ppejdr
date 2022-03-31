
namespace formjdrppe
{
    partial class ListeJoueur
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.projet_prosqlDataSet8 = new formjdrppe.projet_prosqlDataSet8();
            this.jOUEURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jOUEURTableAdapter = new formjdrppe.projet_prosqlDataSet8TableAdapters.JOUEURTableAdapter();
            this.idjoueurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pseudoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOUEURBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idjoueurDataGridViewTextBoxColumn,
            this.pseudoDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.passDataGridViewTextBoxColumn,
            this.adminDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.jOUEURBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // projet_prosqlDataSet8
            // 
            this.projet_prosqlDataSet8.DataSetName = "projet_prosqlDataSet8";
            this.projet_prosqlDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jOUEURBindingSource
            // 
            this.jOUEURBindingSource.DataMember = "JOUEUR";
            this.jOUEURBindingSource.DataSource = this.projet_prosqlDataSet8;
            // 
            // jOUEURTableAdapter
            // 
            this.jOUEURTableAdapter.ClearBeforeFill = true;
            // 
            // idjoueurDataGridViewTextBoxColumn
            // 
            this.idjoueurDataGridViewTextBoxColumn.DataPropertyName = "id_joueur";
            this.idjoueurDataGridViewTextBoxColumn.HeaderText = "id_joueur";
            this.idjoueurDataGridViewTextBoxColumn.Name = "idjoueurDataGridViewTextBoxColumn";
            this.idjoueurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pseudoDataGridViewTextBoxColumn
            // 
            this.pseudoDataGridViewTextBoxColumn.DataPropertyName = "pseudo";
            this.pseudoDataGridViewTextBoxColumn.HeaderText = "pseudo";
            this.pseudoDataGridViewTextBoxColumn.Name = "pseudoDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // passDataGridViewTextBoxColumn
            // 
            this.passDataGridViewTextBoxColumn.DataPropertyName = "pass";
            this.passDataGridViewTextBoxColumn.HeaderText = "pass";
            this.passDataGridViewTextBoxColumn.Name = "passDataGridViewTextBoxColumn";
            // 
            // adminDataGridViewCheckBoxColumn
            // 
            this.adminDataGridViewCheckBoxColumn.DataPropertyName = "admin";
            this.adminDataGridViewCheckBoxColumn.HeaderText = "admin";
            this.adminDataGridViewCheckBoxColumn.Name = "adminDataGridViewCheckBoxColumn";
            // 
            // ListeJoueur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListeJoueur";
            this.Text = "ListeJoueur";
            this.Load += new System.EventHandler(this.ListeJoueur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOUEURBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private projet_prosqlDataSet8 projet_prosqlDataSet8;
        private System.Windows.Forms.BindingSource jOUEURBindingSource;
        private projet_prosqlDataSet8TableAdapters.JOUEURTableAdapter jOUEURTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idjoueurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pseudoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
    }
}