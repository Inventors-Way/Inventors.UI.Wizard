namespace Inventors.UI.Wizard.Example
{
    partial class StartupWizard
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
            this.SuspendLayout();
            // 
            // StartupWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 141);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartupWizard";
            this.ShowInTaskbar = false;
            this.Text = "Start experiment ...";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartupWizard_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion
    }
}