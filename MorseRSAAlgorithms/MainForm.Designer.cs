
namespace MorseRSAAlgorithms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.morseButton = new System.Windows.Forms.Button();
            this.rsaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // logoPicture
            // 
            this.logoPicture.Image = ((System.Drawing.Image)(resources.GetObject("logoPicture.Image")));
            this.logoPicture.Location = new System.Drawing.Point(147, 37);
            this.logoPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(733, 251);
            this.logoPicture.TabIndex = 0;
            this.logoPicture.TabStop = false;
            // 
            // morseButton
            // 
            this.morseButton.Location = new System.Drawing.Point(243, 294);
            this.morseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.morseButton.Name = "morseButton";
            this.morseButton.Size = new System.Drawing.Size(157, 80);
            this.morseButton.TabIndex = 1;
            this.morseButton.Text = "Morse Code";
            this.morseButton.UseVisualStyleBackColor = true;
            this.morseButton.Click += new System.EventHandler(this.morseButton_Click);
            // 
            // rsaButton
            // 
            this.rsaButton.Location = new System.Drawing.Point(615, 294);
            this.rsaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rsaButton.Name = "rsaButton";
            this.rsaButton.Size = new System.Drawing.Size(157, 80);
            this.rsaButton.TabIndex = 2;
            this.rsaButton.Text = "RSA";
            this.rsaButton.UseVisualStyleBackColor = true;
            this.rsaButton.Click += new System.EventHandler(this.rsaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 576);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "V1.0 ALPHA BETA OMEGA GAMMA THETA DELTA LAMBDA";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1045, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rsaButton);
            this.Controls.Add(this.morseButton);
            this.Controls.Add(this.logoPicture);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Morse and RSA Algorithm TestBench";
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Button morseButton;
        private System.Windows.Forms.Button rsaButton;
        private System.Windows.Forms.Label label1;
    }
}

