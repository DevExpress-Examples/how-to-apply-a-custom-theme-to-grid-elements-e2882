﻿Imports System
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports System.Collections.ObjectModel

Namespace Q223568ConditionalFormattingInSL
    Public Class TestData
        Private privateList As ObservableCollection(Of TestDataItem)
        Public Property List() As ObservableCollection(Of TestDataItem)
            Get
                Return privateList
            End Get
            Private Set(ByVal value As ObservableCollection(Of TestDataItem))
                privateList = value
            End Set
        End Property
        Public Sub New()
            List = GetTestData()
        End Sub
        Private Function GetTestData() As ObservableCollection(Of TestDataItem)
            Dim random As New Random()

            Dim list_Renamed As New ObservableCollection(Of TestDataItem)()
            For i As Integer = 0 To 9
                list_Renamed.Add(New TestDataItem() With {.Text = "Row" & i Mod 2, .Red = random.Next(255), .Green = random.Next(255), .Blue = random.Next(255)})
            Next i
            Return list_Renamed
        End Function
    End Class
    Public Class TestDataItem
        Public Property Red() As Integer
        Public Property Green() As Integer
        Public Property Blue() As Integer
        Public Property Text() As String
    End Class
End Namespace
