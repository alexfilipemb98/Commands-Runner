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
            this.colName = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colId = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bsiStatus = new DevExpress.XtraBars.BarStaticItem();
            this.bsiTime = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.bsiVersion = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gcCommands = new DevExpress.XtraGrid.GridControl();
            this.commandsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tvCommands = new DevExpress.XtraGrid.Views.Tile.TileView();
            this.colType = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.colCommand = new DevExpress.XtraGrid.Columns.TileViewColumn();
            this.scComands = new DevExpress.XtraEditors.SearchControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandsModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvCommands)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scComands.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
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
            this.ribbonControl.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.ItemPanelStyle = DevExpress.XtraBars.Ribbon.RibbonItemPanelStyle.Classic;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl.ExpandCollapseItem,
            this.bsiStatus,
            this.bsiTime,
            this.bbiNew,
            this.bbiEdit,
            this.bbiDelete,
            this.bbiRefresh,
            this.bsiVersion});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 11;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbonControl.ShowPageKeyTipsMode = DevExpress.XtraBars.Ribbon.ShowPageKeyTipsMode.Hide;
            this.ribbonControl.ShowQatLocationSelector = false;
            this.ribbonControl.ShowToolbarCustomizeItem = false;
            this.ribbonControl.Size = new System.Drawing.Size(758, 49);
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
            // bbiNew
            // 
            this.bbiNew.Caption = "New ";
            this.bbiNew.Id = 5;
            this.bbiNew.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.actions_add;
            this.bbiNew.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
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
            // bbiRefresh
            // 
            this.bbiRefresh.Caption = "Refresh";
            this.bbiRefresh.Id = 9;
            this.bbiRefresh.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.actions_refresh;
            this.bbiRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.bbiRefresh.Name = "bbiRefresh";
            this.bbiRefresh.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            this.bbiRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiRefresh_ItemClick);
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
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiStatus);
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiTime);
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiVersion);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 362);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(758, 37);
            // 
            // gcCommands
            // 
            this.gcCommands.DataSource = this.commandsModelBindingSource;
            this.gcCommands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCommands.Location = new System.Drawing.Point(0, 102);
            this.gcCommands.MainView = this.tvCommands;
            this.gcCommands.MenuManager = this.ribbonControl;
            this.gcCommands.Name = "gcCommands";
            this.gcCommands.Size = new System.Drawing.Size(758, 260);
            this.gcCommands.TabIndex = 1;
            this.gcCommands.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tvCommands});
            // 
            // commandsModelBindingSource
            // 
            this.commandsModelBindingSource.DataSource = typeof(Commands_Runner.CommandsModel);
            // 
            // tvCommands
            // 
            this.tvCommands.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.tvCommands.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colName,
            this.colDescription,
            this.colType,
            this.colCommand});
            this.tvCommands.GridControl = this.gcCommands;
            this.tvCommands.Name = "tvCommands";
            this.tvCommands.OptionsBehavior.KeepFocusedRowOnUpdate = false;
            this.tvCommands.OptionsFind.ShowClearButton = false;
            this.tvCommands.OptionsFind.ShowCloseButton = false;
            this.tvCommands.OptionsTiles.HighlightFocusedTileStyle = DevExpress.XtraGrid.Views.Tile.HighlightFocusedTileStyle.None;
            this.tvCommands.OptionsTiles.IndentBetweenGroups = 10;
            this.tvCommands.OptionsTiles.IndentBetweenItems = 10;
            this.tvCommands.OptionsTiles.ItemPadding = new System.Windows.Forms.Padding(0);
            this.tvCommands.OptionsTiles.ItemSize = new System.Drawing.Size(200, 78);
            this.tvCommands.OptionsTiles.RowCount = 0;
            this.tvCommands.TileHtmlTemplate.Styles = resources.GetString("tvCommands.TileHtmlTemplate.Styles");
            this.tvCommands.TileHtmlTemplate.Template = "<div class=\"card Shadow\">\r\n\t<div class=\"title\">\r\n\t\t<span>${Id} - {Name}</span>\r\n\t" +
    "</div>\r\n\t<div>\r\n\t\t<span>${Description}</span>\r\n\t</div>\r\n\t<div class=\"footer\">\r\n\t" +
    "\t<span >${Type}</span>\r\n\t</div>\r\n</div>";
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
            this.tvCommands.ItemClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tvCommands_ItemClick);
            this.tvCommands.ItemRightClick += new DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventHandler(this.tvCommands_ItemRightClick);
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
            // scComands
            // 
            this.scComands.Client = this.gcCommands;
            this.scComands.Dock = System.Windows.Forms.DockStyle.Top;
            this.scComands.Location = new System.Drawing.Point(5, 5);
            this.scComands.MenuManager = this.ribbonControl;
            this.scComands.Name = "scComands";
            this.scComands.Properties.AdvancedModeOptions.Label = "Search command";
            this.scComands.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.scComands.Properties.Client = this.gcCommands;
            this.scComands.Size = new System.Drawing.Size(748, 42);
            this.scComands.TabIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.scComands);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 49);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Padding = new System.Windows.Forms.Padding(5);
            this.panelControl1.Size = new System.Drawing.Size(758, 53);
            this.panelControl1.TabIndex = 4;
            // 
            // popupMenu
            // 
            this.popupMenu.ItemLinks.Add(this.bbiRefresh);
            this.popupMenu.ItemLinks.Add(this.bbiNew);
            this.popupMenu.ItemLinks.Add(this.bbiEdit);
            this.popupMenu.ItemLinks.Add(this.bbiDelete, true);
            this.popupMenu.Name = "popupMenu";
            this.popupMenu.Ribbon = this.ribbonControl;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 399);
            this.Controls.Add(this.gcCommands);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Main.IconOptions.Image")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Command Executer";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandsModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvCommands)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scComands.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
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
        private DevExpress.XtraEditors.SearchControl scComands;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraBars.BarStaticItem bsiStatus;
        private DevExpress.XtraBars.BarStaticItem bsiTime;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEdit;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private DevExpress.XtraBars.BarButtonItem bbiDelete;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraBars.BarButtonItem bbiRefresh;
        private DevExpress.XtraBars.BarStaticItem bsiVersion;
    }
}

