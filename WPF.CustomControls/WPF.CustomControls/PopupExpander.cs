using System.Windows;
using System.Windows.Controls;

namespace WPF.CustomControls
{
    /// <summary>An Expander that presents its content in a Popup.</summary>
    public class PopupExpander : Expander
    {
        #region Properties

        /// <summary>Gets or sets the corner radius for the expander.</summary>
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(PopupExpander), new PropertyMetadata(null));

        /// <summary>Gets or sets whether or not the popup stays open or not. Default is false.</summary>
        public bool PopupStaysOpen
        {
            get { return (bool)GetValue(PopupStaysOpenProperty); }
            set { SetValue(PopupStaysOpenProperty, value); }
        }

        public static readonly DependencyProperty PopupStaysOpenProperty =
            DependencyProperty.Register("PopupStaysOpen", typeof(bool), typeof(PopupExpander), new PropertyMetadata(false));

        #endregion

        #region Constructors

        static PopupExpander()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PopupExpander), new FrameworkPropertyMetadata(typeof(PopupExpander)));
        }

        #endregion
    }
}
