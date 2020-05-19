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
    public partial class SelectExperimentPage : InternalWizardPage
    {
        private StartupWizard owner;

        public SelectExperimentPage(StartupWizard owner)
        {
            InitializeComponent();
            this.owner = owner;
        }

        private void LoadExperimentPage_SetActive(object sender, CancelEventArgs e)
        {
            experiments = new List<string>
            {
                "Exp 1",
                "Exp 2",
                "Exp 3"
            };

            experimentList.Items.AddRange(experiments.ToArray());

            experimentList.SelectedIndex = -1;
            SetWizardButtons(WizardButtons.None);
        }

        private void experimentList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (experiments != null)
            {
                if ((experimentList.SelectedIndex >= 0) &&
                    (experimentList.SelectedIndex < experiments.Count))
                {
                    SetWizardButtons(WizardButtons.Next);
                }
            }
        }

        private void SelectExperimentPage_WizardNext(object sender, WizardPageEventArgs e)
        {
        }

        private List<string> experiments = null;
    }
}
