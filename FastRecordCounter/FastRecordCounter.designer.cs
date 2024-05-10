
namespace Fic.XTB.FastRecordCounter
{
    partial class FastRecordCounter
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastRecordCounter));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.tstbSearch = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbCount = new System.Windows.Forms.ToolStripButton();
            this.tsbSelectAll = new System.Windows.Forms.ToolStripButton();
            this.tsbUnselectAll = new System.Windows.Forms.ToolStripButton();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tsbExport = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbCsv = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslEntityNumber = new System.Windows.Forms.ToolStripLabel();
            this.tblEntitiesCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tslSelectedLabel = new System.Windows.Forms.ToolStripLabel();
            this.tslSelectedCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tslCountLastUpdated = new System.Windows.Forms.ToolStripLabel();
            this.dgvEntities = new System.Windows.Forms.DataGridView();
            this.Selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DisplayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchemaName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbDonate = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntities)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose,
            this.tstbSearch,
            this.toolStripSeparator1,
            this.tsbCount,
            this.tsbSelectAll,
            this.tsbUnselectAll,
            this.tsbRefresh,
            this.tsbExport,
            this.toolStripSeparator2,
            this.tslEntityNumber,
            this.tblEntitiesCount,
            this.toolStripSeparator3,
            this.tslSelectedLabel,
            this.tslSelectedCount,
            this.toolStripSeparator4,
            this.tslCountLastUpdated,
            this.tsbDonate});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStripMenu.Size = new System.Drawing.Size(1374, 34);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(34, 29);
            this.tsbClose.Text = "Close";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // tstbSearch
            // 
            this.tstbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tstbSearch.Name = "tstbSearch";
            this.tstbSearch.Size = new System.Drawing.Size(148, 38);
            this.tstbSearch.Text = "search...";
            this.tstbSearch.Enter += new System.EventHandler(this.tstbSearch_Enter);
            this.tstbSearch.TextChanged += new System.EventHandler(this.tstbSearch_TextChanged);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsbCount
            // 
            this.tsbCount.Image = ((System.Drawing.Image)(resources.GetObject("tsbCount.Image")));
            this.tsbCount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCount.Name = "tsbCount";
            this.tsbCount.Size = new System.Drawing.Size(88, 33);
            this.tsbCount.Text = "Count";
            this.tsbCount.Click += new System.EventHandler(this.tsbCount_Click);
            // 
            // tsbSelectAll
            // 
            this.tsbSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbSelectAll.Image")));
            this.tsbSelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSelectAll.Name = "tsbSelectAll";
            this.tsbSelectAll.Size = new System.Drawing.Size(111, 33);
            this.tsbSelectAll.Text = "Select All";
            this.tsbSelectAll.Click += new System.EventHandler(this.tsbSelectAll_Click);
            // 
            // tsbUnselectAll
            // 
            this.tsbUnselectAll.Image = ((System.Drawing.Image)(resources.GetObject("tsbUnselectAll.Image")));
            this.tsbUnselectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnselectAll.Name = "tsbUnselectAll";
            this.tsbUnselectAll.Size = new System.Drawing.Size(131, 33);
            this.tsbUnselectAll.Text = "Unselect All";
            this.tsbUnselectAll.Click += new System.EventHandler(this.tsbUnselectAll_Click);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(159, 33);
            this.tsbRefresh.Text = "Refresh Entities";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // tsbExport
            // 
            this.tsbExport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCsv,
            this.tsbExcel});
            this.tsbExport.Image = ((System.Drawing.Image)(resources.GetObject("tsbExport.Image")));
            this.tsbExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbExport.Name = "tsbExport";
            this.tsbExport.Size = new System.Drawing.Size(105, 33);
            this.tsbExport.Text = "Export";
            // 
            // tsbCsv
            // 
            this.tsbCsv.Image = ((System.Drawing.Image)(resources.GetObject("tsbCsv.Image")));
            this.tsbCsv.Name = "tsbCsv";
            this.tsbCsv.Size = new System.Drawing.Size(152, 34);
            this.tsbCsv.Text = "CSV";
            this.tsbCsv.Click += new System.EventHandler(this.tsbCsv_Click);
            // 
            // tsbExcel
            // 
            this.tsbExcel.Image = ((System.Drawing.Image)(resources.GetObject("tsbExcel.Image")));
            this.tsbExcel.Name = "tsbExcel";
            this.tsbExcel.Size = new System.Drawing.Size(152, 34);
            this.tsbExcel.Text = "Excel";
            this.tsbExcel.Click += new System.EventHandler(this.tsbExcel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // tslEntityNumber
            // 
            this.tslEntityNumber.Name = "tslEntityNumber";
            this.tslEntityNumber.Size = new System.Drawing.Size(167, 33);
            this.tslEntityNumber.Text = "Number Of Entities:";
            // 
            // tblEntitiesCount
            // 
            this.tblEntitiesCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tblEntitiesCount.Name = "tblEntitiesCount";
            this.tblEntitiesCount.Size = new System.Drawing.Size(22, 33);
            this.tblEntitiesCount.Text = "0";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // tslSelectedLabel
            // 
            this.tslSelectedLabel.Name = "tslSelectedLabel";
            this.tslSelectedLabel.Size = new System.Drawing.Size(143, 33);
            this.tslSelectedLabel.Text = "Selected Entities:";
            // 
            // tslSelectedCount
            // 
            this.tslSelectedCount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tslSelectedCount.Name = "tslSelectedCount";
            this.tslSelectedCount.Size = new System.Drawing.Size(22, 33);
            this.tslSelectedCount.Text = "0";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // tslCountLastUpdated
            // 
            this.tslCountLastUpdated.Name = "tslCountLastUpdated";
            this.tslCountLastUpdated.Size = new System.Drawing.Size(0, 33);
            // 
            // dgvEntities
            // 
            this.dgvEntities.AllowUserToAddRows = false;
            this.dgvEntities.AllowUserToDeleteRows = false;
            this.dgvEntities.AllowUserToResizeRows = false;
            this.dgvEntities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEntities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Selected,
            this.DisplayName,
            this.SchemaName,
            this.Result});
            this.dgvEntities.Location = new System.Drawing.Point(4, 52);
            this.dgvEntities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEntities.Name = "dgvEntities";
            this.dgvEntities.RowHeadersWidth = 62;
            this.dgvEntities.Size = new System.Drawing.Size(1365, 660);
            this.dgvEntities.TabIndex = 5;
            this.dgvEntities.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntities_CellClick);
            this.dgvEntities.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvEntities_CurrentCellDirtyStateChanged);
            // 
            // Selected
            // 
            this.Selected.FalseValue = false;
            this.Selected.FillWeight = 20.30457F;
            this.Selected.HeaderText = "";
            this.Selected.MinimumWidth = 8;
            this.Selected.Name = "Selected";
            this.Selected.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Selected.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Selected.TrueValue = true;
            // 
            // DisplayName
            // 
            this.DisplayName.FillWeight = 126.5651F;
            this.DisplayName.HeaderText = "Display Name";
            this.DisplayName.MinimumWidth = 8;
            this.DisplayName.Name = "DisplayName";
            // 
            // SchemaName
            // 
            this.SchemaName.FillWeight = 126.5651F;
            this.SchemaName.HeaderText = "Schema Name";
            this.SchemaName.MinimumWidth = 8;
            this.SchemaName.Name = "SchemaName";
            // 
            // Result
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            this.Result.DefaultCellStyle = dataGridViewCellStyle3;
            this.Result.FillWeight = 126.5651F;
            this.Result.HeaderText = "Result";
            this.Result.MinimumWidth = 8;
            this.Result.Name = "Result";
            // 
            // tsbDonate
            // 
            this.tsbDonate.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbDonate.Image = ((System.Drawing.Image)(resources.GetObject("tsbDonate.Image")));
            this.tsbDonate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDonate.Name = "tsbDonate";
            this.tsbDonate.Size = new System.Drawing.Size(98, 33);
            this.tsbDonate.Text = "Donate";
            // 
            // FastRecordCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEntities);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FastRecordCounter";
            this.Size = new System.Drawing.Size(1374, 717);
            this.OnCloseTool += new System.EventHandler(this.FastRecordCounter_OnCloseTool);
            this.ConnectionUpdated += new XrmToolBox.Extensibility.PluginControlBase.ConnectionUpdatedHandler(this.FastRecordCounter_ConnectionUpdated);
            this.Load += new System.EventHandler(this.MyPluginControl_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripTextBox tstbSearch;
        private System.Windows.Forms.DataGridView dgvEntities;
        private System.Windows.Forms.ToolStripButton tsbCount;
        private System.Windows.Forms.ToolStripButton tsbSelectAll;
        private System.Windows.Forms.ToolStripButton tsbUnselectAll;
        private System.Windows.Forms.ToolStripLabel tslEntityNumber;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel tblEntitiesCount;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ToolStripLabel tslSelectedLabel;
        private System.Windows.Forms.ToolStripLabel tslSelectedCount;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton tsbExport;
        private System.Windows.Forms.ToolStripMenuItem tsbCsv;
        private System.Windows.Forms.ToolStripMenuItem tsbExcel;
        private System.Windows.Forms.ToolStripLabel tslCountLastUpdated;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisplayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchemaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.ToolStripButton tsbDonate;
    }
}
