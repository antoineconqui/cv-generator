using System;
using System.Drawing;
using System.Windows.Forms;
using DAL;
using Domain;

namespace App
{
    public partial class FormSection : Form
    {
        private static elementRepository elementRepository = new elementRepository();
        private static sectionRepository sectionRepository = new sectionRepository();

        public Cv _cv;
        public Section _section;
        public Element _element;
        public FormCv _formCv;

        public FormSection(Cv cv, Section section, FormCv formCv)
        {
            InitializeComponent();
            _cv = cv;
            _section = section;
            _formCv = formCv;
            this.Text = _section.Titre;
            textBoxTitreSection.Text = _section.Titre;
            groupBoxElements.Text += _section.Titre;
            UpdateElements();
            ShowDatas();
        }

        // CONTROLES

            // Controles liés aux Elements
        private void listBoxElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxElements.SelectedIndex;

            if (_element != null && !_section.contient(_element))
            {
                SaveElementInfos();
                UpdateElements();
                listBoxElements.SelectedIndex = (index != -1) ? index : listBoxElements.Items.Count - 1;
            }
            else
                SaveElementInfos();


            if (listBoxElements.SelectedIndex >= 0)
            {
                _element = _section.Elements[listBoxElements.SelectedIndex];
                if((string)listBoxElements.SelectedItem != _element.ToString())
                    listBoxElements.SelectedItem = _element.ToString();
                ShowDatas();
                ActiveButton(buttonDeleteElement, true, Color.Red);
                ActiveButton(buttonSaveElement, true, Color.ForestGreen);
            }
        }
        private void buttonDeleteElement_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sûrs de vouloir supprimer cet élément ?", "Supprimer cet élément", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                Element element = elementRepository.GetElements(_section.Id)[listBoxElements.SelectedIndex];
                elementRepository.Delete(element);
                _section.Elements.Remove(element);
                ShowDatas();
                ActiveButton(buttonDeleteElement, false, Color.Red);
                ActiveButton(buttonSaveElement, false, Color.ForestGreen);
                _element = null;
                ClearTextBoxes();
            }
            UpdateElements();
            listBoxElements.SelectedIndex = listBoxElements.Items.Count - 1;
        }
        private void buttonAddElement_Click(object sender, EventArgs e)
        {
            if(_element!=null)
                SaveElementInfos();
            listBoxElements.SelectedIndex = -1;
            _element = new Element();
            ClearTextBoxes();
            ActiveButton(buttonSaveElement, true, Color.ForestGreen);
            this.ActiveControl = textBoxTitre;
        }

            // Controles liés au Form
        private void buttonContinue_Click(object sender, EventArgs e)
        {
            SaveSectionInfos();
            if (_section.Elements.Count != 0)
            {
                if (_section.Titre != null)
                {
                    _formCv.UpdateCv();
                    this.Close();
                }
                else
                    MessageBox.Show("Veuillez nommer cette section.");
            }
            else
                MessageBox.Show("Veuillez ajouter au moins un élément.");
        }

        // METHODES
            
            // Méthodes liées à la Section
        public void SaveSectionInfos()
        {
            _section.Titre = textBoxTitreSection.Text;
            _section.IdCv = _cv.Id;
            _section.IdUtilisateur = _cv.IdUtilisateur;
            sectionRepository.SaveOrUpdate(_section);
        }
            
            // Méthodes liées aux Eléments
        public void SaveElementInfos()
        {
            if (_element != null && (textBoxTitre.Text != "" || textBoxDateDebut.Text != "" || textBoxDateFin.Text != "" || textBoxLieu.Text != "" || textBoxCompetences.Text != ""))
            {
                _element.Titre = (textBoxTitre.Text!="") ? textBoxTitre.Text : "Element sans titre";
                _element.Debut = textBoxDateDebut.Text;
                _element.Fin = textBoxDateFin.Text;
                _element.Lieu = textBoxLieu.Text;
                _element.Competences = textBoxCompetences.Text;
                _element.Active = 1;
                _element.Hobbies = 0;
                _element.IdSection = _section.Id;
                _element.IdCv = _cv.Id;
                if (!_section.contient(_element))
                    _section.Elements.Add(_element);
                elementRepository.SaveOrUpdate(_element);
            }
        }
        public void UpdateElements()
        {
            listBoxElements.Items.Clear();
            _section.Elements = elementRepository.GetElements(_section.Id);
            for (int i = 0; i < _section.Elements.Count; i++)
                listBoxElements.Items.Add(_section.Elements[i].ToString());
        }
        
            // Méthodes liées au Form
        public void ShowDatas()
        {
            if (_element != null)
            {
                textBoxTitre.Text = _element.Titre;
                textBoxDateDebut.Text = _element.Debut;
                textBoxDateFin.Text = _element.Fin;
                textBoxLieu.Text = _element.Lieu;
                textBoxCompetences.Text = _element.Competences;
            }
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
        public void ClearTextBoxes()
        {
            textBoxTitre.Clear();
            textBoxDateDebut.Clear();
            textBoxDateFin.Clear();
            textBoxLieu.Clear();
            textBoxCompetences.Clear();
        }
    }
}
