namespace Commands_Runner.Views
{
    partial class CommandsListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandsListView));
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            this.colName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colId = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.commandsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRunAdmin = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCreateFile = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEnabled = new DevExpress.XtraBars.BarButtonItem();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar = new DevExpress.XtraBars.Bar();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.btsiShowDisabled = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.btsiFilterCmd = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.btsiFilterPs1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.btsiFilterPy = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.bbiSearch = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.gcCommands = new DevExpress.XtraGrid.GridControl();
            this.tvCommands = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colType = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCommand = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colEnabled = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colIcon = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImportCommands = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.commandsModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // colName
            // 
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            // 
            // colDescription
            // 
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 2;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            // 
            // commandsModelBindingSource
            // 
            this.commandsModelBindingSource.DataSource = typeof(Commands_Runner.Models.CommandModel);
            // 
            // popupMenu
            // 
            this.popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRunAdmin),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiCreateFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiDelete, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiEnabled)});
            this.popupMenu.Manager = this.barManager;
            this.popupMenu.Name = "popupMenu";
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
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 4;
            this.bbiEdit.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.actions_edit;
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiRunAdmin
            // 
            this.bbiRunAdmin.Caption = "Run Admin";
            this.bbiRunAdmin.Id = 8;
            this.bbiRunAdmin.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.bo_attention;
            this.bbiRunAdmin.Name = "bbiRunAdmin";
            this.bbiRunAdmin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRunAdmin_ItemClick);
            // 
            // bbiCreateFile
            // 
            this.bbiCreateFile.Caption = "Create File";
            this.bbiCreateFile.Id = 21;
            this.bbiCreateFile.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.exportas;
            this.bbiCreateFile.Name = "bbiCreateFile";
            this.bbiCreateFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCreateFile_ItemClick);
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
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 1;
            this.bbiDelete.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.del;
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiEnabled
            // 
            this.bbiEnabled.Caption = "Enabled";
            this.bbiEnabled.Id = 7;
            this.bbiEnabled.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.actions_checkcircled;
            this.bbiEnabled.Name = "bbiEnabled";
            this.bbiEnabled.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEnabled_ItemClick);
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
            this.bbiEnabled,
            this.bbiRunAdmin,
            this.barSubItem1,
            this.btsiShowDisabled,
            this.btsiFilterCmd,
            this.btsiFilterPs1,
            this.btsiFilterPy,
            this.bbiCreateFile,
            this.bbiExport,
            this.bbiImportCommands});
            this.barManager.MaxItemId = 24;
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
            new DevExpress.XtraBars.LinkPersistInfo(this.barSubItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.bbiSearch, "", false, true, true, 224),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiRefresh),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiExport, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiImportCommands, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar.OptionsBar.AllowQuickCustomization = false;
            this.bar.OptionsBar.DrawDragBorder = false;
            this.bar.OptionsBar.MultiLine = true;
            this.bar.OptionsBar.UseWholeRow = true;
            this.bar.Text = "Main menu";
            // 
            // barSubItem1
            // 
            this.barSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barSubItem1.Caption = "Filters";
            this.barSubItem1.Id = 10;
            this.barSubItem1.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.filter;
            this.barSubItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btsiShowDisabled),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btsiFilterCmd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btsiFilterPs1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btsiFilterPy)});
            this.barSubItem1.Name = "barSubItem1";
            this.barSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // btsiShowDisabled
            // 
            this.btsiShowDisabled.Caption = "Show Disabled";
            this.btsiShowDisabled.Id = 16;
            this.btsiShowDisabled.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.clearfilter;
            this.btsiShowDisabled.Name = "btsiShowDisabled";
            this.btsiShowDisabled.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btsiShowDisabled_CheckedChanged);
            // 
            // btsiFilterCmd
            // 
            this.btsiFilterCmd.BindableChecked = true;
            this.btsiFilterCmd.Caption = "Show Cmd";
            this.btsiFilterCmd.Checked = true;
            this.btsiFilterCmd.Id = 17;
            this.btsiFilterCmd.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.clearfilter;
            this.btsiFilterCmd.Name = "btsiFilterCmd";
            this.btsiFilterCmd.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btsiFilterCmd_CheckedChanged);
            // 
            // btsiFilterPs1
            // 
            this.btsiFilterPs1.BindableChecked = true;
            this.btsiFilterPs1.Caption = "Show PS1";
            this.btsiFilterPs1.Checked = true;
            this.btsiFilterPs1.Id = 18;
            this.btsiFilterPs1.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.clearfilter;
            this.btsiFilterPs1.Name = "btsiFilterPs1";
            this.btsiFilterPs1.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btsiFilterPs1_CheckedChanged);
            // 
            // btsiFilterPy
            // 
            this.btsiFilterPy.BindableChecked = true;
            this.btsiFilterPy.Caption = "Show Python";
            this.btsiFilterPy.Checked = true;
            this.btsiFilterPy.Id = 20;
            this.btsiFilterPy.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.clearfilter;
            this.btsiFilterPy.Name = "btsiFilterPy";
            this.btsiFilterPy.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btsiFilterPy_CheckedChanged);
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
            this.repositoryItemSearchControl1.Client = this.gcCommands;
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            this.repositoryItemSearchControl1.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.AutoChangeSearchToClear;
            // 
            // gcCommands
            // 
            this.gcCommands.DataSource = this.commandsModelBindingSource;
            this.gcCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCommands.Location = new System.Drawing.Point(0, 39);
            this.gcCommands.MainView = this.tvCommands;
            this.gcCommands.Name = "gcCommands";
            this.gcCommands.Size = new System.Drawing.Size(885, 498);
            this.gcCommands.TabIndex = 2;
            this.gcCommands.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tvCommands});
            // 
            // tvCommands
            // 
            this.tvCommands.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tvCommands.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colDescription,
            this.colType,
            this.colCommand,
            this.colEnabled,
            this.colIcon});
            this.tvCommands.GridControl = this.gcCommands;
            this.tvCommands.Name = "tvCommands";
            this.tvCommands.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.tvCommands.OptionsDragDrop.AllowDrag = true;
            this.tvCommands.OptionsFind.ShowClearButton = false;
            this.tvCommands.OptionsFind.ShowCloseButton = false;
            this.tvCommands.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None;
            this.tvCommands.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(0);
            this.tvCommands.OptionsTiles.ItemSize = new System.Drawing.Size(248, 110);
            this.tvCommands.OptionsTiles.RowCount = 0;
            this.tvCommands.TileHtmlTemplate.Styles = resources.GetString("tvCommands.TileHtmlTemplate.Styles");
            this.tvCommands.TileHtmlTemplate.Template = resources.GetString("tvCommands.TileHtmlTemplate.Template");
            tableRowDefinition1.AutoHeight = true;
            tableRowDefinition1.Length.Value = 33D;
            tableRowDefinition2.Length.Value = 67D;
            this.tvCommands.TileRows.Add(tableRowDefinition1);
            this.tvCommands.TileRows.Add(tableRowDefinition2);
            tileViewItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement1.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement1.Column = this.colName;
            tileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement1.Text = "colName";
            tileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.Column = this.colDescription;
            tileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement2.RowIndex = 1;
            tileViewItemElement2.Text = "colDescription";
            tileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tileViewItemElement3.Appearance.Normal.Options.UseFont = true;
            tileViewItemElement3.Column = this.colId;
            tileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            tileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze;
            tileViewItemElement3.Text = "colId";
            tileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.tvCommands.TileTemplate.Add(tileViewItemElement1);
            this.tvCommands.TileTemplate.Add(tileViewItemElement2);
            this.tvCommands.TileTemplate.Add(tileViewItemElement3);
            this.tvCommands.ItemDrop += new DevExpress.XtraGrid.Views.Tile.TileViewItemDropEventHandler(this.tvCommands_ItemDrop);
            this.tvCommands.ItemDrag += new DevExpress.XtraGrid.Views.Tile.TileViewItemDragEventHandler(this.tvCommands_ItemDrag);
            this.tvCommands.ItemClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tvCommands_ItemClick);
            this.tvCommands.ItemRightClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tvCommands_ItemRightClick);
            this.tvCommands.CustomItemTemplate += new DevExpress.XtraGrid.Views.Tile.TileViewCustomItemTemplateEventHandler(this.tvCommands_CustomItemTemplate);
            this.tvCommands.Click += new System.EventHandler(this.tvCommands_Click);
            // 
            // colType
            // 
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.Visible = true;
            this.colType.VisibleIndex = 3;
            // 
            // colCommand
            // 
            this.colCommand.FieldName = "Command";
            this.colCommand.Name = "colCommand";
            this.colCommand.Visible = true;
            this.colCommand.VisibleIndex = 4;
            // 
            // colEnabled
            // 
            this.colEnabled.FieldName = "Enabled";
            this.colEnabled.Name = "colEnabled";
            this.colEnabled.Visible = true;
            this.colEnabled.VisibleIndex = 5;
            // 
            // colIcon
            // 
            this.colIcon.FieldName = "Icon";
            this.colIcon.Name = "colIcon";
            this.colIcon.Visible = true;
            this.colIcon.VisibleIndex = 6;
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Id = 22;
            this.bbiExport.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.exportfile;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // bbiImportCommands
            // 
            this.bbiImportCommands.Caption = "Import";
            this.bbiImportCommands.Id = 23;
            this.bbiImportCommands.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.import;
            this.bbiImportCommands.Name = "bbiImportCommands";
            this.bbiImportCommands.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImportCommands_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(885, 39);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 537);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(885, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 39);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 498);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(885, 39);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 498);
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // CommandsListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gcCommands);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "CommandsListView";
            this.Size = new System.Drawing.Size(885, 537);
            ((System.ComponentModel.ISupportInitialize)(this.commandsModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource commandsModelBindingSource;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gcCommands;
        private DevExpress.XtraGrid.Views.Tile.TileView tvCommands;
        private DevExpress.XtraGrid.Columns.TileViewColumn colId;
        private DevExpress.XtraGrid.Columns.TileViewColumn colName;
        private DevExpress.XtraGrid.Columns.TileViewColumn colDescription;
        private DevExpress.XtraGrid.Columns.TileViewColumn colType;
        private DevExpress.XtraGrid.Columns.TileViewColumn colCommand;
        private DevExpress.XtraGrid.Columns.TileViewColumn colEnabled;
        private DevExpress.XtraGrid.Columns.TileViewColumn colIcon;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private DevExpress.XtraBars.BarEditItem bbiSearch;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarButtonItem bbiEnabled;
        private DevExpress.XtraBars.BarButtonItem bbiRunAdmin;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem bbiCreateFile;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarButtonItem bbiImportCommands;
        public DevExpress.XtraBars.BarToggleSwitchItem btsiShowDisabled;
        public DevExpress.XtraBars.BarToggleSwitchItem btsiFilterCmd;
        public DevExpress.XtraBars.BarToggleSwitchItem btsiFilterPs1;
        public DevExpress.XtraBars.BarToggleSwitchItem btsiFilterPy;
    }
}
