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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.worldViewModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            fileLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).BeginInit();
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
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "World Files(\"json)|\".json";
            // 
            // worldViewModelBindingSource
            // 
            this.worldViewModelBindingSource.DataSource = typeof(Zork.Builder.WinForms.ViewModels.WorldViewModel);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 709);
            this.Controls.Add(this.FileNameTextBox);
            this.Controls.Add(this.SelectFileButton);
            this.Controls.Add(fileLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Zork Builder";
            ((System.ComponentModel.ISupportInitialize)(this.worldViewModelBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SelectFileButton;
        private System.Windows.Forms.TextBox FileNameTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.BindingSource worldViewModelBindingSource;
    }
}

