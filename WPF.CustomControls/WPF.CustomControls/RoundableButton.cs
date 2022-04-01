using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF.CustomControls
{
    /// <summary>A normal button with a CornerRadius Property.</summary>
    public class RoundableButton : Button
    {
        #region Properties

        /// <summary>Gets or sets the corner radius for the button.</summary>
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(RoundableButton), new PropertyMetadata(null));

        #endregion

        #region Constructors

        static RoundableButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RoundableButton), new FrameworkPropertyMetadata(typeof(RoundableButton)));
        }

        #endregion
    }
}
