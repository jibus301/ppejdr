
namespace formjdrppe
{
    partial class creationObjetRare
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxPerso = new System.Windows.Forms.ComboBox();
            this.projet_prosqlDataSet12 = new formjdrppe.projet_prosqlDataSet12();
            this.pERSONNAGEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERSONNAGETableAdapter = new formjdrppe.projet_prosqlDataSet12TableAdapters.PERSONNAGETableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDescrip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSats = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONNAGEBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(179, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(88, 81);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(100, 20);
            this.textBoxNom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(114, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom de l\'objet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personnage";
            // 
            // comboBoxPerso
            // 
            this.comboBoxPerso.DataSource = this.pERSONNAGEBindingSource;
            this.comboBoxPerso.DisplayMember = "nom";
            this.comboBoxPerso.FormattingEnabled = true;
            this.comboBoxPerso.Location = new System.Drawing.Point(88, 155);
            this.comboBoxPerso.Name = "comboBoxPerso";
            this.comboBoxPerso.Size = new System.Drawing.Size(100, 21);
            this.comboBoxPerso.TabIndex = 5;
            this.comboBoxPerso.ValueMember = "id_perso";
            // 
            // projet_prosqlDataSet12
            // 
            this.projet_prosqlDataSet12.DataSetName = "projet_prosqlDataSet12";
            this.projet_prosqlDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERSONNAGEBindingSource
            // 
            this.pERSONNAGEBindingSource.DataMember = "PERSONNAGE";
            this.pERSONNAGEBindingSource.DataSource = this.projet_prosqlDataSet12;
            // 
            // pERSONNAGETableAdapter
            // 
            this.pERSONNAGETableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // textBoxDescrip
            // 
            this.textBoxDescrip.AcceptsReturn = true;
            this.textBoxDescrip.Location = new System.Drawing.Point(223, 81);
            this.textBoxDescrip.Multiline = true;
            this.textBoxDescrip.Name = "textBoxDescrip";
            this.textBoxDescrip.Size = new System.Drawing.Size(164, 170);
            this.textBoxDescrip.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Stats";
            // 
            // textBoxSats
            // 
            this.textBoxSats.Location = new System.Drawing.Point(88, 231);
            this.textBoxSats.Name = "textBoxSats";
            this.textBoxSats.Size = new System.Drawing.Size(100, 20);
            this.textBoxSats.TabIndex = 8;
            // 
            // creationObjetRare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 351);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxSats);
            this.Controls.Add(this.textBoxDescrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxPerso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.button1);
            this.Name = "creationObjetRare";
            this.Text = "creationObjetRare";
            this.Load += new System.EventHandler(this.creationObjetRare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERSONNAGEBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxPerso;
        private projet_prosqlDataSet12 projet_prosqlDataSet12;
        private System.Windows.Forms.BindingSource pERSONNAGEBindingSource;
        private projet_prosqlDataSet12TableAdapters.PERSONNAGETableAdapter pERSONNAGETableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDescrip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSats;
    }
}