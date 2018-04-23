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

			Dim random As New Random()

			Dim list As New ObservableCollection(Of TestData)()
			For i As Integer = 0 To 9
				list.Add(New TestData() With {.Text = "Row" & i Mod 2, .Red = random.Next(255), .Green = random.Next(255), .Blue = random.Next(255)})
			Next i
			grid.ItemsSource = list

			Dim theme As New Theme("DevExpress.Xpf.Themes.LightGrayBasedTheme.v11.1") With {.IsStandard = False, .FullName = "Light Gray Based Theme"}
			ThemeManager.ApplicationTheme = theme
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			DXVisualizer.DXVisualTreeVisualizer.Show()
		End Sub

	End Class
	Public Class TestData
		Public Property Red() As Integer
		Public Property Green() As Integer
		Public Property Blue() As Integer
		Public Property Text() As String
	End Class
	Public Class NumberToColorConverter
		Implements IValueConverter
		Private rowPropertyValueConverter As IValueConverter = New RowPropertyValueConverter()
		#Region "IValueConverter Members"
		Private Function IValueConverter_Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Dim red As Byte = Convert.ToByte((CType(value, TestData)).Red)
			Dim green As Byte = Convert.ToByte((CType(value, TestData)).Green)
			Dim blue As Byte = Convert.ToByte((CType(value, TestData)).Blue)
			Return New SolidColorBrush(Color.FromArgb(255, red, green, blue))
		End Function

		Private Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function

		#End Region
	End Class




End Namespace
