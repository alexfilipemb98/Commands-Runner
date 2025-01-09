namespace Commands_Runner.Views
{
    partial class PriExtensionsListView
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
            this.components = new System.ComponentModel.Container();
            this.gcExtensibilityConfiguration = new DevExpress.XtraGrid.GridControl();
            this.primaveraExtensionModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvExtensibilityConfiguration = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFileVersion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExecutionQueue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHashCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCompany = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCommonExtension = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAssemblyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsSystem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar = new DevExpress.XtraBars.Bar();
            this.bbiSearch = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.bbiExportPDF = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExportExcel = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcExtensibilityConfiguration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.primaveraExtensionModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExtensibilityConfiguration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
            // 
            // gcExtensibilityConfiguration
            // 
            this.gcExtensibilityConfiguration.DataSource = this.primaveraExtensionModelBindingSource;
            this.gcExtensibilityConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcExtensibilityConfiguration.Location = new System.Drawing.Point(2, 2);
            this.gcExtensibilityConfiguration.MainView = this.gvExtensibilityConfiguration;
            this.gcExtensibilityConfiguration.Margin = new System.Windows.Forms.Padding(0);
            this.gcExtensibilityConfiguration.Name = "gcExtensibilityConfiguration";
            this.gcExtensibilityConfiguration.Size = new System.Drawing.Size(779, 531);
            this.gcExtensibilityConfiguration.TabIndex = 1;
            this.gcExtensibilityConfiguration.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvExtensibilityConfiguration});
            // 
            // primaveraExtensionModelBindingSource
            // 
            this.primaveraExtensionModelBindingSource.DataSource = typeof(Commands_Runner.Models.PrimaveraExtensionModel);
            // 
            // gvExtensibilityConfiguration
            // 
            this.gvExtensibilityConfiguration.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvExtensibilityConfiguration.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colFileName,
            this.colFileVersion,
            this.colExecutionQueue,
            this.colHashCode,
            this.colCompany,
            this.colCommonExtension,
            this.colIsActive,
            this.colAssemblyName,
            this.colIsSystem});
            this.gvExtensibilityConfiguration.CustomizationFormBounds = new System.Drawing.Rectangle(873, 402, 264, 334);
            this.gvExtensibilityConfiguration.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            this.gvExtensibilityConfiguration.GridControl = this.gcExtensibilityConfiguration;
            this.gvExtensibilityConfiguration.Name = "gvExtensibilityConfiguration";
            this.gvExtensibilityConfiguration.OptionsBehavior.Editable = false;
            this.gvExtensibilityConfiguration.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.gvExtensibilityConfiguration.OptionsScrollAnnotations.ShowFocusedRow = DevExpress.Utils.DefaultBoolean.True;
            this.gvExtensibilityConfiguration.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvExtensibilityConfiguration.OptionsView.ShowAutoFilterRow = true;
            this.gvExtensibilityConfiguration.OptionsView.ShowGroupPanel = false;
            this.gvExtensibilityConfiguration.OptionsView.ShowIndicator = false;
            this.gvExtensibilityConfiguration.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colExecutionQueue, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvExtensibilityConfiguration.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvExtensibilityConfiguration_RowClick);
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            // 
            // colFileName
            // 
            this.colFileName.FieldName = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.Visible = true;
            this.colFileName.VisibleIndex = 0;
            this.colFileName.Width = 195;
            // 
            // colFileVersion
            // 
            this.colFileVersion.FieldName = "FileVersion";
            this.colFileVersion.Name = "colFileVersion";
            this.colFileVersion.Width = 84;
            // 
            // colExecutionQueue
            // 
            this.colExecutionQueue.FieldName = "ExecutionQueue";
            this.colExecutionQueue.Name = "colExecutionQueue";
            this.colExecutionQueue.Width = 124;
            // 
            // colHashCode
            // 
            this.colHashCode.FieldName = "HashCode";
            this.colHashCode.Name = "colHashCode";
            // 
            // colCompany
            // 
            this.colCompany.FieldName = "Company";
            this.colCompany.Name = "colCompany";
            this.colCompany.Visible = true;
            this.colCompany.VisibleIndex = 1;
            this.colCompany.Width = 235;
            // 
            // colCommonExtension
            // 
            this.colCommonExtension.Caption = "Is Common";
            this.colCommonExtension.FieldName = "CommonExtension";
            this.colCommonExtension.Name = "colCommonExtension";
            this.colCommonExtension.OptionsColumn.FixedWidth = true;
            this.colCommonExtension.Visible = true;
            this.colCommonExtension.VisibleIndex = 2;
            this.colCommonExtension.Width = 100;
            // 
            // colIsActive
            // 
            this.colIsActive.FieldName = "IsActive";
            this.colIsActive.Name = "colIsActive";
            this.colIsActive.OptionsColumn.FixedWidth = true;
            this.colIsActive.Visible = true;
            this.colIsActive.VisibleIndex = 3;
            this.colIsActive.Width = 100;
            // 
            // colAssemblyName
            // 
            this.colAssemblyName.FieldName = "AssemblyName";
            this.colAssemblyName.Name = "colAssemblyName";
            this.colAssemblyName.Width = 233;
            // 
            // colIsSystem
            // 
            this.colIsSystem.FieldName = "IsSystem";
            this.colIsSystem.Name = "colIsSystem";
            this.colIsSystem.OptionsColumn.FixedWidth = true;
            this.colIsSystem.Visible = true;
            this.colIsSystem.VisibleIndex = 4;
            this.colIsSystem.Width = 100;
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiNew,
            this.bbiDelete,
            this.bbiSearch,
            this.bbiEdit,
            this.bbiRefresh,
            this.barSubItem1,
            this.bbiExportPDF,
            this.bbiExportExcel});
            this.barManager.MaxItemId = 27;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1,
            this.repositoryItemTextEdit1});
            // 
            // bar
            // 
            this.bar.BarName = "Main menu";
            this.bar.DockCol = 0;
            this.bar.DockRow = 0;
            this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.bbiSearch, "", false, true, true, 224),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSubItem1, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar.OptionsBar.AllowQuickCustomization = false;
            this.bar.OptionsBar.DrawDragBorder = false;
            this.bar.OptionsBar.MultiLine = true;
            this.bar.OptionsBar.UseWholeRow = true;
            this.bar.Text = "Main menu";
            // 
            // bbiSearch
            // 
            this.bbiSearch.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bbiSearch.Caption = "Search Commands";
            this.bbiSearch.Edit = this.repositoryItemSearchControl1;
            this.bbiSearch.Id = 3;
            this.bbiSearch.Name = "bbiSearch";
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Client = this.gcExtensibilityConfiguration;
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            this.repositoryItemSearchControl1.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.AutoChangeSearchToClear;
            // 
            // bbiNew
            // 
            this.bbiNew.Border = DevExpress.XtraEditors.Controls.BorderStyles.Default;
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 0;
            this.bbiNew.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.actions_add;
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 6;
            this.bbiRefresh.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.actions_refresh;
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Export";
            this.barSubItem1.Id = 24;
            this.barSubItem1.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.exportfile;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExportPDF),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiExportExcel)});
            this.barSubItem1.Name = "barSubItem1";
            // 
            // bbiExportPDF
            // 
            this.bbiExportPDF.Caption = "To PDF";
            this.bbiExportPDF.Id = 25;
            this.bbiExportPDF.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.exporttopdf;
            this.bbiExportPDF.Name = "bbiExportPDF";
            this.bbiExportPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExportPDF_ItemClick);
            // 
            // bbiExportExcel
            // 
            this.bbiExportExcel.Caption = "To Excel";
            this.bbiExportExcel.Id = 26;
            this.bbiExportExcel.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.exporttoxls;
            this.bbiExportExcel.Name = "bbiExportExcel";
            this.bbiExportExcel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExportExcel_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(815, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 606);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(815, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 567);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(815, 39);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 567);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 1;
            this.bbiDelete.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.del;
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 4;
            this.bbiEdit.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.actions_edit;
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDelete, true)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 39);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(815, 567);
            this.layoutControl1.TabIndex = 6;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(815, 567);
            this.Root.TextVisible = false;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcExtensibilityConfiguration);
            this.panelControl1.Location = new System.Drawing.Point(16, 16);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(783, 535);
            this.panelControl1.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(789, 541);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // PriExtensionsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PriExtensionsListView";
            this.Size = new System.Drawing.Size(815, 606);
            ((System.ComponentModel.ISupportInitialize)(this.gcExtensibilityConfiguration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.primaveraExtensionModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvExtensibilityConfiguration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gcExtensibilityConfiguration;
        private DevExpress.XtraGrid.Views.Grid.GridView gvExtensibilityConfiguration;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colFileName;
        private DevExpress.XtraGrid.Columns.GridColumn colFileVersion;
        private DevExpress.XtraGrid.Columns.GridColumn colExecutionQueue;
        private DevExpress.XtraGrid.Columns.GridColumn colHashCode;
        private DevExpress.XtraGrid.Columns.GridColumn colCompany;
        private DevExpress.XtraGrid.Columns.GridColumn colCommonExtension;
        private DevExpress.XtraGrid.Columns.GridColumn colIsActive;
        private DevExpress.XtraGrid.Columns.GridColumn colAssemblyName;
        private DevExpress.XtraGrid.Columns.GridColumn colIsSystem;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarEditItem bbiSearch;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private System.Windows.Forms.BindingSource primaveraExtensionModelBindingSource;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem bbiExportPDF;
        private DevExpress.XtraBars.BarButtonItem bbiExportExcel;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}
