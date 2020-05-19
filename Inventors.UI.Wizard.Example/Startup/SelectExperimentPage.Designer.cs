namespace Inventors.UI.Wizard.Example
{
    partial class SelectExperimentPage
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
            this.experimentList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Banner
            // 
            this.Banner.Size = new System.Drawing.Size(380, 64);
            this.Banner.Subtitle = "Select the experiment to run ...";
            this.Banner.Title = "Load experiment";
            // 
            // experimentList
            // 
            this.experimentList.FormattingEnabled = true;
            this.experimentList.Location = new System.Drawing.Point(4, 67);
            this.experimentList.Name = "experimentList";
            this.experimentList.ScrollAlwaysVisible = true;
            this.experimentList.Size = new System.Drawing.Size(373, 277);
            this.experimentList.TabIndex = 1;
            this.experimentList.SelectedIndexChanged += new System.EventHandler(this.experimentList_SelectedIndexChanged);
            // 
            // SelectExperimentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.experimentList);
            this.Name = "SelectExperimentPage";
            this.Size = new System.Drawing.Size(380, 350);
            this.SetActive += new System.ComponentModel.CancelEventHandler(this.LoadExperimentPage_SetActive);
            this.WizardNext += new Inventors.UI.Wizard.WizardPageEventHandler(this.SelectExperimentPage_WizardNext);
            this.Controls.SetChildIndex(this.Banner, 0);
            this.Controls.SetChildIndex(this.experimentList, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox experimentList;
    }
}