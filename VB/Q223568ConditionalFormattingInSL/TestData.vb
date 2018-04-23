Imports System.Collections.ObjectModel

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
        Dim random As New System.Random()
        Dim list As New ObservableCollection(Of TestDataItem)()
        For i As Integer = 0 To 9
            list.Add(New TestDataItem() With {.Text = "Row" & i Mod 2, .Red = random.Next(255), .Green = random.Next(255), .Blue = random.Next(255)})
        Next i
        Return list
    End Function
End Class
Public Class TestDataItem
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



