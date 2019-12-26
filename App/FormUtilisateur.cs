using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    public partial class FormUtilisateur : Form
    {
        private static utilisateurRepository utilisateurRepository = new utilisateurRepository();
        private static langueRepository langueRepository = new langueRepository();
        
            public Utilisateur _utilisateur;
        public FormAcceuil _formAcceuil;
        
        public FormUtilisateur(FormAcceuil formAcceuil)
        {
            _formAcceuil = formAcceuil;
            InitializeComponent();
            UpdateUtilisateurs();
        }
        public FormUtilisateur(Utilisateur utilisateur, FormAcceuil formAcceuil)
        {
            _utilisateur = utilisateur;
            _formAcceuil = formAcceuil;
            InitializeComponent();
            UpdateUtilisateurs();
            ShowDatas();
        }

        // CONTROLES

            // Controles liés aux Utilisateurs
        private void listBoxUtilisateurs_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Brush myBrush = Brushes.Black;
            if(e.Index!=-1)
                e.Graphics.DrawString(listBoxUtilisateurs.Items[e.Index].ToString(), e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }
        private void listBoxUtilisateurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(_utilisateur != null)
                SaveUserInfos();
            _utilisateur = utilisateurRepository.GetAll()[listBoxUtilisateurs.SelectedIndex];
            _utilisateur.Langues = langueRepository.GetLangues(_utilisateur.Id);
            ShowDatas();

            ActiveButton(buttonDeleteUtilisateur, true, Color.Red);

            buttonContinue.Text = "Continuer avec " + _utilisateur.ToString();
            buttonContinue.Visible = true;
        }
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            SaveUserInfos();
            _utilisateur = new Utilisateur();
            ShowDatas();
        }
        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sûrs de vouloir supprimer cet Utilisateur ?", "Supprimer cet Utilisateur", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Utilisateur utilisateur = utilisateurRepository.GetUtilisateur(_utilisateur.Id);
                utilisateurRepository.Delete(utilisateur);
                UpdateUtilisateurs();
                ActiveButton(buttonDeleteUtilisateur, false, Color.Red);
            }
            buttonContinue.Visible = false;
        }
        
            // Controles liés aux Langues
        private void listBoxLangues_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveButton(buttonDeleteLangue, true, Color.Red);
        }
        private void buttonAddLangue_Click(object sender, EventArgs e)
        {
            Langue langue = new Langue(textBoxLangue.Text, textBoxCertification.Text, _utilisateur.Id);
            langueRepository.SaveOrUpdate(langue);
            _utilisateur.Langues.Add(langue);
            ShowDatas();
            textBoxCertification.Clear();
            textBoxLangue.Clear();
        }
        private void buttonDeleteLangue_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sûrs de vouloir supprimer cette langue ?", "Supprimer cette langue", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Langue langue = langueRepository.GetLangues(_utilisateur.Id)[listBoxLangues.SelectedIndex];
                _utilisateur.Langues.Remove(langue);
                langueRepository.Delete(langue);
                ShowDatas();
                ActiveButton(buttonDeleteLangue, false, Color.Red);
            }
        }

            // Controles liés au Form
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            SaveUserInfos();
            if (_formAcceuil != null)
                _formAcceuil.UpdateUtilisateur(_utilisateur);
            this.Close();
        }

        // METHODES

            // Méthodes liées aux Utilisateurs
        public void UpdateUtilisateurs()
        {
            listBoxUtilisateurs.Items.Clear();
            List<Utilisateur> utilisateurs = utilisateurRepository.GetAll();
            for (int i = 0; i < utilisateurs.Count; i++)
                listBoxUtilisateurs.Items.Add(utilisateurs[i].ToString());
        }
        public void SaveUserInfos()
        {
            _utilisateur.Nom = textBoxName.Text;
            _utilisateur.Prenom = textBoxFirstName.Text;
            _utilisateur.Mail = textBoxMail.Text;
            _utilisateur.Tel = textBoxTel.Text;
            _utilisateur.Description = textBoxDescription.Text;
            _utilisateur.Adresse = textBoxAdresse.Text;
            
            utilisateurRepository.SaveOrUpdate(_utilisateur);
        }
        
            // Méthodes liées aux Langues
        public void UpdateLanguesList()
        {
            List<Langue> langues = langueRepository.GetLangues(this._utilisateur.Id);
            listBoxLangues.Items.Clear();
            for (int i = 0; i < langues.Count; i++)
                listBoxLangues.Items.Add(langues[i].Nom + " (" + langues[i].Certification + ")");
        }
            
            // Méthodes liées aux Form
        public void ShowDatas()
        {
            if(_utilisateur != null)
            {
                textBoxName.Text = _utilisateur.Nom;
                textBoxFirstName.Text = _utilisateur.Prenom;
                textBoxMail.Text = _utilisateur.Mail;
                textBoxTel.Text = _utilisateur.Tel;
                textBoxDescription.Text = _utilisateur.Description;
                textBoxAdresse.Text = _utilisateur.Adresse;

                UpdateLanguesList();
            }

            UpdateUtilisateurs();
        }
        public void ActiveButton(Button button, bool active, Color color)
        {
            if (active)
            {
                button.Enabled = true;
                button.ForeColor = button.FlatAppearance.BorderColor = color;
                button.BackColor = Color.White;
            }
            else
            {
                button.Enabled = false;
                button.ForeColor = button.FlatAppearance.BorderColor = Color.Gray;
                button.BackColor = Color.LightGray;
            }
        }
    }
}
