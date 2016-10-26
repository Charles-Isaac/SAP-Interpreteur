namespace SAP_Interpreteur
{
    partial class frmInterpreteur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.GridCode = new System.Windows.Forms.DataGridView();
            this.Mem1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mem2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mem3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mem4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbPauseLoop = new System.Windows.Forms.CheckBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblAff = new System.Windows.Forms.Label();
            this.lblN = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.lblAcc = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.msFile = new System.Windows.Forms.MenuStrip();
            this.tsSave = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridCode)).BeginInit();
            this.msFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridCode
            // 
            this.GridCode.AllowUserToDeleteRows = false;
            this.GridCode.AllowUserToResizeRows = false;
            this.GridCode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridCode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mem1,
            this.Data1,
            this.Mem2,
            this.Data2,
            this.Mem3,
            this.Data3,
            this.Mem4,
            this.Data4});
            this.GridCode.Location = new System.Drawing.Point(32, 45);
            this.GridCode.Name = "GridCode";
            this.GridCode.RowHeadersWidth = 4;
            this.GridCode.Size = new System.Drawing.Size(335, 269);
            this.GridCode.TabIndex = 1;
            this.GridCode.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.GridCode_CellFormatting);
            this.GridCode.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.GridCode_CellValidating);
            // 
            // Mem1
            // 
            this.Mem1.DataPropertyName = "1";
            this.Mem1.Frozen = true;
            this.Mem1.HeaderText = "Mem#";
            this.Mem1.MaxInputLength = 2;
            this.Mem1.Name = "Mem1";
            this.Mem1.ReadOnly = true;
            this.Mem1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Mem1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Mem1.Width = 40;
            // 
            // Data1
            // 
            this.Data1.Frozen = true;
            this.Data1.HeaderText = "Data";
            this.Data1.MaxInputLength = 2;
            this.Data1.Name = "Data1";
            this.Data1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Data1.Width = 40;
            // 
            // Mem2
            // 
            this.Mem2.Frozen = true;
            this.Mem2.HeaderText = "Mem#";
            this.Mem2.MaxInputLength = 2;
            this.Mem2.Name = "Mem2";
            this.Mem2.ReadOnly = true;
            this.Mem2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Mem2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Mem2.Width = 40;
            // 
            // Data2
            // 
            this.Data2.Frozen = true;
            this.Data2.HeaderText = "Data";
            this.Data2.MaxInputLength = 2;
            this.Data2.Name = "Data2";
            this.Data2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Data2.Width = 40;
            // 
            // Mem3
            // 
            this.Mem3.Frozen = true;
            this.Mem3.HeaderText = "Mem#";
            this.Mem3.MaxInputLength = 2;
            this.Mem3.Name = "Mem3";
            this.Mem3.ReadOnly = true;
            this.Mem3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Mem3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Mem3.Width = 40;
            // 
            // Data3
            // 
            this.Data3.Frozen = true;
            this.Data3.HeaderText = "Data";
            this.Data3.MaxInputLength = 2;
            this.Data3.Name = "Data3";
            this.Data3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Data3.Width = 40;
            // 
            // Mem4
            // 
            this.Mem4.Frozen = true;
            this.Mem4.HeaderText = "Mem#";
            this.Mem4.MaxInputLength = 2;
            this.Mem4.Name = "Mem4";
            this.Mem4.ReadOnly = true;
            this.Mem4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Mem4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Mem4.Width = 40;
            // 
            // Data4
            // 
            this.Data4.Frozen = true;
            this.Data4.HeaderText = "Data";
            this.Data4.MaxInputLength = 2;
            this.Data4.Name = "Data4";
            this.Data4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Data4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Data4.Width = 40;
            // 
            // cbPauseLoop
            // 
            this.cbPauseLoop.AutoSize = true;
            this.cbPauseLoop.Location = new System.Drawing.Point(373, 54);
            this.cbPauseLoop.Name = "cbPauseLoop";
            this.cbPauseLoop.Size = new System.Drawing.Size(122, 17);
            this.cbPauseLoop.TabIndex = 4;
            this.cbPauseLoop.Text = "Executer sans arrets";
            this.cbPauseLoop.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(373, 77);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 5;
            this.btnRun.Text = "Executer";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblAff
            // 
            this.lblAff.AutoSize = true;
            this.lblAff.Location = new System.Drawing.Point(391, 233);
            this.lblAff.Name = "lblAff";
            this.lblAff.Size = new System.Drawing.Size(26, 13);
            this.lblAff.TabIndex = 11;
            this.lblAff.Text = "Aff: ";
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(391, 202);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(18, 13);
            this.lblN.TabIndex = 10;
            this.lblN.Text = "N:";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(391, 173);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(20, 13);
            this.lblZ.TabIndex = 9;
            this.lblZ.Text = "Z: ";
            // 
            // lblAcc
            // 
            this.lblAcc.AutoSize = true;
            this.lblAcc.Location = new System.Drawing.Point(391, 149);
            this.lblAcc.Name = "lblAcc";
            this.lblAcc.Size = new System.Drawing.Size(32, 13);
            this.lblAcc.TabIndex = 8;
            this.lblAcc.Text = "Acc: ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(373, 106);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // msFile
            // 
            this.msFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSave});
            this.msFile.Location = new System.Drawing.Point(0, 0);
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(747, 24);
            this.msFile.TabIndex = 14;
            this.msFile.Text = "menuStrip1";
            // 
            // tsSave
            // 
            this.tsSave.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.openToolStripMenuItem});
            this.tsSave.Name = "tsSave";
            this.tsSave.Size = new System.Drawing.Size(54, 20);
            this.tsSave.Text = "Fichier";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Enregister";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "Ouvrir";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // lblCO
            // 
            this.lblCO.AutoSize = true;
            this.lblCO.Location = new System.Drawing.Point(391, 257);
            this.lblCO.Name = "lblCO";
            this.lblCO.Size = new System.Drawing.Size(34, 13);
            this.lblCO.TabIndex = 15;
            this.lblCO.Text = "CO: 0";
            // 
            // frmInterpreteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 371);
            this.Controls.Add(this.lblCO);
            this.Controls.Add(this.msFile);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblAff);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblAcc);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.cbPauseLoop);
            this.Controls.Add(this.GridCode);
            this.Name = "frmInterpreteur";
            this.Text = "Interpreteur SAP";
            this.Load += new System.EventHandler(this.Interpreteur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCode)).EndInit();
            this.msFile.ResumeLayout(false);
            this.msFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mem4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mem3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mem1;
        private System.Windows.Forms.CheckBox cbPauseLoop;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblAff;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.Label lblAcc;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.MenuStrip msFile;
        private System.Windows.Forms.ToolStripMenuItem tsSave;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.Label lblCO;
    }
}

