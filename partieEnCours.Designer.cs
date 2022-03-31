
namespace formjdrppe
{
    partial class partieEnCours
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
            this.projet_prosqlDataSet14 = new formjdrppe.projet_prosqlDataSet14();
            this.viewPartiePersoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_Partie_PersoTableAdapter = new formjdrppe.projet_prosqlDataSet14TableAdapters.View_Partie_PersoTableAdapter();
            this.projet_prosqlDataSet15 = new formjdrppe.projet_prosqlDataSet15();
            this.viewPartiePersoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.view_Partie_PersoTableAdapter1 = new formjdrppe.projet_prosqlDataSet15TableAdapters.View_Partie_PersoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewPartiePersoBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new formjdrppe.DataSet1();
            this.viewPartiePersoBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.viewPartiePersoBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.view_Partie_PersoTableAdapter2 = new formjdrppe.DataSet1TableAdapters.View_Partie_PersoTableAdapter();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPartiePersoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPartiePersoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPartiePersoBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPartiePersoBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPartiePersoBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // projet_prosqlDataSet14
            // 
            this.projet_prosqlDataSet14.DataSetName = "projet_prosqlDataSet14";
            this.projet_prosqlDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewPartiePersoBindingSource
            // 
            this.viewPartiePersoBindingSource.DataMember = "View_Partie_Perso";
            this.viewPartiePersoBindingSource.DataSource = this.projet_prosqlDataSet14;
            // 
            // view_Partie_PersoTableAdapter
            // 
            this.view_Partie_PersoTableAdapter.ClearBeforeFill = true;
            // 
            // projet_prosqlDataSet15
            // 
            this.projet_prosqlDataSet15.DataSetName = "projet_prosqlDataSet15";
            this.projet_prosqlDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewPartiePersoBindingSource1
            // 
            this.viewPartiePersoBindingSource1.DataMember = "View_Partie_Perso";
            this.viewPartiePersoBindingSource1.DataSource = this.projet_prosqlDataSet15;
            // 
            // view_Partie_PersoTableAdapter1
            // 
            this.view_Partie_PersoTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.expr1DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewPartiePersoBindingSource4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // viewPartiePersoBindingSource4
            // 
            this.viewPartiePersoBindingSource4.DataMember = "View_Partie_Perso";
            this.viewPartiePersoBindingSource4.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // viewPartiePersoBindingSource3
            // 
            this.viewPartiePersoBindingSource3.DataMember = "View_Partie_Perso";
            this.viewPartiePersoBindingSource3.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // viewPartiePersoBindingSource2
            // 
            this.viewPartiePersoBindingSource2.DataMember = "View_Partie_Perso";
            this.viewPartiePersoBindingSource2.DataSource = this.dataSet1;
            // 
            // view_Partie_PersoTableAdapter2
            // 
            this.view_Partie_PersoTableAdapter2.ClearBeforeFill = true;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomDataGridViewTextBoxColumn.Width = 250;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Width = 250;
            // 
            // partieEnCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 465);
            this.Controls.Add(this.dataGridView1);
            this.Name = "partieEnCours";
            this.Text = "partieEnCours";
            this.Load += new System.EventHandler(this.partieEnCours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPartiePersoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPartiePersoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPartiePersoBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPartiePersoBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewPartiePersoBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private projet_prosqlDataSet14 projet_prosqlDataSet14;
        private System.Windows.Forms.BindingSource viewPartiePersoBindingSource;
        private projet_prosqlDataSet14TableAdapters.View_Partie_PersoTableAdapter view_Partie_PersoTableAdapter;
        private projet_prosqlDataSet15 projet_prosqlDataSet15;
        private System.Windows.Forms.BindingSource viewPartiePersoBindingSource1;
        private projet_prosqlDataSet15TableAdapters.View_Partie_PersoTableAdapter view_Partie_PersoTableAdapter1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource viewPartiePersoBindingSource2;
        private DataSet1TableAdapters.View_Partie_PersoTableAdapter view_Partie_PersoTableAdapter2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource viewPartiePersoBindingSource3;
        
        private System.Windows.Forms.BindingSource viewPartiePersoBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
    }
}