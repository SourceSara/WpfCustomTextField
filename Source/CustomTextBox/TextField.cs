using System.Windows;
using System.Windows.Controls;

namespace CustomTextBox
{
    public class TextField : TextBox
    {
        #region Constructors

        static TextField()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(TextField),
                new FrameworkPropertyMetadata(typeof(TextField)));
        }

        #endregion

        #region DependencyProperty : Caption

        public static readonly DependencyProperty CaptionProperty =
            DependencyProperty.Register(nameof(Caption), typeof(object),
                typeof(TextField), new PropertyMetadata(default));

        public object Caption
        {
            get => GetValue(CaptionProperty);
            set => SetValue(CaptionProperty, value);
        }

        #endregion

        #region DependencyProperty : CaptionFontSize

        public static readonly DependencyProperty CaptionFontSizeProperty =
            DependencyProperty.Register(nameof(CaptionFontSize), typeof(double),
                typeof(TextField), new PropertyMetadata(default));

        public double CaptionFontSize
        {
            get => (double)GetValue(CaptionFontSizeProperty);
            set => SetValue(CaptionFontSizeProperty, value);
        }

        #endregion

        #region DependencyProperty : CaptionOpacity

        public static readonly DependencyProperty CaptionOpacityProperty =
            DependencyProperty.Register(nameof(CaptionOpacity), typeof(double),
                typeof(TextField), new PropertyMetadata(default));

        public double CaptionOpacity
        {
            get => (double)GetValue(CaptionOpacityProperty);
            set => SetValue(CaptionOpacityProperty, value);
        }

        #endregion

        #region DependencyProperty : CaptionAlignment

        public static readonly DependencyProperty CaptionAlignmentProperty =
            DependencyProperty.Register(nameof(CaptionAlignment), typeof(HorizontalAlignment),
                typeof(TextField), new PropertyMetadata(default));

        public HorizontalAlignment CaptionAlignment
        {
            get => (HorizontalAlignment)GetValue(CaptionAlignmentProperty);
            set => SetValue(CaptionAlignmentProperty, value);
        }

        #endregion

        #region DependencyProperty : CornerRadius

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius),
                typeof(TextField), new PropertyMetadata(default));

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        #endregion
    }
}
