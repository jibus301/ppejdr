
namespace formjdrppe
{
    partial class creationPerso
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
            this.comboBoxRace = new System.Windows.Forms.ComboBox();
            this.rACEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projet_prosqlDataSet = new formjdrppe.projet_prosqlDataSet();
            this.rACETableAdapter = new formjdrppe.projet_prosqlDataSetTableAdapters.RACETableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxClasse = new System.Windows.Forms.ComboBox();
            this.cLASSEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projet_prosqlDataSet1 = new formjdrppe.projet_prosqlDataSet1();
            this.cLASSETableAdapter = new formjdrppe.projet_prosqlDataSet1TableAdapters.CLASSETableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxJoueur = new System.Windows.Forms.ComboBox();
            this.jOUEURBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projet_prosqlDataSet2 = new formjdrppe.projet_prosqlDataSet2();
            this.jOUEURTableAdapter = new formjdrppe.projet_prosqlDataSet2TableAdapters.JOUEURTableAdapter();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.maskedTextBoxNiveau = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxDgtCc = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBoxDgtAd = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskedTextBoxDef = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonImg = new System.Windows.Forms.Button();
            this.checkedListCompetence = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.checkedListObjet = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rACEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOUEURBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRace
            // 
            this.comboBoxRace.DataSource = this.rACEBindingSource;
            this.comboBoxRace.DisplayMember = "nom";
            this.comboBoxRace.FormattingEnabled = true;
            this.comboBoxRace.Location = new System.Drawing.Point(100, 184);
            this.comboBoxRace.Name = "comboBoxRace";
            this.comboBoxRace.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxRace.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRace.TabIndex = 0;
            this.comboBoxRace.ValueMember = "id_race";
            this.comboBoxRace.SelectedIndexChanged += new System.EventHandler(this.comboBoxRace_SelectedIndexChanged);
            // 
            // rACEBindingSource
            // 
            this.rACEBindingSource.DataMember = "RACE";
            this.rACEBindingSource.DataSource = this.projet_prosqlDataSet;
            // 
            // projet_prosqlDataSet
            // 
            this.projet_prosqlDataSet.DataSetName = "projet_prosqlDataSet";
            this.projet_prosqlDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rACETableAdapter
            // 
            this.rACETableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Race";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Classe";
            // 
            // comboBoxClasse
            // 
            this.comboBoxClasse.DataSource = this.cLASSEBindingSource;
            this.comboBoxClasse.DisplayMember = "nom";
            this.comboBoxClasse.FormattingEnabled = true;
            this.comboBoxClasse.Location = new System.Drawing.Point(100, 235);
            this.comboBoxClasse.Name = "comboBoxClasse";
            this.comboBoxClasse.Size = new System.Drawing.Size(121, 21);
            this.comboBoxClasse.TabIndex = 3;
            this.comboBoxClasse.ValueMember = "id_class";
            this.comboBoxClasse.SelectedIndexChanged += new System.EventHandler(this.comboBoxClasse_SelectedIndexChanged);
            // 
            // cLASSEBindingSource
            // 
            this.cLASSEBindingSource.DataMember = "CLASSE";
            this.cLASSEBindingSource.DataSource = this.projet_prosqlDataSet1;
            // 
            // projet_prosqlDataSet1
            // 
            this.projet_prosqlDataSet1.DataSetName = "projet_prosqlDataSet1";
            this.projet_prosqlDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLASSETableAdapter
            // 
            this.cLASSETableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nom";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(100, 73);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(121, 20);
            this.textBoxNom.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Joueur";
            // 
            // comboBoxJoueur
            // 
            this.comboBoxJoueur.DataSource = this.jOUEURBindingSource;
            this.comboBoxJoueur.DisplayMember = "pseudo";
            this.comboBoxJoueur.FormattingEnabled = true;
            this.comboBoxJoueur.Location = new System.Drawing.Point(100, 131);
            this.comboBoxJoueur.Name = "comboBoxJoueur";
            this.comboBoxJoueur.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBoxJoueur.Size = new System.Drawing.Size(121, 21);
            this.comboBoxJoueur.TabIndex = 6;
            this.comboBoxJoueur.ValueMember = "id_joueur";
            // 
            // jOUEURBindingSource
            // 
            this.jOUEURBindingSource.DataMember = "JOUEUR";
            this.jOUEURBindingSource.DataSource = this.projet_prosqlDataSet2;
            // 
            // projet_prosqlDataSet2
            // 
            this.projet_prosqlDataSet2.DataSetName = "projet_prosqlDataSet2";
            this.projet_prosqlDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jOUEURTableAdapter
            // 
            this.jOUEURTableAdapter.ClearBeforeFill = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(145, 112);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "(Nouveau Joueur)";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Niveau";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // maskedTextBoxNiveau
            // 
            this.maskedTextBoxNiveau.Location = new System.Drawing.Point(100, 291);
            this.maskedTextBoxNiveau.Mask = "99";
            this.maskedTextBoxNiveau.Name = "maskedTextBoxNiveau";
            this.maskedTextBoxNiveau.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxNiveau.TabIndex = 11;
            // 
            // maskedTextBoxDgtCc
            // 
            this.maskedTextBoxDgtCc.Location = new System.Drawing.Point(552, 73);
            this.maskedTextBoxDgtCc.Mask = "99";
            this.maskedTextBoxDgtCc.Name = "maskedTextBoxDgtCc";
            this.maskedTextBoxDgtCc.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxDgtCc.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(552, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Degats Cac";
            // 
            // maskedTextBoxDgtAd
            // 
            this.maskedTextBoxDgtAd.Location = new System.Drawing.Point(552, 131);
            this.maskedTextBoxDgtAd.Mask = "99";
            this.maskedTextBoxDgtAd.Name = "maskedTextBoxDgtAd";
            this.maskedTextBoxDgtAd.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxDgtAd.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(552, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Degats Ad";
            // 
            // maskedTextBoxDef
            // 
            this.maskedTextBoxDef.Location = new System.Drawing.Point(555, 184);
            this.maskedTextBoxDef.Mask = "99";
            this.maskedTextBoxDef.Name = "maskedTextBoxDef";
            this.maskedTextBoxDef.Size = new System.Drawing.Size(121, 20);
            this.maskedTextBoxDef.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(555, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Défense";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(555, 219);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Image du personnage";
            // 
            // buttonImg
            // 
            this.buttonImg.Location = new System.Drawing.Point(555, 235);
            this.buttonImg.Name = "buttonImg";
            this.buttonImg.Size = new System.Drawing.Size(107, 23);
            this.buttonImg.TabIndex = 20;
            this.buttonImg.Text = "Ajouter une image";
            this.buttonImg.UseVisualStyleBackColor = true;
            // 
            // checkedListCompetence
            // 
            this.checkedListCompetence.FormattingEnabled = true;
            this.checkedListCompetence.Location = new System.Drawing.Point(269, 73);
            this.checkedListCompetence.Name = "checkedListCompetence";
            this.checkedListCompetence.Size = new System.Drawing.Size(104, 244);
            this.checkedListCompetence.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(266, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Compétences";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(406, 57);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Objets / Armes";
            // 
            // checkedListObjet
            // 
            this.checkedListObjet.FormattingEnabled = true;
            this.checkedListObjet.Location = new System.Drawing.Point(409, 73);
            this.checkedListObjet.Name = "checkedListObjet";
            this.checkedListObjet.Size = new System.Drawing.Size(104, 244);
            this.checkedListObjet.TabIndex = 23;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(356, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 25;
            this.button2.Text = "Valider";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(563, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Aucune image";
            // 
            // creationPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.checkedListObjet);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkedListCompetence);
            this.Controls.Add(this.buttonImg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.maskedTextBoxDef);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.maskedTextBoxDgtAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextBoxDgtCc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.maskedTextBoxNiveau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxJoueur);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxClasse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxRace);
            this.Name = "creationPerso";
            this.Text = "creationPerso";
            this.Load += new System.EventHandler(this.creationPerso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rACEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jOUEURBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projet_prosqlDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRace;
        private projet_prosqlDataSet projet_prosqlDataSet;
        private System.Windows.Forms.BindingSource rACEBindingSource;
        private projet_prosqlDataSetTableAdapters.RACETableAdapter rACETableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxClasse;
        private projet_prosqlDataSet1 projet_prosqlDataSet1;
        private System.Windows.Forms.BindingSource cLASSEBindingSource;
        private projet_prosqlDataSet1TableAdapters.CLASSETableAdapter cLASSETableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxJoueur;
        private projet_prosqlDataSet2 projet_prosqlDataSet2;
        private System.Windows.Forms.BindingSource jOUEURBindingSource;
        private projet_prosqlDataSet2TableAdapters.JOUEURTableAdapter jOUEURTableAdapter;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNiveau;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDgtCc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDgtAd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDef;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonImg;
        private System.Windows.Forms.CheckedListBox checkedListCompetence;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckedListBox checkedListObjet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
    }
}