using DevExpress.Utils;
using DevExpress.Utils.Drawing;
using DevExpress.XtraBars.Navigation;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace Life_Log.Components
{
    [ToolboxItem(true)]
    public class NavigationPaneEx : NavigationPane
    {
        public NavigationPaneEx() : base()
        {
            StateChanged += NavigationPaneEx_StateChanged;
            SelectedPageChanging += NavigationPaneEx_SelectedPageChanging; ;
        }

        private void NavigationPaneEx_StateChanged(object sender, StateChangedEventArgs e)
        {
            State = NavigationPaneState.Expanded;

        }

        private void NavigationPaneEx_SelectedPageChanging(object sender, SelectedPageChangingEventArgs e)
        {
            if (SelectedPage == e.Page)
                e.Cancel = true;
        }
    }

    public class NavigationPageEx : NavigationPage
    {
        public NavigationPageEx() : base()
        {

        }
        protected override NavigationPageViewInfo CreateViewInfo()
        {
            return new NavigationPageViewInfoEx(this);
        }
    }
    public class NavigationPageViewInfoEx : NavigationPageViewInfo
    {
        public NavigationPageViewInfoEx(INavigationPage owner) : base(owner)
        {

        }
        protected override Size CalcTextSize(GraphicsCache g, Rectangle clientBounds)
        {

            return Size.Empty;// base.CalcTextSize(g, clientBounds);
        }
        public override void CalcNC(GraphicsCache g, Rectangle bounds, ObjectPainter painter)
        {
            //  base.CalcNC(g, bounds, painter);
            if (Owner.IsDisposing) return;
            if (Owner is NavigationPage)
            {
                INavigationPage owner = Owner as NavigationPage;
                // UpdateDefaultButtonsVisibility();
                Bounds = bounds;
                var navigationPane = Owner.Parent as INavigationFrame;
                bool rightToLeft = navigationPane != null && navigationPane.IsRightToLeftLayout();
                owner.ButtonsPanel.ViewInfo.SetDirty();
                owner.ButtonsPanel.BeginUpdate();
                if (rightToLeft)
                {
                    owner.ButtonsPanel.RightToLeft = true;
                    owner.ButtonsPanel.ContentAlignment = ContentAlignment.MiddleLeft;
                }
                else
                {
                    owner.ButtonsPanel.RightToLeft = false;
                    owner.ButtonsPanel.ContentAlignment = ContentAlignment.MiddleRight;
                }
                owner.ButtonsPanel.CancelUpdate();
                var pagePainter = painter as NavigationPagePainter;
                if (Owner is NavigationPage)
                    AppearanceHelper.Combine(PaintAppearance, new AppearanceObject[] { (Owner as NavigationPage).Properties.ActualAppearanceCaption }, pagePainter.DefaultAppearanceCaption);
                PaintAppearance.TextOptions.RightToLeft = navigationPane != null && navigationPane.IsRightToLeft();
                if (PaintAppearance.TextOptions.HAlignment == HorzAlignment.Default)
                    PaintAppearance.TextOptions.HAlignment = HorzAlignment.Near;
                owner.ButtonsPanel.Buttons.Merge(owner.CustomHeaderButtons);
                int buttonsHeight = owner.ButtonsPanel.ViewInfo.CalcMinSize(g).Height;
                Rectangle captionClientBounds = painter.GetObjectClientRectangle(this);
                Size textSize = CalcTextSize(g, captionClientBounds);
                captionClientBounds = new Rectangle(captionClientBounds.Location, new Size(captionClientBounds.Width, Math.Max(buttonsHeight, textSize.Height)));
                CaptionBounds = Rectangle.Empty;// painter.CalcBoundsByClientRectangle(this, captionClientBounds);
                owner.ButtonsPanel.ViewInfo.SetDirty();
                owner.ButtonsPanel.ViewInfo.Calc(g, captionClientBounds);
                captionClientBounds.Width -= owner.ButtonsPanel.ViewInfo.Bounds.Width;
                if (rightToLeft)
                {
                    captionClientBounds.X += owner.ButtonsPanel.ViewInfo.Bounds.Width;
                    captionClientBounds.Width -= 0;
                }
                textSize.Width = captionClientBounds.Width;
                TextBounds = PlacementHelper.Arrange(textSize, captionClientBounds, ContentAlignment.MiddleCenter);
                BackgroundBounds = new Rectangle(bounds.X, CaptionBounds.Bottom, bounds.Width, bounds.Height - CaptionBounds.Height);
                ClientBounds = GetBackgroundObjectClientRectangle(pagePainter, BackgroundBounds);
            }
            else
            {
                CalcNCWithoutCaption(g, bounds, painter);
            }
        }
    }
}
