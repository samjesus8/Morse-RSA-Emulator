namespace MorseRSAAlgorithms
{
    partial class RSAEmulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RSAEmulator));
            this.label1 = new System.Windows.Forms.Label();
            this.encoderGroup = new System.Windows.Forms.GroupBox();
            this.encodeButton = new System.Windows.Forms.Button();
            this.eOutputLabel = new System.Windows.Forms.Label();
            this.eInputLabel = new System.Windows.Forms.Label();
            this.encodeOutput = new System.Windows.Forms.TextBox();
            this.encodeInput = new System.Windows.Forms.TextBox();
            this.decoderGroup = new System.Windows.Forms.GroupBox();
            this.decodeButton = new System.Windows.Forms.Button();
            this.dOutputLabel = new System.Windows.Forms.Label();
            this.dInputLabel = new System.Windows.Forms.Label();
            this.decodeOutput = new System.Windows.Forms.TextBox();
            this.decodeInput = new System.Windows.Forms.TextBox();
            this.accessKeyGroup = new System.Windows.Forms.GroupBox();
            this.keyCreateButton = new System.Windows.Forms.Button();
            this.privateKeyLabel = new System.Windows.Forms.Label();
            this.publicKeyLabel = new System.Windows.Forms.Label();
            this.privateKeyBox = new System.Windows.Forms.TextBox();
            this.publicKeyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.encoderGroup.SuspendLayout();
            this.decoderGroup.SuspendLayout();
            this.accessKeyGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSA Encryptor/Decryptor";
            // 
            // encoderGroup
            // 
            this.encoderGroup.Controls.Add(this.encodeButton);
            this.encoderGroup.Controls.Add(this.eOutputLabel);
            this.encoderGroup.Controls.Add(this.eInputLabel);
            this.encoderGroup.Controls.Add(this.encodeOutput);
            this.encoderGroup.Controls.Add(this.encodeInput);
            this.encoderGroup.Location = new System.Drawing.Point(16, 46);
            this.encoderGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encoderGroup.Name = "encoderGroup";
            this.encoderGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encoderGroup.Size = new System.Drawing.Size(353, 473);
            this.encoderGroup.TabIndex = 1;
            this.encoderGroup.TabStop = false;
            this.encoderGroup.Text = "Encoder";
            // 
            // encodeButton
            // 
            this.encodeButton.Location = new System.Drawing.Point(53, 176);
            this.encodeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(243, 82);
            this.encodeButton.TabIndex = 4;
            this.encodeButton.Text = "ENCODE";
            this.encodeButton.UseVisualStyleBackColor = true;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // eOutputLabel
            // 
            this.eOutputLabel.AutoSize = true;
            this.eOutputLabel.Location = new System.Drawing.Point(11, 281);
            this.eOutputLabel.Name = "eOutputLabel";
            this.eOutputLabel.Size = new System.Drawing.Size(45, 16);
            this.eOutputLabel.TabIndex = 3;
            this.eOutputLabel.Text = "Output";
            // 
            // eInputLabel
            // 
            this.eInputLabel.AutoSize = true;
            this.eInputLabel.Location = new System.Drawing.Point(7, 50);
            this.eInputLabel.Name = "eInputLabel";
            this.eInputLabel.Size = new System.Drawing.Size(120, 16);
            this.eInputLabel.TabIndex = 2;
            this.eInputLabel.Text = "Enter your text here";
            // 
            // encodeOutput
            // 
            this.encodeOutput.Location = new System.Drawing.Point(7, 302);
            this.encodeOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encodeOutput.Multiline = true;
            this.encodeOutput.Name = "encodeOutput";
            this.encodeOutput.ReadOnly = true;
            this.encodeOutput.Size = new System.Drawing.Size(339, 82);
            this.encodeOutput.TabIndex = 1;
            // 
            // encodeInput
            // 
            this.encodeInput.Location = new System.Drawing.Point(5, 71);
            this.encodeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.encodeInput.Multiline = true;
            this.encodeInput.Name = "encodeInput";
            this.encodeInput.Size = new System.Drawing.Size(340, 82);
            this.encodeInput.TabIndex = 0;
            // 
            // decoderGroup
            // 
            this.decoderGroup.Controls.Add(this.decodeButton);
            this.decoderGroup.Controls.Add(this.dOutputLabel);
            this.decoderGroup.Controls.Add(this.dInputLabel);
            this.decoderGroup.Controls.Add(this.decodeOutput);
            this.decoderGroup.Controls.Add(this.decodeInput);
            this.decoderGroup.Location = new System.Drawing.Point(400, 46);
            this.decoderGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decoderGroup.Name = "decoderGroup";
            this.decoderGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decoderGroup.Size = new System.Drawing.Size(341, 473);
            this.decoderGroup.TabIndex = 2;
            this.decoderGroup.TabStop = false;
            this.decoderGroup.Text = "Decoder";
            // 
            // decodeButton
            // 
            this.decodeButton.Location = new System.Drawing.Point(40, 176);
            this.decodeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(267, 82);
            this.decodeButton.TabIndex = 6;
            this.decodeButton.Text = "DECODE";
            this.decodeButton.UseVisualStyleBackColor = true;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // dOutputLabel
            // 
            this.dOutputLabel.AutoSize = true;
            this.dOutputLabel.Location = new System.Drawing.Point(7, 281);
            this.dOutputLabel.Name = "dOutputLabel";
            this.dOutputLabel.Size = new System.Drawing.Size(45, 16);
            this.dOutputLabel.TabIndex = 5;
            this.dOutputLabel.Text = "Output";
            // 
            // dInputLabel
            // 
            this.dInputLabel.AutoSize = true;
            this.dInputLabel.Location = new System.Drawing.Point(7, 50);
            this.dInputLabel.Name = "dInputLabel";
            this.dInputLabel.Size = new System.Drawing.Size(184, 16);
            this.dInputLabel.TabIndex = 3;
            this.dInputLabel.Text = "Enter your encoded data here";
            // 
            // decodeOutput
            // 
            this.decodeOutput.Location = new System.Drawing.Point(6, 302);
            this.decodeOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decodeOutput.Multiline = true;
            this.decodeOutput.Name = "decodeOutput";
            this.decodeOutput.ReadOnly = true;
            this.decodeOutput.Size = new System.Drawing.Size(328, 82);
            this.decodeOutput.TabIndex = 2;
            // 
            // decodeInput
            // 
            this.decodeInput.Location = new System.Drawing.Point(7, 71);
            this.decodeInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.decodeInput.Multiline = true;
            this.decodeInput.Name = "decodeInput";
            this.decodeInput.Size = new System.Drawing.Size(328, 82);
            this.decodeInput.TabIndex = 0;
            // 
            // accessKeyGroup
            // 
            this.accessKeyGroup.Controls.Add(this.keyCreateButton);
            this.accessKeyGroup.Controls.Add(this.privateKeyLabel);
            this.accessKeyGroup.Controls.Add(this.publicKeyLabel);
            this.accessKeyGroup.Controls.Add(this.privateKeyBox);
            this.accessKeyGroup.Controls.Add(this.publicKeyBox);
            this.accessKeyGroup.Location = new System.Drawing.Point(772, 133);
            this.accessKeyGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accessKeyGroup.Name = "accessKeyGroup";
            this.accessKeyGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accessKeyGroup.Size = new System.Drawing.Size(333, 386);
            this.accessKeyGroup.TabIndex = 3;
            this.accessKeyGroup.TabStop = false;
            this.accessKeyGroup.Text = "Access Keys";
            // 
            // keyCreateButton
            // 
            this.keyCreateButton.Location = new System.Drawing.Point(5, 23);
            this.keyCreateButton.Margin = new System.Windows.Forms.Padding(4);
            this.keyCreateButton.Name = "keyCreateButton";
            this.keyCreateButton.Size = new System.Drawing.Size(152, 43);
            this.keyCreateButton.TabIndex = 4;
            this.keyCreateButton.Text = "Create Keys";
            this.keyCreateButton.UseVisualStyleBackColor = true;
            this.keyCreateButton.Click += new System.EventHandler(this.keyCreateButton_Click);
            // 
            // privateKeyLabel
            // 
            this.privateKeyLabel.AutoSize = true;
            this.privateKeyLabel.Location = new System.Drawing.Point(7, 215);
            this.privateKeyLabel.Name = "privateKeyLabel";
            this.privateKeyLabel.Size = new System.Drawing.Size(75, 16);
            this.privateKeyLabel.TabIndex = 3;
            this.privateKeyLabel.Text = "Private Key";
            // 
            // publicKeyLabel
            // 
            this.publicKeyLabel.AutoSize = true;
            this.publicKeyLabel.Location = new System.Drawing.Point(5, 89);
            this.publicKeyLabel.Name = "publicKeyLabel";
            this.publicKeyLabel.Size = new System.Drawing.Size(70, 16);
            this.publicKeyLabel.TabIndex = 2;
            this.publicKeyLabel.Text = "Public Key";
            // 
            // privateKeyBox
            // 
            this.privateKeyBox.Location = new System.Drawing.Point(5, 238);
            this.privateKeyBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.privateKeyBox.Multiline = true;
            this.privateKeyBox.Name = "privateKeyBox";
            this.privateKeyBox.ReadOnly = true;
            this.privateKeyBox.Size = new System.Drawing.Size(320, 59);
            this.privateKeyBox.TabIndex = 1;
            // 
            // publicKeyBox
            // 
            this.publicKeyBox.Location = new System.Drawing.Point(7, 107);
            this.publicKeyBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publicKeyBox.Multiline = true;
            this.publicKeyBox.Name = "publicKeyBox";
            this.publicKeyBox.ReadOnly = true;
            this.publicKeyBox.Size = new System.Drawing.Size(320, 59);
            this.publicKeyBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(699, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(378, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "V1.0 ALPHA BETA OMEGA GAMMA THETA DELTA LAMBDA";
            // 
            // RSAEmulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1117, 533);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.accessKeyGroup);
            this.Controls.Add(this.decoderGroup);
            this.Controls.Add(this.encoderGroup);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "RSAEmulator";
            this.Text = "RSA Emulator";
            this.encoderGroup.ResumeLayout(false);
            this.encoderGroup.PerformLayout();
            this.decoderGroup.ResumeLayout(false);
            this.decoderGroup.PerformLayout();
            this.accessKeyGroup.ResumeLayout(false);
            this.accessKeyGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox encoderGroup;
        private System.Windows.Forms.GroupBox decoderGroup;
        private System.Windows.Forms.GroupBox accessKeyGroup;
        private System.Windows.Forms.Label eOutputLabel;
        private System.Windows.Forms.Label eInputLabel;
        private System.Windows.Forms.TextBox encodeOutput;
        private System.Windows.Forms.TextBox encodeInput;
        private System.Windows.Forms.Label dOutputLabel;
        private System.Windows.Forms.Label dInputLabel;
        private System.Windows.Forms.TextBox decodeOutput;
        private System.Windows.Forms.TextBox decodeInput;
        private System.Windows.Forms.Label privateKeyLabel;
        private System.Windows.Forms.Label publicKeyLabel;
        private System.Windows.Forms.TextBox privateKeyBox;
        private System.Windows.Forms.TextBox publicKeyBox;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.Button keyCreateButton;
        private System.Windows.Forms.Label label2;
    }
}