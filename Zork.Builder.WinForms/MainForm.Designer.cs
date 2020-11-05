namespace Zork.Builder.WinForms
{
    partial class MainForm
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
            System.Windows.Forms.Label fileLabel;
            this.SelectFileButton = new System.Windows.Forms.Button();
            this.FileNameTextBox = new System.Windows.Forms.TextBox();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.playersTabPage = new System.Windows.Forms.TabPage();
            this.deletePlayerButton = new System.Windows.Forms.Button();
            this.addPlayerButton = new System.Windows.Forms.Button();
            this.playersListBox = new System.Windows.Forms.ListBox();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.worldBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            fileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
            this.mainTabControl.SuspendLayout();
            this.playersTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fileLabel
            // 
            fileLabel.AutoSize = true;
            fileLabel.Location = new System.Drawing.Point(0, 0);
            fileLabel.Name = "fileLabel";
            fileLabel.Size = new System.Drawing.Size(36, 20);
            fileLabel.TabIndex = 0;
            fileLabel.Text = "FIle";
            // 
            // SelectFileButton
            // 
            this.SelectFileButton.Location = new System.Drawing.Point(1204, -2);
            this.SelectFileButton.Name = "SelectFileButton";
            this.SelectFileButton.Size = new System.Drawing.Size(49, 25);
            this.SelectFileButton.TabIndex = 1;
            this.SelectFileButton.Text = "...";
            this.SelectFileButton.UseVisualStyleBackColor = true;
            this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
            // 
            // FileNameTextBox
            // 
            this.FileNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.worldViewModelBindingSource, "Filename", true));
            this.FileNameTextBox.Location = new System.Drawing.Point(52, -3);
            this.FileNameTextBox.Name = "FileNameTextBox";
            this.FileNameTextBox.ReadOnly = true;
            this.FileNameTextBox.Size = new System.Drawing.Size(1131, 26);
            this.FileNameTextBox.TabIndex = 2;
            this.FileNameTextBox.TextChanged += new System.EventHandler(this.FileNameTextBox_TextChanged);
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(Zork.Builder.WinForms.ViewModels.WorldViewModel);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files(*json)|*.json";
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.playersTabPage);
            this.mainTabControl.Controls.Add(this.itemsTabPage);
            this.mainTabControl.Location = new System.Drawing.Point(12, 52);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(1229, 645);
            this.mainTabControl.TabIndex = 3;
            // 
            // playersTabPage
            // 
            this.playersTabPage.Controls.Add(this.deletePlayerButton);
            this.playersTabPage.Controls.Add(this.addPlayerButton);
            this.playersTabPage.Controls.Add(this.playersListBox);
            this.playersTabPage.Location = new System.Drawing.Point(4, 29);
            this.playersTabPage.Name = "playersTabPage";
            this.playersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.playersTabPage.Size = new System.Drawing.Size(1221, 612);
            this.playersTabPage.TabIndex = 0;
            this.playersTabPage.Text = "Players";
            this.playersTabPage.UseVisualStyleBackColor = true;
            // 
            // deletePlayerButton
            // 
            this.deletePlayerButton.Location = new System.Drawing.Point(87, 550);
            this.deletePlayerButton.Name = "deletePlayerButton";
            this.deletePlayerButton.Size = new System.Drawing.Size(75, 37);
            this.deletePlayerButton.TabIndex = 2;
            this.deletePlayerButton.Text = "&Delete";
            this.deletePlayerButton.UseVisualStyleBackColor = true;
            // 
            // addPlayerButton
            // 
            this.addPlayerButton.Location = new System.Drawing.Point(6, 550);
            this.addPlayerButton.Name = "addPlayerButton";
            this.addPlayerButton.Size = new System.Drawing.Size(75, 37);
            this.addPlayerButton.TabIndex = 1;
            this.addPlayerButton.Text = "&Add...";
            this.addPlayerButton.UseVisualStyleBackColor = true;
            // 
            // playersListBox
            // 
            this.playersListBox.DataSource = this.playersBindingSource;
            this.playersListBox.DisplayMember = "Health";
            this.playersListBox.FormattingEnabled = true;
            this.playersListBox.ItemHeight = 20;
            this.playersListBox.Location = new System.Drawing.Point(0, 0);
            this.playersListBox.Name = "playersListBox";
            this.playersListBox.Size = new System.Drawing.Size(318, 544);
            this.playersListBox.TabIndex = 0;
            this.playersListBox.ValueMember = "Health";
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataSource = this.worldBindingSource;
            this.playersBindingSource.CurrentChanged += new System.EventHandler(this.playersBindingSource_CurrentChanged);
            // 
            // worldBindingSource
            // 
            this.worldBindingSource.DataMember = "World";
            this.worldBindingSource.DataSource = this.worldViewModelBindingSource;
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Location = new System.Drawing.Point(4, 29);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTabPage.Size = new System.Drawing.Size(1221, 612);
            this.itemsTabPage.TabIndex = 1;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 709);
            this.Controls.Add(this.mainTabControl);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(fileLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.mainTabControl.ResumeLayout(false);
            this.playersTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.worldBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage playersTabPage;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.ListBox playersListBox;
        private System.Windows.Forms.Button addPlayerButton;
        private System.Windows.Forms.Button deletePlayerButton;
        private System.Windows.Forms.BindingSource worldBindingSource;
        private System.Windows.Forms.BindingSource playersBindingSource;
    }
}

