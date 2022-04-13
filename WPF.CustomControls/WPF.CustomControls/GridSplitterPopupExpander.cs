using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WPF.CustomControls
{
    /// <summary>An Expander that presents its content in a Popup and is resizable.</summary>
    public class GridSplitterPopupExpander : PopupExpander
    {
        #region Properties

        /// <summary>Gets or sets the background for the GridSplitter.</summary>
        public SolidColorBrush GridSplitterBackground
        {
            get { return (SolidColorBrush)GetValue(GridSplitterBackgroundProperty); }
            set { SetValue(GridSplitterBackgroundProperty, value); }
        }

        public static readonly DependencyProperty GridSplitterBackgroundProperty =
            DependencyProperty.Register("GridSplitterBackground", typeof(SolidColorBrush), typeof(GridSplitterPopupExpander), new PropertyMetadata(null));

        /// <summary>Gets or sets whether or not the GridSplitter updates the column or row size as the user drags the control. Default is false.</summary>
        /// <see cref="GridSplitter.ShowsPreview" />
        public bool GrisSplitterShowsPreview
        {
            get { return (bool)GetValue(GrisSplitterShowsPreviewProperty); }
            set { SetValue(GrisSplitterShowsPreviewProperty, value); }
        }

        public static readonly DependencyProperty GrisSplitterShowsPreviewProperty =
            DependencyProperty.Register("GrisSplitterShowsPreview", typeof(bool), typeof(GridSplitterPopupExpander), new PropertyMetadata(false));

        /// <summary>Gets or sets the maximum height for the popup. Default is double.PositiveInfinity.</summary>
        public double PopupMaximumHeight
        {
            get { return (double)GetValue(PopupMaximumHeightProperty); }
            set { SetValue(PopupMaximumHeightProperty, value); }
        }

        public static readonly DependencyProperty PopupMaximumHeightProperty =
            DependencyProperty.Register("PopupMaximumHeight", typeof(double), typeof(GridSplitterPopupExpander), 
                new PropertyMetadata(double.PositiveInfinity, null, CoercePopupMaximumHeight));

        private static object CoercePopupMaximumHeight(DependencyObject d, object baseValue)
        {
            double val = (double)baseValue;

            if (val < 0.0) return 0.0; // cannot be less than 0.0

            return baseValue;
        }

        /// <summary>Gets or sets the maximum width for the popup. Default is double.PositiveInfinity.</summary>
        public double PopupMaximumWidth
        {
            get { return (double)GetValue(PopupMaximumWidthProperty); }
            set { SetValue(PopupMaximumWidthProperty, value); }
        }

        public static readonly DependencyProperty PopupMaximumWidthProperty =
            DependencyProperty.Register("PopupMaximumWidth", typeof(double), typeof(GridSplitterPopupExpander), 
                new PropertyMetadata(double.PositiveInfinity, null, CoercePopupMaximumWidth));

        private static object CoercePopupMaximumWidth(DependencyObject d, object baseValue)
        {
            double val = (double)baseValue;

            if (val < 0.0) return 0.0; // cannot be less than 0.0

            return baseValue;
        }

        /// <summary>Gets or sets the minimum height for the popup. Default is 0.0.</summary>
        public double PopupMinimumHeight
        {
            get { return (double)GetValue(PopupMinimumHeightProperty); }
            set { SetValue(PopupMinimumHeightProperty, value); }
        }

        public static readonly DependencyProperty PopupMinimumHeightProperty =
            DependencyProperty.Register("PopupMinimumHeight", typeof(double), typeof(GridSplitterPopupExpander), 
                new PropertyMetadata(0.0, null, CoercePopupMinimumHeight));

        private static object CoercePopupMinimumHeight(DependencyObject d, object baseValue)
        {
            double val = (double)baseValue;

            if (val < 0.0) return 0.0; // cannot be less than 0.0

            return baseValue;
        }

        /// <summary>Gets or sets the minimum width for the popup. Default is 0.0.</summary>
        public double PopupMinimumWidth
        {
            get { return (double)GetValue(PopupMinimumWidthProperty); }
            set { SetValue(PopupMinimumWidthProperty, value); }
        }

        public static readonly DependencyProperty PopupMinimumWidthProperty =
            DependencyProperty.Register("PopupMinimumWidth", typeof(double), typeof(GridSplitterPopupExpander), 
                new PropertyMetadata(0.0, null, CoercePopupMinimumWidth));

        private static object CoercePopupMinimumWidth(DependencyObject d, object baseValue)
        {
            double val = (double)baseValue;

            if (val < 0.0) return 0.0; // cannot be less than 0.0

            return baseValue;
        }

        /// <summary>Gets or sets the preferred height when rendering the popup content.</summary>
        public double PopupPreferredHeight
        {
            get { return (double)GetValue(PopupPreferredHeightProperty); }
            set { SetValue(PopupPreferredHeightProperty, value); }
        }

        public static readonly DependencyProperty PopupPreferredHeightProperty =
            DependencyProperty.Register("PopupPreferredHeight", typeof(double), typeof(GridSplitterPopupExpander), new PropertyMetadata(-1.0));

        /// <summary>Gets or sets the preferred width when rendering the popup content.</summary>
        public double PopupPreferredWidth
        {
            get { return (double)GetValue(PopupPreferredWidthProperty); }
            set { SetValue(PopupPreferredWidthProperty, value); }
        }

        public static readonly DependencyProperty PopupPreferredWidthProperty =
            DependencyProperty.Register("PopupPreferredWidth", typeof(double), typeof(GridSplitterPopupExpander), new PropertyMetadata(-1.0));

        #endregion

        #region Constructors

        static GridSplitterPopupExpander()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(GridSplitterPopupExpander), new FrameworkPropertyMetadata(typeof(GridSplitterPopupExpander)));
        }

        #endregion
    }
}
