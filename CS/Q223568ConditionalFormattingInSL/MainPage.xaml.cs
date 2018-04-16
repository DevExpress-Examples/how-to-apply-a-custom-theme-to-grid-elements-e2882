// Developer Express Code Central Example:
// How to apply a custom theme to grid elements
// 
// The following example demonstrates how to create a custom theme and apply it to
// DXGrid control elements.
// In this example the custom theme assembly is used to
// customize grid control elements.
// Please notice that this assembly should follow
// this naming rule: DevExpress.Xpf.Themes.CustomAssemblyName.VersionNumber
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E2882

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;
using DevExpress.Xpf.Data;
using DevExpress.Xpf.Grid;
using System.Collections.ObjectModel;
using DevExpress.Xpf.Core;

namespace Q223568ConditionalFormattingInSL {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
            DataContext = new TestData();
            ApplyTheme();
        }
        private void ApplyTheme() {
            Theme theme = new Theme("DevExpress.Xpf.Themes.LightGrayBasedTheme.v13.2") { IsStandard = false, 
                FullName = "Light Gray Based Theme" };
            ThemeManager.ApplicationTheme = theme;
        }
    }
}
