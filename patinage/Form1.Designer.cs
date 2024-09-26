
namespace patinage
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.combo_typenatation = new System.Windows.Forms.ComboBox();
            this.combo_competition = new System.Windows.Forms.ComboBox();
            this.text_code = new System.Windows.Forms.TextBox();
            this.text_nom = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rb_individuel = new System.Windows.Forms.RadioButton();
            this.rb_collectif = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.combo_categorie = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.datacompetitions = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacompetitions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Competition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Effectif";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Anne D\'integration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Code";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.combo_typenatation);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(67, 296);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 51);
            this.panel1.TabIndex = 6;
            // 
            // combo_typenatation
            // 
            this.combo_typenatation.FormattingEnabled = true;
            this.combo_typenatation.Location = new System.Drawing.Point(151, 16);
            this.combo_typenatation.Name = "combo_typenatation";
            this.combo_typenatation.Size = new System.Drawing.Size(154, 24);
            this.combo_typenatation.TabIndex = 13;
            // 
            // combo_competition
            // 
            this.combo_competition.FormattingEnabled = true;
            this.combo_competition.Location = new System.Drawing.Point(229, 81);
            this.combo_competition.Name = "combo_competition";
            this.combo_competition.Size = new System.Drawing.Size(121, 24);
            this.combo_competition.TabIndex = 7;
            this.combo_competition.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.combo_competition.TextChanged += new System.EventHandler(this.combo_competition_TextChanged);
            // 
            // text_code
            // 
            this.text_code.Location = new System.Drawing.Point(229, 121);
            this.text_code.Name = "text_code";
            this.text_code.Size = new System.Drawing.Size(100, 22);
            this.text_code.TabIndex = 8;
            // 
            // text_nom
            // 
            this.text_nom.Location = new System.Drawing.Point(229, 166);
            this.text_nom.Name = "text_nom";
            this.text_nom.Size = new System.Drawing.Size(100, 22);
            this.text_nom.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 208);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 22);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // rb_individuel
            // 
            this.rb_individuel.AutoSize = true;
            this.rb_individuel.Location = new System.Drawing.Point(229, 260);
            this.rb_individuel.Name = "rb_individuel";
            this.rb_individuel.Size = new System.Drawing.Size(88, 21);
            this.rb_individuel.TabIndex = 11;
            this.rb_individuel.TabStop = true;
            this.rb_individuel.Text = "Individuel";
            this.rb_individuel.UseVisualStyleBackColor = true;
            // 
            // rb_collectif
            // 
            this.rb_collectif.AutoSize = true;
            this.rb_collectif.Location = new System.Drawing.Point(345, 260);
            this.rb_collectif.Name = "rb_collectif";
            this.rb_collectif.Size = new System.Drawing.Size(78, 21);
            this.rb_collectif.TabIndex = 12;
            this.rb_collectif.TabStop = true;
            this.rb_collectif.Text = "Collectif";
            this.rb_collectif.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.combo_categorie);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(67, 296);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 51);
            this.panel2.TabIndex = 14;
            // 
            // combo_categorie
            // 
            this.combo_categorie.FormattingEnabled = true;
            this.combo_categorie.Location = new System.Drawing.Point(151, 16);
            this.combo_categorie.Name = "combo_categorie";
            this.combo_categorie.Size = new System.Drawing.Size(154, 24);
            this.combo_categorie.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = "Categorie";
            // 
            // datacompetitions
            // 
            this.datacompetitions.AllowUserToAddRows = false;
            this.datacompetitions.AllowUserToDeleteRows = false;
            this.datacompetitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datacompetitions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.datacompetitions.Location = new System.Drawing.Point(67, 449);
            this.datacompetitions.Name = "datacompetitions";
            this.datacompetitions.ReadOnly = true;
            this.datacompetitions.RowHeadersWidth = 51;
            this.datacompetitions.RowTemplate.Height = 24;
            this.datacompetitions.Size = new System.Drawing.Size(805, 191);
            this.datacompetitions.TabIndex = 15;
            this.datacompetitions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datacompetitions_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Code";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Annee d\'integration";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Effectif";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Type";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Categorie";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(404, 410);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(75, 23);
            this.btn_annuler.TabIndex = 16;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(646, 662);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(75, 23);
            this.btn_quitter.TabIndex = 17;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(423, 662);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_modifier.TabIndex = 18;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(208, 662);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(93, 23);
            this.btn_supprimer.TabIndex = 19;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(579, 410);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_ajouter.TabIndex = 20;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 711);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.datacompetitions);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.rb_collectif);
            this.Controls.Add(this.rb_individuel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.text_nom);
            this.Controls.Add(this.text_code);
            this.Controls.Add(this.combo_competition);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datacompetitions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox combo_typenatation;
        private System.Windows.Forms.ComboBox combo_competition;
        private System.Windows.Forms.TextBox text_code;
        private System.Windows.Forms.TextBox text_nom;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.RadioButton rb_individuel;
        private System.Windows.Forms.RadioButton rb_collectif;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox combo_categorie;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView datacompetitions;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

