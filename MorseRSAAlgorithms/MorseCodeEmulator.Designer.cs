namespace MorseRSAAlgorithms
{
    partial class MorseCodeEmulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MorseCodeEmulator));
            this.morseTitleLabel = new System.Windows.Forms.Label();
            this.encryptorGroup = new System.Windows.Forms.GroupBox();
            this.encodeImportButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.encryptOutput = new System.Windows.Forms.TextBox();
            this.encryptButton = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.encryptInput = new System.Windows.Forms.TextBox();
            this.decryptorGroup = new System.Windows.Forms.GroupBox();
            this.decodeImportButton = new System.Windows.Forms.Button();
            this.dOutputLabel = new System.Windows.Forms.Label();
            this.decryptOutput = new System.Windows.Forms.TextBox();
            this.decryptButton = new System.Windows.Forms.Button();
            this.decryptInput = new System.Windows.Forms.TextBox();
            this.decryptLabel = new System.Windows.Forms.Label();
            this.encryptImportDialog = new System.Windows.Forms.OpenFileDialog();
            this.decryptImportDialog = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.encryptorGroup.SuspendLayout();
            this.decryptorGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // morseTitleLabel
            // 
            this.morseTitleLabel.AutoSize = true;
            this.morseTitleLabel.Location = new System.Drawing.Point(12, 9);
            this.morseTitleLabel.Name = "morseTitleLabel";
            this.morseTitleLabel.Size = new System.Drawing.Size(204, 16);
            this.morseTitleLabel.TabIndex = 0;
            this.morseTitleLabel.Text = "Morse Code Encryptor/Decryptor";
            // 
            // encryptorGroup
            // 
            this.encryptorGroup.Controls.Add(this.encodeImportButton);
            this.encryptorGroup.Controls.Add(this.outputLabel);
            this.encryptorGroup.Controls.Add(this.encryptOutput);
            this.encryptorGroup.Controls.Add(this.encryptButton);
            this.encryptorGroup.Controls.Add(this.inputLabel);
            this.encryptorGroup.Controls.Add(this.encryptInput);
            this.encryptorGroup.Location = new System.Drawing.Point(13, 30);
            this.encryptorGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encryptorGroup.Name = "encryptorGroup";
            this.encryptorGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encryptorGroup.Size = new System.Drawing.Size(373, 523);
            this.encryptorGroup.TabIndex = 1;
            this.encryptorGroup.TabStop = false;
            this.encryptorGroup.Text = "Encoder";
            // 
            // encodeImportButton
            // 
            this.encodeImportButton.Location = new System.Drawing.Point(128, 167);
            this.encodeImportButton.Margin = new System.Windows.Forms.Padding(4);
            this.encodeImportButton.Name = "encodeImportButton";
            this.encodeImportButton.Size = new System.Drawing.Size(100, 28);
            this.encodeImportButton.TabIndex = 5;
            this.encodeImportButton.Text = "Import";
            this.encodeImportButton.UseVisualStyleBackColor = true;
            this.encodeImportButton.Click += new System.EventHandler(this.encryptImportButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(11, 358);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(45, 16);
            this.outputLabel.TabIndex = 4;
            this.outputLabel.Text = "Output";
            // 
            // encryptOutput
            // 
            this.encryptOutput.Location = new System.Drawing.Point(11, 380);
            this.encryptOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encryptOutput.Multiline = true;
            this.encryptOutput.Name = "encryptOutput";
            this.encryptOutput.ReadOnly = true;
            this.encryptOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encryptOutput.Size = new System.Drawing.Size(357, 84);
            this.encryptOutput.TabIndex = 3;
            // 
            // encryptButton
            // 
            this.encryptButton.Location = new System.Drawing.Point(99, 231);
            this.encryptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encryptButton.Name = "encryptButton";
            this.encryptButton.Size = new System.Drawing.Size(160, 63);
            this.encryptButton.TabIndex = 2;
            this.encryptButton.Text = "ENCODE";
            this.encryptButton.UseVisualStyleBackColor = true;
            this.encryptButton.Click += new System.EventHandler(this.encryptButton_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Location = new System.Drawing.Point(5, 39);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(133, 16);
            this.inputLabel.TabIndex = 1;
            this.inputLabel.Text = "Enter in your text here";
            // 
            // encryptInput
            // 
            this.encryptInput.Location = new System.Drawing.Point(5, 58);
            this.encryptInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encryptInput.Multiline = true;
            this.encryptInput.Name = "encryptInput";
            this.encryptInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.encryptInput.Size = new System.Drawing.Size(360, 88);
            this.encryptInput.TabIndex = 0;
            // 
            // decryptorGroup
            // 
            this.decryptorGroup.Controls.Add(this.decodeImportButton);
            this.decryptorGroup.Controls.Add(this.dOutputLabel);
            this.decryptorGroup.Controls.Add(this.decryptOutput);
            this.decryptorGroup.Controls.Add(this.decryptButton);
            this.decryptorGroup.Controls.Add(this.decryptInput);
            this.decryptorGroup.Controls.Add(this.decryptLabel);
            this.decryptorGroup.Location = new System.Drawing.Point(415, 30);
            this.decryptorGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decryptorGroup.Name = "decryptorGroup";
            this.decryptorGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decryptorGroup.Size = new System.Drawing.Size(373, 523);
            this.decryptorGroup.TabIndex = 2;
            this.decryptorGroup.TabStop = false;
            this.decryptorGroup.Text = "Decoder";
            // 
            // decodeImportButton
            // 
            this.decodeImportButton.Location = new System.Drawing.Point(135, 167);
            this.decodeImportButton.Margin = new System.Windows.Forms.Padding(4);
            this.decodeImportButton.Name = "decodeImportButton";
            this.decodeImportButton.Size = new System.Drawing.Size(100, 28);
            this.decodeImportButton.TabIndex = 6;
            this.decodeImportButton.Text = "Import";
            this.decodeImportButton.UseVisualStyleBackColor = true;
            this.decodeImportButton.Click += new System.EventHandler(this.decodeImportButton_Click);
            // 
            // dOutputLabel
            // 
            this.dOutputLabel.AutoSize = true;
            this.dOutputLabel.Location = new System.Drawing.Point(7, 358);
            this.dOutputLabel.Name = "dOutputLabel";
            this.dOutputLabel.Size = new System.Drawing.Size(45, 16);
            this.dOutputLabel.TabIndex = 5;
            this.dOutputLabel.Text = "Output";
            // 
            // decryptOutput
            // 
            this.decryptOutput.Location = new System.Drawing.Point(7, 380);
            this.decryptOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decryptOutput.Multiline = true;
            this.decryptOutput.Name = "decryptOutput";
            this.decryptOutput.ReadOnly = true;
            this.decryptOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decryptOutput.Size = new System.Drawing.Size(360, 84);
            this.decryptOutput.TabIndex = 3;
            // 
            // decryptButton
            // 
            this.decryptButton.Location = new System.Drawing.Point(105, 231);
            this.decryptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decryptButton.Name = "decryptButton";
            this.decryptButton.Size = new System.Drawing.Size(157, 63);
            this.decryptButton.TabIndex = 2;
            this.decryptButton.Text = "DECODE";
            this.decryptButton.UseVisualStyleBackColor = true;
            this.decryptButton.Click += new System.EventHandler(this.decryptButton_Click);
            // 
            // decryptInput
            // 
            this.decryptInput.Location = new System.Drawing.Point(11, 58);
            this.decryptInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decryptInput.Multiline = true;
            this.decryptInput.Name = "decryptInput";
            this.decryptInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.decryptInput.Size = new System.Drawing.Size(357, 88);
            this.decryptInput.TabIndex = 1;
            // 
            // decryptLabel
            // 
            this.decryptLabel.AutoSize = true;
            this.decryptLabel.Location = new System.Drawing.Point(7, 38);
            this.decryptLabel.Name = "decryptLabel";
            this.decryptLabel.Size = new System.Drawing.Size(158, 16);
            this.decryptLabel.TabIndex = 0;
            this.decryptLabel.Text = "Enter in Morse Code here";
            // 
            // encryptImportDialog
            // 
            this.encryptImportDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // decryptImportDialog
            // 
            this.decryptImportDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 560);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "V1.0 ALPHA BETA OMEGA GAMMA THETA DELTA LAMBDA";
            // 
            // MorseCodeEmulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 585);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.decryptorGroup);
            this.Controls.Add(this.encryptorGroup);
            this.Controls.Add(this.morseTitleLabel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MorseCodeEmulator";
            this.Text = "Morse Code Emulator";
            this.encryptorGroup.ResumeLayout(false);
            this.encryptorGroup.PerformLayout();
            this.decryptorGroup.ResumeLayout(false);
            this.decryptorGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label morseTitleLabel;
        private System.Windows.Forms.GroupBox encryptorGroup;
        private System.Windows.Forms.Button encryptButton;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.TextBox encryptInput;
        private System.Windows.Forms.GroupBox decryptorGroup;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox encryptOutput;
        private System.Windows.Forms.Label dOutputLabel;
        private System.Windows.Forms.TextBox decryptOutput;
        private System.Windows.Forms.Button decryptButton;
        private System.Windows.Forms.TextBox decryptInput;
        private System.Windows.Forms.Label decryptLabel;
        private System.Windows.Forms.Button encodeImportButton;
        private System.Windows.Forms.OpenFileDialog encryptImportDialog;
        private System.Windows.Forms.Button decodeImportButton;
        private System.Windows.Forms.OpenFileDialog decryptImportDialog;
        private System.Windows.Forms.Label label1;
    }
}