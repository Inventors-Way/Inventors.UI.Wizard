using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventors.UI.Wizard;

namespace Inventors.UI.Wizard.Example
{
    /**
     * \brief Startup wizard
     * The startup wizard runs when the program is started, and guides an experimenter
     * through the initialization of an experimental session.
     * 
     * The startup wizard consists of the following steps:
     *      
     *   2. SelectExperimentPage:
     *      On this page the experiments that are present on the computer is presented to
     *      the experimenter, and it will ask the experimenter to choose one of these experiments.
     *      
     *   3. CheckEquipmentPage
     *      This page displays the setup instructions from the experiment, and the experimenter can continue when
     *      he/she confirms that the setup has been checked.
     *      
     *   3. SelectSessionPage:
     *      On this page the experimenter is asked whether he or she wants to resume an allready
     *      existing session (b), or if he or she wants to start a new session (a). If there are no existing
     *      sessions then the option to resume a session will be greyed out.
     *   
     */
    public partial class StartupWizard : WizardSheet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "This is done in FormClosed")]
        public StartupWizard()
        {
            InitializeComponent();

            Pages.Add(new SelectExperimentPage(this));
            Pages.Add(new SelectSubjectPage(this));

            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            TopMost = true;
        }

        private void StartupWizard_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (var page in Pages)
            {
                page.Dispose();
            }
        }
    }
}
