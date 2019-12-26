using DAL;
using Domain;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace App
{
    public partial class FormAcceuil : Form
    {
        public static cvRepository cvRepository = new cvRepository();
        public static utilisateurRepository utilisateurRepository = new utilisateurRepository();
        
        public Utilisateur _utilisateur;
        
        public FormAcceuil()
        {
            InitializeComponent();
        }

        // CONTROLES

            // Controles liés aux Utilisateurs
        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            FormUtilisateur formUtilisateur;
            if (_utilisateur == null)
                formUtilisateur = new FormUtilisateur(this);
            else
                formUtilisateur = new FormUtilisateur(_utilisateur, this);
            formUtilisateur.Show();
        }
        
            // Controles liés aux Cvs
        public void listBoxCvs_DrawItem(object sender, DrawItemEventArgs e)
        {
            ListBox list = (ListBox)sender;
            if (e.Index > -1)
            {
                object item = list.Items[e.Index];
                e.DrawBackground();
                e.DrawFocusRectangle();
                Brush brush = new SolidBrush(e.ForeColor);
                SizeF size = e.Graphics.MeasureString(item.ToString(), e.Font);
                e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds.Left + (e.Bounds.Width / 2 - size.Width / 2), e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));
            }
        }
        private void listBoxCvs_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEditCv.Enabled = buttonDeleteCv.Enabled = true;
            buttonDeleteCv.FlatAppearance.BorderColor = buttonDeleteCv.ForeColor = Color.Red;
            buttonEditCv.FlatAppearance.BorderColor = buttonEditCv.ForeColor = Color.ForestGreen;
            buttonDeleteCv.BackColor = buttonEditCv.BackColor = Color.White;
        }
        private void buttonAddCv_Click(object sender, EventArgs e)
        {
            String cvName = Interaction.InputBox("Comment voulez-vous nommer le nouveau CV ?", "Titre", "Nouveau CV");
            if (cvName.Length != 0)
            {
                Cv cv = new Cv(cvName, _utilisateur);
                cvRepository.SaveOrUpdate(cv);
                OpenCv(cv);
            }
        }
        private void buttonDeleteCv_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sûrs de vouloir supprimer ce CV ?", "Supprimer ce CV", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Cv cv = cvRepository.GetCV(_utilisateur)[listBoxCvs.SelectedIndex];
                cvRepository.Delete(cv);
                UpdateCvs();
                buttonDeleteCv.Enabled = buttonEditCv.Enabled = false;
                buttonEditCv.ForeColor = buttonDeleteCv.ForeColor = buttonEditCv.FlatAppearance.BorderColor = buttonDeleteCv.FlatAppearance.BorderColor = Color.Gray;
                buttonEditCv.BackColor = buttonDeleteCv.BackColor = Color.LightGray;
            }
        }
        private void buttonEditCv_Click(object sender, EventArgs e)
        {
            List<Cv> cvs = cvRepository.GetAll();
            Cv cv = cvs[listBoxCvs.SelectedIndex];
            OpenCv(cv);
        }
        
        // METHODES
            
            // Méthodes liées aux Utilisateurs
        public void UpdateUtilisateur(Utilisateur utilisateur)
        {
            _utilisateur = utilisateur;
            labelUtilisateur.Text = _utilisateur.ToString();
            buttonChangeUser.Text = "Changer d'utilisateur";
            buttonNewCv.Enabled = true;
            buttonNewCv.FlatAppearance.BorderColor = buttonNewCv.ForeColor = Color.SteelBlue;
            buttonNewCv.BackColor = Color.White;
            UpdateCvs();
        }
        
            //Méthodes liées aux Cvs
        public void UpdateCvs()
        {
            listBoxCvs.Items.Clear();
            List<Cv> cvs = cvRepository.GetCV(_utilisateur);
            for (int i = 0; i < cvs.Count; i++)
                listBoxCvs.Items.Add(cvs[i].Titre);
        }
        public void OpenCv(Cv cv)
        {
            FormCv formCv = new FormCv(cv, this);
            formCv.Show();
            this.Hide();
        }
    }
}
;