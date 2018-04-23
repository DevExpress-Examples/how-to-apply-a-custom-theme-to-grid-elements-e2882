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
			grid.DataSource = list

			Dim theme As New Theme("LightGrayBasedTheme") With {.IsStandard = False, .FullName = "Light Gray Based Theme"}
			ThemeManager.ApplicationTheme = theme
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			DXVisualizer.DXVisualTreeVisualizer.Show()
		End Sub

	End Class
	Public Class TestData
		Private privateRed As Integer
		Public Property Red() As Integer
			Get
				Return privateRed
			End Get
			Set(ByVal value As Integer)
				privateRed = value
			End Set
		End Property
		Private privateGreen As Integer
		Public Property Green() As Integer
			Get
				Return privateGreen
			End Get
			Set(ByVal value As Integer)
				privateGreen = value
			End Set
		End Property
		Private privateBlue As Integer
		Public Property Blue() As Integer
			Get
				Return privateBlue
			End Get
			Set(ByVal value As Integer)
				privateBlue = value
			End Set
		End Property
		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Set(ByVal value As String)
				privateText = value
			End Set
		End Property
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
