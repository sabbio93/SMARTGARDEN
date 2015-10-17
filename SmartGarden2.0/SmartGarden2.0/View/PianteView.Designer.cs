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
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeComune = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeBotanico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FabbisognoAcqua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visitor = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Provider = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NomeComune,
            this.NomeBotanico,
            this.FabbisognoAcqua,
            this.Visitor,
            this.Provider});
            this._dataGridView.Location = new System.Drawing.Point(0, 0);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.RowHeadersVisible = false;
            this._dataGridView.Size = new System.Drawing.Size(976, 508);
            this._dataGridView.TabIndex = 1;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 46;
            // 
            // NomeComune
            // 
            this.NomeComune.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeComune.HeaderText = "Nome comune";
            this.NomeComune.Name = "NomeComune";
            // 
            // NomeBotanico
            // 
            this.NomeBotanico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeBotanico.HeaderText = "Nome Botanico";
            this.NomeBotanico.Name = "NomeBotanico";
            this.NomeBotanico.ReadOnly = true;
            // 
            // FabbisognoAcqua
            // 
            this.FabbisognoAcqua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.FabbisognoAcqua.HeaderText = "Fabbisogno acqua";
            this.FabbisognoAcqua.Name = "FabbisognoAcqua";
            this.FabbisognoAcqua.ReadOnly = true;
            this.FabbisognoAcqua.Width = 144;
            // 
            // Visitor
            // 
            this.Visitor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Visitor.HeaderText = "Visitor";
            this.Visitor.Name = "Visitor";
            // 
            // Provider
            // 
            this.Provider.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Provider.HeaderText = "Provider";
            this.Provider.Name = "Provider";
            this.Provider.ReadOnly = true;
            // 
            // PianteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this._dataGridView);
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PianteView";
            this.Size = new System.Drawing.Size(979, 511);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeComune;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeBotanico;
        private System.Windows.Forms.DataGridViewTextBoxColumn FabbisognoAcqua;
        private System.Windows.Forms.DataGridViewComboBoxColumn Visitor;
        private System.Windows.Forms.DataGridViewComboBoxColumn Provider;
    }
}
