using DevExpress.XtraRichEdit;
using DevExpress.XtraTab;

namespace Commands_Runner.Views
{
    partial class NotesListView
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
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling1 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            DevExpress.XtraSpellChecker.OptionsSpelling optionsSpelling2 = new DevExpress.XtraSpellChecker.OptionsSpelling();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar = new DevExpress.XtraBars.Bar();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiSave = new DevExpress.XtraBars.BarButtonItem();
            this.bbiEditName = new DevExpress.XtraBars.BarButtonItem();
            this.bbiExport = new DevExpress.XtraBars.BarButtonItem();
            this.bbiImport = new DevExpress.XtraBars.BarButtonItem();
            this.fontBar1 = new DevExpress.XtraRichEdit.UI.FontBar();
            this.richEditControl2 = new DevExpress.XtraRichEdit.RichEditControl();
            this.spellChecker = new DevExpress.XtraSpellChecker.SpellChecker(this.components);
            this.changeFontNameItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontNameItem();
            this.repositoryItemFontEditRichEdit1 = new DevExpress.XtraRichEdit.UI.RepositoryItemFontEditRichEdit();
            this.changeFontSizeItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontSizeItem();
            this.repositoryItemRichEditFontSizeEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit();
            this.fontSizeIncreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem();
            this.fontSizeDecreaseItem1 = new DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem();
            this.toggleFontBoldItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontBoldItem();
            this.toggleFontItalicItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontItalicItem();
            this.toggleFontUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem();
            this.toggleFontDoubleUnderlineItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem();
            this.toggleFontStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem();
            this.toggleFontDoubleStrikeoutItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem();
            this.toggleFontSuperscriptItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem();
            this.toggleFontSubscriptItem1 = new DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem();
            this.changeFontColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontColorItem();
            this.changeFontHighlightColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeFontHighlightColorItem();
            this.changeTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ChangeTextCaseItem();
            this.makeTextUpperCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem();
            this.makeTextLowerCaseItem1 = new DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem();
            this.capitalizeEachWordCaseItem1 = new DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem();
            this.toggleTextCaseItem1 = new DevExpress.XtraRichEdit.UI.ToggleTextCaseItem();
            this.clearFormattingItem1 = new DevExpress.XtraRichEdit.UI.ClearFormattingItem();
            this.showFontFormItem1 = new DevExpress.XtraRichEdit.UI.ShowFontFormItem();
            this.paragraphBar1 = new DevExpress.XtraRichEdit.UI.ParagraphBar();
            this.toggleBulletedListItem1 = new DevExpress.XtraRichEdit.UI.ToggleBulletedListItem();
            this.toggleNumberingListItem1 = new DevExpress.XtraRichEdit.UI.ToggleNumberingListItem();
            this.toggleMultiLevelListItem1 = new DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem();
            this.decreaseIndentItem1 = new DevExpress.XtraRichEdit.UI.DecreaseIndentItem();
            this.increaseIndentItem1 = new DevExpress.XtraRichEdit.UI.IncreaseIndentItem();
            this.rtlToggleBulletedListItem1 = new DevExpress.XtraRichEdit.UI.RtlToggleBulletedListItem();
            this.rtlToggleNumberingListItem1 = new DevExpress.XtraRichEdit.UI.RtlToggleNumberingListItem();
            this.rtlToggleMultiLevelListItem1 = new DevExpress.XtraRichEdit.UI.RtlToggleMultiLevelListItem();
            this.rtlDecreaseIndentItem1 = new DevExpress.XtraRichEdit.UI.RtlDecreaseIndentItem();
            this.rtlIncreaseIndentItem1 = new DevExpress.XtraRichEdit.UI.RtlIncreaseIndentItem();
            this.toggleParagraphLeftToRightItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphLeftToRightItem();
            this.toggleParagraphRightToLeftItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphRightToLeftItem();
            this.toggleParagraphAlignmentLeftItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem();
            this.toggleParagraphAlignmentCenterItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem();
            this.toggleParagraphAlignmentRightItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem();
            this.toggleParagraphAlignmentJustifyItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem();
            this.toggleParagraphAlignmentArabicJustifyGroupItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentArabicJustifyGroupItem();
            this.toggleParagraphAlignmentArabicJustifyItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentArabicJustifyItem();
            this.toggleParagraphAlignmentJustifyLowItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyLowItem();
            this.toggleParagraphAlignmentJustifyMediumItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyMediumItem();
            this.toggleParagraphAlignmentJustifyHighItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyHighItem();
            this.toggleParagraphAlignmentDistributeItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentDistributeItem();
            this.toggleParagraphAlignmentThaiDistributeItem1 = new DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentThaiDistributeItem();
            this.toggleShowWhitespaceItem1 = new DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem();
            this.changeParagraphLineSpacingItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem();
            this.setSingleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem();
            this.setSesquialteralParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem();
            this.setDoubleParagraphSpacingItem1 = new DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem();
            this.showLineSpacingFormItem1 = new DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem();
            this.addSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem();
            this.removeSpacingBeforeParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem();
            this.addSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem();
            this.removeSpacingAfterParagraphItem1 = new DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem();
            this.changeParagraphBackColorItem1 = new DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem();
            this.showParagraphFormItem1 = new DevExpress.XtraRichEdit.UI.ShowParagraphFormItem();
            this.stylesBar1 = new DevExpress.XtraRichEdit.UI.StylesBar();
            this.changeStyleItem1 = new DevExpress.XtraRichEdit.UI.ChangeStyleItem();
            this.repositoryItemRichEditStyleEdit1 = new DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit();
            this.showEditStyleFormItem1 = new DevExpress.XtraRichEdit.UI.ShowEditStyleFormItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.pasteItem1 = new DevExpress.XtraRichEdit.UI.PasteItem();
            this.cutItem1 = new DevExpress.XtraRichEdit.UI.CutItem();
            this.copyItem1 = new DevExpress.XtraRichEdit.UI.CopyItem();
            this.pasteSpecialItem1 = new DevExpress.XtraRichEdit.UI.PasteSpecialItem();
            this.findItem1 = new DevExpress.XtraRichEdit.UI.FindItem();
            this.replaceItem1 = new DevExpress.XtraRichEdit.UI.ReplaceItem();
            this.repositoryItemSearchControl1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.richEditBarController = new DevExpress.XtraRichEdit.UI.RichEditBarController(this.components);
            this.spellChecker1 = new DevExpress.XtraSpellChecker.SpellChecker(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEditRichEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditStyleEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar,
            this.fontBar1,
            this.paragraphBar1,
            this.stylesBar1});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiExport,
            this.bbiImport,
            this.bbiSave,
            this.bbiNew,
            this.bbiEditName,
            this.pasteItem1,
            this.cutItem1,
            this.copyItem1,
            this.pasteSpecialItem1,
            this.changeFontNameItem1,
            this.changeFontSizeItem1,
            this.fontSizeIncreaseItem1,
            this.fontSizeDecreaseItem1,
            this.toggleFontBoldItem1,
            this.toggleFontItalicItem1,
            this.toggleFontUnderlineItem1,
            this.toggleFontDoubleUnderlineItem1,
            this.toggleFontStrikeoutItem1,
            this.toggleFontDoubleStrikeoutItem1,
            this.toggleFontSuperscriptItem1,
            this.toggleFontSubscriptItem1,
            this.changeFontColorItem1,
            this.changeFontHighlightColorItem1,
            this.changeTextCaseItem1,
            this.makeTextUpperCaseItem1,
            this.makeTextLowerCaseItem1,
            this.capitalizeEachWordCaseItem1,
            this.toggleTextCaseItem1,
            this.clearFormattingItem1,
            this.showFontFormItem1,
            this.toggleBulletedListItem1,
            this.toggleNumberingListItem1,
            this.toggleMultiLevelListItem1,
            this.decreaseIndentItem1,
            this.increaseIndentItem1,
            this.rtlToggleBulletedListItem1,
            this.rtlToggleNumberingListItem1,
            this.rtlToggleMultiLevelListItem1,
            this.rtlDecreaseIndentItem1,
            this.rtlIncreaseIndentItem1,
            this.toggleParagraphLeftToRightItem1,
            this.toggleParagraphRightToLeftItem1,
            this.toggleParagraphAlignmentLeftItem1,
            this.toggleParagraphAlignmentCenterItem1,
            this.toggleParagraphAlignmentRightItem1,
            this.toggleParagraphAlignmentJustifyItem1,
            this.toggleParagraphAlignmentArabicJustifyGroupItem1,
            this.toggleParagraphAlignmentArabicJustifyItem1,
            this.toggleParagraphAlignmentJustifyLowItem1,
            this.toggleParagraphAlignmentJustifyMediumItem1,
            this.toggleParagraphAlignmentJustifyHighItem1,
            this.toggleParagraphAlignmentDistributeItem1,
            this.toggleParagraphAlignmentThaiDistributeItem1,
            this.toggleShowWhitespaceItem1,
            this.changeParagraphLineSpacingItem1,
            this.setSingleParagraphSpacingItem1,
            this.setSesquialteralParagraphSpacingItem1,
            this.setDoubleParagraphSpacingItem1,
            this.showLineSpacingFormItem1,
            this.addSpacingBeforeParagraphItem1,
            this.removeSpacingBeforeParagraphItem1,
            this.addSpacingAfterParagraphItem1,
            this.removeSpacingAfterParagraphItem1,
            this.changeParagraphBackColorItem1,
            this.showParagraphFormItem1,
            this.changeStyleItem1,
            this.showEditStyleFormItem1,
            this.findItem1,
            this.replaceItem1});
            this.barManager.MaxItemId = 91;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemSearchControl1,
            this.repositoryItemTextEdit1,
            this.repositoryItemFontEditRichEdit1,
            this.repositoryItemRichEditFontSizeEdit1,
            this.repositoryItemRichEditStyleEdit1});
            // 
            // bar
            // 
            this.bar.BarName = "Main menu";
            this.bar.DockCol = 0;
            this.bar.DockRow = 0;
            this.bar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiNew, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiEditName, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiExport, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.bbiImport, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar.Offset = 9;
            this.bar.OptionsBar.AllowQuickCustomization = false;
            this.bar.OptionsBar.DisableCustomization = true;
            this.bar.OptionsBar.DrawBorder = false;
            this.bar.OptionsBar.DrawDragBorder = false;
            this.bar.Text = "Main menu";
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 25;
            this.bbiNew.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.actions_add;
            this.bbiNew.Name = "bbiNew";
            this.bbiNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiNew_ItemClick);
            // 
            // bbiSave
            // 
            this.bbiSave.Caption = "Save";
            this.bbiSave.Id = 24;
            this.bbiSave.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.saveas;
            this.bbiSave.Name = "bbiSave";
            this.bbiSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiSave_ItemClick);
            // 
            // bbiEditName
            // 
            this.bbiEditName.Caption = "Edit Name";
            this.bbiEditName.Id = 26;
            this.bbiEditName.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.actions_edit;
            this.bbiEditName.Name = "bbiEditName";
            this.bbiEditName.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiEditName_ItemClick);
            // 
            // bbiExport
            // 
            this.bbiExport.Caption = "Export";
            this.bbiExport.Id = 22;
            this.bbiExport.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.exportfile;
            this.bbiExport.Name = "bbiExport";
            this.bbiExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiExport_ItemClick);
            // 
            // bbiImport
            // 
            this.bbiImport.Caption = "Import";
            this.bbiImport.Id = 23;
            this.bbiImport.ImageOptions.SvgImage = global::Commands_Runner.Properties.Resources.exportfile;
            this.bbiImport.Name = "bbiImport";
            this.bbiImport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImport_ItemClick);
            // 
            // fontBar1
            // 
            this.fontBar1.Control = this.richEditControl2;
            this.fontBar1.DockCol = 0;
            this.fontBar1.DockRow = 2;
            this.fontBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.fontBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.changeFontNameItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "FF", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeFontSizeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.fontSizeIncreaseItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "FG", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.fontSizeDecreaseItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "FK", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontBoldItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontItalicItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontUnderlineItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontDoubleUnderlineItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontStrikeoutItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontDoubleStrikeoutItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontSuperscriptItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleFontSubscriptItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.changeFontColorItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "FC", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.changeFontHighlightColorItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "I", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.changeTextCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.clearFormattingItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "E", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.showFontFormItem1)});
            this.fontBar1.OptionsBar.AllowQuickCustomization = false;
            this.fontBar1.OptionsBar.DrawDragBorder = false;
            // 
            // richEditControl2
            // 
            this.richEditControl2.ActiveViewType = DevExpress.XtraRichEdit.RichEditViewType.Simple;
            this.richEditControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.richEditControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richEditControl2.LayoutUnit = DevExpress.XtraRichEdit.DocumentLayoutUnit.Pixel;
            this.richEditControl2.Location = new System.Drawing.Point(0, 0);
            this.richEditControl2.MenuManager = this.barManager;
            this.richEditControl2.Name = "richEditControl2";
            this.richEditControl2.Options.DocumentCapabilities.FootNotes = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.richEditControl2.Options.DocumentCapabilities.HeadersFooters = DevExpress.XtraRichEdit.DocumentCapability.Disabled;
            this.richEditControl2.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText;
            this.richEditControl2.Options.HorizontalRuler.ShowLeftIndent = false;
            this.richEditControl2.Options.HorizontalRuler.ShowRightIndent = false;
            this.richEditControl2.Options.HorizontalRuler.ShowTabs = false;
            this.richEditControl2.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden;
            this.richEditControl2.Size = new System.Drawing.Size(913, 397);
            this.richEditControl2.SpellChecker = this.spellChecker;
            this.spellChecker.SetSpellCheckerOptions(this.richEditControl2, optionsSpelling1);
            this.spellChecker1.SetSpellCheckerOptions(this.richEditControl2, optionsSpelling2);
            this.richEditControl2.TabIndex = 0;
            this.richEditControl2.Text = "Test";
            this.richEditControl2.UseWaitCursor = true;
            // 
            // spellChecker
            // 
            this.spellChecker.Culture = new System.Globalization.CultureInfo("pt-PT");
            this.spellChecker.ParentContainer = null;
            // 
            // changeFontNameItem1
            // 
            this.changeFontNameItem1.Edit = this.repositoryItemFontEditRichEdit1;
            this.changeFontNameItem1.Id = 31;
            this.changeFontNameItem1.Name = "changeFontNameItem1";
            // 
            // repositoryItemFontEditRichEdit1
            // 
            this.repositoryItemFontEditRichEdit1.AutoHeight = false;
            this.repositoryItemFontEditRichEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemFontEditRichEdit1.Name = "repositoryItemFontEditRichEdit1";
            // 
            // changeFontSizeItem1
            // 
            this.changeFontSizeItem1.Edit = this.repositoryItemRichEditFontSizeEdit1;
            this.changeFontSizeItem1.Id = 32;
            this.changeFontSizeItem1.Name = "changeFontSizeItem1";
            // 
            // repositoryItemRichEditFontSizeEdit1
            // 
            this.repositoryItemRichEditFontSizeEdit1.AutoHeight = false;
            this.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemRichEditFontSizeEdit1.Control = this.richEditControl2;
            this.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1";
            // 
            // fontSizeIncreaseItem1
            // 
            this.fontSizeIncreaseItem1.Id = 33;
            this.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1";
            // 
            // fontSizeDecreaseItem1
            // 
            this.fontSizeDecreaseItem1.Id = 34;
            this.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1";
            // 
            // toggleFontBoldItem1
            // 
            this.toggleFontBoldItem1.Id = 35;
            this.toggleFontBoldItem1.Name = "toggleFontBoldItem1";
            // 
            // toggleFontItalicItem1
            // 
            this.toggleFontItalicItem1.Id = 36;
            this.toggleFontItalicItem1.Name = "toggleFontItalicItem1";
            // 
            // toggleFontUnderlineItem1
            // 
            this.toggleFontUnderlineItem1.Id = 37;
            this.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1";
            // 
            // toggleFontDoubleUnderlineItem1
            // 
            this.toggleFontDoubleUnderlineItem1.Id = 38;
            this.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1";
            // 
            // toggleFontStrikeoutItem1
            // 
            this.toggleFontStrikeoutItem1.Id = 39;
            this.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1";
            // 
            // toggleFontDoubleStrikeoutItem1
            // 
            this.toggleFontDoubleStrikeoutItem1.Id = 40;
            this.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1";
            // 
            // toggleFontSuperscriptItem1
            // 
            this.toggleFontSuperscriptItem1.Id = 41;
            this.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1";
            // 
            // toggleFontSubscriptItem1
            // 
            this.toggleFontSubscriptItem1.Id = 42;
            this.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1";
            // 
            // changeFontColorItem1
            // 
            this.changeFontColorItem1.Id = 43;
            this.changeFontColorItem1.Name = "changeFontColorItem1";
            // 
            // changeFontHighlightColorItem1
            // 
            this.changeFontHighlightColorItem1.Id = 44;
            this.changeFontHighlightColorItem1.Name = "changeFontHighlightColorItem1";
            // 
            // changeTextCaseItem1
            // 
            this.changeTextCaseItem1.Id = 45;
            this.changeTextCaseItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.makeTextUpperCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.makeTextLowerCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.capitalizeEachWordCaseItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleTextCaseItem1)});
            this.changeTextCaseItem1.Name = "changeTextCaseItem1";
            // 
            // makeTextUpperCaseItem1
            // 
            this.makeTextUpperCaseItem1.Id = 46;
            this.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1";
            // 
            // makeTextLowerCaseItem1
            // 
            this.makeTextLowerCaseItem1.Id = 47;
            this.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1";
            // 
            // capitalizeEachWordCaseItem1
            // 
            this.capitalizeEachWordCaseItem1.Id = 48;
            this.capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1";
            // 
            // toggleTextCaseItem1
            // 
            this.toggleTextCaseItem1.Id = 49;
            this.toggleTextCaseItem1.Name = "toggleTextCaseItem1";
            // 
            // clearFormattingItem1
            // 
            this.clearFormattingItem1.Id = 50;
            this.clearFormattingItem1.Name = "clearFormattingItem1";
            // 
            // showFontFormItem1
            // 
            this.showFontFormItem1.Id = 51;
            this.showFontFormItem1.Name = "showFontFormItem1";
            // 
            // paragraphBar1
            // 
            this.paragraphBar1.Control = this.richEditControl2;
            this.paragraphBar1.DockCol = 1;
            this.paragraphBar1.DockRow = 1;
            this.paragraphBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.paragraphBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.toggleBulletedListItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "U", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.toggleNumberingListItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "N", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.toggleMultiLevelListItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "M", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.decreaseIndentItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AO", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.increaseIndentItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AI", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.rtlToggleBulletedListItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "U", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.rtlToggleNumberingListItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "N", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.rtlToggleMultiLevelListItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "M", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.rtlDecreaseIndentItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AO", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.rtlIncreaseIndentItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AI", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphLeftToRightItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphRightToLeftItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.toggleParagraphAlignmentLeftItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AL", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.toggleParagraphAlignmentCenterItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AC", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.toggleParagraphAlignmentRightItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AR", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.toggleParagraphAlignmentJustifyItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AJ", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphAlignmentArabicJustifyGroupItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphAlignmentDistributeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphAlignmentThaiDistributeItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleShowWhitespaceItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.changeParagraphLineSpacingItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "K", ""),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.changeParagraphBackColorItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "H", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.showParagraphFormItem1)});
            this.paragraphBar1.Offset = 11;
            this.paragraphBar1.OptionsBar.AllowQuickCustomization = false;
            this.paragraphBar1.OptionsBar.DrawDragBorder = false;
            // 
            // toggleBulletedListItem1
            // 
            this.toggleBulletedListItem1.Id = 52;
            this.toggleBulletedListItem1.Name = "toggleBulletedListItem1";
            // 
            // toggleNumberingListItem1
            // 
            this.toggleNumberingListItem1.Id = 53;
            this.toggleNumberingListItem1.Name = "toggleNumberingListItem1";
            // 
            // toggleMultiLevelListItem1
            // 
            this.toggleMultiLevelListItem1.Id = 54;
            this.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1";
            // 
            // decreaseIndentItem1
            // 
            this.decreaseIndentItem1.Id = 55;
            this.decreaseIndentItem1.Name = "decreaseIndentItem1";
            // 
            // increaseIndentItem1
            // 
            this.increaseIndentItem1.Id = 56;
            this.increaseIndentItem1.Name = "increaseIndentItem1";
            // 
            // rtlToggleBulletedListItem1
            // 
            this.rtlToggleBulletedListItem1.Id = 57;
            this.rtlToggleBulletedListItem1.Name = "rtlToggleBulletedListItem1";
            // 
            // rtlToggleNumberingListItem1
            // 
            this.rtlToggleNumberingListItem1.Id = 58;
            this.rtlToggleNumberingListItem1.Name = "rtlToggleNumberingListItem1";
            // 
            // rtlToggleMultiLevelListItem1
            // 
            this.rtlToggleMultiLevelListItem1.Id = 59;
            this.rtlToggleMultiLevelListItem1.Name = "rtlToggleMultiLevelListItem1";
            // 
            // rtlDecreaseIndentItem1
            // 
            this.rtlDecreaseIndentItem1.Id = 60;
            this.rtlDecreaseIndentItem1.Name = "rtlDecreaseIndentItem1";
            // 
            // rtlIncreaseIndentItem1
            // 
            this.rtlIncreaseIndentItem1.Id = 61;
            this.rtlIncreaseIndentItem1.Name = "rtlIncreaseIndentItem1";
            // 
            // toggleParagraphLeftToRightItem1
            // 
            this.toggleParagraphLeftToRightItem1.Id = 62;
            this.toggleParagraphLeftToRightItem1.Name = "toggleParagraphLeftToRightItem1";
            // 
            // toggleParagraphRightToLeftItem1
            // 
            this.toggleParagraphRightToLeftItem1.Id = 63;
            this.toggleParagraphRightToLeftItem1.Name = "toggleParagraphRightToLeftItem1";
            // 
            // toggleParagraphAlignmentLeftItem1
            // 
            this.toggleParagraphAlignmentLeftItem1.Id = 64;
            this.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1";
            // 
            // toggleParagraphAlignmentCenterItem1
            // 
            this.toggleParagraphAlignmentCenterItem1.Id = 65;
            this.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1";
            // 
            // toggleParagraphAlignmentRightItem1
            // 
            this.toggleParagraphAlignmentRightItem1.Id = 66;
            this.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1";
            // 
            // toggleParagraphAlignmentJustifyItem1
            // 
            this.toggleParagraphAlignmentJustifyItem1.Id = 67;
            this.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1";
            // 
            // toggleParagraphAlignmentArabicJustifyGroupItem1
            // 
            this.toggleParagraphAlignmentArabicJustifyGroupItem1.Id = 68;
            this.toggleParagraphAlignmentArabicJustifyGroupItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.toggleParagraphAlignmentArabicJustifyItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "AJ", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphAlignmentJustifyLowItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphAlignmentJustifyMediumItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.toggleParagraphAlignmentJustifyHighItem1)});
            this.toggleParagraphAlignmentArabicJustifyGroupItem1.Name = "toggleParagraphAlignmentArabicJustifyGroupItem1";
            // 
            // toggleParagraphAlignmentArabicJustifyItem1
            // 
            this.toggleParagraphAlignmentArabicJustifyItem1.Id = 69;
            this.toggleParagraphAlignmentArabicJustifyItem1.Name = "toggleParagraphAlignmentArabicJustifyItem1";
            // 
            // toggleParagraphAlignmentJustifyLowItem1
            // 
            this.toggleParagraphAlignmentJustifyLowItem1.Id = 70;
            this.toggleParagraphAlignmentJustifyLowItem1.Name = "toggleParagraphAlignmentJustifyLowItem1";
            // 
            // toggleParagraphAlignmentJustifyMediumItem1
            // 
            this.toggleParagraphAlignmentJustifyMediumItem1.Id = 71;
            this.toggleParagraphAlignmentJustifyMediumItem1.Name = "toggleParagraphAlignmentJustifyMediumItem1";
            // 
            // toggleParagraphAlignmentJustifyHighItem1
            // 
            this.toggleParagraphAlignmentJustifyHighItem1.Id = 72;
            this.toggleParagraphAlignmentJustifyHighItem1.Name = "toggleParagraphAlignmentJustifyHighItem1";
            // 
            // toggleParagraphAlignmentDistributeItem1
            // 
            this.toggleParagraphAlignmentDistributeItem1.Id = 73;
            this.toggleParagraphAlignmentDistributeItem1.Name = "toggleParagraphAlignmentDistributeItem1";
            // 
            // toggleParagraphAlignmentThaiDistributeItem1
            // 
            this.toggleParagraphAlignmentThaiDistributeItem1.Id = 74;
            this.toggleParagraphAlignmentThaiDistributeItem1.Name = "toggleParagraphAlignmentThaiDistributeItem1";
            // 
            // toggleShowWhitespaceItem1
            // 
            this.toggleShowWhitespaceItem1.Id = 75;
            this.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1";
            // 
            // changeParagraphLineSpacingItem1
            // 
            this.changeParagraphLineSpacingItem1.Id = 76;
            this.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.setSingleParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setSesquialteralParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.setDoubleParagraphSpacingItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.showLineSpacingFormItem1),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, this.addSpacingBeforeParagraphItem1, "", false, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.Standard, "B", ""),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeSpacingBeforeParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.addSpacingAfterParagraphItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.removeSpacingAfterParagraphItem1)});
            this.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1";
            // 
            // setSingleParagraphSpacingItem1
            // 
            this.setSingleParagraphSpacingItem1.Id = 77;
            this.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1";
            // 
            // setSesquialteralParagraphSpacingItem1
            // 
            this.setSesquialteralParagraphSpacingItem1.Id = 78;
            this.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1";
            // 
            // setDoubleParagraphSpacingItem1
            // 
            this.setDoubleParagraphSpacingItem1.Id = 79;
            this.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1";
            // 
            // showLineSpacingFormItem1
            // 
            this.showLineSpacingFormItem1.Id = 80;
            this.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1";
            // 
            // addSpacingBeforeParagraphItem1
            // 
            this.addSpacingBeforeParagraphItem1.Id = 81;
            this.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1";
            // 
            // removeSpacingBeforeParagraphItem1
            // 
            this.removeSpacingBeforeParagraphItem1.Id = 82;
            this.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1";
            // 
            // addSpacingAfterParagraphItem1
            // 
            this.addSpacingAfterParagraphItem1.Id = 83;
            this.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1";
            // 
            // removeSpacingAfterParagraphItem1
            // 
            this.removeSpacingAfterParagraphItem1.Id = 84;
            this.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1";
            // 
            // changeParagraphBackColorItem1
            // 
            this.changeParagraphBackColorItem1.Id = 85;
            this.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1";
            // 
            // showParagraphFormItem1
            // 
            this.showParagraphFormItem1.Id = 86;
            this.showParagraphFormItem1.Name = "showParagraphFormItem1";
            // 
            // stylesBar1
            // 
            this.stylesBar1.Control = this.richEditControl2;
            this.stylesBar1.DockCol = 0;
            this.stylesBar1.DockRow = 1;
            this.stylesBar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.stylesBar1.FloatLocation = new System.Drawing.Point(1052, 90);
            this.stylesBar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.Width, this.changeStyleItem1, "", false, true, true, 117),
            new DevExpress.XtraBars.LinkPersistInfo(this.showEditStyleFormItem1)});
            this.stylesBar1.OptionsBar.AllowQuickCustomization = false;
            this.stylesBar1.OptionsBar.DrawBorder = false;
            // 
            // changeStyleItem1
            // 
            this.changeStyleItem1.Edit = this.repositoryItemRichEditStyleEdit1;
            this.changeStyleItem1.Id = 87;
            this.changeStyleItem1.Name = "changeStyleItem1";
            // 
            // repositoryItemRichEditStyleEdit1
            // 
            this.repositoryItemRichEditStyleEdit1.AutoHeight = false;
            this.repositoryItemRichEditStyleEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemRichEditStyleEdit1.Control = this.richEditControl2;
            this.repositoryItemRichEditStyleEdit1.Name = "repositoryItemRichEditStyleEdit1";
            // 
            // showEditStyleFormItem1
            // 
            this.showEditStyleFormItem1.Id = 88;
            this.showEditStyleFormItem1.Name = "showEditStyleFormItem1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager;
            this.barDockControlTop.Size = new System.Drawing.Size(947, 103);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 563);
            this.barDockControlBottom.Manager = this.barManager;
            this.barDockControlBottom.Size = new System.Drawing.Size(947, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 103);
            this.barDockControlLeft.Manager = this.barManager;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 460);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(947, 103);
            this.barDockControlRight.Manager = this.barManager;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 460);
            // 
            // pasteItem1
            // 
            this.pasteItem1.Id = 27;
            this.pasteItem1.Name = "pasteItem1";
            // 
            // cutItem1
            // 
            this.cutItem1.Id = 28;
            this.cutItem1.Name = "cutItem1";
            // 
            // copyItem1
            // 
            this.copyItem1.Id = 29;
            this.copyItem1.Name = "copyItem1";
            // 
            // pasteSpecialItem1
            // 
            this.pasteSpecialItem1.Id = 30;
            this.pasteSpecialItem1.Name = "pasteSpecialItem1";
            // 
            // findItem1
            // 
            this.findItem1.Id = 89;
            this.findItem1.Name = "findItem1";
            // 
            // replaceItem1
            // 
            this.replaceItem1.Id = 90;
            this.replaceItem1.Name = "replaceItem1";
            // 
            // repositoryItemSearchControl1
            // 
            this.repositoryItemSearchControl1.AutoHeight = false;
            this.repositoryItemSearchControl1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.repositoryItemSearchControl1.Name = "repositoryItemSearchControl1";
            this.repositoryItemSearchControl1.ShowDefaultButtonsMode = DevExpress.XtraEditors.Repository.ShowDefaultButtonsMode.AutoChangeSearchToClear;
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.xtraTabControl);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 103);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(947, 460);
            this.layoutControl1.TabIndex = 4;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl.BorderStylePage = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.xtraTabControl.HeaderButtons = ((DevExpress.XtraTab.TabButtons)((((DevExpress.XtraTab.TabButtons.Prev | DevExpress.XtraTab.TabButtons.Next) 
            | DevExpress.XtraTab.TabButtons.Close) 
            | DevExpress.XtraTab.TabButtons.Default)));
            this.xtraTabControl.Location = new System.Drawing.Point(16, 16);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl.Size = new System.Drawing.Size(915, 428);
            this.xtraTabControl.TabIndex = 4;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2});
            this.xtraTabControl.Visible = false;
            this.xtraTabControl.CloseButtonClick += new System.EventHandler(this.xtraTabControl_CloseButtonClick);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.richEditControl2);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(913, 397);
            this.xtraTabPage2.Text = "xtraTabPage2";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(947, 460);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.xtraTabControl;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(921, 434);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // richEditBarController
            // 
            this.richEditBarController.BarItems.Add(this.pasteItem1);
            this.richEditBarController.BarItems.Add(this.cutItem1);
            this.richEditBarController.BarItems.Add(this.copyItem1);
            this.richEditBarController.BarItems.Add(this.pasteSpecialItem1);
            this.richEditBarController.BarItems.Add(this.changeFontNameItem1);
            this.richEditBarController.BarItems.Add(this.changeFontSizeItem1);
            this.richEditBarController.BarItems.Add(this.fontSizeIncreaseItem1);
            this.richEditBarController.BarItems.Add(this.fontSizeDecreaseItem1);
            this.richEditBarController.BarItems.Add(this.toggleFontBoldItem1);
            this.richEditBarController.BarItems.Add(this.toggleFontItalicItem1);
            this.richEditBarController.BarItems.Add(this.toggleFontUnderlineItem1);
            this.richEditBarController.BarItems.Add(this.toggleFontDoubleUnderlineItem1);
            this.richEditBarController.BarItems.Add(this.toggleFontStrikeoutItem1);
            this.richEditBarController.BarItems.Add(this.toggleFontDoubleStrikeoutItem1);
            this.richEditBarController.BarItems.Add(this.toggleFontSuperscriptItem1);
            this.richEditBarController.BarItems.Add(this.toggleFontSubscriptItem1);
            this.richEditBarController.BarItems.Add(this.changeFontColorItem1);
            this.richEditBarController.BarItems.Add(this.changeFontHighlightColorItem1);
            this.richEditBarController.BarItems.Add(this.makeTextUpperCaseItem1);
            this.richEditBarController.BarItems.Add(this.makeTextLowerCaseItem1);
            this.richEditBarController.BarItems.Add(this.capitalizeEachWordCaseItem1);
            this.richEditBarController.BarItems.Add(this.toggleTextCaseItem1);
            this.richEditBarController.BarItems.Add(this.changeTextCaseItem1);
            this.richEditBarController.BarItems.Add(this.clearFormattingItem1);
            this.richEditBarController.BarItems.Add(this.showFontFormItem1);
            this.richEditBarController.BarItems.Add(this.toggleBulletedListItem1);
            this.richEditBarController.BarItems.Add(this.toggleNumberingListItem1);
            this.richEditBarController.BarItems.Add(this.toggleMultiLevelListItem1);
            this.richEditBarController.BarItems.Add(this.decreaseIndentItem1);
            this.richEditBarController.BarItems.Add(this.increaseIndentItem1);
            this.richEditBarController.BarItems.Add(this.rtlToggleBulletedListItem1);
            this.richEditBarController.BarItems.Add(this.rtlToggleNumberingListItem1);
            this.richEditBarController.BarItems.Add(this.rtlToggleMultiLevelListItem1);
            this.richEditBarController.BarItems.Add(this.rtlDecreaseIndentItem1);
            this.richEditBarController.BarItems.Add(this.rtlIncreaseIndentItem1);
            this.richEditBarController.BarItems.Add(this.toggleParagraphLeftToRightItem1);
            this.richEditBarController.BarItems.Add(this.toggleParagraphRightToLeftItem1);
            this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentLeftItem1);
            this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentCenterItem1);
            this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentRightItem1);
            this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentJustifyItem1);
            this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentArabicJustifyItem1);
            this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentJustifyLowItem1);
            this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentJustifyMediumItem1);
            this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentJustifyHighItem1);
            this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentArabicJustifyGroupItem1);
            this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentDistributeItem1);
            this.richEditBarController.BarItems.Add(this.toggleParagraphAlignmentThaiDistributeItem1);
            this.richEditBarController.BarItems.Add(this.toggleShowWhitespaceItem1);
            this.richEditBarController.BarItems.Add(this.setSingleParagraphSpacingItem1);
            this.richEditBarController.BarItems.Add(this.setSesquialteralParagraphSpacingItem1);
            this.richEditBarController.BarItems.Add(this.setDoubleParagraphSpacingItem1);
            this.richEditBarController.BarItems.Add(this.showLineSpacingFormItem1);
            this.richEditBarController.BarItems.Add(this.addSpacingBeforeParagraphItem1);
            this.richEditBarController.BarItems.Add(this.removeSpacingBeforeParagraphItem1);
            this.richEditBarController.BarItems.Add(this.addSpacingAfterParagraphItem1);
            this.richEditBarController.BarItems.Add(this.removeSpacingAfterParagraphItem1);
            this.richEditBarController.BarItems.Add(this.changeParagraphLineSpacingItem1);
            this.richEditBarController.BarItems.Add(this.changeParagraphBackColorItem1);
            this.richEditBarController.BarItems.Add(this.showParagraphFormItem1);
            this.richEditBarController.BarItems.Add(this.changeStyleItem1);
            this.richEditBarController.BarItems.Add(this.showEditStyleFormItem1);
            this.richEditBarController.BarItems.Add(this.findItem1);
            this.richEditBarController.BarItems.Add(this.replaceItem1);
            this.richEditBarController.Control = this.richEditControl2;
            // 
            // spellChecker1
            // 
            this.spellChecker1.Culture = new System.Globalization.CultureInfo("pt-PT");
            this.spellChecker1.ParentContainer = null;
            // 
            // NotesListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "NotesListView";
            this.Size = new System.Drawing.Size(947, 563);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemFontEditRichEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditFontSizeEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemRichEditStyleEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.richEditBarController)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar;
        private DevExpress.XtraBars.BarButtonItem bbiSave;
        private DevExpress.XtraBars.BarButtonItem bbiExport;
        private DevExpress.XtraBars.BarButtonItem bbiImport;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchControl repositoryItemSearchControl1;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        private DevExpress.XtraBars.BarButtonItem bbiEditName;
        private DevExpress.XtraRichEdit.UI.PasteItem pasteItem1;
        private DevExpress.XtraRichEdit.UI.CutItem cutItem1;
        private DevExpress.XtraRichEdit.UI.CopyItem copyItem1;
        private DevExpress.XtraRichEdit.UI.PasteSpecialItem pasteSpecialItem1;
        private DevExpress.XtraRichEdit.UI.FontBar fontBar1;
        private DevExpress.XtraRichEdit.UI.ChangeFontNameItem changeFontNameItem1;
        private DevExpress.XtraRichEdit.UI.RepositoryItemFontEditRichEdit repositoryItemFontEditRichEdit1;
        private DevExpress.XtraRichEdit.UI.ChangeFontSizeItem changeFontSizeItem1;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit repositoryItemRichEditFontSizeEdit1;
        private DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem fontSizeIncreaseItem1;
        private DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem fontSizeDecreaseItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontBoldItem toggleFontBoldItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontItalicItem toggleFontItalicItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem toggleFontUnderlineItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem toggleFontDoubleUnderlineItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem toggleFontStrikeoutItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem toggleFontDoubleStrikeoutItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem toggleFontSuperscriptItem1;
        private DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem toggleFontSubscriptItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFontColorItem changeFontColorItem1;
        private DevExpress.XtraRichEdit.UI.ChangeFontHighlightColorItem changeFontHighlightColorItem1;
        private DevExpress.XtraRichEdit.UI.ChangeTextCaseItem changeTextCaseItem1;
        private DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem makeTextUpperCaseItem1;
        private DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem makeTextLowerCaseItem1;
        private DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem capitalizeEachWordCaseItem1;
        private DevExpress.XtraRichEdit.UI.ToggleTextCaseItem toggleTextCaseItem1;
        private DevExpress.XtraRichEdit.UI.ClearFormattingItem clearFormattingItem1;
        private DevExpress.XtraRichEdit.UI.ShowFontFormItem showFontFormItem1;
        private DevExpress.XtraRichEdit.UI.ParagraphBar paragraphBar1;
        private DevExpress.XtraRichEdit.UI.ToggleBulletedListItem toggleBulletedListItem1;
        private DevExpress.XtraRichEdit.UI.ToggleNumberingListItem toggleNumberingListItem1;
        private DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem toggleMultiLevelListItem1;
        private DevExpress.XtraRichEdit.UI.DecreaseIndentItem decreaseIndentItem1;
        private DevExpress.XtraRichEdit.UI.IncreaseIndentItem increaseIndentItem1;
        private DevExpress.XtraRichEdit.UI.RtlToggleBulletedListItem rtlToggleBulletedListItem1;
        private DevExpress.XtraRichEdit.UI.RtlToggleNumberingListItem rtlToggleNumberingListItem1;
        private DevExpress.XtraRichEdit.UI.RtlToggleMultiLevelListItem rtlToggleMultiLevelListItem1;
        private DevExpress.XtraRichEdit.UI.RtlDecreaseIndentItem rtlDecreaseIndentItem1;
        private DevExpress.XtraRichEdit.UI.RtlIncreaseIndentItem rtlIncreaseIndentItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphLeftToRightItem toggleParagraphLeftToRightItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphRightToLeftItem toggleParagraphRightToLeftItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem toggleParagraphAlignmentLeftItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem toggleParagraphAlignmentCenterItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem toggleParagraphAlignmentRightItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem toggleParagraphAlignmentJustifyItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentArabicJustifyGroupItem toggleParagraphAlignmentArabicJustifyGroupItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentArabicJustifyItem toggleParagraphAlignmentArabicJustifyItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyLowItem toggleParagraphAlignmentJustifyLowItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyMediumItem toggleParagraphAlignmentJustifyMediumItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyHighItem toggleParagraphAlignmentJustifyHighItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentDistributeItem toggleParagraphAlignmentDistributeItem1;
        private DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentThaiDistributeItem toggleParagraphAlignmentThaiDistributeItem1;
        private DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem toggleShowWhitespaceItem1;
        private DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem changeParagraphLineSpacingItem1;
        private DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem setSingleParagraphSpacingItem1;
        private DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem setSesquialteralParagraphSpacingItem1;
        private DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem setDoubleParagraphSpacingItem1;
        private DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem showLineSpacingFormItem1;
        private DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem addSpacingBeforeParagraphItem1;
        private DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem removeSpacingBeforeParagraphItem1;
        private DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem addSpacingAfterParagraphItem1;
        private DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem removeSpacingAfterParagraphItem1;
        private DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem changeParagraphBackColorItem1;
        private DevExpress.XtraRichEdit.UI.ShowParagraphFormItem showParagraphFormItem1;
        private DevExpress.XtraRichEdit.UI.StylesBar stylesBar1;
        private DevExpress.XtraRichEdit.UI.ChangeStyleItem changeStyleItem1;
        private DevExpress.XtraRichEdit.Design.RepositoryItemRichEditStyleEdit repositoryItemRichEditStyleEdit1;
        private DevExpress.XtraRichEdit.UI.ShowEditStyleFormItem showEditStyleFormItem1;
        private DevExpress.XtraRichEdit.UI.FindItem findItem1;
        private DevExpress.XtraRichEdit.UI.ReplaceItem replaceItem1;
        private DevExpress.XtraRichEdit.UI.RichEditBarController richEditBarController;
        private XtraTabPage xtraTabPage2;
        private RichEditControl richEditControl2;
        private DevExpress.XtraSpellChecker.SpellChecker spellChecker;
        private DevExpress.XtraSpellChecker.SpellChecker spellChecker1;
    }
}
