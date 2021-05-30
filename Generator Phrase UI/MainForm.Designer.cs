
namespace Generator_Phrase_UI
{
    partial class MainForn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.phraseLabel = new System.Windows.Forms.Label();
            this.generatedLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            this.generatedPhraseTxt = new System.Windows.Forms.RichTextBox();
            this.phraseTxt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // phraseLabel
            // 
            this.phraseLabel.AutoSize = true;
            this.phraseLabel.Location = new System.Drawing.Point(74, 11);
            this.phraseLabel.Name = "phraseLabel";
            this.phraseLabel.Size = new System.Drawing.Size(77, 15);
            this.phraseLabel.TabIndex = 0;
            this.phraseLabel.Text = "Insertar frase:";
            // 
            // generatedLabel
            // 
            this.generatedLabel.AutoSize = true;
            this.generatedLabel.Location = new System.Drawing.Point(402, 11);
            this.generatedLabel.Name = "generatedLabel";
            this.generatedLabel.Size = new System.Drawing.Size(89, 15);
            this.generatedLabel.TabIndex = 3;
            this.generatedLabel.Text = "Frase generada:";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(234, 59);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(100, 23);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generar";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // generatedPhraseTxt
            // 
            this.generatedPhraseTxt.Location = new System.Drawing.Point(349, 29);
            this.generatedPhraseTxt.Name = "generatedPhraseTxt";
            this.generatedPhraseTxt.ReadOnly = true;
            this.generatedPhraseTxt.Size = new System.Drawing.Size(184, 96);
            this.generatedPhraseTxt.TabIndex = 5;
            this.generatedPhraseTxt.Text = "";
            // 
            // phraseTxt
            // 
            this.phraseTxt.Location = new System.Drawing.Point(23, 29);
            this.phraseTxt.Name = "phraseTxt";
            this.phraseTxt.Size = new System.Drawing.Size(184, 96);
            this.phraseTxt.TabIndex = 6;
            this.phraseTxt.Text = "";
            // 
            // MainForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 141);
            this.Controls.Add(this.phraseTxt);
            this.Controls.Add(this.generatedPhraseTxt);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.generatedLabel);
            this.Controls.Add(this.phraseLabel);
            this.MaximizeBox = false;
            this.Name = "MainForn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de frases:";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label phraseLabel;
        private System.Windows.Forms.Label generatedLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.RichTextBox generatedPhraseTxt;
        private System.Windows.Forms.RichTextBox phraseTxt;
    }
}

