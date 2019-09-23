using System.ComponentModel;

namespace RLAB.UI.Wizard
{
	public class WizardPageEventArgs : CancelEventArgs
	{
	   public string NewPage { get; set; }
	}

	public delegate void WizardPageEventHandler(object sender, WizardPageEventArgs e);
}
