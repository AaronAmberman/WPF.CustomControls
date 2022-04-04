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
    /// <summary>An Expander that presents its content in a Popup.</summary>
    public class PopupExpander : Expander
    {
        #region Constructors

        static PopupExpander()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PopupExpander), new FrameworkPropertyMetadata(typeof(PopupExpander)));
        }

        #endregion
    }
}
