namespace Commands_Runner.Forms
{
    partial class ExtensionsEditorForm
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
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnGuardar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiCancelar = new DevExpress.XtraBars.BarButtonItem();
            this.bbiReadFile = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ccbeCompanys = new DevExpress.XtraEditors.CheckedComboBoxEdit();
            this.empresasModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teID = new DevExpress.XtraEditors.TextEdit();
            this.seExecutionQueue = new DevExpress.XtraEditors.SpinEdit();
            this.tsIsActive = new DevExpress.XtraEditors.ToggleSwitch();
            this.tsCommonExtension = new DevExpress.XtraEditors.ToggleSwitch();
            this.tsIsSystem = new DevExpress.XtraEditors.ToggleSwitch();
            this.teAssemblyName = new DevExpress.XtraEditors.TextEdit();
            this.teHashCode = new DevExpress.XtraEditors.TextEdit();
            this.teFileVersion = new DevExpress.XtraEditors.TextEdit();
            this.teFileName = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ccbeCompanys.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seExecutionQueue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsIsActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsCommonExtension.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsIsSystem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAssemblyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHashCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFileVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFileName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationCaption = "Commands Runner";
            this.ribbon.ApplicationDocumentCaption = "Extensions";
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ItemPanelStyle = DevExpress.XtraBars.Ribbon.RibbonItemPanelStyle.Classic;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnGuardar,
            this.bbiCancelar,
            this.bbiReadFile});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.RibbonCaptionAlignment = DevExpress.XtraBars.Ribbon.RibbonCaptionAlignment.Center;
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.OfficeUniversal;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(598, 87);
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Caption = "Guardar";
            this.btnGuardar.Id = 1;
            this.btnGuardar.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.saveas;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuardar_ItemClick);
            // 
            // bbiCancelar
            // 
            this.bbiCancelar.Caption = "Cancelar";
            this.bbiCancelar.Id = 2;
            this.bbiCancelar.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.del;
            this.bbiCancelar.Name = "bbiCancelar";
            this.bbiCancelar.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiCancelar_ItemClick);
            // 
            // bbiReadFile
            // 
            this.bbiReadFile.Caption = "Read File";
            this.bbiReadFile.Id = 3;
            this.bbiReadFile.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.import;
            this.bbiReadFile.Name = "bbiReadFile";
            this.bbiReadFile.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiReadFile_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup
            // 
            this.ribbonPageGroup.ItemLinks.Add(this.bbiReadFile);
            this.ribbonPageGroup.ItemLinks.Add(this.btnGuardar);
            this.ribbonPageGroup.ItemLinks.Add(this.bbiCancelar);
            this.ribbonPageGroup.Name = "ribbonPageGroup";
            // 
            // layoutControl1
            // 
            this.layoutControl1.AllowDrop = true;
            this.layoutControl1.Controls.Add(this.ccbeCompanys);
            this.layoutControl1.Controls.Add(this.teID);
            this.layoutControl1.Controls.Add(this.seExecutionQueue);
            this.layoutControl1.Controls.Add(this.tsIsActive);
            this.layoutControl1.Controls.Add(this.tsCommonExtension);
            this.layoutControl1.Controls.Add(this.tsIsSystem);
            this.layoutControl1.Controls.Add(this.teAssemblyName);
            this.layoutControl1.Controls.Add(this.teHashCode);
            this.layoutControl1.Controls.Add(this.teFileVersion);
            this.layoutControl1.Controls.Add(this.teFileName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 87);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(598, 392);
            this.layoutControl1.TabIndex = 2;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ccbeCompanys
            // 
            this.ccbeCompanys.Location = new System.Drawing.Point(16, 256);
            this.ccbeCompanys.MenuManager = this.ribbon;
            this.ccbeCompanys.Name = "ccbeCompanys";
            this.ccbeCompanys.Properties.AdvancedModeOptions.Label = "Empresas";
            this.ccbeCompanys.Properties.AllowMultiSelect = true;
            this.ccbeCompanys.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ccbeCompanys.Properties.DataSource = this.empresasModelBindingSource;
            this.ccbeCompanys.Properties.DisplayMember = "StringComcat";
            this.ccbeCompanys.Properties.IncrementalSearch = true;
            this.ccbeCompanys.Properties.ValueMember = "Codigo";
            this.ccbeCompanys.Size = new System.Drawing.Size(566, 42);
            this.ccbeCompanys.StyleController = this.layoutControl1;
            this.ccbeCompanys.TabIndex = 15;
            // 
            // empresasModelBindingSource
            // 
            this.empresasModelBindingSource.DataSource = typeof(Commands_Runner.Models.PrimaveraEmpresasModel);
            // 
            // teID
            // 
            this.teID.Location = new System.Drawing.Point(16, 16);
            this.teID.MenuManager = this.ribbon;
            this.teID.Name = "teID";
            this.teID.Properties.AdvancedModeOptions.Label = "ID";
            this.teID.Properties.ReadOnly = true;
            this.teID.Properties.UseReadOnlyAppearance = false;
            this.teID.Size = new System.Drawing.Size(566, 42);
            this.teID.StyleController = this.layoutControl1;
            this.teID.TabIndex = 12;
            // 
            // seExecutionQueue
            // 
            this.seExecutionQueue.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seExecutionQueue.Location = new System.Drawing.Point(16, 160);
            this.seExecutionQueue.MenuManager = this.ribbon;
            this.seExecutionQueue.Name = "seExecutionQueue";
            this.seExecutionQueue.Properties.AdvancedModeOptions.Label = "Execution Queue";
            this.seExecutionQueue.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seExecutionQueue.Size = new System.Drawing.Size(566, 42);
            this.seExecutionQueue.StyleController = this.layoutControl1;
            this.seExecutionQueue.TabIndex = 11;
            // 
            // tsIsActive
            // 
            this.tsIsActive.AutoSizeInLayoutControl = true;
            this.tsIsActive.Location = new System.Drawing.Point(320, 352);
            this.tsIsActive.MenuManager = this.ribbon;
            this.tsIsActive.Name = "tsIsActive";
            this.tsIsActive.Properties.AutoWidth = true;
            this.tsIsActive.Properties.OffText = "Off";
            this.tsIsActive.Properties.OnText = "On";
            this.tsIsActive.Properties.ShowText = false;
            this.tsIsActive.Size = new System.Drawing.Size(50, 24);
            this.tsIsActive.StyleController = this.layoutControl1;
            this.tsIsActive.TabIndex = 10;
            // 
            // tsCommonExtension
            // 
            this.tsCommonExtension.AutoSizeInLayoutControl = true;
            this.tsCommonExtension.Location = new System.Drawing.Point(112, 352);
            this.tsCommonExtension.MenuManager = this.ribbon;
            this.tsCommonExtension.Name = "tsCommonExtension";
            this.tsCommonExtension.Properties.AutoWidth = true;
            this.tsCommonExtension.Properties.OffText = "Off";
            this.tsCommonExtension.Properties.OnText = "On";
            this.tsCommonExtension.Properties.ShowText = false;
            this.tsCommonExtension.Size = new System.Drawing.Size(50, 24);
            this.tsCommonExtension.StyleController = this.layoutControl1;
            this.tsCommonExtension.TabIndex = 9;
            // 
            // tsIsSystem
            // 
            this.tsIsSystem.AutoSizeInLayoutControl = true;
            this.tsIsSystem.Location = new System.Drawing.Point(532, 352);
            this.tsIsSystem.MenuManager = this.ribbon;
            this.tsIsSystem.Name = "tsIsSystem";
            this.tsIsSystem.Properties.AutoWidth = true;
            this.tsIsSystem.Properties.OffText = "Off";
            this.tsIsSystem.Properties.OnText = "On";
            this.tsIsSystem.Properties.ShowText = false;
            this.tsIsSystem.Size = new System.Drawing.Size(50, 24);
            this.tsIsSystem.StyleController = this.layoutControl1;
            this.tsIsSystem.TabIndex = 8;
            // 
            // teAssemblyName
            // 
            this.teAssemblyName.Location = new System.Drawing.Point(16, 304);
            this.teAssemblyName.MenuManager = this.ribbon;
            this.teAssemblyName.Name = "teAssemblyName";
            this.teAssemblyName.Properties.AdvancedModeOptions.Label = "Assembly Name";
            this.teAssemblyName.Size = new System.Drawing.Size(566, 42);
            this.teAssemblyName.StyleController = this.layoutControl1;
            this.teAssemblyName.TabIndex = 7;
            // 
            // teHashCode
            // 
            this.teHashCode.Location = new System.Drawing.Point(16, 208);
            this.teHashCode.MenuManager = this.ribbon;
            this.teHashCode.Name = "teHashCode";
            this.teHashCode.Properties.AdvancedModeOptions.Label = "HashCode";
            this.teHashCode.Size = new System.Drawing.Size(566, 42);
            this.teHashCode.StyleController = this.layoutControl1;
            this.teHashCode.TabIndex = 6;
            // 
            // teFileVersion
            // 
            this.teFileVersion.Location = new System.Drawing.Point(16, 112);
            this.teFileVersion.MenuManager = this.ribbon;
            this.teFileVersion.Name = "teFileVersion";
            this.teFileVersion.Properties.AdvancedModeOptions.Label = "File Version";
            this.teFileVersion.Size = new System.Drawing.Size(566, 42);
            this.teFileVersion.StyleController = this.layoutControl1;
            this.teFileVersion.TabIndex = 5;
            // 
            // teFileName
            // 
            this.teFileName.Location = new System.Drawing.Point(16, 64);
            this.teFileName.MenuManager = this.ribbon;
            this.teFileName.Name = "teFileName";
            this.teFileName.Properties.AdvancedModeOptions.Label = "File Name";
            this.teFileName.Size = new System.Drawing.Size(566, 42);
            this.teFileName.StyleController = this.layoutControl1;
            this.teFileName.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem9,
            this.layoutControlItem8,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.layoutControlItem12});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(598, 392);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.teFileName;
            this.layoutControlItem1.CustomizationFormText = "File Name";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(572, 48);
            this.layoutControlItem1.Text = "File Name";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.teFileVersion;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 96);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(572, 48);
            this.layoutControlItem2.Text = "File Version";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.teHashCode;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 192);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(572, 48);
            this.layoutControlItem3.Text = "HashCode";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.teAssemblyName;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 288);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(572, 48);
            this.layoutControlItem4.Text = "Assembly Name";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.tsIsSystem;
            this.layoutControlItem5.Location = new System.Drawing.Point(464, 336);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(108, 30);
            this.layoutControlItem5.Text = "Is System";
            this.layoutControlItem5.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(47, 13);
            this.layoutControlItem5.TextToControlDistance = 5;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.layoutControlItem6.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControlItem6.Control = this.tsCommonExtension;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 336);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(152, 30);
            this.layoutControlItem6.Text = "Common Extension";
            this.layoutControlItem6.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(91, 13);
            this.layoutControlItem6.TextToControlDistance = 5;
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.tsIsActive;
            this.layoutControlItem7.Location = new System.Drawing.Point(257, 336);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(103, 30);
            this.layoutControlItem7.Text = "Is Active";
            this.layoutControlItem7.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(42, 13);
            this.layoutControlItem7.TextToControlDistance = 5;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.teID;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(572, 48);
            this.layoutControlItem9.Text = "ID";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.seExecutionQueue;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 144);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(572, 48);
            this.layoutControlItem8.Text = "Execution Queue";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(360, 336);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(104, 30);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(152, 336);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(105, 30);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.ccbeCompanys;
            this.layoutControlItem12.Location = new System.Drawing.Point(0, 240);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(572, 48);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // ExtensionsEditorForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 479);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ribbon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.SvgImage = global::Commands_Runner.Properties.Resources.actions_edit;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtensionsEditorForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ccbeCompanys.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seExecutionQueue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsIsActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsCommonExtension.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsIsSystem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAssemblyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teHashCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFileVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFileName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit teHashCode;
        private DevExpress.XtraEditors.TextEdit teFileVersion;
        private DevExpress.XtraEditors.TextEdit teFileName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.ToggleSwitch tsIsActive;
        private DevExpress.XtraEditors.ToggleSwitch tsCommonExtension;
        private DevExpress.XtraEditors.ToggleSwitch tsIsSystem;
        private DevExpress.XtraEditors.TextEdit teAssemblyName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.TextEdit teID;
        private DevExpress.XtraEditors.SpinEdit seExecutionQueue;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraEditors.CheckedComboBoxEdit ccbeCompanys;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private System.Windows.Forms.BindingSource empresasModelBindingSource;
        private DevExpress.XtraBars.BarButtonItem btnGuardar;
        private DevExpress.XtraBars.BarButtonItem bbiCancelar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup;
        private DevExpress.XtraBars.BarButtonItem bbiReadFile;
    }
}