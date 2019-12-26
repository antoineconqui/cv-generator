namespace App
{
    partial class FormSection
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
            this.groupBoxElements = new System.Windows.Forms.GroupBox();
            this.buttonDeleteElement = new System.Windows.Forms.Button();
            this.buttonAddElement = new System.Windows.Forms.Button();
            this.listBoxElements = new System.Windows.Forms.ListBox();
            this.textBoxCompetences = new System.Windows.Forms.RichTextBox();
            this.labelCompetences = new System.Windows.Forms.Label();
            this.groupBoxEditElement = new System.Windows.Forms.GroupBox();
            this.buttonSaveElement = new System.Windows.Forms.Button();
            this.labelLieu = new System.Windows.Forms.Label();
            this.textBoxLieu = new System.Windows.Forms.TextBox();
            this.labelDateFin = new System.Windows.Forms.Label();
            this.textBoxDateFin = new System.Windows.Forms.TextBox();
            this.labelDateDebut = new System.Windows.Forms.Label();
            this.textBoxDateDebut = new System.Windows.Forms.TextBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.textBoxTitre = new System.Windows.Forms.TextBox();
            this.textBoxTitreSection = new System.Windows.Forms.TextBox();
            this.labelTitreSection = new System.Windows.Forms.Label();
            this.labelTitreForm = new System.Windows.Forms.Label();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.groupBoxElements.SuspendLayout();
            this.groupBoxEditElement.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxElements
            // 
            this.groupBoxElements.Controls.Add(this.buttonDeleteElement);
            this.groupBoxElements.Controls.Add(this.buttonAddElement);
            this.groupBoxElements.Controls.Add(this.listBoxElements);
            this.groupBoxElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxElements.Location = new System.Drawing.Point(35, 144);
            this.groupBoxElements.Name = "groupBoxElements";
            this.groupBoxElements.Size = new System.Drawing.Size(294, 380);
            this.groupBoxElements.TabIndex = 29;
            this.groupBoxElements.TabStop = false;
            this.groupBoxElements.Text = "Vos éléments de ";
            // 
            // buttonDeleteElement
            // 
            this.buttonDeleteElement.BackColor = System.Drawing.Color.LightGray;
            this.buttonDeleteElement.Enabled = false;
            this.buttonDeleteElement.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonDeleteElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteElement.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteElement.ForeColor = System.Drawing.Color.Gray;
            this.buttonDeleteElement.Location = new System.Drawing.Point(149, 322);
            this.buttonDeleteElement.Name = "buttonDeleteElement";
            this.buttonDeleteElement.Size = new System.Drawing.Size(130, 50);
            this.buttonDeleteElement.TabIndex = 34;
            this.buttonDeleteElement.Text = "Supprimer";
            this.buttonDeleteElement.UseVisualStyleBackColor = false;
            this.buttonDeleteElement.Click += new System.EventHandler(this.buttonDeleteElement_Click);
            // 
            // buttonAddElement
            // 
            this.buttonAddElement.BackColor = System.Drawing.Color.White;
            this.buttonAddElement.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonAddElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddElement.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddElement.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonAddElement.Location = new System.Drawing.Point(7, 322);
            this.buttonAddElement.Name = "buttonAddElement";
            this.buttonAddElement.Size = new System.Drawing.Size(130, 50);
            this.buttonAddElement.TabIndex = 33;
            this.buttonAddElement.Text = "Ajouter";
            this.buttonAddElement.UseVisualStyleBackColor = false;
            this.buttonAddElement.Click += new System.EventHandler(this.buttonAddElement_Click);
            // 
            // listBoxElements
            // 
            this.listBoxElements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxElements.FormattingEnabled = true;
            this.listBoxElements.ItemHeight = 20;
            this.listBoxElements.Location = new System.Drawing.Point(7, 24);
            this.listBoxElements.Name = "listBoxElements";
            this.listBoxElements.Size = new System.Drawing.Size(272, 284);
            this.listBoxElements.TabIndex = 15;
            this.listBoxElements.SelectedIndexChanged += new System.EventHandler(this.listBoxElements_SelectedIndexChanged);
            // 
            // textBoxCompetences
            // 
            this.textBoxCompetences.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCompetences.Location = new System.Drawing.Point(232, 206);
            this.textBoxCompetences.Name = "textBoxCompetences";
            this.textBoxCompetences.Size = new System.Drawing.Size(281, 110);
            this.textBoxCompetences.TabIndex = 11;
            this.textBoxCompetences.Text = "";
            // 
            // labelCompetences
            // 
            this.labelCompetences.AutoSize = true;
            this.labelCompetences.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompetences.Location = new System.Drawing.Point(26, 209);
            this.labelCompetences.Name = "labelCompetences";
            this.labelCompetences.Size = new System.Drawing.Size(122, 20);
            this.labelCompetences.TabIndex = 10;
            this.labelCompetences.Text = "Compétences :";
            // 
            // groupBoxEditElement
            // 
            this.groupBoxEditElement.Controls.Add(this.buttonSaveElement);
            this.groupBoxEditElement.Controls.Add(this.textBoxCompetences);
            this.groupBoxEditElement.Controls.Add(this.labelCompetences);
            this.groupBoxEditElement.Controls.Add(this.labelLieu);
            this.groupBoxEditElement.Controls.Add(this.textBoxLieu);
            this.groupBoxEditElement.Controls.Add(this.labelDateFin);
            this.groupBoxEditElement.Controls.Add(this.textBoxDateFin);
            this.groupBoxEditElement.Controls.Add(this.labelDateDebut);
            this.groupBoxEditElement.Controls.Add(this.textBoxDateDebut);
            this.groupBoxEditElement.Controls.Add(this.labelTitre);
            this.groupBoxEditElement.Controls.Add(this.textBoxTitre);
            this.groupBoxEditElement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEditElement.Location = new System.Drawing.Point(376, 144);
            this.groupBoxEditElement.Name = "groupBoxEditElement";
            this.groupBoxEditElement.Size = new System.Drawing.Size(519, 380);
            this.groupBoxEditElement.TabIndex = 26;
            this.groupBoxEditElement.TabStop = false;
            this.groupBoxEditElement.Text = "Modifier l\'élément";
            // 
            // buttonSaveElement
            // 
            this.buttonSaveElement.BackColor = System.Drawing.Color.LightGray;
            this.buttonSaveElement.Enabled = false;
            this.buttonSaveElement.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonSaveElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveElement.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveElement.ForeColor = System.Drawing.Color.Gray;
            this.buttonSaveElement.Location = new System.Drawing.Point(232, 322);
            this.buttonSaveElement.Name = "buttonSaveElement";
            this.buttonSaveElement.Size = new System.Drawing.Size(281, 50);
            this.buttonSaveElement.TabIndex = 35;
            this.buttonSaveElement.Text = "Valider";
            this.buttonSaveElement.UseVisualStyleBackColor = false;
            this.buttonSaveElement.Click += new System.EventHandler(this.listBoxElements_SelectedIndexChanged);
            // 
            // labelLieu
            // 
            this.labelLieu.AutoSize = true;
            this.labelLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLieu.Location = new System.Drawing.Point(26, 157);
            this.labelLieu.Name = "labelLieu";
            this.labelLieu.Size = new System.Drawing.Size(51, 20);
            this.labelLieu.TabIndex = 7;
            this.labelLieu.Text = "Lieu :";
            // 
            // textBoxLieu
            // 
            this.textBoxLieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLieu.Location = new System.Drawing.Point(232, 157);
            this.textBoxLieu.Name = "textBoxLieu";
            this.textBoxLieu.Size = new System.Drawing.Size(281, 26);
            this.textBoxLieu.TabIndex = 6;
            // 
            // labelDateFin
            // 
            this.labelDateFin.AutoSize = true;
            this.labelDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateFin.Location = new System.Drawing.Point(26, 115);
            this.labelDateFin.Name = "labelDateFin";
            this.labelDateFin.Size = new System.Drawing.Size(42, 20);
            this.labelDateFin.TabIndex = 5;
            this.labelDateFin.Text = "Fin :";
            // 
            // textBoxDateFin
            // 
            this.textBoxDateFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateFin.Location = new System.Drawing.Point(232, 115);
            this.textBoxDateFin.Name = "textBoxDateFin";
            this.textBoxDateFin.Size = new System.Drawing.Size(281, 26);
            this.textBoxDateFin.TabIndex = 4;
            // 
            // labelDateDebut
            // 
            this.labelDateDebut.AutoSize = true;
            this.labelDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateDebut.Location = new System.Drawing.Point(26, 72);
            this.labelDateDebut.Name = "labelDateDebut";
            this.labelDateDebut.Size = new System.Drawing.Size(64, 20);
            this.labelDateDebut.TabIndex = 3;
            this.labelDateDebut.Text = "Début :";
            // 
            // textBoxDateDebut
            // 
            this.textBoxDateDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDateDebut.Location = new System.Drawing.Point(232, 72);
            this.textBoxDateDebut.Name = "textBoxDateDebut";
            this.textBoxDateDebut.Size = new System.Drawing.Size(281, 26);
            this.textBoxDateDebut.TabIndex = 2;
            // 
            // labelTitre
            // 
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(26, 29);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(53, 20);
            this.labelTitre.TabIndex = 1;
            this.labelTitre.Text = "Titre :";
            // 
            // textBoxTitre
            // 
            this.textBoxTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitre.Location = new System.Drawing.Point(232, 29);
            this.textBoxTitre.Name = "textBoxTitre";
            this.textBoxTitre.Size = new System.Drawing.Size(281, 26);
            this.textBoxTitre.TabIndex = 0;
            // 
            // textBoxTitreSection
            // 
            this.textBoxTitreSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitreSection.Location = new System.Drawing.Point(376, 100);
            this.textBoxTitreSection.Name = "textBoxTitreSection";
            this.textBoxTitreSection.Size = new System.Drawing.Size(278, 26);
            this.textBoxTitreSection.TabIndex = 30;
            // 
            // labelTitreSection
            // 
            this.labelTitreSection.AutoSize = true;
            this.labelTitreSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreSection.Location = new System.Drawing.Point(159, 103);
            this.labelTitreSection.Name = "labelTitreSection";
            this.labelTitreSection.Size = new System.Drawing.Size(155, 20);
            this.labelTitreSection.TabIndex = 15;
            this.labelTitreSection.Text = "Titre de la Section :";
            // 
            // labelTitreForm
            // 
            this.labelTitreForm.AutoSize = true;
            this.labelTitreForm.Font = new System.Drawing.Font("Microsoft YaHei Light", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitreForm.Location = new System.Drawing.Point(12, 9);
            this.labelTitreForm.Name = "labelTitreForm";
            this.labelTitreForm.Size = new System.Drawing.Size(470, 60);
            this.labelTitreForm.TabIndex = 33;
            this.labelTitreForm.Text = "Gestion de la Section";
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.White;
            this.buttonContinue.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.buttonContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonContinue.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.ForeColor = System.Drawing.Color.ForestGreen;
            this.buttonContinue.Location = new System.Drawing.Point(608, 19);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(281, 50);
            this.buttonContinue.TabIndex = 34;
            this.buttonContinue.Text = "Continuer";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // FormSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 549);
            this.Controls.Add(this.buttonContinue);
            this.Controls.Add(this.labelTitreForm);
            this.Controls.Add(this.labelTitreSection);
            this.Controls.Add(this.textBoxTitreSection);
            this.Controls.Add(this.groupBoxElements);
            this.Controls.Add(this.groupBoxEditElement);
            this.MinimumSize = new System.Drawing.Size(925, 536);
            this.Name = "FormSection";
            this.Text = "FormSection";
            this.groupBoxElements.ResumeLayout(false);
            this.groupBoxEditElement.ResumeLayout(false);
            this.groupBoxEditElement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxElements;
        private System.Windows.Forms.ListBox listBoxElements;
        private System.Windows.Forms.RichTextBox textBoxCompetences;
        private System.Windows.Forms.Label labelCompetences;
        private System.Windows.Forms.GroupBox groupBoxEditElement;
        private System.Windows.Forms.Label labelLieu;
        private System.Windows.Forms.TextBox textBoxLieu;
        private System.Windows.Forms.Label labelDateFin;
        private System.Windows.Forms.TextBox textBoxDateFin;
        private System.Windows.Forms.Label labelDateDebut;
        private System.Windows.Forms.TextBox textBoxDateDebut;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.TextBox textBoxTitre;
        private System.Windows.Forms.TextBox textBoxTitreSection;
        private System.Windows.Forms.Label labelTitreSection;
        private System.Windows.Forms.Button buttonAddElement;
        private System.Windows.Forms.Button buttonDeleteElement;
        private System.Windows.Forms.Label labelTitreForm;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonSaveElement;
    }
}