using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace Commands_Runner
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.bsiStatus = new DevExpress.XtraBars.BarStaticItem();
            this.bsiTime = new DevExpress.XtraBars.BarStaticItem();
            this.bbiNewCommand = new DevExpress.XtraBars.BarButtonItem();
            this.bsiVersion = new DevExpress.XtraBars.BarStaticItem();
            this.bsiSizse = new DevExpress.XtraBars.BarStaticItem();
            this.bbiThreeSimpleRule = new DevExpress.XtraBars.BarButtonItem();
            this.btsSetTopMost = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.bbiConverterHtmPNG = new DevExpress.XtraBars.BarButtonItem();
            this.bsiSQLState = new DevExpress.XtraBars.BarStaticItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rpgMainPage = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rpgFilters = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.commandsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.popupMenu = new DevExpress.XtraBars.PopupMenu(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.barToggleSwitchItem2 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.navigationPaneEx = new Life_Log.Components.NavigationPaneEx();
            this.npPasswordsListView = new Life_Log.Components.NavigationPageEx();
            this.passwordsListView = new Commands_Runner.Views.PasswordsListView();
            this.npCommandsListView = new Life_Log.Components.NavigationPageEx();
            this.commandsListView = new Commands_Runner.Views.CommandsListView();
            this.npPrimaveraExtensions = new Life_Log.Components.NavigationPageEx();
            this.priExtensionsListView1 = new Commands_Runner.Views.PriExtensionsListView();
            this.npSettingsView = new Life_Log.Components.NavigationPageEx();
            this.settingsView = new Commands_Runner.Views.SettingsView();
            this.npNoteView = new Life_Log.Components.NavigationPageEx();
            this.notesView = new Commands_Runner.Views.NotesListView();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.tasksView1 = new Commands_Runner.Views.TasksView();
            this.passwordsModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandsModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneEx)).BeginInit();
            this.navigationPaneEx.SuspendLayout();
            this.npPasswordsListView.SuspendLayout();
            this.npCommandsListView.SuspendLayout();
            this.npPrimaveraExtensions.SuspendLayout();
            this.npSettingsView.SuspendLayout();
            this.npNoteView.SuspendLayout();
            this.navigationPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.passwordsModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            this.SuspendLayout();
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
            this.bsiVersion,
            this.bsiSizse,
            this.bbiThreeSimpleRule,
            this.btsSetTopMost,
            this.bbiConverterHtmPNG,
            this.bsiSQLState});
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 45;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.OptionsSearchMenu.SearchItemPosition = DevExpress.XtraBars.Ribbon.SearchItemPosition.Caption;
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
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
            this.bsiStatus.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bsiStatus.ImageOptions.SvgImage")));
            this.bsiStatus.Name = "bsiStatus";
            this.bsiStatus.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bsiTime
            // 
            this.bsiTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiTime.Caption = "Time: 2024/09/14 11:50";
            this.bsiTime.Id = 3;
            this.bsiTime.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bsiTime.ImageOptions.SvgImage")));
            this.bsiTime.Name = "bsiTime";
            this.bsiTime.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiNewCommand
            // 
            this.bbiNewCommand.Caption = "New ";
            this.bbiNewCommand.Id = 5;
            this.bbiNewCommand.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiNewCommand.ImageOptions.SvgImage")));
            this.bbiNewCommand.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N));
            this.bbiNewCommand.Name = "bbiNewCommand";
            this.bbiNewCommand.ShowItemShortcut = DevExpress.Utils.DefaultBoolean.False;
            // 
            // bsiVersion
            // 
            this.bsiVersion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiVersion.Caption = "v1.0.0.3";
            this.bsiVersion.Id = 10;
            this.bsiVersion.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bsiVersion.ImageOptions.SvgImage")));
            this.bsiVersion.Name = "bsiVersion";
            this.bsiVersion.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bsiSizse
            // 
            this.bsiSizse.Caption = "Size";
            this.bsiSizse.Id = 17;
            this.bsiSizse.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bsiSizse.ImageOptions.SvgImage")));
            this.bsiSizse.Name = "bsiSizse";
            this.bsiSizse.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiThreeSimpleRule
            // 
            this.bbiThreeSimpleRule.Caption = "Three Simple Rule";
            this.bbiThreeSimpleRule.Id = 23;
            this.bbiThreeSimpleRule.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiThreeSimpleRule.ImageOptions.SvgImage")));
            this.bbiThreeSimpleRule.Name = "bbiThreeSimpleRule";
            this.bbiThreeSimpleRule.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiThreeSimpleRule_ItemClick);
            // 
            // btsSetTopMost
            // 
            this.btsSetTopMost.Caption = "Top Most";
            this.btsSetTopMost.Id = 42;
            this.btsSetTopMost.Name = "btsSetTopMost";
            this.btsSetTopMost.VisibleInSearchMenu = false;
            this.btsSetTopMost.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.btsSetTopMost_CheckedChanged);
            // 
            // bbiConverterHtmPNG
            // 
            this.bbiConverterHtmPNG.Caption = "HTM to IMG";
            this.bbiConverterHtmPNG.Id = 43;
            this.bbiConverterHtmPNG.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("bbiConverterHtmPNG.ImageOptions.SvgImage")));
            this.bbiConverterHtmPNG.Name = "bbiConverterHtmPNG";
            this.bbiConverterHtmPNG.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiConverterHtmPNG_ItemClick);
            // 
            // bsiSQLState
            // 
            this.bsiSQLState.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.bsiSQLState.Caption = "SQL";
            this.bsiSQLState.Id = 44;
            this.bsiSQLState.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.actions_deletecircled;
            this.bsiSQLState.Name = "bsiSQLState";
            this.bsiSQLState.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
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
            this.rpgMainPage.ItemLinks.Add(this.bbiConverterHtmPNG);
            this.rpgMainPage.ItemLinks.Add(this.bbiThreeSimpleRule);
            this.rpgMainPage.Name = "rpgMainPage";
            this.rpgMainPage.Text = "Main Page";
            // 
            // rpgFilters
            // 
            this.rpgFilters.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.rpgFilters.ItemLinks.Add(this.btsSetTopMost);
            this.rpgFilters.Name = "rpgFilters";
            this.rpgFilters.Text = "Filters";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiStatus);
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiTime);
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiVersion);
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiSizse);
            this.ribbonStatusBar1.ItemLinks.Add(this.bsiSQLState);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 607);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(998, 37);
            // 
            // commandsModelBindingSource
            // 
            this.commandsModelBindingSource.DataSource = typeof(Commands_Runner.Models.CommandModel);
            // 
            // popupMenu
            // 
            this.popupMenu.ItemLinks.Add(this.bbiNewCommand);
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
            this.barToggleSwitchItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barToggleSwitchItem2.ImageOptions.SvgImage")));
            this.barToggleSwitchItem2.Name = "barToggleSwitchItem2";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.navigationPaneEx);
            this.panelControl1.Location = new System.Drawing.Point(16, 16);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(966, 492);
            this.panelControl1.TabIndex = 0;
            // 
            // navigationPaneEx
            // 
            this.navigationPaneEx.Controls.Add(this.npPasswordsListView);
            this.navigationPaneEx.Controls.Add(this.npCommandsListView);
            this.navigationPaneEx.Controls.Add(this.npPrimaveraExtensions);
            this.navigationPaneEx.Controls.Add(this.npSettingsView);
            this.navigationPaneEx.Controls.Add(this.npNoteView);
            this.navigationPaneEx.Controls.Add(this.navigationPage1);
            this.navigationPaneEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navigationPaneEx.Location = new System.Drawing.Point(2, 2);
            this.navigationPaneEx.Name = "navigationPaneEx";
            this.navigationPaneEx.PageProperties.ShowCollapseButton = false;
            this.navigationPaneEx.PageProperties.ShowExpandButton = false;
            this.navigationPaneEx.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.navigationPaneEx.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.npCommandsListView,
            this.npPasswordsListView,
            this.npNoteView,
            this.npPrimaveraExtensions,
            this.npSettingsView,
            this.navigationPage1});
            this.navigationPaneEx.RegularSize = new System.Drawing.Size(962, 488);
            this.navigationPaneEx.SelectedPage = null;
            this.navigationPaneEx.Size = new System.Drawing.Size(962, 488);
            this.navigationPaneEx.State = DevExpress.XtraBars.Navigation.NavigationPaneState.Expanded;
            this.navigationPaneEx.TabIndex = 0;
            this.navigationPaneEx.Text = "Navigation";
            this.navigationPaneEx.SelectedPageChanged += new DevExpress.XtraBars.Navigation.SelectedPageChangedEventHandler(this.navigationPaneEx_SelectedPageChanged);
            // 
            // npPasswordsListView
            // 
            this.npPasswordsListView.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.npPasswordsListView.Caption = " Passwords";
            this.npPasswordsListView.Controls.Add(this.passwordsListView);
            this.npPasswordsListView.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.bo_user;
            this.npPasswordsListView.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.npPasswordsListView.Name = "npPasswordsListView";
            this.npPasswordsListView.Size = new System.Drawing.Size(816, 488);
            // 
            // passwordsListView
            // 
            this.passwordsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordsListView.Location = new System.Drawing.Point(0, 0);
            this.passwordsListView.Name = "passwordsListView";
            this.passwordsListView.Size = new System.Drawing.Size(816, 488);
            this.passwordsListView.TabIndex = 0;
            // 
            // npCommandsListView
            // 
            this.npCommandsListView.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.npCommandsListView.Caption = "Commands";
            this.npCommandsListView.Controls.Add(this.commandsListView);
            this.npCommandsListView.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.bo_category;
            this.npCommandsListView.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.npCommandsListView.Name = "npCommandsListView";
            this.npCommandsListView.Properties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.ImageAndText;
            this.npCommandsListView.Size = new System.Drawing.Size(816, 488);
            // 
            // commandsListView
            // 
            this.commandsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commandsListView.Location = new System.Drawing.Point(0, 0);
            this.commandsListView.Name = "commandsListView";
            this.commandsListView.Size = new System.Drawing.Size(816, 488);
            this.commandsListView.TabIndex = 0;
            // 
            // npPrimaveraExtensions
            // 
            this.npPrimaveraExtensions.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.npPrimaveraExtensions.Caption = " Pri Extensions";
            this.npPrimaveraExtensions.Controls.Add(this.priExtensionsListView1);
            this.npPrimaveraExtensions.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.bo_document;
            this.npPrimaveraExtensions.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.npPrimaveraExtensions.Name = "npPrimaveraExtensions";
            this.npPrimaveraExtensions.PageEnabled = false;
            this.npPrimaveraExtensions.Size = new System.Drawing.Size(962, 488);
            // 
            // priExtensionsListView1
            // 
            this.priExtensionsListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priExtensionsListView1.Location = new System.Drawing.Point(0, 0);
            this.priExtensionsListView1.Name = "priExtensionsListView1";
            this.priExtensionsListView1.Size = new System.Drawing.Size(962, 488);
            this.priExtensionsListView1.TabIndex = 0;
            // 
            // npSettingsView
            // 
            this.npSettingsView.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.npSettingsView.Caption = "Settings";
            this.npSettingsView.Controls.Add(this.settingsView);
            this.npSettingsView.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("npSettingsView.ImageOptions.SvgImage")));
            this.npSettingsView.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.npSettingsView.Name = "npSettingsView";
            this.npSettingsView.Size = new System.Drawing.Size(816, 488);
            // 
            // settingsView
            // 
            this.settingsView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsView.Location = new System.Drawing.Point(0, 0);
            this.settingsView.Name = "settingsView";
            this.settingsView.Size = new System.Drawing.Size(816, 488);
            this.settingsView.TabIndex = 0;
            // 
            // npNoteView
            // 
            this.npNoteView.BackgroundPadding = new System.Windows.Forms.Padding(0);
            this.npNoteView.Caption = " Notes";
            this.npNoteView.Controls.Add(this.notesView);
            this.npNoteView.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.bo_note;
            this.npNoteView.ImageOptions.SvgImageSize = new System.Drawing.Size(24, 24);
            this.npNoteView.Name = "npNoteView";
            this.npNoteView.Size = new System.Drawing.Size(816, 488);
            // 
            // notesView
            // 
            this.notesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.notesView.Location = new System.Drawing.Point(0, 0);
            this.notesView.Name = "notesView";
            this.notesView.Size = new System.Drawing.Size(816, 488);
            this.notesView.TabIndex = 0;
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "navigationPage1";
            this.navigationPage1.Controls.Add(this.tasksView1);
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.PageVisible = false;
            this.navigationPage1.Size = new System.Drawing.Size(783, 429);
            // 
            // tasksView1
            // 
            this.tasksView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksView1.Location = new System.Drawing.Point(0, 0);
            this.tasksView1.Name = "tasksView1";
            this.tasksView1.Size = new System.Drawing.Size(783, 429);
            this.tasksView1.TabIndex = 0;
            // 
            // passwordsModelBindingSource
            // 
            this.passwordsModelBindingSource.DataSource = typeof(Commands_Runner.Models.PasswordModel);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Show";
            this.barButtonItem1.Id = 32;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Show";
            this.barButtonItem2.Id = 32;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.panelControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 83);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(998, 524);
            this.layoutControl1.TabIndex = 10;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(998, 524);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.panelControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(972, 498);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 644);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("MainForm.IconOptions.Image")));
            this.MinimumSize = new System.Drawing.Size(600, 260);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Command Executer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Resize += new System.EventHandler(this.Main_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commandsModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navigationPaneEx)).EndInit();
            this.navigationPaneEx.ResumeLayout(false);
            this.npPasswordsListView.ResumeLayout(false);
            this.npCommandsListView.ResumeLayout(false);
            this.npPrimaveraExtensions.ResumeLayout(false);
            this.npSettingsView.ResumeLayout(false);
            this.npNoteView.ResumeLayout(false);
            this.navigationPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.passwordsModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private System.Windows.Forms.BindingSource commandsModelBindingSource;
        private DevExpress.XtraBars.BarStaticItem bsiTime;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem bbiNewCommand;
        private DevExpress.XtraBars.PopupMenu popupMenu;
        private System.Windows.Forms.Timer timer;
        private DevExpress.XtraBars.BarStaticItem bsiVersion;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgFilters;
        private DevExpress.XtraBars.BarStaticItem bsiSizse;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rpgMainPage;
        private DevExpress.XtraBars.BarButtonItem bbiThreeSimpleRule;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem2;
        private System.Windows.Forms.BindingSource passwordsModelBindingSource;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private PanelControl panelControl1;
        private DevExpress.XtraBars.BarToggleSwitchItem btsSetTopMost;
        private DevExpress.XtraBars.BarButtonItem bbiConverterHtmPNG;
        private LayoutControl layoutControl1;
        private LayoutControlGroup Root;
        private Life_Log.Components.NavigationPageEx npPasswordsListView;
        private LayoutControlItem layoutControlItem1;
        private Life_Log.Components.NavigationPageEx npCommandsListView;
        private Views.CommandsListView commandsListView;
        public DevExpress.XtraBars.BarStaticItem bsiStatus;
        private Views.PriExtensionsListView priExtensionsListView1;
        private Views.PasswordsListView passwordsListView;
        public Life_Log.Components.NavigationPageEx npPrimaveraExtensions;
        private Life_Log.Components.NavigationPageEx npSettingsView;
        private Views.SettingsView settingsView;
        public DevExpress.XtraBars.BarStaticItem bsiSQLState;
        private Life_Log.Components.NavigationPageEx npNoteView;
        private Views.NotesListView notesView;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private Views.TasksView tasksView1;
        public Life_Log.Components.NavigationPaneEx navigationPaneEx;
    }
}

