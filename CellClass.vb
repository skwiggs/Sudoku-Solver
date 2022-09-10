Imports Microsoft.VisualBasic
Imports System.Collections.Generic


Public Class CellKeeper

    Private possibiles As List(Of Char)
    Private answer As Char

    Private Sub answerFill()
        If Me.poss.Count = 1 Then
            Me.answer = Me.poss.Item(0)

        End If
    End Sub



    Public Property cellAnswer() As Char
        Get
            Return answer
        End Get
        Set(ByVal value As Char)
            answer = value
        End Set
    End Property


    Public Property poss() As List(Of Char)
        Get
            Return possibiles
        End Get
        Set(ByVal value As List(Of Char))
            possibiles = value
        End Set
    End Property

    Public Sub New()
        Me.answer = ""
        Me.poss.Clear()

        For i As Int16 = 49 To 57
            Me.poss.Add(ChrW(i))
        Next


    End Sub

End Class
