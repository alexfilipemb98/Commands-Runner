using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace Commands_Runner
{
	partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition1 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraEditors.TableLayout.TableRowDefinition tableRowDefinition2 = new DevExpress.XtraEditors.TableLayout.TableRowDefinition();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement1 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement2 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraGrid.Views.Tile.TileViewItemElement tileViewItemElement3 = new DevExpress.XtraGrid.Views.Tile.TileViewItemElement();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.colName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colId = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bsiStatus = new DevExpress.XtraBars.BarStaticItem();
            this.bsiTime = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNewCommand = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefreshCommands = new DevExpress.XtraBars.BarButtonItem();
            this.bsiVersion = new DevExpress.XtraBars.BarStaticItem();
            this.bbiEnabled = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRunAdmin = new DevExpress.XtraBars.BarButtonItem();
            this.beiSearch = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.gcCommands = new DevExpress.XtraGrid.GridControl();
            this.commandsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tvCommands = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colType = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCommand = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colEnabled = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colIcon = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.bsiSizse = new DevExpress.XtraBars.BarStaticItem();
            this.bbiImportCommands = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExportCommand = new DevExpress.XtraBars.BarButtonItem();
            this.bMenuCommands = new DevExpress.XtraBars.BarSubItem();
            this.bbiResetFormSize = new DevExpress.XtraBars.BarButtonItem();
            this.bMenuTools = new DevExpress.XtraBars.BarSubItem();
            this.bbiThreeSimpleRule = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMenuCommandsFilters = new DevExpress.XtraBars.BarSubItem();
            this.btsiShowDisabled = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.btsiFilterCmd = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.btsiFilterPs1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.btsiFilterPy = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.bbiCreateFile = new DevExpress.XtraBars.BarButtonItem();
            this.bbiTogglePassword = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgMainPage = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgFilters = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemSearchControl2 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.barToggleSwitchItem2 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.navigationFrame = new DevExpress.XtraBars.Navigation.NavigationFrame();
            this.npCommands = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.npPasswords = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gcPasswords = new DevExpress.XtraGrid.GridControl();
            this.passwordsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvPasswords = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gcPasswordsAction = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandsModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).BeginInit();
            this.navigationFrame.SuspendLayout();
            this.npCommands.SuspendLayout();
            this.npPasswords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPasswords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPasswords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
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
            // ribbonControl
            // 
            this.ribbonControl.AllowMinimizeRibbon = false;
            this.ribbonControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.ItemPanelStyle = DevExpress.XtraBars.Ribbon.RibbonItemPanelStyle.Classic;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bsiStatus,
            this.bsiTime,
            this.bbiNewCommand,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefreshCommands,
            this.bsiVersion,
            this.bbiEnabled,
            this.bbiRunAdmin,
            this.beiSearch,
            this.bsiSizse,
            this.bbiImportCommands,
            this.bbiExportCommand,
            this.bMenuCommands,
            this.bbiResetFormSize,
            this.bMenuTools,
            this.bbiThreeSimpleRule,
            this.bbiMenuCommandsFilters,
            this.btsiShowDisabled,
            this.btsiFilterCmd,
            this.btsiFilterPs1,
            this.btsiFilterPy,
            this.bbiCreateFile,
            this.bbiTogglePassword});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 41;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1,
            this.repositoryItemSearchControl2});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbonControl.SearchItemPosition = DevExpress.XtraBars.Ribbon.SearchItemPosition.Caption;
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowQatLocationSelector = false;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(998, 83);
            this.ribbonControl.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // bsiStatus
            // 
            this.bsiStatus.Caption = "Program started";
            this.bsiStatus.Id = 2;
            this.bsiStatus.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.bo_category;
            this.bsiStatus.Name = "bsiStatus";
            this.bsiStatus.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bsiTime
            // 
            this.bsiTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiTime.Caption = "Time: 2024/09/14 11:50";
            this.bsiTime.Id = 3;
            this.bsiTime.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.time;
            this.bsiTime.Name = "bsiTime";
            this.bsiTime.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiNewCommand
            // 
            this.bbiNewCommand.Caption = "New ";
            this.bbiNewCommand.Id = 5;
            this.bbiNewCommand.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.actions_add;
            this.bbiNewCommand.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.bbiNewCommand.Name = "bbiNewCommand";
            this.bbiNewCommand.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            this.bbiNewCommand.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiEdit
            // 
            this.bbiEdit.Caption = "Edit";
            this.bbiEdit.Id = 7;
            this.bbiEdit.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.actions_edit;
            this.bbiEdit.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.bbiEdit.Name = "bbiEdit";
            this.bbiEdit.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            this.bbiEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEdit_ItemClick);
            // 
            // bbiDelete
            // 
            this.bbiDelete.Caption = "Delete";
            this.bbiDelete.Id = 8;
            this.bbiDelete.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.del;
            this.bbiDelete.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D));
            this.bbiDelete.Name = "bbiDelete";
            this.bbiDelete.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            this.bbiDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiDelete_ItemClick);
            // 
            // bbiRefreshCommands
            // 
            this.bbiRefreshCommands.Caption = "Refresh";
            this.bbiRefreshCommands.Id = 9;
            this.bbiRefreshCommands.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.actions_refresh;
            this.bbiRefreshCommands.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.bbiRefreshCommands.Name = "bbiRefreshCommands";
            this.bbiRefreshCommands.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            this.bbiRefreshCommands.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
            // 
            // bsiVersion
            // 
            this.bsiVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiVersion.Caption = "v1.0.0.3";
            this.bsiVersion.Id = 10;
            this.bsiVersion.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.bo_fileattachment;
            this.bsiVersion.Name = "bsiVersion";
            this.bsiVersion.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiEnabled
            // 
            this.bbiEnabled.Caption = "Disable";
            this.bbiEnabled.Id = 11;
            this.bbiEnabled.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.gettingstarted;
            this.bbiEnabled.Name = "bbiEnabled";
            this.bbiEnabled.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEnabled_ItemClick);
            // 
            // bbiRunAdmin
            // 
            this.bbiRunAdmin.Caption = "Run Admin";
            this.bbiRunAdmin.Id = 12;
            this.bbiRunAdmin.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.bo_attention;
            this.bbiRunAdmin.Name = "bbiRunAdmin";
            this.bbiRunAdmin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRunAdmin_ItemClick);
            // 
            // beiSearch
            // 
            this.beiSearch.Edit = this.repositoryItemSearchControl1;
            this.beiSearch.EditWidth = 250;
            this.beiSearch.Id = 15;
            this.beiSearch.Name = "beiSearch";
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Client = this.gcCommands;
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            this.repositoryItemSearchControl1.ShowClearButton = false;
            this.repositoryItemSearchControl1.ShowSearchButton = false;
            // 
            // gcCommands
            // 
            this.gcCommands.DataSource = this.commandsModelBindingSource;
            this.gcCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCommands.Location = new System.Drawing.Point(0, 0);
            this.gcCommands.MainView = this.tvCommands;
            this.gcCommands.MenuManager = this.ribbonControl;
            this.gcCommands.Name = "gcCommands";
            this.gcCommands.Size = new System.Drawing.Size(998, 409);
            this.gcCommands.TabIndex = 1;
            this.gcCommands.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tvCommands});
            // 
            // commandsModelBindingSource
            // 
            this.commandsModelBindingSource.DataSource = typeof(Commands_Runner.Models.CommandsModel);
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
            // bsiSizse
            // 
            this.bsiSizse.Caption = "Size";
            this.bsiSizse.Id = 17;
            this.bsiSizse.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.actions_fullscreen;
            this.bsiSizse.Name = "bsiSizse";
            this.bsiSizse.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiImportCommands
            // 
            this.bbiImportCommands.Caption = "Import Commands";
            this.bbiImportCommands.Id = 18;
            this.bbiImportCommands.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.import;
            this.bbiImportCommands.Name = "bbiImportCommands";
            this.bbiImportCommands.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImportCommands_ItemClick);
            // 
            // bbiExportCommand
            // 
            this.bbiExportCommand.Caption = "Export Commands";
            this.bbiExportCommand.Id = 19;
            this.bbiExportCommand.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.exportfile;
            this.bbiExportCommand.Name = "bbiExportCommand";
            this.bbiExportCommand.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // bMenuCommands
            // 
            this.bMenuCommands.Caption = "Commands";
            this.bMenuCommands.Id = 20;
            this.bMenuCommands.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources._new;
            this.bMenuCommands.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiNewCommand, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiRefreshCommands, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiExportCommand, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiImportCommands)});
            this.bMenuCommands.Name = "bMenuCommands";
            this.bMenuCommands.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.False;
            // 
            // bbiResetFormSize
            // 
            this.bbiResetFormSize.Caption = "Reset Size";
            this.bbiResetFormSize.Id = 21;
            this.bbiResetFormSize.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.fittopage;
            this.bbiResetFormSize.Name = "bbiResetFormSize";
            this.bbiResetFormSize.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiResetFormSize_ItemClick);
            // 
            // bMenuTools
            // 
            this.bMenuTools.Caption = "Tools";
            this.bMenuTools.Id = 22;
            this.bMenuTools.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.actions_options;
            this.bMenuTools.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiThreeSimpleRule, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiResetFormSize, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bMenuTools.Name = "bMenuTools";
            this.bMenuTools.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.False;
            // 
            // bbiThreeSimpleRule
            // 
            this.bbiThreeSimpleRule.Caption = "Three Simple Rule";
            this.bbiThreeSimpleRule.Id = 23;
            this.bbiThreeSimpleRule.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.topbottomrules;
            this.bbiThreeSimpleRule.Name = "bbiThreeSimpleRule";
            this.bbiThreeSimpleRule.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiThreeSimpleRule_ItemClick);
            // 
            // bbiMenuCommandsFilters
            // 
            this.bbiMenuCommandsFilters.Id = 24;
            this.bbiMenuCommandsFilters.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.filter;
            this.bbiMenuCommandsFilters.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btsiShowDisabled, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btsiFilterCmd, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.btsiFilterPs1),
            new DevExpress.XtraBars.LinkPersistInfo(this.btsiFilterPy)});
            this.bbiMenuCommandsFilters.Name = "bbiMenuCommandsFilters";
            this.bbiMenuCommandsFilters.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.False;
            // 
            // btsiShowDisabled
            // 
            this.btsiShowDisabled.BindableChecked = true;
            this.btsiShowDisabled.Caption = "Show Disabled";
            this.btsiShowDisabled.Checked = true;
            this.btsiShowDisabled.Id = 26;
            this.btsiShowDisabled.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.quickfilter;
            this.btsiShowDisabled.Name = "btsiShowDisabled";
            this.btsiShowDisabled.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btsiShowDisabled_CheckedChanged);
            // 
            // btsiFilterCmd
            // 
            this.btsiFilterCmd.BindableChecked = true;
            this.btsiFilterCmd.Caption = "Show Type CMD";
            this.btsiFilterCmd.Checked = true;
            this.btsiFilterCmd.Id = 28;
            this.btsiFilterCmd.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.quickfilter;
            this.btsiFilterCmd.Name = "btsiFilterCmd";
            this.btsiFilterCmd.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btsiFilterCmd_CheckedChanged);
            // 
            // btsiFilterPs1
            // 
            this.btsiFilterPs1.BindableChecked = true;
            this.btsiFilterPs1.Caption = "Show Type PS1";
            this.btsiFilterPs1.Checked = true;
            this.btsiFilterPs1.Id = 29;
            this.btsiFilterPs1.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.quickfilter;
            this.btsiFilterPs1.Name = "btsiFilterPs1";
            this.btsiFilterPs1.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btsiFilterPs1_CheckedChanged);
            // 
            // btsiFilterPy
            // 
            this.btsiFilterPy.BindableChecked = true;
            this.btsiFilterPy.Caption = "Show Type PY";
            this.btsiFilterPy.Checked = true;
            this.btsiFilterPy.Id = 30;
            this.btsiFilterPy.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.quickfilter;
            this.btsiFilterPy.Name = "btsiFilterPy";
            this.btsiFilterPy.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btsiFilterPy_CheckedChanged);
            // 
            // bbiCreateFile
            // 
            this.bbiCreateFile.Caption = "Create File";
            this.bbiCreateFile.Id = 31;
            this.bbiCreateFile.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.exportas;
            this.bbiCreateFile.Name = "bbiCreateFile";
            this.bbiCreateFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCreateFile_ItemClick);
            // 
            // bbiTogglePassword
            // 
            this.bbiTogglePassword.Caption = "Show Passwords";
            this.bbiTogglePassword.Id = 32;
            this.bbiTogglePassword.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.bo_user;
            this.bbiTogglePassword.Name = "bbiTogglePassword";
            this.bbiTogglePassword.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiTogglePassword_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rpgMainPage,
            this.rpgFilters});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // rpgMainPage
            // 
            this.rpgMainPage.ItemLinks.Add(this.bMenuCommands);
            this.rpgMainPage.ItemLinks.Add(this.bbiTogglePassword);
            this.rpgMainPage.ItemLinks.Add(this.bMenuTools);
            this.rpgMainPage.Name = "rpgMainPage";
            this.rpgMainPage.Text = "Main Page";
            // 
            // rpgFilters
            // 
            this.rpgFilters.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.rpgFilters.ItemLinks.Add(this.bbiMenuCommandsFilters);
            this.rpgFilters.ItemLinks.Add(this.beiSearch);
            this.rpgFilters.Name = "rpgFilters";
            this.rpgFilters.Text = "Filters";
            // 
            // repositoryItemSearchControl2
            // 
            this.repositoryItemSearchControl2.AutoHeight = false;
            this.repositoryItemSearchControl2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl2.Name = "repositoryItemSearchControl2";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiStatus);
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiTime);
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiVersion);
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiSizse);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 492);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(998, 37);
            // 
            // popupMenu
            // 
            this.popupMenu.ItemLinks.Add(this.bbiNewCommand);
            this.popupMenu.ItemLinks.Add(this.bbiEdit);
            this.popupMenu.ItemLinks.Add(this.bbiRunAdmin);
            this.popupMenu.ItemLinks.Add(this.bbiCreateFile);
            this.popupMenu.ItemLinks.Add(this.bbiRefreshCommands);
            this.popupMenu.ItemLinks.Add(this.bbiDelete, true);
            this.popupMenu.ItemLinks.Add(this.bbiEnabled);
            this.popupMenu.Name = "popupMenu";
            this.popupMenu.Ribbon = this.ribbonControl;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // barToggleSwitchItem2
            // 
            this.barToggleSwitchItem2.Caption = "cmd";
            this.barToggleSwitchItem2.Id = 28;
            this.barToggleSwitchItem2.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.quickfilter;
            this.barToggleSwitchItem2.Name = "barToggleSwitchItem2";
            // 
            // navigationFrame
            // 
            this.navigationFrame.Controls.Add(this.npCommands);
            this.navigationFrame.Controls.Add(this.npPasswords);
            this.navigationFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationFrame.Location = new System.Drawing.Point(0, 83);
            this.navigationFrame.Name = "navigationFrame";
            this.navigationFrame.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npCommands,
            this.npPasswords});
            this.navigationFrame.SelectedPage = this.npCommands;
            this.navigationFrame.Size = new System.Drawing.Size(998, 409);
            this.navigationFrame.TabIndex = 7;
            this.navigationFrame.Text = "navigationFrame1";
            // 
            // npCommands
            // 
            this.npCommands.Controls.Add(this.gcCommands);
            this.npCommands.Name = "npCommands";
            this.npCommands.Size = new System.Drawing.Size(998, 409);
            // 
            // npPasswords
            // 
            this.npPasswords.Controls.Add(this.layoutControl1);
            this.npPasswords.Name = "npPasswords";
            this.npPasswords.Size = new System.Drawing.Size(998, 409);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(998, 409);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gcPasswords);
            this.panelControl1.Location = new System.Drawing.Point(16, 16);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(966, 377);
            this.panelControl1.TabIndex = 0;
            // 
            // gcPasswords
            // 
            this.gcPasswords.DataSource = this.passwordsModelBindingSource;
            this.gcPasswords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPasswords.Location = new System.Drawing.Point(2, 2);
            this.gcPasswords.MainView = this.gvPasswords;
            this.gcPasswords.Margin = new System.Windows.Forms.Padding(0);
            this.gcPasswords.MenuManager = this.ribbonControl;
            this.gcPasswords.Name = "gcPasswords";
            this.gcPasswords.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2});
            this.gcPasswords.Size = new System.Drawing.Size(962, 373);
            this.gcPasswords.TabIndex = 0;
            this.gcPasswords.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvPasswords});
            // 
            // passwordsModelBindingSource
            // 
            this.passwordsModelBindingSource.DataSource = typeof(Commands_Runner.Models.PasswordsModel);
            // 
            // gvPasswords
            // 
            this.gvPasswords.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.gvPasswords.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId1,
            this.colName1,
            this.colPassword,
            this.gcPasswordsAction});
            this.gvPasswords.GridControl = this.gcPasswords;
            this.gvPasswords.Name = "gvPasswords";
            this.gvPasswords.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gvPasswords.OptionsView.ShowGroupPanel = false;
            this.gvPasswords.CustomRowCellEdit += new DevExpress.XtraGrid.Views.Grid.CustomRowCellEditEventHandler(this.gvPasswords_CustomRowCellEdit);
            this.gvPasswords.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gvPasswords_RowUpdated);
            // 
            // colId1
            // 
            this.colId1.FieldName = "Id";
            this.colId1.Name = "colId1";
            this.colId1.Width = 97;
            // 
            // colName1
            // 
            this.colName1.FieldName = "Name";
            this.colName1.Name = "colName1";
            this.colName1.Visible = true;
            this.colName1.VisibleIndex = 0;
            this.colName1.Width = 279;
            // 
            // colPassword
            // 
            this.colPassword.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 1;
            this.colPassword.Width = 600;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.SvgImage = global::Commands_Runner.Properties.Resources.security_visibilityoff;
            editorButtonImageOptions1.SvgImageSize = new System.Drawing.Size(24, 24);
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", "ShowPassword", null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.UseSystemPasswordChar = true;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // gcPasswordsAction
            // 
            this.gcPasswordsAction.Caption = "Actions";
            this.gcPasswordsAction.ColumnEdit = this.repositoryItemButtonEdit2;
            this.gcPasswordsAction.Name = "gcPasswordsAction";
            this.gcPasswordsAction.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.gcPasswordsAction.OptionsColumn.AllowIncrementalSearch = false;
            this.gcPasswordsAction.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.gcPasswordsAction.OptionsColumn.AllowMove = false;
            this.gcPasswordsAction.OptionsColumn.AllowShowHide = false;
            this.gcPasswordsAction.OptionsColumn.AllowSize = false;
            this.gcPasswordsAction.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.gcPasswordsAction.OptionsColumn.ShowInCustomizationForm = false;
            this.gcPasswordsAction.OptionsFilter.AllowAutoFilter = false;
            this.gcPasswordsAction.OptionsFilter.AllowFilter = false;
            this.gcPasswordsAction.OptionsFilter.AllowFilterModeChanging = DevExpress.Utils.DefaultBoolean.False;
            this.gcPasswordsAction.OptionsFilter.AllowInHeaderSearch = DevExpress.Utils.DefaultBoolean.False;
            this.gcPasswordsAction.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gcPasswordsAction.Visible = true;
            this.gcPasswordsAction.VisibleIndex = 2;
            this.gcPasswordsAction.Width = 53;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            editorButtonImageOptions2.SvgImage = global::Commands_Runner.Properties.Resources.del;
            editorButtonImageOptions2.SvgImageSize = new System.Drawing.Size(24, 24);
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", "DEL", null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit2_ButtonClick);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(998, 409);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(972, 383);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Show";
            this.barButtonItem1.Id = 32;
            this.barButtonItem1.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.showcontainerheader;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Show";
            this.barButtonItem2.Id = 32;
            this.barButtonItem2.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.showcontainerheader;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 529);
            this.Controls.Add(this.navigationFrame);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.Image = global::Commands_Runner.Properties.Resources.icon;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 260);
            this.Name = "Main";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Command Executer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandsModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationFrame)).EndInit();
            this.navigationFrame.ResumeLayout(false);
            this.npCommands.ResumeLayout(false);
            this.npPasswords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPasswords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPasswords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
		private DevExpress.XtraGrid.GridControl gcCommands;
		private System.Windows.Forms.BindingSource commandsModelBindingSource;
		private DevExpress.XtraGrid.Views.Tile.TileView tvCommands;
		private DevExpress.XtraGrid.Columns.TileViewColumn colId;
		private DevExpress.XtraGrid.Columns.TileViewColumn colName;
		private DevExpress.XtraGrid.Columns.TileViewColumn colDescription;
		private DevExpress.XtraGrid.Columns.TileViewColumn colType;
		private DevExpress.XtraGrid.Columns.TileViewColumn colCommand;
		private DevExpress.XtraBars.BarStaticItem bsiStatus;
		private DevExpress.XtraBars.BarStaticItem bsiTime;
		private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
		private DevExpress.XtraBars.BarButtonItem bbiNewCommand;
		private DevExpress.XtraBars.BarButtonItem bbiEdit;
		private DevExpress.XtraBars.PopupMenu popupMenu;
		private DevExpress.XtraBars.BarButtonItem bbiDelete;
		private System.Windows.Forms.Timer timer;
		private DevExpress.XtraBars.BarButtonItem bbiRefreshCommands;
		private DevExpress.XtraBars.BarStaticItem bsiVersion;
		private DevExpress.XtraGrid.Columns.TileViewColumn colEnabled;
		private DevExpress.XtraBars.BarButtonItem bbiEnabled;
		private DevExpress.XtraGrid.Columns.TileViewColumn colIcon;
		private DevExpress.XtraBars.BarButtonItem bbiRunAdmin;
		private DevExpress.XtraBars.BarEditItem beiSearch;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
		private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgFilters;
		private DevExpress.XtraBars.BarStaticItem bsiSizse;
		private DevExpress.XtraBars.BarButtonItem bbiImportCommands;
		private DevExpress.XtraBars.BarButtonItem bbiExportCommand;
		private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgMainPage;
		private DevExpress.XtraBars.BarSubItem bMenuCommands;
		private DevExpress.XtraBars.BarButtonItem bbiResetFormSize;
		private DevExpress.XtraBars.BarSubItem bMenuTools;
		private DevExpress.XtraBars.BarButtonItem bbiThreeSimpleRule;
		private DevExpress.XtraBars.BarSubItem bbiMenuCommandsFilters;
		private DevExpress.XtraBars.BarToggleSwitchItem btsiShowDisabled;
		private DevExpress.XtraBars.BarToggleSwitchItem btsiFilterCmd;
		private DevExpress.XtraBars.BarToggleSwitchItem btsiFilterPs1;
		private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem2;
		private DevExpress.XtraBars.BarToggleSwitchItem btsiFilterPy;
		private DevExpress.XtraBars.BarButtonItem bbiCreateFile;
		private DevExpress.XtraBars.BarButtonItem bbiTogglePassword;
		private DevExpress.XtraBars.Navigation.NavigationFrame navigationFrame;
		private DevExpress.XtraBars.Navigation.NavigationPage npCommands;
		private DevExpress.XtraBars.Navigation.NavigationPage npPasswords;
		private DevExpress.XtraGrid.GridControl gcPasswords;
		private DevExpress.XtraGrid.Views.Grid.GridView gvPasswords;
		private System.Windows.Forms.BindingSource passwordsModelBindingSource;
		private DevExpress.XtraGrid.Columns.GridColumn colId1;
		private DevExpress.XtraGrid.Columns.GridColumn colName1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem1;
		private DevExpress.XtraBars.BarButtonItem barButtonItem2;
		private DevExpress.XtraGrid.Columns.GridColumn colPassword;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
		private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl2;
		private LayoutControl layoutControl1;
		private PanelControl panelControl1;
		private LayoutControlGroup Root;
		private LayoutControlItem layoutControlItem1;
		private DevExpress.XtraGrid.Columns.GridColumn gcPasswordsAction;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
	}
}

