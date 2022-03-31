
namespace formjdrppe
{
    partial class ListePartie
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
            this.idpartieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pARTIEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projet_prosqlDataSet9 = new formjdrppe.projet_prosqlDataSet9();
            this.pARTIETableAdapter = new formjdrppe.projet_prosqlDataSet9TableAdapters.PARTIETableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTIEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpartieDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.datestartDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pARTIEBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 217);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // idpartieDataGridViewTextBoxColumn
            // 
            this.idpartieDataGridViewTextBoxColumn.DataPropertyName = "id_partie";
            this.idpartieDataGridViewTextBoxColumn.HeaderText = "id_partie";
            this.idpartieDataGridViewTextBoxColumn.Name = "idpartieDataGridViewTextBoxColumn";
            this.idpartieDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // datestartDataGridViewTextBoxColumn
            // 
            this.datestartDataGridViewTextBoxColumn.DataPropertyName = "date_start";
            this.datestartDataGridViewTextBoxColumn.HeaderText = "date_start";
            this.datestartDataGridViewTextBoxColumn.Name = "datestartDataGridViewTextBoxColumn";
            // 
            // pARTIEBindingSource
            // 
            this.pARTIEBindingSource.DataMember = "PARTIE";
            this.pARTIEBindingSource.DataSource = this.projet_prosqlDataSet9;
            // 
            // projet_prosqlDataSet9
            // 
            this.projet_prosqlDataSet9.DataSetName = "projet_prosqlDataSet9";
            this.projet_prosqlDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pARTIETableAdapter
            // 
            this.pARTIETableAdapter.ClearBeforeFill = true;
            // 
            // ListePartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 217);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListePartie";
            this.Text = "ListePartie";
            this.Load += new System.EventHandler(this.ListePartie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pARTIEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private projet_prosqlDataSet9 projet_prosqlDataSet9;
        private System.Windows.Forms.BindingSource pARTIEBindingSource;
        private projet_prosqlDataSet9TableAdapters.PARTIETableAdapter pARTIETableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpartieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datestartDataGridViewTextBoxColumn;
    }
}