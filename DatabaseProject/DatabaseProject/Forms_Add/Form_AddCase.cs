using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Forms_Add;

namespace WindowsFormsApplication1
{
    public partial class Form_AddCase : Form 
    {
        private DiagnosisRepository _diagnosisRepository = new DiagnosisRepository();
        private DoctorRepository _doctorRepository = new DoctorRepository();
        private PatientRepository _patientRepository = new PatientRepository();
        private DrugRepository _drugRepository = new DrugRepository();
        private Repository.VisitRepository _visitRepository = new Repository.VisitRepository();
        private Repository.DiagnosisDrugRepository _dgRepository = new Repository.DiagnosisDrugRepository();
        private BindingList<Visit> _visitBindingList = new BindingList<Visit>();

        private Case c = null;

        public Form_AddCase()
        {
            InitializeComponent();

            this.FillBoxes();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (ValidateValues())
            {
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public Case GetData() //metoda pro předání dat z ovladacích prvků do instance 
        {
            Case p = new Case();

            p.idDoctor = this.GetID(this.comboBox_Doctors);
            p.idPatient = this.GetID(this.comboBox_Patients);
            p.idDiagnosis = this.GetID(this.comboBox_Diagnosis);
            p.Description = this.textBox_Description.Text;
            p.Doctor = this.GetName(this.comboBox_Doctors);
            p.Patient = this.GetName(this.comboBox_Patients);
            p.Name = this.textBox_Name.Text;
            
            return p;
        }

        public void FillInfo(Case p) //metoda pro předání dat z instance do ovládacích prvků
        {
            if (p != null)
            {
                c = p;
                Patient pa = this._patientRepository.FindById(p.idPatient);
                Doctor doc = this._doctorRepository.FindById(p.idDoctor);

                this.comboBox_Diagnosis.Text = p.idDiagnosis + " - " + this._diagnosisRepository.FindById(p.idDiagnosis).Name;
                this.comboBox_DiagnosisCategory.Text = this._diagnosisRepository.FindById(p.idDiagnosis).Category;
                this.comboBox_Patients.Text = Convert.ToString(pa.idPatient) + " - " + pa.Name + " " + pa.Surname;
                this.comboBox_Doctors.Text = Convert.ToString(doc.idDoctor) + " - " + doc.Name + " " + doc.Surname;
                this.textBox_Description.Text = p.Description;
                this.textBox_Name.Text = p.Name;


                this.dataGridView2_Drugs.DataSource = this.RefreshDrugs(p.idDiagnosis);
                this.dataGridView2_Drugs.Columns["idDrug"].Visible = false;
                this.dataGridView2_Drugs.Columns["idDiagnosis"].Visible = false;
                this.dataGridView2_Drugs.Columns["DiagnosisName"].Visible = false;
                this.dataGridView2_Drugs.Columns["DrugName"].HeaderText = "Název léku";

                this.RefreshVisit(c.idCase);
            }
        }

        private void FillBoxes() //nastavení defaultních hodnot ovládacích prvků
        {
            var diagnosis = _diagnosisRepository.FindAll().Select(d => d.Category).Distinct().ToArray();
            this.comboBox_DiagnosisCategory.Items.AddRange(diagnosis);


            foreach (Doctor item in _doctorRepository.FindAll())
            {
                this.comboBox_Doctors.Items.Add(item.idDoctor + " - " + item.Name + " " + item.Surname);
            }

            foreach (Patient item in _patientRepository.FindAll())
            {
                this.comboBox_Patients.Items.Add(item.idPatient + " - " + item.Name + " " + item.Surname);
            }

        }

        private int GetID(ComboBox element)
        {
            string[] split = element.Text.Split('-');

            int id = Convert.ToInt32(split[0]);

            return id;
        }

        private string GetName(ComboBox element)
        {
            string[] split = element.Text.Split('-');

            string name = Convert.ToString(split[1].TrimStart(' '));

            return name;
        }

        private BindingList<DiagnosisDrugs> RefreshDrugs(int idDiagnosis) //naplnění léků do BindingListu podle zrovna zvolené diagnozy
        {
            BindingList<DiagnosisDrugs> _diagnosisDrugsBindingList = new BindingList<DiagnosisDrugs>(this._dgRepository.FindByidDiagnosis(idDiagnosis));

            this.dataGridView2_Drugs.DataSource = null;

            foreach (DiagnosisDrugs item in _diagnosisDrugsBindingList)
            {
                item.DrugName = this._drugRepository.FindById(item.idDrug).Name;
                item.DiagnosisName = this._diagnosisRepository.FindById(item.idDiagnosis).Name;
            }

            return _diagnosisDrugsBindingList;
        }

        private void comboBox_DiagnosisCategory_SelectedIndexChanged(object sender, EventArgs e) //refreshování diagnoz podle zrovna zvolené kategorie diagnoz
        {
            this.comboBox_Diagnosis.Items.Clear();

            foreach (Diagnosis item in _diagnosisRepository.FindByCategory(this.comboBox_DiagnosisCategory.Text))
            {
                this.comboBox_Diagnosis.Items.Add(item.idDiagnosis + " - " + item.Name);
            }

            //this.comboBox_Diagnosis.SelectedIndex = 0;
        }

        private void RefreshVisit(int idCase) //refresh datagridu Visit
        {
            BindingList<Visit> _visitBindingList = new BindingList<Visit>(this._visitRepository.FindByCaseID(idCase));

            this.dataGridView_Visits.DataSource = _visitBindingList;
            this.dataGridView_Visits.Columns["VisitDate"].HeaderText = "Datum";
            this.dataGridView_Visits.Columns["Description"].HeaderText = "Popis";
        }

        private void dataGridView2_Drugs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form_DI_Patient_Drug frm = new Form_DI_Patient_Drug();

            string value = this.dataGridView2_Drugs.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString();
            Drug c = this._drugRepository.FindByName(value);

            frm.FillInfo(c);
            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {
                c.AdultDosage = frm.GetData().AdultDosage;
                c.KinderDosage = frm.GetData().KinderDosage;

                this._drugRepository.Update(c);
            }
        }

        private void button_AddVisit_Click(object sender, EventArgs e)
        {
            Form_AddVisit frm = new Form_AddVisit();

            if (c != null)
                frm.FillCase(c);

            frm.ShowDialog();

            if(frm.DialogResult == DialogResult.OK)
            {
                Visit v = frm.GetData();

                _visitRepository.Create(v);
                _visitBindingList.Add(v);

                this.RefreshVisit(v.idCase);
            }
        }

        private void comboBox_Diagnosis_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idDiagnosis = this.GetID(comboBox_Diagnosis);

            this.dataGridView2_Drugs.DataSource = this.RefreshDrugs(idDiagnosis);
            this.dataGridView2_Drugs.Columns["idDrug"].Visible = false;
            this.dataGridView2_Drugs.Columns["idDiagnosis"].Visible = false;
            this.dataGridView2_Drugs.Columns["DiagnosisName"].Visible = false;
            this.dataGridView2_Drugs.Columns["DrugName"].HeaderText = "Název léku";
        }

        private bool ValidateValues() //Validace vstupních hodnot
        {
            errorProvider1.Clear();
            ComboBox[] controls_combobox= { comboBox_Diagnosis, comboBox_DiagnosisCategory, comboBox_Doctors, comboBox_Patients};
            bool passing = true;


            foreach (ComboBox cb in controls_combobox)
            {
                if (string.IsNullOrWhiteSpace(cb.Text))
                {
                    errorProvider1.SetError(cb, "Hodnota musí být vyplněna");
                    passing = false;
                }
            }

            if (string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                errorProvider1.SetError(textBox_Name, "Hodnota musí být vyplněna");
                passing = false;
            }

            return passing;
        }
    }
}
