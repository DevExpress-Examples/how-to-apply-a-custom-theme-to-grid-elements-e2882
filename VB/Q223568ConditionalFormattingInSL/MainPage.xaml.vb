' Developer Express Code Central Example:
' How to apply a custom theme to grid elements
' 
' The following example demonstrates how to create a custom theme and apply it to
' DXGrid control elements.
' In this example the custom theme assembly is used to
' customize grid control elements.
' Please notice that this assembly should follow
' this naming rule: DevExpress.Xpf.Themes.CustomAssemblyName.VersionNumber
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E2882


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Windows.Data
Imports DevExpress.Xpf.Data
Imports DevExpress.Xpf.Grid
Imports System.Collections.ObjectModel
Imports DevExpress.Xpf.Core

Namespace Q223568ConditionalFormattingInSL
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
            InitializeComponent()
            DataContext = New TestData()
            ApplyTheme()
        End Sub
        Private Sub ApplyTheme()
            Dim theme As New Theme("DevExpress.Xpf.Themes.LightGrayBasedTheme.v12.1") With {.IsStandard = False, .FullName = "Light Gray Based Theme"}
            ThemeManager.ApplicationTheme = theme
        End Sub
    End Class
End Namespace
