namespace Be.HexEditor
{
    partial class FormOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptions));
            tabControl = new System.Windows.Forms.TabControl();
            generalTabPage = new System.Windows.Forms.TabPage();
            languageSettingsGroupBox = new System.Windows.Forms.GroupBox();
            selectLanguageLabel = new System.Windows.Forms.Label();
            languageComboBox = new System.Windows.Forms.ComboBox();
            useSystemLanguageCheckBox = new System.Windows.Forms.CheckBox();
            recentFilesGroupBox = new System.Windows.Forms.GroupBox();
            clearRecentFilesButton = new System.Windows.Forms.Button();
            recentFilesMaxlabel = new System.Windows.Forms.Label();
            recentFilesMaxTextBox = new System.Windows.Forms.TextBox();
            okButton = new System.Windows.Forms.Button();
            cancelButton = new System.Windows.Forms.Button();
            flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            tabControl.SuspendLayout();
            generalTabPage.SuspendLayout();
            languageSettingsGroupBox.SuspendLayout();
            recentFilesGroupBox.SuspendLayout();
            flowLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            resources.ApplyResources(tabControl, "tabControl");
            tabControl.Controls.Add(generalTabPage);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            // 
            // generalTabPage
            // 
            generalTabPage.Controls.Add(languageSettingsGroupBox);
            generalTabPage.Controls.Add(recentFilesGroupBox);
            resources.ApplyResources(generalTabPage, "generalTabPage");
            generalTabPage.Name = "generalTabPage";
            generalTabPage.UseVisualStyleBackColor = true;
            // 
            // languageSettingsGroupBox
            // 
            resources.ApplyResources(languageSettingsGroupBox, "languageSettingsGroupBox");
            languageSettingsGroupBox.Controls.Add(selectLanguageLabel);
            languageSettingsGroupBox.Controls.Add(languageComboBox);
            languageSettingsGroupBox.Controls.Add(useSystemLanguageCheckBox);
            languageSettingsGroupBox.Name = "languageSettingsGroupBox";
            languageSettingsGroupBox.TabStop = false;
            // 
            // selectLanguageLabel
            // 
            resources.ApplyResources(selectLanguageLabel, "selectLanguageLabel");
            selectLanguageLabel.Name = "selectLanguageLabel";
            // 
            // languageComboBox
            // 
            languageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            languageComboBox.FormattingEnabled = true;
            resources.ApplyResources(languageComboBox, "languageComboBox");
            languageComboBox.Name = "languageComboBox";
            // 
            // useSystemLanguageCheckBox
            // 
            resources.ApplyResources(useSystemLanguageCheckBox, "useSystemLanguageCheckBox");
            useSystemLanguageCheckBox.Name = "useSystemLanguageCheckBox";
            useSystemLanguageCheckBox.UseVisualStyleBackColor = true;
            useSystemLanguageCheckBox.CheckedChanged += useSystemLanguageCheckBox_CheckedChanged;
            // 
            // recentFilesGroupBox
            // 
            resources.ApplyResources(recentFilesGroupBox, "recentFilesGroupBox");
            recentFilesGroupBox.Controls.Add(clearRecentFilesButton);
            recentFilesGroupBox.Controls.Add(recentFilesMaxlabel);
            recentFilesGroupBox.Controls.Add(recentFilesMaxTextBox);
            recentFilesGroupBox.Name = "recentFilesGroupBox";
            recentFilesGroupBox.TabStop = false;
            // 
            // clearRecentFilesButton
            // 
            resources.ApplyResources(clearRecentFilesButton, "clearRecentFilesButton");
            clearRecentFilesButton.Name = "clearRecentFilesButton";
            clearRecentFilesButton.UseVisualStyleBackColor = true;
            clearRecentFilesButton.Click += clearRecentFilesButton_Click;
            // 
            // recentFilesMaxlabel
            // 
            resources.ApplyResources(recentFilesMaxlabel, "recentFilesMaxlabel");
            recentFilesMaxlabel.Name = "recentFilesMaxlabel";
            // 
            // recentFilesMaxTextBox
            // 
            resources.ApplyResources(recentFilesMaxTextBox, "recentFilesMaxTextBox");
            recentFilesMaxTextBox.Name = "recentFilesMaxTextBox";
            // 
            // okButton
            // 
            resources.ApplyResources(okButton, "okButton");
            okButton.Name = "okButton";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // cancelButton
            // 
            resources.ApplyResources(cancelButton, "cancelButton");
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel
            // 
            resources.ApplyResources(flowLayoutPanel, "flowLayoutPanel");
            flowLayoutPanel.Controls.Add(cancelButton);
            flowLayoutPanel.Controls.Add(okButton);
            flowLayoutPanel.Name = "flowLayoutPanel";
            // 
            // FormOptions
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            CancelButton = cancelButton;
            Controls.Add(flowLayoutPanel);
            Controls.Add(tabControl);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormOptions";
            ShowIcon = false;
            ShowInTaskbar = false;
            tabControl.ResumeLayout(false);
            generalTabPage.ResumeLayout(false);
            languageSettingsGroupBox.ResumeLayout(false);
            languageSettingsGroupBox.PerformLayout();
            recentFilesGroupBox.ResumeLayout(false);
            recentFilesGroupBox.PerformLayout();
            flowLayoutPanel.ResumeLayout(false);
            flowLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox recentFilesGroupBox;
        private System.Windows.Forms.Button clearRecentFilesButton;
        private System.Windows.Forms.Label recentFilesMaxlabel;
        private System.Windows.Forms.TextBox recentFilesMaxTextBox;
        private System.Windows.Forms.GroupBox languageSettingsGroupBox;
        private System.Windows.Forms.Label selectLanguageLabel;
        private System.Windows.Forms.ComboBox languageComboBox;
        private System.Windows.Forms.CheckBox useSystemLanguageCheckBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}