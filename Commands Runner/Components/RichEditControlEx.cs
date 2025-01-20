using DevExpress.Portable.Input;
using DevExpress.XtraRichEdit;
using DevExpress.XtraRichEdit.Internal;
using DevExpress.XtraRichEdit.Layout;
using DevExpress.XtraRichEdit.Mouse;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace Commands_Runner.Components
{
    [ToolboxItem(true)]
    public class RichEditControlEx : RichEditControl
    {
        public RichEditControlEx() : base()
        {
        }

        protected override InnerRichEditControl CreateInnerControl()
        {
            return new InnerControlEx(this);
        }

        private bool _FormatCalculatorEnabled;
        [DefaultValue(false)]
        public bool FormatCalculatorEnabled
        {
            get { return _FormatCalculatorEnabled; }
            set
            {
                _FormatCalculatorEnabled = value;
            }
        }

    }

    public class InnerControlEx : InnerRichEditControl
    {
        public InnerControlEx(IInnerRichEditControlOwner owner)
            : base(owner)
        {
        }

        protected override MouseCursorCalculator CreateMouseCursorCalculator() => new MouseCursorCalculatorEx(ActiveView);
    }

    public class MouseCursorCalculatorEx : MouseCursorCalculator
    {
        public MouseCursorCalculatorEx(RichEditView view) : base(view)
        {

        }

        public override IPortableCursor Calculate(RichEditHitTestResultCore hitTestResult, Point physicalPoint)
        {
            if ((View.Control as RichEditControlEx).FormatCalculatorEnabled)
                return DevExpress.XtraRichEdit.Utils.RichEditCursors.Hand;

            return base.Calculate(hitTestResult, physicalPoint);
        }
    }

}
