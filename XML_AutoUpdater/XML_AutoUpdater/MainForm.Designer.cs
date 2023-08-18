namespace XML_AutoUpdater
{
    partial class MainForm
    {
        /// Required designer variable.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Step1Label = new System.Windows.Forms.Label();
            this.Instructions1 = new System.Windows.Forms.Label();
            this.Instructions2 = new System.Windows.Forms.Label();
            this.Step2Label = new System.Windows.Forms.Label();
            this.Instructions3 = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.FinishLabel = new System.Windows.Forms.Label();
            this.TargetFileButton = new System.Windows.Forms.Button();
            this.SelectedTargetFolder = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Source File";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Step1Label
            // 
            this.Step1Label.AutoSize = true;
            this.Step1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step1Label.Location = new System.Drawing.Point(275, 129);
            this.Step1Label.Name = "Step1Label";
            this.Step1Label.Size = new System.Drawing.Size(322, 29);
            this.Step1Label.TabIndex = 1;
            this.Step1Label.Text = "Step 1 : Select Target Folder";
            this.Step1Label.Click += new System.EventHandler(this.label1_Click);
            // 
            // Instructions1
            // 
            this.Instructions1.AutoSize = true;
            this.Instructions1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions1.Location = new System.Drawing.Point(12, 9);
            this.Instructions1.MaximumSize = new System.Drawing.Size(800, 0);
            this.Instructions1.Name = "Instructions1";
            this.Instructions1.Size = new System.Drawing.Size(798, 120);
            this.Instructions1.TabIndex = 2;
            this.Instructions1.Text = resources.GetString("Instructions1.Text");
            this.Instructions1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Instructions2
            // 
            this.Instructions2.AutoSize = true;
            this.Instructions2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions2.Location = new System.Drawing.Point(134, 158);
            this.Instructions2.MaximumSize = new System.Drawing.Size(850, 0);
            this.Instructions2.Name = "Instructions2";
            this.Instructions2.Size = new System.Drawing.Size(605, 100);
            this.Instructions2.TabIndex = 3;
            this.Instructions2.Text = resources.GetString("Instructions2.Text");
            this.Instructions2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Step2Label
            // 
            this.Step2Label.AutoSize = true;
            this.Step2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Step2Label.Location = new System.Drawing.Point(296, 339);
            this.Step2Label.Name = "Step2Label";
            this.Step2Label.Size = new System.Drawing.Size(281, 29);
            this.Step2Label.TabIndex = 4;
            this.Step2Label.Text = "Step 2 : Run the Program";
            // 
            // Instructions3
            // 
            this.Instructions3.AutoSize = true;
            this.Instructions3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instructions3.Location = new System.Drawing.Point(172, 368);
            this.Instructions3.MaximumSize = new System.Drawing.Size(850, 0);
            this.Instructions3.Name = "Instructions3";
            this.Instructions3.Size = new System.Drawing.Size(529, 20);
            this.Instructions3.TabIndex = 5;
            this.Instructions3.Text = "When ready, Press the run button below and wait for “Finished” to appear.";
            // 
            // RunButton
            // 
            this.RunButton.Location = new System.Drawing.Point(318, 413);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(237, 42);
            this.RunButton.TabIndex = 6;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // FinishLabel
            // 
            this.FinishLabel.AutoSize = true;
            this.FinishLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinishLabel.Location = new System.Drawing.Point(351, 458);
            this.FinishLabel.Name = "FinishLabel";
            this.FinishLabel.Size = new System.Drawing.Size(171, 39);
            this.FinishLabel.TabIndex = 8;
            this.FinishLabel.Text = "\"Finished\"";
            this.FinishLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TargetFileButton
            // 
            this.TargetFileButton.Location = new System.Drawing.Point(318, 261);
            this.TargetFileButton.Name = "TargetFileButton";
            this.TargetFileButton.Size = new System.Drawing.Size(237, 42);
            this.TargetFileButton.TabIndex = 9;
            this.TargetFileButton.Text = "Select Target File";
            this.TargetFileButton.UseVisualStyleBackColor = true;
            this.TargetFileButton.Click += new System.EventHandler(this.TargetFileButton_Click);
            // 
            // SelectedTargetFolder
            // 
            this.SelectedTargetFolder.Location = new System.Drawing.Point(176, 304);
            this.SelectedTargetFolder.Name = "SelectedTargetFolder";
            this.SelectedTargetFolder.ReadOnly = true;
            this.SelectedTargetFolder.Size = new System.Drawing.Size(524, 20);
            this.SelectedTargetFolder.TabIndex = 10;
            this.SelectedTargetFolder.TextChanged += new System.EventHandler(this.SelectedTargetFolder_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 506);
            this.Controls.Add(this.SelectedTargetFolder);
            this.Controls.Add(this.TargetFileButton);
            this.Controls.Add(this.FinishLabel);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.Instructions3);
            this.Controls.Add(this.Step2Label);
            this.Controls.Add(this.Instructions2);
            this.Controls.Add(this.Step1Label);
            this.Controls.Add(this.Instructions1);
            this.Name = "MainForm";
            this.Text = "XML Auto Updater";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
            #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label Step1Label;
        private System.Windows.Forms.Label Instructions1;
        private System.Windows.Forms.Label Instructions2;
        private System.Windows.Forms.Label Step2Label;
        private System.Windows.Forms.Label Instructions3;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.Label FinishLabel;
        private System.Windows.Forms.Button TargetFileButton;
        private System.Windows.Forms.TextBox SelectedTargetFolder;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

    }
}