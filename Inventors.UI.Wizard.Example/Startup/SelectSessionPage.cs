using Inventors.UI.Wizard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventors.UI.Wizard.Example
{
    public partial class SelectSubjectPage : InternalWizardPage
    {
        private StartupWizard owner;

        public SelectSubjectPage(StartupWizard owner)
        {
            InitializeComponent();
            this.owner = owner;
        }

        private void ExistingSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExistingSubjects.SelectedIndex >= 0)
            {
                ActiveSubject.Text = (string) ExistingSubjects.Items[ExistingSubjects.SelectedIndex];
            }

            UpdateButtons();
        }

        private void ActiveSubject_TextChanged(object sender, EventArgs e)
        {
            UpdateExistingIndex();
            UpdateButtons();
        }

        private void UpdateExistingIndex()
        {
            int index = ExistingSubjects.Items.IndexOf(ActiveSubject.Text);

            if (index >= 0)
            {
                ExistingSubjects.SelectedIndex = index;
            }
            else
            {
                ExistingSubjects.SelectedIndex = -1;
            }
        }

        private void SelectSubjectPage_SetActive(object sender, CancelEventArgs e)
        {
            var sessions = new string[] { "Session 1", "Session 2", "Session 3"};
            ExistingSubjects.Items.Clear();
            ActiveSubject.AutoCompleteCustomSource.Clear();
            ActiveSubject.AutoCompleteMode = AutoCompleteMode.Suggest;
            ActiveSubject.AutoCompleteSource = AutoCompleteSource.CustomSource;

            foreach (var subject in sessions)
            {
                ExistingSubjects.Items.Add(subject.ToString());
                ActiveSubject.AutoCompleteCustomSource.Add(subject.ToString());
            }

            ActiveSubject.Text = "";

            UpdateExistingIndex();
            UpdateButtons();
        }

        private void UpdateButtons()
        {
            if (IsIDValid())
            {
                SetWizardButtons(WizardButtons.Finish);
            }
            else
            {
                SetWizardButtons(WizardButtons.None);
            }
        }

        private bool IsIDValid()
        {
            if (ActiveSubject.Text.Length == 0)
                return false;

            return true;
        }

        private void SelectSubjectPage_WizardFinish(object sender, CancelEventArgs e)
        {
        }

        private void ActiveSubject_KeyPress(object sender, KeyPressEventArgs e)
        {
            UpdateExistingIndex();
            UpdateButtons();
        }  
    }
}
