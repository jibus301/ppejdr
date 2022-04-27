
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
            this.jOUEURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projet_prosqlDataSet8 = new formjdrppe.projet_prosqlDataSet8();
            this.jOUEURTableAdapter = new formjdrppe.projet_prosqlDataSet8TableAdapters.JOUEURTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOUEURBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // jOUEURBindingSource
            // 
            this.jOUEURBindingSource.DataMember = "JOUEUR";
            this.jOUEURBindingSource.DataSource = this.projet_prosqlDataSet8;
            // 
            // projet_prosqlDataSet8
            // 
            this.projet_prosqlDataSet8.DataSetName = "projet_prosqlDataSet8";
            this.projet_prosqlDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jOUEURTableAdapter
            // 
            this.jOUEURTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.jOUEURBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private projet_prosqlDataSet8 projet_prosqlDataSet8;
        private System.Windows.Forms.BindingSource jOUEURBindingSource;
        private projet_prosqlDataSet8TableAdapters.JOUEURTableAdapter jOUEURTableAdapter;
    }
}