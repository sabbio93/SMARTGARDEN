namespace SmartGarden2._0.View
{
    partial class PianteView
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
            this._listPianteView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // _listPianteView
            // 
            this._listPianteView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._listPianteView.Location = new System.Drawing.Point(0, 0);
            this._listPianteView.Name = "_listPianteView";
            this._listPianteView.Size = new System.Drawing.Size(464, 370);
            this._listPianteView.TabIndex = 0;
            this._listPianteView.UseCompatibleStateImageBehavior = false;
            this._listPianteView.View = System.Windows.Forms.View.Details;
            // 
            // PianteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._listPianteView);
            this.Name = "PianteView";
            this.Size = new System.Drawing.Size(464, 370);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView _listPianteView;
    }
}
