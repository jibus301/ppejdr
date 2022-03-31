
namespace formjdrppe
{
    partial class creationCompetence
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
            this.projet_prosqlDataSet10 = new formjdrppe.projet_prosqlDataSet10();
            this.cOMPETENCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPETENCETableAdapter = new formjdrppe.projet_prosqlDataSet10TableAdapters.COMPETENCETableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBonus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.projet_prosqlDataSet11 = new formjdrppe.projet_prosqlDataSet11();
            this.pERSONNAGEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONNAGETableAdapter = new formjdrppe.projet_prosqlDataSet11TableAdapters.PERSONNAGETableAdapter();
            this.labelValidation = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPETENCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONNAGEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // projet_prosqlDataSet10
            // 
            this.projet_prosqlDataSet10.DataSetName = "projet_prosqlDataSet10";
            this.projet_prosqlDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cOMPETENCEBindingSource
            // 
            this.cOMPETENCEBindingSource.DataMember = "COMPETENCE";
            this.cOMPETENCEBindingSource.DataSource = this.projet_prosqlDataSet10;
            // 
            // cOMPETENCETableAdapter
            // 
            this.cOMPETENCETableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de la compétence";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(117, 56);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pv",
            "Force",
            "Agilité",
            "Intelligence",
            "Social",
            "Initiative",
            "cac",
            "ad",
            "magie",
            " "});
            this.comboBox1.Location = new System.Drawing.Point(117, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "stat liée";
            // 
            // textBoxBonus
            // 
            this.textBoxBonus.Location = new System.Drawing.Point(117, 192);
            this.textBoxBonus.Name = "textBoxBonus";
            this.textBoxBonus.Size = new System.Drawing.Size(100, 20);
            this.textBoxBonus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "bonus";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(129, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // projet_prosqlDataSet11
            // 
            this.projet_prosqlDataSet11.DataSetName = "projet_prosqlDataSet11";
            this.projet_prosqlDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERSONNAGEBindingSource
            // 
            this.pERSONNAGEBindingSource.DataMember = "PERSONNAGE";
            this.pERSONNAGEBindingSource.DataSource = this.projet_prosqlDataSet11;
            // 
            // pERSONNAGETableAdapter
            // 
            this.pERSONNAGETableAdapter.ClearBeforeFill = true;
            // 
            // labelValidation
            // 
            this.labelValidation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelValidation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelValidation.Location = new System.Drawing.Point(0, 303);
            this.labelValidation.Name = "labelValidation";
            this.labelValidation.Size = new System.Drawing.Size(343, 24);
            this.labelValidation.TabIndex = 7;
            this.labelValidation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creationCompetence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 327);
            this.Controls.Add(this.labelValidation);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxBonus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label1);
            this.Name = "creationCompetence";
            this.Text = "creationCompetence";
            this.Load += new System.EventHandler(this.creationCompetence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPETENCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONNAGEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private projet_prosqlDataSet10 projet_prosqlDataSet10;
        private System.Windows.Forms.BindingSource cOMPETENCEBindingSource;
        private projet_prosqlDataSet10TableAdapters.COMPETENCETableAdapter cOMPETENCETableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBonus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private projet_prosqlDataSet11 projet_prosqlDataSet11;
        private System.Windows.Forms.BindingSource pERSONNAGEBindingSource;
        private projet_prosqlDataSet11TableAdapters.PERSONNAGETableAdapter pERSONNAGETableAdapter;
        private System.Windows.Forms.Label labelValidation;
    }
}