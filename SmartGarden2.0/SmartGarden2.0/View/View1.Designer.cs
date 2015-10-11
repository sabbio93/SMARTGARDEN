namespace SmartGarden2._0.View
{
    partial class View1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._textBox = new System.Windows.Forms.TextBox();
            this._caricaInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _textBox
            // 
            this._textBox.Dock = System.Windows.Forms.DockStyle.Top;
            this._textBox.Location = new System.Drawing.Point(0, 0);
            this._textBox.Multiline = true;
            this._textBox.Name = "_textBox";
            this._textBox.ReadOnly = true;
            this._textBox.Size = new System.Drawing.Size(278, 214);
            this._textBox.TabIndex = 0;
            // 
            // _caricaInfoButton
            // 
            this._caricaInfoButton.Location = new System.Drawing.Point(82, 220);
            this._caricaInfoButton.Name = "_caricaInfoButton";
            this._caricaInfoButton.Size = new System.Drawing.Size(102, 25);
            this._caricaInfoButton.TabIndex = 1;
            this._caricaInfoButton.Text = "Carica Info";
            this._caricaInfoButton.UseVisualStyleBackColor = true;
            this._caricaInfoButton.Click += new System.EventHandler(this._caricaSettoriButton_Click);
            // 
            // View1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this._caricaInfoButton);
            this.Controls.Add(this._textBox);
            this.Name = "View1";
            this.Size = new System.Drawing.Size(278, 248);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBox;
        private System.Windows.Forms.Button _caricaInfoButton;
    }
}
