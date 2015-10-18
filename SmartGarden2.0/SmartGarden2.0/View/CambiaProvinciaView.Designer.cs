namespace SmartGarden2._0.View
{
    partial class CambiaProvinciaView
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
            this._regioniComboBox = new System.Windows.Forms.ComboBox();
            this._cittàComboBox = new System.Windows.Forms.ComboBox();
            this._okButton = new System.Windows.Forms.Button();
            this._resetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _regioniComboBox
            // 
            this._regioniComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._regioniComboBox.FormattingEnabled = true;
            this._regioniComboBox.Location = new System.Drawing.Point(33, 79);
            this._regioniComboBox.Name = "_regioniComboBox";
            this._regioniComboBox.Size = new System.Drawing.Size(137, 21);
            this._regioniComboBox.TabIndex = 0;
            // 
            // _cittàComboBox
            // 
            this._cittàComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._cittàComboBox.FormattingEnabled = true;
            this._cittàComboBox.Location = new System.Drawing.Point(208, 79);
            this._cittàComboBox.Name = "_cittàComboBox";
            this._cittàComboBox.Size = new System.Drawing.Size(137, 21);
            this._cittàComboBox.TabIndex = 1;
            // 
            // _okButton
            // 
            this._okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this._okButton.Location = new System.Drawing.Point(64, 122);
            this._okButton.Name = "_okButton";
            this._okButton.Size = new System.Drawing.Size(75, 23);
            this._okButton.TabIndex = 2;
            this._okButton.Text = "OK";
            this._okButton.UseVisualStyleBackColor = true;
            // 
            // _resetButton
            // 
            this._resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._resetButton.Location = new System.Drawing.Point(235, 122);
            this._resetButton.Name = "_resetButton";
            this._resetButton.Size = new System.Drawing.Size(75, 23);
            this._resetButton.TabIndex = 3;
            this._resetButton.Text = "Reset";
            this._resetButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Regione";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(232, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Provincia";
            // 
            // CambiaProvinciaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._resetButton);
            this.Controls.Add(this._okButton);
            this.Controls.Add(this._cittàComboBox);
            this.Controls.Add(this._regioniComboBox);
            this.Name = "CambiaProvinciaView";
            this.Size = new System.Drawing.Size(390, 177);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox _regioniComboBox;
        private System.Windows.Forms.ComboBox _cittàComboBox;
        private System.Windows.Forms.Button _okButton;
        private System.Windows.Forms.Button _resetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
