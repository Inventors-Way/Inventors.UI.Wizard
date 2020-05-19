namespace Inventors.UI.Wizard.Example
{
    partial class SelectSubjectPage
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ActiveSubject = new System.Windows.Forms.TextBox();
            this.ExistingSubjects = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Banner
            // 
            this.Banner.Size = new System.Drawing.Size(380, 70);
            this.Banner.Subtitle = "Please create a new subject or choose an existing subject";
            this.Banner.Title = "Select subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject:";
            // 
            // ActiveSubject
            // 
            this.ActiveSubject.Location = new System.Drawing.Point(60, 76);
            this.ActiveSubject.Name = "ActiveSubject";
            this.ActiveSubject.Size = new System.Drawing.Size(317, 20);
            this.ActiveSubject.TabIndex = 2;
            this.ActiveSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ActiveSubject.TextChanged += new System.EventHandler(this.ActiveSubject_TextChanged);
            this.ActiveSubject.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ActiveSubject_KeyPress);
            // 
            // ExistingSubjects
            // 
            this.ExistingSubjects.FormattingEnabled = true;
            this.ExistingSubjects.Location = new System.Drawing.Point(60, 103);
            this.ExistingSubjects.Name = "ExistingSubjects";
            this.ExistingSubjects.ScrollAlwaysVisible = true;
            this.ExistingSubjects.Size = new System.Drawing.Size(317, 238);
            this.ExistingSubjects.TabIndex = 3;
            this.ExistingSubjects.SelectedIndexChanged += new System.EventHandler(this.ExistingSubjects_SelectedIndexChanged);
            // 
            // SelectSubjectPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ExistingSubjects);
            this.Controls.Add(this.ActiveSubject);
            this.Controls.Add(this.label1);
            this.Name = "SelectSubjectPage";
            this.Size = new System.Drawing.Size(380, 350);
            this.SetActive += new System.ComponentModel.CancelEventHandler(this.SelectSubjectPage_SetActive);
            this.WizardFinish += new System.ComponentModel.CancelEventHandler(this.SelectSubjectPage_WizardFinish);
            this.Controls.SetChildIndex(this.Banner, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ActiveSubject, 0);
            this.Controls.SetChildIndex(this.ExistingSubjects, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ActiveSubject;
        private System.Windows.Forms.ListBox ExistingSubjects;
        private System.Windows.Forms.Timer timer1;
    }
}