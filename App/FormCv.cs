using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using DAL;
using Domain;
using IronPdf;

namespace App
{
    public partial class FormCv : Form
    {
        private static cvRepository cvRepository = new cvRepository();
        private static utilisateurRepository utilisateurRepository = new utilisateurRepository();
        private static sectionRepository sectionRepository = new sectionRepository();
        private static elementRepository elementRepository = new elementRepository();
        private static contactRepository contactRepository = new contactRepository();
        private static langueRepository langueRepository = new langueRepository();

        public Cv _cv;
        public FormAcceuil _formAcceuil;
        public WebBrowser webBrowser = new WebBrowser();

        public FormCv(Cv cv, FormAcceuil formAcceuil)
        {
            InitializeComponent();
            _cv = cv;
            _formAcceuil = formAcceuil;
            UpdateCv();
        }

        // CONTROLES

            // Controles liés aux Sections
        private void buttonAddSection_Click(object sender, EventArgs e)
        {
            Section section = new Section();
            sectionRepository.SaveOrUpdate(section);
            Form sectionForm = new FormSection(_cv, section, this);
            sectionForm.Show();
        }
        private void buttonDeleteSection_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Etes vous sûrs de vouloir supprimer cette section ?", "Supprimer cette section", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
            {
                sectionRepository.Delete((Section)((Button)sender).Tag);
                UpdateCv();
            }
        }
        private void buttonEditSection_Click(object sender, EventArgs e)
        {
            FormSection formSection = new FormSection(_cv, (Section)((Button)sender).Tag, this);
            formSection.Show();
        }

            // Controles liés aux Elements
        private void CheckBoxElement_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            Element element = (Element)checkBox.Tag;
            element.Active = (checkBox.Checked) ? 1 : 0;
            elementRepository.SaveOrUpdate(element);
            UpdateCv();
        }

            // Controles liés au Form
        private void textBoxJob_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            _cv.Job = textBox.Text;
        }
        private void panelApercu_SizeChanged(object sender, EventArgs e)
        {
            if (panelApercu.Height < panelApercu.Width * 297 / 210)
            {
                pictureBoxApercuCv.Height = panelApercu.Height;
                pictureBoxApercuCv.Width = panelApercu.Height * 210 / 297;
                pictureBoxApercuCv.Top = 0;
                pictureBoxApercuCv.Left = (panelApercu.Width - pictureBoxApercuCv.Width) / 2;
            }
            else
            {
                pictureBoxApercuCv.Width = panelApercu.Width;
                pictureBoxApercuCv.Height = panelApercu.Width * 297 / 210;
                pictureBoxApercuCv.Left = 0;
                pictureBoxApercuCv.Top = (panelApercu.Height - pictureBoxApercuCv.Height) / 2;
            }
        }
        private void buttonRetour_Click(object sender, EventArgs e)
        {
            SaveCvInfos();
            if(_formAcceuil!=null)
                _formAcceuil.Show();
            this.Close();
        }
        
            // Controles liés à la Génération du CV
        private void buttonGenererPdf_Click(object sender, EventArgs e)
        {
            string htmlFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), _cv.Titre + ".html");
            string pdfFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), _cv.Titre + ".pdf");

            FileInfo fileInfo = new FileInfo(htmlFilePath);
            StreamWriter streamWriter = fileInfo.CreateText();
            streamWriter.Write(GetHtml());
            streamWriter.Close();

            HtmlToPdf htmlToPdf = new HtmlToPdf();
            htmlToPdf.PrintOptions.CssMediaType = PdfPrintOptions.PdfCssMediaType.Print;
            htmlToPdf.PrintOptions.PaperSize = PdfPrintOptions.PdfPaperSize.A4;
            PdfDocument pdfDocument = htmlToPdf.RenderHtmlAsPdf(File.ReadAllText(htmlFilePath));
            pdfDocument.SaveAs(pdfFilePath);

            System.Diagnostics.Process.Start(pdfFilePath);
            System.Diagnostics.Process.Start(htmlFilePath);
            // Controles liés au Form
        }

        // METHODES

            // Méthodes liées au Cv
        public void SaveCvInfos()
        {
            //_cv.Titre = textBoxTitre.Text;
            cvRepository.SaveOrUpdate(_cv);
        }
        public void UpdateCv()
        {
            _cv = cvRepository.GetCV(_cv.Id);
            this.Text = _cv.Titre;
            _cv.Utilisateur = utilisateurRepository.GetUtilisateur(_cv.IdUtilisateur);
            _cv.Sections = sectionRepository.GetSections(_cv.Id);
            foreach (Section section in _cv.Sections)
                section.Elements = elementRepository.GetElements(section.Id);
            _cv.Competences = elementRepository.GetCompetences(_cv.IdUtilisateur);
            _cv.Hobbies = elementRepository.GetHobbies(_cv.IdUtilisateur);
            cvRepository.SaveOrUpdate(_cv);
            DisplayCV();
        }

            // Méthodes liées au Form
        public void DisplayCV()
        {
            DisplaySections();
            DisplayInfos();
            DisplayApercu();
        }
        public void DisplaySections()
        {
            panelFond.Controls.Clear();

            int y = 0;
            int ySection;

            Label labelName = new Label();
            labelName.Text = _cv.Utilisateur.ToString();
            labelName.Font = new Font("Microsoft YaHei Light", 16);
            labelName.TextAlign = ContentAlignment.MiddleCenter;
            labelName.Location = new Point(0, y);
            labelName.Size = new Size(200, 70);
            panelFond.Controls.Add(labelName);

            y += 80;

            Label labelJob = new Label();
            labelJob.Text = "Nom du Job : ";
            labelName.Font = new Font("Microsoft YaHei Light", 10);
            labelJob.Location = new Point(0, y);
            labelJob.Size = new Size(80, 20);
            panelFond.Controls.Add(labelJob);

            TextBox textBoxJob = new TextBox();
            textBoxJob.Text = _cv.Job;
            textBoxJob.Location = new Point(80, y);
            textBoxJob.Size = new Size(120, 20);
            textBoxJob.TextChanged += textBoxJob_TextChanged;
            panelFond.Controls.Add(textBoxJob);

            y += 20;

            foreach (Section section in _cv.Sections)
            {
                ySection = 20;

                GroupBox groupBox = new GroupBox();
                groupBox.Tag = section;
                groupBox.Text = section.Titre;
                groupBox.Font = new Font("Microsoft YaHei Light", 10);
                groupBox.Location = new Point(0, y);

                foreach (Element element in section.Elements)
                {
                    CheckBox checkBox = new CheckBox();
                    checkBox.Tag = element;
                    checkBox.Text = element.Titre;
                    checkBox.Font = new Font("Microsoft YaHei Light", 10);
                    checkBox.Location = new Point(10, ySection);
                    checkBox.Size = new Size(180, 30);
                    checkBox.Checked = (element.Active == 1);
                    checkBox.CheckedChanged += CheckBoxElement_CheckedChanged;
                    groupBox.Controls.Add(checkBox);

                    ySection += 30;
                }

                ySection += 5;

                Button buttonDeleteSection = new Button();
                buttonDeleteSection.Tag = section;
                buttonDeleteSection.Text = "Supprimer";
                buttonDeleteSection.Font = new Font("Microsoft YaHei", 10);
                buttonDeleteSection.Location = new Point(5, ySection);
                buttonDeleteSection.FlatStyle = FlatStyle.Flat;
                buttonDeleteSection.FlatAppearance.BorderColor = buttonDeleteSection.ForeColor = Color.Red;
                buttonDeleteSection.BackColor = Color.White;
                buttonDeleteSection.Size = new Size(90, 30);
                buttonDeleteSection.Click += buttonDeleteSection_Click;
                groupBox.Controls.Add(buttonDeleteSection);

                Button buttonEditSection = new Button();
                buttonEditSection.Tag = section;
                buttonEditSection.Text = "Editer";
                buttonEditSection.Font = new Font("Microsoft YaHei", 10);
                buttonEditSection.Location = new Point(105, ySection);
                buttonEditSection.FlatStyle = FlatStyle.Flat;
                buttonEditSection.FlatAppearance.BorderColor = buttonEditSection.ForeColor = Color.ForestGreen;
                buttonEditSection.BackColor = Color.White;
                buttonEditSection.Size = new Size(90, 30);
                buttonEditSection.Click += buttonEditSection_Click;
                groupBox.Controls.Add(buttonEditSection);

                ySection += 35;

                groupBox.Size = new Size(200, ySection);
                panelFond.Controls.Add(groupBox);

                y += ySection + 5;
            }

            Button buttonAddSection = new Button();
            buttonAddSection.Text = "Ajouter";
            buttonAddSection.Font = new Font("Microsoft YaHei", 12);
            buttonAddSection.Location = new Point(0, y);
            buttonAddSection.FlatStyle = FlatStyle.Flat;
            buttonAddSection.FlatAppearance.BorderColor = buttonAddSection.ForeColor = Color.SteelBlue;
            buttonAddSection.BackColor = Color.White;
            buttonAddSection.Size = new Size(200, 63);
            buttonAddSection.Click += buttonAddSection_Click;
            panelFond.Controls.Add(buttonAddSection);
        }
        public void DisplayApercu()
        {
            pictureBoxApercuCv.Controls.Remove(webBrowser);
            webBrowser.AllowWebBrowserDrop = false;
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.DocumentText = GetHtml();
            pictureBoxApercuCv.Controls.Add(webBrowser);
        }
        public void DisplayInfos()
        {
            panelForme.Controls.Clear();

            int y = 0;

            GroupBox groupBoxCompetences = new GroupBox();
            groupBoxCompetences.Text = "Compétences";
            groupBoxCompetences.Font = new Font("Microsoft YaHei Light", 10);
            groupBoxCompetences.Location = new Point(0, y);

            int yElement = 20;
            
            foreach (Element element in _cv.Competences)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Tag = element;
                checkBox.Text = element.Titre;
                checkBox.Font = new Font("Microsoft YaHei Light", 10);
                checkBox.Location = new Point(10, yElement);
                checkBox.Size = new Size(180, 30);
                checkBox.Checked = (element.Active == 1);
                checkBox.CheckedChanged += CheckBoxElement_CheckedChanged;
                groupBoxCompetences.Controls.Add(checkBox);

                yElement += 30;
            }

            y += yElement +10;

            groupBoxCompetences.Size = new Size(200, y);

            y += 10;

            GroupBox groupBoxHobbies = new GroupBox();
            groupBoxHobbies.Text = "Hobbies";
            groupBoxHobbies.Font = new Font("Microsoft YaHei Light", 10);
            groupBoxHobbies.Location = new Point(0, y);

            yElement = 20;

            foreach (Element element in _cv.Hobbies)
            {
                CheckBox checkBox = new CheckBox();
                checkBox.Tag = element;
                checkBox.Text = element.Titre;
                checkBox.Font = new Font("Microsoft YaHei Light", 10);
                checkBox.Location = new Point(10, yElement);
                checkBox.Size = new Size(180, 30);
                checkBox.Checked = (element.Active == 1);
                checkBox.CheckedChanged += CheckBoxElement_CheckedChanged;
                groupBoxHobbies.Controls.Add(checkBox);

                yElement += 30;
            }

            y += yElement;

            groupBoxHobbies.Size = new Size(200, y - groupBoxCompetences.Size.Height);

            panelForme.Controls.Add(groupBoxCompetences);
            panelForme.Controls.Add(groupBoxHobbies);
        }
        
            // Méthodes liées à la Génération du CV
        public string GetHtml()
        {
            string name = "<div class=\"titre\">" + _cv.Utilisateur.ToString() + "</div>";

            string description = "<div class=\"description\">" + _cv.Utilisateur.Description + "</div>";

            string contacts = "<h2>CONTACT</h2><p><strong> Adresse </strong> : " + _cv.Utilisateur.Adresse + " </p><p><strong> Tel </strong> : " + _cv.Utilisateur.Tel + " </p><p><strong> Email </strong> : " + _cv.Utilisateur.Mail + " </p>";
            foreach (Contact contact in contactRepository.GetContacts(_cv.IdUtilisateur))
                contacts += "<p><strong>" + contact.Nom + "</strong> : " + contact.Lien + "</p>";

            string langues = "<h2>LANGUES</h2>";
            foreach (Langue langue in langueRepository.GetLangues(_cv.IdUtilisateur))
                langues += "<p><strong>" + langue.Nom + "</strong> : " + langue.Certification + "</p>";

            string competences = "<h2>COMPETENCES</h2>";
            foreach (Element element in elementRepository.GetCompetences(_cv.IdUtilisateur))
                if (element.Active == 1)
                    competences += "<p>" + element.Titre + "</p>";

            string hobbies = "<h2>HOBBIES</h2>";
            foreach (Element element in elementRepository.GetHobbies(_cv.IdUtilisateur))
                if (element.Active == 1)
                    hobbies += "<p>" + element.Titre + "</p>";

            string infos = "<div class=\"infos\">" + contacts + langues + competences + hobbies + "</div>";

            string sections = "<div class=\"sections\">";
            foreach (Section section in _cv.Sections)
            {
                sections += "<h2>" + section.Titre.ToUpper() + "</h2>";

                foreach (Element element in elementRepository.GetElements(section.Id))
                {
                    if (element.Active == 1)
                    {
                        sections += "<div class=\"titre\">" + element.Titre + " ~ " + element.Lieu + "</div>";
                        sections += "<div class=\"date\">" + element.Debut + " - " + element.Fin + "</div>";
                        sections += "<div class=\"competences\">" + element.Competences + "</div>";
                    }
                }
            }
            sections += "</div>";

            string html = "<html><head><style>" +
                ":root{--gray:#CED6DA;--light:#84D1FC;--middle:#4A8999;--dark:#11385E}html{height:297mm;width:210mm;background-color:#000}body{height:297mm;width:210mm;background-color:#fff;font-family:'Open Sans',sans-serif;margin:auto}body>.titre{position:absolute;left:21mm;top:21mm;font-size:2.5em;color:var(--dark)}body>.description{position:absolute;left:10mm;top:47mm;font-size:large;color:var(--dark)}.infos{position:absolute;left:136mm;top:15mm;width:70mm;padding:4mm;font-size:medium;border-left:1px solid #000}.infos h2{padding:2mm;padding-left:4mm;color:var(--dark)}.sections{position:absolute;left:21mm;top:74mm;width:105mm;font-size:medium}.sections h2{padding:2mm;padding-left:4mm;color:var(--dark);background-color:var(--gray)}.sections .titre{color:var(--middle);font-size:larger}.sections .date{color:var(--light);padding-left:8mm}" +
                "</style><link href=\"https://fonts.googleapis.com/css?family=Open+Sans&display=swap\" rel=\"stylesheet\"></head>" +
                "<body>" + name + description + infos + sections + "</body></html>";

            return html;
        }
    }
}
