namespace App
{
    partial class FormAcceuil
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonNewCv = new System.Windows.Forms.Button();
            this.listBoxCvs = new System.Windows.Forms.ListBox();
            this.buttonDeleteCv = new System.Windows.Forms.Button();
            this.buttonEditCv = new System.Windows.Forms.Button();
            this.labelUtilisateur = new System.Windows.Forms.Label();
            this.buttonChangeUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei Light", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(48, 80);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(694, 70);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Curriculum Vitae Generator";
            // 
            // buttonNewCv
            // 
            this.buttonNewCv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonNewCv.BackColor = System.Drawing.Color.LightGray;
            this.buttonNewCv.Enabled = false;
            this.buttonNewCv.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonNewCv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewCv.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewCv.ForeColor = System.Drawing.Color.Gray;
            this.buttonNewCv.Location = new System.Drawing.Point(194, 332);
            this.buttonNewCv.Name = "buttonNewCv";
            this.buttonNewCv.Size = new System.Drawing.Size(130, 50);
            this.buttonNewCv.TabIndex = 2;
            this.buttonNewCv.Text = "Nouveau";
            this.buttonNewCv.UseVisualStyleBackColor = false;
            this.buttonNewCv.Click += new System.EventHandler(this.buttonAddCv_Click);
            // 
            // listBoxCvs
            // 
            this.listBoxCvs.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listBoxCvs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxCvs.FormattingEnabled = true;
            this.listBoxCvs.Location = new System.Drawing.Point(194, 218);
            this.listBoxCvs.Name = "listBoxCvs";
            this.listBoxCvs.Size = new System.Drawing.Size(402, 95);
            this.listBoxCvs.TabIndex = 3;
            this.listBoxCvs.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxCvs_DrawItem);
            this.listBoxCvs.SelectedIndexChanged += new System.EventHandler(this.listBoxCvs_SelectedIndexChanged);
            // 
            // buttonDeleteCv
            // 
            this.buttonDeleteCv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonDeleteCv.BackColor = System.Drawing.Color.LightGray;
            this.buttonDeleteCv.Enabled = false;
            this.buttonDeleteCv.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonDeleteCv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteCv.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteCv.ForeColor = System.Drawing.Color.Gray;
            this.buttonDeleteCv.Location = new System.Drawing.Point(330, 332);
            this.buttonDeleteCv.Name = "buttonDeleteCv";
            this.buttonDeleteCv.Size = new System.Drawing.Size(130, 50);
            this.buttonDeleteCv.TabIndex = 4;
            this.buttonDeleteCv.Text = "Supprimer";
            this.buttonDeleteCv.UseVisualStyleBackColor = false;
            this.buttonDeleteCv.Click += new System.EventHandler(this.buttonDeleteCv_Click);
            // 
            // buttonEditCv
            // 
            this.buttonEditCv.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonEditCv.BackColor = System.Drawing.Color.LightGray;
            this.buttonEditCv.Enabled = false;
            this.buttonEditCv.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonEditCv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditCv.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEditCv.ForeColor = System.Drawing.Color.Gray;
            this.buttonEditCv.Location = new System.Drawing.Point(466, 332);
            this.buttonEditCv.Name = "buttonEditCv";
            this.buttonEditCv.Size = new System.Drawing.Size(130, 50);
            this.buttonEditCv.TabIndex = 5;
            this.buttonEditCv.Text = "Editer";
            this.buttonEditCv.UseVisualStyleBackColor = false;
            this.buttonEditCv.Click += new System.EventHandler(this.buttonEditCv_Click);
            // 
            // labelUtilisateur
            // 
            this.labelUtilisateur.AutoSize = true;
            this.labelUtilisateur.Font = new System.Drawing.Font("Microsoft YaHei Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUtilisateur.Location = new System.Drawing.Point(189, 185);
            this.labelUtilisateur.Name = "labelUtilisateur";
            this.labelUtilisateur.Size = new System.Drawing.Size(193, 27);
            this.labelUtilisateur.TabIndex = 6;
            this.labelUtilisateur.Text = "Choisir un utilisateur";
            // 
            // buttonChangeUser
            // 
            this.buttonChangeUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonChangeUser.BackColor = System.Drawing.Color.White;
            this.buttonChangeUser.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.buttonChangeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeUser.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeUser.ForeColor = System.Drawing.Color.SteelBlue;
            this.buttonChangeUser.Location = new System.Drawing.Point(432, 177);
            this.buttonChangeUser.Name = "buttonChangeUser";
            this.buttonChangeUser.Size = new System.Drawing.Size(164, 35);
            this.buttonChangeUser.TabIndex = 8;
            this.buttonChangeUser.Text = "Choisir";
            this.buttonChangeUser.UseVisualStyleBackColor = false;
            this.buttonChangeUser.Click += new System.EventHandler(this.buttonChangeUser_Click);
            // 
            // FormAcceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonChangeUser);
            this.Controls.Add(this.labelUtilisateur);
            this.Controls.Add(this.buttonEditCv);
            this.Controls.Add(this.buttonDeleteCv);
            this.Controls.Add(this.listBoxCvs);
            this.Controls.Add(this.buttonNewCv);
            this.Controls.Add(this.labelTitle);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "FormAcceuil";
            this.Text = "FormAcceuil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonNewCv;
        private System.Windows.Forms.ListBox listBoxCvs;
        private System.Windows.Forms.Button buttonDeleteCv;
        private System.Windows.Forms.Button buttonEditCv;
        private System.Windows.Forms.Label labelUtilisateur;
        private System.Windows.Forms.Button buttonChangeUser;
    }
}